using System;

namespace HelpConsole
{
    public static partial class HelpConsole
    {
        // Screen Color Option.
        internal static ScreenColorOption _defaultScreenColorOption = new ScreenColorOption(foregroundColor: ConsoleColor.Black, backgroundColor: ConsoleColor.White);

        /// <summary>
        /// Set and holds screen color options.
        /// </summary>
        public static ScreenColorOption ScreenColorOptions { get => _defaultScreenColorOption; set => _defaultScreenColorOption = value; }

        /// <summary>
        /// Preset black for background, yellow for foreground.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionYellow = new ScreenColorOption(foregroundColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, green for foreground color.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionGreen = new ScreenColorOption(foregroundColor: ConsoleColor.Green, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, green for foreground color.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionCyan = new ScreenColorOption(foregroundColor: ConsoleColor.Cyan, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, dark yellow for foreground color.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionDarkYellow = new ScreenColorOption(foregroundColor: ConsoleColor.DarkYellow, backgroundColor: ConsoleColor.Black);


        /// <summary>
        /// Settings for console colors.
        /// </summary>
        public class ScreenColorOption
        {
            /// <summary>
            /// Sets foreground color for text.
            /// </summary>
            public ConsoleColor ForegroundColor = ConsoleColor.Black;

            /// <summary>
            /// Sets background color for background.
            /// </summary>
            public ConsoleColor BackgroundColor = ConsoleColor.White;

            /// <summary>
            /// Sets ScreenColorOption.
            /// </summary>
            /// <param name="foregroundColor">Text color.</param>
            /// <param name="backgroundColor">Background color.</param>
            public ScreenColorOption(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
            {
                // Text color.
                ForegroundColor = foregroundColor;

                // Foreground color.
                BackgroundColor = backgroundColor;
            }
        }
    }
}
