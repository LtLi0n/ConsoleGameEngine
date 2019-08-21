namespace ConsoleGameEngine
{
    public struct Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static explicit operator Color(int aColor) =>
            new Color(
                r: (byte)((aColor >> 16) & 0xFF),
                g: (byte)((aColor >> 8) & 0xFF),
                b: (byte)((aColor) & 0xFF));

        public static implicit operator int(Color color) =>
            (color.R & 0xff) << 16 |
            (color.G & 0xff) << 8 |
            (color.B & 0xff);

        public static Color Black => new Color(0, 0, 0);
        public static Color Blue => new Color(0, 0, 255);

        public static class Palettes
        {
            public static Color[] Pico8 =>
                new Color[16]
                {
                    new Color(0, 0, 0),
                    new Color(29, 43, 83),
                    new Color(126, 37, 83),
                    new Color(0, 135, 81),
                    new Color(171, 82, 54),
                    new Color(95, 87, 79),
                    new Color(194, 195, 199),
                    new Color(255, 241, 232),
                    new Color(255, 0, 77),
                    new Color(255, 163, 0),
                    new Color(255, 236, 39),
                    new Color(0, 228, 54),
                    new Color(41, 173, 255),
                    new Color(131, 118, 156),
                    new Color(255, 119, 168),
                    new Color(255, 204, 170),
                };

            /// <summary> default windows console palette. </summary>
            public static Color[] Default =>
                new Color[16]
                {
                    new Color(12, 12, 12), // Black
                    new Color(0, 55, 218), // DarkBlue
                    new Color(19, 161, 14), // DarkGreen
                    new Color(58, 150, 221), // DarkCyan
                    new Color(197, 15, 31), // DarkRed
                    new Color(136, 23, 152), // DarkMagenta
                    new Color(193, 156, 0), // DarkYellow
                    new Color(204, 204, 204), // Gray
                    new Color(118, 118, 118), // DarkGray
                    new Color(59, 120, 255), // Blue
                    new Color(22, 192, 12), // Green
                    new Color(97, 214, 214), // Cyan
                    new Color(231, 72, 86), // Red
                    new Color(180, 0, 158), // Magenta
                    new Color(249, 241, 165), // Yellow
                    new Color(242, 242, 242), // White
                };
        }
    }
}
