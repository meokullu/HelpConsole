using System;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        // Screen Color Option.
        internal static ScreenColorOption s_defaultScreenColorOption;

        /// <summary>
        /// Set and holds screen color options.
        /// </summary>
        public static ScreenColorOption ScreenColorOptions { get => s_defaultScreenColorOption; set => s_defaultScreenColorOption = value; }

        /// <summary>
        /// Preset black for background, yellow for foreground.
        /// </summary>
        public static readonly ScreenColorOption ScreenColorOptionYellow = new ScreenColorOption(foregroundColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, green for foreground color.
        /// </summary>
        public static readonly ScreenColorOption ScreenColorOptionGreen = new ScreenColorOption(foregroundColor: ConsoleColor.Green, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, green for foreground color.
        /// </summary>
        public static readonly ScreenColorOption ScreenColorOptionCyan = new ScreenColorOption(foregroundColor: ConsoleColor.Cyan, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset black for background, dark yellow for foreground color.
        /// </summary>
        public static readonly ScreenColorOption ScreenColorOptionDarkYellow = new ScreenColorOption(foregroundColor: ConsoleColor.DarkYellow, backgroundColor: ConsoleColor.Black);

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

        /// <summary>
        /// Sets console screen background and foreground colors. Foreground color specifies text color.
        /// </summary>
        /// <param name="screenColorOption">Pre-built or specified ScreenColorOption.</param>
        public static void SetScreenColors(ScreenColorOption screenColorOption)
        {
            // Sets foreground color of console. Text color is foreground color.
            Console.ForegroundColor = screenColorOption.ForegroundColor;

            // Sets background color of console.
            Console.BackgroundColor = screenColorOption.BackgroundColor;

            // Sets values to use later.
            ScreenColorOptions.ForegroundColor = screenColorOption.ForegroundColor;

            // Sets values to use later.
            ScreenColorOptions.BackgroundColor = screenColorOption.BackgroundColor;
        }

        /// <summary>
        /// List available console color pairs provided by <see cref="System.ConsoleColor"/>.
        /// </summary>
        public static void ShowAvailableColors()
        {
            // Available console colors.
            // Black
            // DarkBlue
            // DarkGreen
            // DarkGreen
            // DarkRed
            // DarkMagenta
            // DarkYellow
            // Gray
            // DarkGray
            // Blue
            // Green
            // Cyan
            // Red
            // Magenta
            // Yellow
            // White

            // Black background with all available foreground colors and light color background with black foreground provides better contrast.
            // Dark color on background with its light version of foreground color provides less constrast but better privacy.
            // Dark versions of light color on background provides smooth color pairs.

            // Gets default color values of screen.
            ConsoleColor currentBackgroundConsoleColor = Console.BackgroundColor;
            ConsoleColor currentForegroundConsoleColor = Console.ForegroundColor;

            // Loop for background colors.
            foreach (ConsoleColor backgroundColor in Enum.GetValues(typeof(ConsoleColor)))
            {
                // Loop for foreground color.
                foreach (ConsoleColor foregroundColor in Enum.GetValues(typeof(ConsoleColor)))
                {
                    // Check if background and foreground colors are same. Since text color is equal to background color text will not be visible.
                    if (backgroundColor == foregroundColor)
                    {
                        // Exiting the loop.
                        continue;
                    }

                    // Created ScreenColorOption with color items on the loop.
                    ScreenColorOption screenColorOption = new ScreenColorOption(foregroundColor: foregroundColor, backgroundColor: backgroundColor);

                    // Calling SetScreenColors method.
                    SetScreenColors(screenColorOption);

                    // Writing current background and foreground colors to screen.
                    Console.Write($" BG: {Enum.GetName(typeof(ConsoleColor), backgroundColor)} FG: {Enum.GetName(typeof(ConsoleColor), foregroundColor)}");

                    SetScreenColors(new ScreenColorOption(foregroundColor: currentForegroundConsoleColor, backgroundColor: currentBackgroundConsoleColor));

                    // Adding a blank line to seperate background color options on listing.
                    WriteLine("");
                }

                // Adding a blank line to seperate background color options on listing.
                WriteLine("");
            }
        }
    }
}
