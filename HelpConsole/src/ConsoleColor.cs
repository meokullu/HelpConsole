using System;

namespace HelpConsole
{
    /// <summary>
    /// ConsoleColor available colors.
    /// </summary>
    public partial class HelpConsole
    {
        #region Console Colors

        /// <summary>
        /// ConsoleColor Black.
        /// </summary>
        public static readonly ConsoleColor Black = ConsoleColor.Black;

        /// <summary>
        /// ConsoleColor DarkBlue.
        /// </summary>
        public static readonly ConsoleColor DarkBlue = ConsoleColor.DarkBlue;

        /// <summary>
        /// ConsoleColor DarkGreen.
        /// </summary>
        public static readonly ConsoleColor DarkGreen = ConsoleColor.DarkGreen;

        /// <summary>
        /// ConsoleColor DarkCyan.
        /// </summary>
        public static readonly ConsoleColor DarkCyan = ConsoleColor.DarkCyan;

        /// <summary>
        /// ConsoleColor DarkRed.
        /// </summary>
        public static readonly ConsoleColor DarkRed = ConsoleColor.DarkRed;

        /// <summary>
        /// ConsoleColor DarkMagenta.
        /// </summary>
        public static readonly ConsoleColor DarkMagenta = ConsoleColor.DarkMagenta;

        /// <summary>
        /// ConsoleColor DarkYellow.
        /// </summary>
        public static readonly ConsoleColor DarkYellow = ConsoleColor.DarkYellow;

        /// <summary>
        /// ConsoleColor Gray.
        /// </summary>
        public static readonly ConsoleColor Gray = ConsoleColor.Gray;

        /// <summary>
        /// ConsoleColor DarkGray.
        /// </summary>
        public static readonly ConsoleColor DarkGray = ConsoleColor.DarkGray;

        /// <summary>
        /// ConsoleColor Blue.
        /// </summary>
        public static readonly ConsoleColor Blue = ConsoleColor.Blue;

        /// <summary>
        /// ConsoleColor Green.
        /// </summary>
        public static readonly ConsoleColor Green = ConsoleColor.Green;

        /// <summary>
        /// ConsoleColor Cyan.
        /// </summary>
        public static readonly ConsoleColor Cyan = ConsoleColor.Cyan;

        /// <summary>
        /// ConsoleColor Red.
        /// </summary>
        public static readonly ConsoleColor Red = ConsoleColor.Red;

        /// <summary>
        /// ConsoleColor Magenta.
        /// </summary>
        public static readonly ConsoleColor Magenta = ConsoleColor.Magenta;

        /// <summary>
        /// ConsoleColor Yellow.
        /// </summary>
        public static readonly ConsoleColor Yellow = ConsoleColor.Yellow;

        /// <summary>
        /// ConsoleColor White.
        /// </summary>
        public static readonly ConsoleColor White = ConsoleColor.White;

        /// <summary>
        /// Predefined console color array that consists all ConsoleColors.
        /// </summary>
        public static readonly ConsoleColor[] AllLightColors = new ConsoleColor[] { Gray, Blue, Green, Cyan, Red, Magenta, Yellow, White };

        /// <summary>
        /// Predefined console color array that consists only light ConsoleColors.
        /// </summary>
        public static readonly ConsoleColor[] AllDarkColors = new ConsoleColor[] { DarkGray, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Black };

        /// <summary>
        /// Predefined console color array that consists only dark ConsoleColors.
        /// </summary>
        public static readonly ConsoleColor[] GrayToneColors = new ConsoleColor[] { Gray, DarkGray };

        /// <summary>
        /// Predefined console color array that consists blue and dark blue.
        /// </summary>
        public static readonly ConsoleColor[] BlueToneColors = new ConsoleColor[] { Blue, DarkBlue };

        /// <summary>
        /// Predefined console color array that consists green and dark green.
        /// </summary>
        public static readonly ConsoleColor[] GreenToneColors = new ConsoleColor[] { Green, DarkGreen };

        /// <summary>
        /// Predefined console color array that consists cyan and dark cyan.
        /// </summary>
        public static readonly ConsoleColor[] CyanToneColors = new ConsoleColor[] { Cyan, DarkCyan };

        /// <summary>
        /// Predefined console color array that consists red and dark red.
        /// </summary>
        public static readonly ConsoleColor[] RedToneColors = new ConsoleColor[] { Red, DarkRed };

        /// <summary>
        /// Predefined console color array that consists magenta and dark magenta.
        /// </summary>
        public static readonly ConsoleColor[] MagentaToneColors = new ConsoleColor[] { Magenta, DarkMagenta };

        /// <summary>
        /// Predefined console color array that consists yellow and dark dark yellow.
        /// </summary>
        public static readonly ConsoleColor[] YellowToneColors = new ConsoleColor[] { Yellow, DarkYellow };

        /// <summary>
        /// Predefined console color array that consists white and black.
        /// </summary>
        public static readonly ConsoleColor[] BlackWhiteColors = new ConsoleColor[] { White, Black };

        #endregion Console Colors
    }
}