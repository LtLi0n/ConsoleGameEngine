namespace ConsoleGameEngine.ColorPalettes
{
    ///<summary> default windows console palette.</summary>
    public class PaletteColorContainer_DefaultWindowsScheme : PaletteColorContainer
    {
        #region Color const definitions
        #region FG 16bit definitions
        public const byte FG_BLACK = 0x00;
        public const byte FG_DARK_BLUE = 0x01;
        public const byte FG_DARK_GREEN = 0x02;
        public const byte FG_DARK_CYAN = 0x03;
        public const byte FG_DARK_RED = 0x04;
        public const byte FG_DARK_MAGENTA = 0x05;
        public const byte FG_DARK_YELLOW = 0x06;
        public const byte FG_GREY = 0x07;
        public const byte FG_DARK_GREY = 0x08;
        public const byte FG_BLUE = 0x09;
        public const byte FG_GREEN = 0x0A;
        public const byte FG_CYAN = 0x0B;
        public const byte FG_RED = 0x0C;
        public const byte FG_MAGENTA = 0x0D;
        public const byte FG_YELLOW = 0x0E;
        public const byte FG_WHITE = 0x0F;
        #endregion
        #region BG 16bit definitions
        public const byte BG_BLACK = 0x00;
        public const byte BG_DARK_BLUE = 0x10;
        public const byte BG_DARK_GREEN = 0x20;
        public const byte BG_DARK_CYAN = 0x30;
        public const byte BG_DARK_RED = 0x40;
        public const byte BG_DARK_MAGENTA = 0x50;
        public const byte BG_DARK_YELLOW = 0x60;
        public const byte BG_GREY = 0x70;
        public const byte BG_DARK_GREY = 0x80;
        public const byte BG_BLUE = 0x90;
        public const byte BG_GREEN = 0xA0;
        public const byte BG_CYAN = 0xB0;
        public const byte BG_RED = 0xC0;
        public const byte BG_MAGENTA = 0xD0;
        public const byte BG_YELLOW = 0xE0;
        public const byte BG_WHITE = 0xF0;
        #endregion
        #endregion

        public PaletteColorContainer_DefaultWindowsScheme()
        {
            this[FG_BLACK] = new PaletteColor(12, 12, 12);
            this[FG_DARK_BLUE] = new PaletteColor(0, 55, 218);
            this[FG_DARK_GREEN] = new PaletteColor(19, 161, 14);
            this[FG_DARK_CYAN] = new PaletteColor(58, 150, 221);
            this[FG_DARK_RED] = new PaletteColor(197, 15, 31);
            this[FG_DARK_MAGENTA] = new PaletteColor(136, 23, 152);
            this[FG_DARK_YELLOW] = new PaletteColor(193, 156, 0);
            this[FG_GREY] = new PaletteColor(204, 204, 204);
            this[FG_DARK_GREY] = new PaletteColor(118, 118, 118);
            this[FG_BLUE] = new PaletteColor(59, 120, 255);
            this[FG_GREEN] = new PaletteColor(22, 192, 12);
            this[FG_CYAN] = new PaletteColor(97, 214, 214);
            this[FG_RED] = new PaletteColor(231, 72, 86);
            this[FG_MAGENTA] = new PaletteColor(180, 0, 158);
            this[FG_YELLOW] = new PaletteColor(249, 241, 165);
            this[FG_WHITE] = new PaletteColor(242, 242, 242);
        }
    }
}
