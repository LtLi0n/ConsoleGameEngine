namespace ConsoleGameEngine
{
    public struct ConsolePixel
    {
        public byte Color { get; }
        public char Glyph { get; }

        public ConsolePixel(byte col, char glyph)
        {
            Color = col;
            Glyph = glyph;
        }
    }
}
