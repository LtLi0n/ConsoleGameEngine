using ConsoleGameEngine.ColorPalettes;

namespace ConsoleGameEngine
{
    public struct PaletteColor
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public PaletteColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static class Containers
        {
            public static PaletteColorContainer Pico8 { get; } = new PaletteColorContainer_Pico8();
            public static PaletteColorContainer Default { get; } = new PaletteColorContainer_DefaultWindowsScheme();
        }
    }
}
