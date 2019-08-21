namespace ConsoleGameEngine
{
    public static class ConsoleCharacter
    {
        public const ushort NULL = 0x0000;
        public const ushort FULL = 0x2588;
        public const ushort Dark = 0x2593;
        public const ushort Medium = 0x2592;
        public const ushort Light = 0x2591;

        // box drawing syboler
        // ┌───────┐
        // │       │
        // │       │
        // └───────┘
        public const ushort BoxDrawingL_H = 0x2500;
        public const ushort BoxDrawingL_V = 0x2502;
        public const ushort BoxDrawingL_DR = 0x250C;
        public const ushort BoxDrawingL_DL = 0x2510;
        public const ushort BoxDrawingL_UL = 0x2518;
        public const ushort BoxDrawingL_UR = 0x2514;
    }
}
