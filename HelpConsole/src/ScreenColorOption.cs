﻿using System;

namespace HelpConsole
{
    public static partial class HelpConsole
    {       
        // Screen Color Option.
        internal static ScreenColorOption s_defaultScreenColorOption = new ScreenColorOption(foregroundColor: ConsoleColor.Black, backgroundColor: ConsoleColor.White);

        /// <summary>
        /// Set and holds screen color options.
        /// </summary>
        public static ScreenColorOption ScreenColorOptions { get => s_defaultScreenColorOption; set => s_defaultScreenColorOption = value; }

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

            // Loop for background colors.
            foreach (var backgroundColor in Enum.GetValues(typeof(ConsoleColor)))
            {
                // Loop for foreground color.
                foreach (var foregroundColor in Enum.GetValues(typeof(ConsoleColor)))
                {
                    // Check if background and foreground colors are same. Since text color is equal to background color text will not be visible.
                    if ((ConsoleColor)backgroundColor == (ConsoleColor)foregroundColor)
                    {
                        // Exiting the loop.
                        continue;
                    }

                    // Created ScreenColorOption with color items on the loop.
                    ScreenColorOption screenColorOption = new ScreenColorOption(foregroundColor: (ConsoleColor)foregroundColor, backgroundColor: (ConsoleColor)backgroundColor);

                    // Calling SetScreenColors method.
                    SetScreenColors(screenColorOption);

                    // Writing current background and foreground colors to screen.
                    Console.WriteLine($" BG: {Enum.GetName(typeof(ConsoleColor), foregroundColor)} FG: {Enum.GetName(typeof(ConsoleColor), backgroundColor)}");
                }

                // Adding a blank line to seperate background color options on listing.
                Console.WriteLine("");
            }
        }
    }
}
