using System;

namespace ConsoleGameEngine
{
    ///<summary>Vector of two floats.</summary>
    public struct Vector
    {
        public float X { get; }
        public float Y { get; }

        public static Vector Zero { get; } = new Vector(0f, 0f);

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Point ToPoint => new Point((int)Math.Round(X, 0), (int)Math.Round(Y, 0));

        public Vector Rotate(float a)
        {
            float x = 0f, y = 0f;

            x = (float)(X * Math.Cos(a / 57.3f) - Y * Math.Sin(a / 57.3f));
            y = (float)(X * Math.Sin(a / 57.3f) + Y * Math.Cos(a / 57.3f));

            return new Vector(x, y);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        public static Vector operator /(Vector a, float b)
        {
            return new Vector((a.X / b), (a.Y / b));
        }
        public static Vector operator *(Vector a, float b)
        {
            return new Vector((a.X * b), (a.Y * b));
        }

        public static float Distance(Vector a, Vector b)
        {
            Vector dV = b - a;
            float d = (float)Math.Sqrt(Math.Pow(dV.X, 2) + Math.Pow(dV.Y, 2));
            return d;
        }
    }
}
