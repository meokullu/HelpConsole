using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using static HelpConsole.src.HelpConsole;

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
        // Start up beeping frequency.
        private const int _startUpBeepFrequency = 850;

        // Start up beeping duration.
        private const int _startUpBeepDuration = 400;

        // Finish up beeping frequency.
        private const int _finishUpBeepFrequency = 1250;

        // Finish up beeping duration.
        private const int _finishUpBeepDuration = 400;

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
            Console.Title = consoleOptions.AppName;

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
                Console.Beep(_startUpBeepFrequency, _startUpBeepDuration);
            }
        }

        /// <summary>
        /// Ending up.
        /// </summary>
        //[SupportedOSPlatform("windows")]
        public static void FinishUp()
        {
            // Setting console title.
            Console.Title = "Done...";

            // Giving a new line.
            Console.WriteLine("");

            // Writing a end text.
            Console.WriteLine("Done...");

            // Beep sound.
            if (_consoleOptions.WarningSound)
            {
                // Beeping.
                Console.Beep(_finishUpBeepFrequency, _finishUpBeepDuration);
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