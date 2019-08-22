namespace ConsoleGameEngine.ColorPalettes
{
    public class PaletteColorContainer_Pico8 : PaletteColorContainer
    {
        #region Color const definitions
        #region FG 16bit definitions
        public const byte FG_BLACK = 0x00;
        public const byte FG_DARK_BLUE = 0x01;
        public const byte FG_DARK_PURPLE = 0x02;
        public const byte FG_DARK_GREEN = 0x03;
        public const byte FG_BROWN = 0x04;
        public const byte FG_DARK_GRAY = 0x05;
        public const byte FG_LIGHT_GRAY = 0x06;
        public const byte FG_WHITE = 0x07;
        public const byte FG_RED = 0x08;
        public const byte FG_ORANGE = 0x09;
        public const byte FG_YELLOW = 0x0A;
        public const byte FG_GREEN = 0x0B;
        public const byte FG_BLUE = 0x0C;
        public const byte FG_INDIGO = 0x0D;
        public const byte FG_PINK = 0x0E;
        public const byte FG_PEACH = 0x0F;
        #endregion
        #region BG 16bit definitions
        public const byte BG_BLACK = 0x00;
        public const byte BG_DARK_BLUE = 0x10;
        public const byte BG_DARK_PURPLE = 0x20;
        public const byte BG_DARK_GREEN = 0x30;
        public const byte BG_BROWN = 0x40;
        public const byte BG_DARK_GRAY = 0x50;
        public const byte BG_LIGHT_GRAY = 0x60;
        public const byte BG_WHITE = 0x70;
        public const byte BG_RED = 0x80;
        public const byte BG_ORANGE = 0x90;
        public const byte BG_YELLOW = 0xA0;
        public const byte BG_GREEN = 0xB0;
        public const byte BG_BLUE = 0xC0;
        public const byte BG_INDIGO = 0xD0;
        public const byte BG_PINK = 0xE0;
        public const byte BG_PEACH = 0xF0;
        #endregion
        #endregion

        public PaletteColorContainer_Pico8()
        {
            this[FG_BLACK] = new PaletteColor(12, 12, 12);
            this[FG_DARK_BLUE] = new PaletteColor(29, 43, 83);
            this[FG_DARK_PURPLE] = new PaletteColor(126, 37, 83);
            this[FG_DARK_GREEN] = new PaletteColor(0, 135, 81);
            this[FG_BROWN] = new PaletteColor(171, 82, 54);
            this[FG_DARK_GRAY] = new PaletteColor(95, 87, 79);
            this[FG_LIGHT_GRAY] = new PaletteColor(194, 195, 199);
            this[FG_WHITE] = new PaletteColor(255, 241, 232);
            this[FG_RED] = new PaletteColor(255, 0, 77);
            this[FG_ORANGE] = new PaletteColor(255, 163, 0);
            this[FG_YELLOW] = new PaletteColor(255, 236, 39);
            this[FG_GREEN] = new PaletteColor(0, 228, 54);
            this[FG_BLUE] = new PaletteColor(41, 173, 255);
            this[FG_INDIGO] = new PaletteColor(131, 118, 156);
            this[FG_PINK] = new PaletteColor(255, 119, 168);
            this[FG_PEACH] = new PaletteColor(255, 204, 170);
        }
    }
}
