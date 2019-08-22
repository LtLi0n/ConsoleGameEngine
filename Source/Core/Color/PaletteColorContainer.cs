namespace ConsoleGameEngine
{
    public abstract class PaletteColorContainer
    {
        public PaletteColor[] Colors { get; }
        public PaletteColor this[int index] 
        { 
            get => Colors[index]; 
            set => Colors[index] = value; 
        }

        public PaletteColorContainer()
        {
            Colors = new PaletteColor[16];
        }
    }
}
