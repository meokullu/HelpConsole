using System;

namespace HelpConsole
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        // Console Option
        internal static ConsoleOption s_consoleOptions = new ConsoleOption();

        /// <summary>
        /// Set and holds console options.
        /// </summary>
        public static ConsoleOption ConsoleOptions { get => s_consoleOptions; set => s_consoleOptions = value; }

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
            public ScreenColorOption ScreenColorOption = s_defaultScreenColorOption;

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
        private static readonly Melody s_startUpMelody = new Melody { Notes = new int[] { 440, 250, 25 , 660, 250, 25} };

        // Finish up beeping frequency and duration.
        private static readonly Melody s_finishUpMelody = new Melody { Notes = new int[] { 1250, 400, 25, 1000, 400, 25 } };

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

            // Set console background and foreground colors with default value.
            SetScreenColors(ScreenColorOptions);

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
            Console.WriteLine("");

            // Writing a end text.
            Console.WriteLine("Done...");

            // Beep sound.
            if (s_consoleOptions.WarningSound)
            {
                // Beeping.
                Beep(s_finishUpMelody);
            }

            // Checking if WaitOnEnd is true.
            if (s_consoleOptions.WaitOnEnd)
            {
                // Waiting for a key.
                Console.ReadKey();
            }
        }
    }
}