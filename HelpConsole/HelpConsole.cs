using System;

namespace HelpConsole
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        // Console Option
        internal static ConsoleOption _consoleOptions = new ConsoleOption();

        /// <summary>
        /// Set and holds console options.
        /// </summary>
        public static ConsoleOption ConsoleOptions { get => _consoleOptions; set => _consoleOptions = value; }

        /// <summary>
        /// Settings for console.
        /// </summary>
        public class ConsoleOption
        {
            /// <summary>
            /// Application name
            /// </summary>
            public string AppName = "HelpConsole";

            /// <summary>
            /// Screen color option. It has foreground and background color individually.
            /// </summary>
            public ScreenColorOption ScreenColorOption = _defaultScreenColorOption;

            /// <summary>
            /// Sets whether cursor is visible or not.
            /// </summary>
            public bool CursorVisible = false;

            /// <summary>
            /// Sets warning beep.
            /// </summary>
            public bool WarningSound = false;

            /// <summary>
            /// Sets whether application should wait end or not.
            /// </summary>
            public bool WaitOnEnd = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        // Start up beeping frequency and duration.
        private static readonly Melody _startUpMelody = new Melody { Notes = new int[] { 850, 400, 0 } };

        // Finish up beeping frequency and duration.
        private static readonly Melody _finishUpMelody = new Melody { Notes = new int[] { 1250, 400, 0 } };

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
                consoleOptions = new ConsoleOption();
            }

            // Set console title with default value.
            SetConsoleTitle(firstText: consoleOptions.AppName);

            // Set console background color with default color value.
            Console.BackgroundColor = consoleOptions.ScreenColorOption.BackgroundColor;

            // Set console background color with default color value.
            Console.ForegroundColor = consoleOptions.ScreenColorOption.ForegroundColor;

            // Set cursor visible false on console.
            Console.CursorVisible = consoleOptions.CursorVisible;

            // Checking if warning sound is enabled.
            if (consoleOptions.WarningSound)
            {
                // Beep sound.
                Beep(_startUpMelody);
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

            // Giving a new line.
            Console.WriteLine("");

            // Writing a end text.
            Console.WriteLine("Done...");

            // Beep sound.
            if (_consoleOptions.WarningSound)
            {
                // Beeping.
                Beep(_finishUpMelody);
            }

            // Checking if WaitOnEnd is true.
            if (_consoleOptions.WaitOnEnd)
            {
                // Waiting for a key.
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Starting up.
        /// </summary>
        /// <param name="appName">Application name</param>
        [Obsolete("This method renamed as StartUp().")]
        public static void StartUp(string appName)
        {
            // Temporary.
            ConsoleOption consoleOption = new ConsoleOption { AppName = appName };

            // Temporary.
            StartUp(consoleOptions: consoleOption);
        }

        /// <summary>
        /// Ending up.
        /// </summary>
        [Obsolete("This method renamed as FinishUp().")]
        public static void FinishingUp()
        {
            // Temporary.
            FinishUp();
        }
    }
}