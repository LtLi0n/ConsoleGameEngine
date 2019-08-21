using System;

namespace ConsoleGameEngine
{
    /// <summary> A Vector containing two ints. </summary>
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public const float Rad2Deg = 180f / (float)Math.PI;
        public const float Deg2Rad = (float)Math.PI / 180f;

        /// <summary> new Point(0, 0); </summary>
        public static Point Zero { get; } = new Point(0, 0);

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector Clone() => new Vector(X, Y);
        public override string ToString() => String.Format("({0}, {1})", X, Y);

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator /(Point a, float b)
        {
            return new Point((int)(a.X / b), (int)(a.Y / b));
        }
        public static Point operator *(Point a, float b)
        {
            return new Point((int)(a.X * b), (int)(a.Y * b));
        }

        /// <summary> Calculates distance between two points. </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <returns>Distance between A and B</returns>
        public static float Distance(Point a, Point b)
        {
            Point dV = b - a;
            float d = (float)Math.Sqrt(Math.Pow(dV.X, 2) + Math.Pow(dV.Y, 2));
            return d;
        }

        public Point Clamp(Point min, Point max)
        {
            int x = X;
            int y = Y;
            x = (X > max.X) ? max.X : X;
            x = (X < min.X) ? min.X : X;

            y = (Y > max.Y) ? max.Y : Y;
            y = (Y < min.Y) ? min.Y : Y;

            return new Point(x, y);
        }
    }
}
