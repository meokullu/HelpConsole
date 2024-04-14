using System;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        private static readonly string s_defaultAppName = "HelpConsole";
        private static readonly bool s_defaultCursorVisible = false;
        private static readonly ScreenColorOption s_defaultScreenColorOption = new(foregroundColor: Green, backgroundColor: Black);
        private static readonly bool s_defaultWaitOnEnd = true;
        private static readonly bool s_defaultWarningSound = false;

        private static readonly ConsoleOption s_defaultConsoleOption = new()
        {
            AppName = s_defaultAppName,
            CursorVisible = s_defaultCursorVisible,
            ScreenColorOption = s_defaultScreenColorOption,
            WaitOnEnd = s_defaultWaitOnEnd,
            WarningSound = s_defaultWarningSound
        };

        // Console Option
        internal static ConsoleOption s_currentConsoleOptions;

        /// <summary>
        /// Set and holds console options.
        /// </summary>
        public static ConsoleOption ConsoleOptions { get => s_currentConsoleOptions ?? s_defaultConsoleOption; set => s_currentConsoleOptions = value; }

        /// <summary>
        /// Settings for console.
        /// </summary>
        public class ConsoleOption
        {
            /// <summary>
            /// Application name
            /// </summary>
            public string AppName = s_defaultAppName;

            /// <summary>
            /// Sets whether cursor is visible or not.
            /// </summary>
            public bool CursorVisible = s_defaultCursorVisible;

            /// <summary>
            /// Screen color option. It has foreground and background color individually.
            /// </summary>
            public ScreenColorOption ScreenColorOption = s_currentScreenColorOption ?? s_defaultScreenColorOption;

            /// <summary>
            /// Sets whether application should wait end or not.
            /// </summary>
            public bool WaitOnEnd = s_defaultWaitOnEnd;

            /// <summary>
            /// Sets warning beep.
            /// </summary>
            public bool WarningSound = s_defaultWarningSound;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class HelpConsole
    {
        #region Melodies

        // Start up beeping frequency and duration. Total duration 500 ms.
        private static readonly Melody s_startUpMelody = new Melody { Notes = new int[] { 440, 190, 60, 660, 190, 60 } };

        // Finish up beeping frequency and duration. Total duration 1.000 ms.
        private static readonly Melody s_finishUpMelody = new Melody { Notes = new int[] { 1250, 400, 100, 1000, 400, 100 } };

        #endregion Melodies

        /// <summary>
        /// Starting up.
        /// </summary>
        /// <param name="consoleOptions">ConsoleOptions are options to change preferences. If it is not provided, it gets default values.</param>
        //[SupportedOSPlatform("windows")]
        public static void StartUp(ConsoleOption consoleOptions = null)
        {
            // Checking if consoleOptions is provided, it is null it gets default value.
            if (consoleOptions == null)
            {
                // Sets parameter variable with default constructor.
                consoleOptions = s_defaultConsoleOption;
            }

            // Set console title with default value.
            SetConsoleTitle(firstText: consoleOptions.AppName);

            // Set given ScreenColorOptions to use it later.
            ScreenColorOptions = new ScreenColorOption(foregroundColor: consoleOptions.ScreenColorOption.ForegroundColor, backgroundColor: consoleOptions.ScreenColorOption.BackgroundColor);

            // Set console background and foreground colors with default value.
            SetScreenColors(consoleOptions.ScreenColorOption);

            // Set given ConsoleOptions to use it later.
            ConsoleOptions = consoleOptions;

            // Set cursor visible false on console.
            Console.CursorVisible = consoleOptions.CursorVisible;

            // Checking if warning sound is enabled.
            if (consoleOptions.WarningSound)
            {
                // Beep sound.
                Beep(s_startUpMelody);
            }
        }

        /// <summary>
        /// Ending up.
        /// </summary>
        //[SupportedOSPlatform("windows")]
        public static void FinishUp()
        {
            // Setting console title.
            SetConsoleTitle("Done...");

            // Adding a new line.
            WriteLine("");

            // Writing a end text.
            WriteLine("Done...");

            // Beep sound.
            if (ConsoleOptions.WarningSound)
            {
                // Beeping.
                Beep(s_finishUpMelody);
            }

            // Checking if WaitOnEnd is true.
            if (ConsoleOptions.WaitOnEnd)
            {
                // Waiting for a key.
                _ = Console.ReadKey();
            }
        }
    }
}
