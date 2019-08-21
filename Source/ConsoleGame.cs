﻿using System;
using System.Linq;
using System.Threading;

namespace ConsoleGameEngine
{
    public abstract class ConsoleGame
    {
        /// <summary> Instance of a ConsoleEngine. </summary>
        public ConsoleEngine Engine { get; private set; }

        /// <summary> A counter representing the current unique frame we're at. </summary>
        public int FrameCounter { get; set; }

        /// <summary> Factor for generating framerate-independent physics. time between last frame and current. </summary>
        public float DeltaTime { get; set; }

        /// <summary> The framerate the engine is trying to run at. </summary>
        public int TargetFramerate { get; set; }

        private bool Running { get; set; }
        private Thread _gameThread;

        private double[] framerateSamples;

        /// <summary> Initializes the ConsoleGame. Creates the instance of a ConsoleEngine and starts the game loop. </summary>
        /// <param name="width">Width of the window.</param>
        /// <param name="height">Height of the window.</param>
        /// <param name="fontW">Width of the font.</param>
        /// <param name="fontH">´Height of the font.</param>
        /// <param name="m">Framerate mode to run at.</param>
        /// <see cref="FramerateMode"/> <see cref="ConsoleEngine"/>
        public void Construct(int width, int height, int fontW, int fontH, FramerateMode m)
        {
            TargetFramerate = 30;

            Engine = new ConsoleEngine(width, height, fontW, fontH);
            Create();

            if (m == FramerateMode.Unlimited) _gameThread = new Thread(new ThreadStart(GameLoopUnlimited));
            else if (m == FramerateMode.MaxFps) _gameThread = new Thread(new ThreadStart(GameLoopLocked));
            Running = true;
            _gameThread.Start();

            // gör special checks som ska gå utanför spelloopen
            // om spel-loopen hänger sig ska man fortfarande kunna avsluta
            while (Running)
            {
                CheckForExit();
            }
        }

        private void GameLoopLocked()
        {
            int sampleCount = TargetFramerate;
            framerateSamples = new double[sampleCount];

            DateTime lastTime;
            float uncorrectedSleepDuration = 1000 / TargetFramerate;
            while (Running)
            {
                lastTime = DateTime.UtcNow;

                FrameCounter++;
                FrameCounter %= sampleCount;

                // kör main programmet
                Update();
                Render();

                float computingDuration = (float)(DateTime.UtcNow - lastTime).TotalMilliseconds;
                int sleepDuration = (int)(uncorrectedSleepDuration - computingDuration);
                if (sleepDuration > 0)
                {
                    // programmet ligger före maxFps, sänker det
                    Thread.Sleep(sleepDuration);
                }

                // beräknar framerate
                TimeSpan diff = DateTime.UtcNow - lastTime;
                DeltaTime = (float)(1 / (TargetFramerate * diff.TotalSeconds));

                framerateSamples[FrameCounter] = (double)diff.TotalSeconds;
            }
        }

        private void GameLoopUnlimited()
        {
            int sampleCount = TargetFramerate;
            framerateSamples = new double[sampleCount];

            DateTime lastTime;
            while (Running)
            {
                lastTime = DateTime.UtcNow;

                FrameCounter++;
                FrameCounter %= sampleCount;

                Update();
                Render();

                // beräknar framerate
                TimeSpan diff = DateTime.UtcNow - lastTime;
                DeltaTime = (float)diff.TotalSeconds;

                framerateSamples[FrameCounter] = diff.TotalSeconds;

                // kollar om spelaren vill sluta
                CheckForExit();
            }
        }

        /// <summary> Gets the current framerate the application is running at. </summary>
        /// <returns> Application Framerate. </returns>
        public double GetFramerate()
        {
            return 1 / (framerateSamples.Sum() / (TargetFramerate));
        }

        private void CheckForExit()
        {
            if (Engine.GetKeyDown(ConsoleKey.Delete))
            {
                Running = false;
            }
        }

        /// <summary> Run once on Creating, import Resources here. </summary>
        public abstract void Create();
        /// <summary> Run every frame before rendering. Do math here. </summary>
        public abstract void Update();
        /// <summary> Run every frame after updating. Do drawing here. </summary>
        public abstract void Render();
    }
}