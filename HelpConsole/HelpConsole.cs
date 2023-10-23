using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;

namespace HelpConsole
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        #region Console Option

        // Console Option
        private static ConsoleOption _consoleOptions = new ConsoleOption();

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

        #endregion Console Option

        #region Screen Color Options

        // Screen Color Option.
        private static ScreenColorOption _defaultScreenColorOption = new ScreenColorOption(foregroundColor: ConsoleColor.Black, backgroundColor: ConsoleColor.White);

        /// <summary>
        /// Set and holds screen color options.
        /// </summary>
        public static ScreenColorOption ScreenColorOptions { get => _defaultScreenColorOption; set => _defaultScreenColorOption = value; }  

        /// <summary>
        /// Preset for black background, yellow foreground.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionYellow = new ScreenColorOption(foregroundColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.Black);

        /// <summary>
        /// Preset for black background, green foreground.
        /// </summary>
        public readonly static ScreenColorOption ScreenColorOptionGreen = new ScreenColorOption(foregroundColor: ConsoleColor.Green, backgroundColor: ConsoleColor.Black);

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

        #endregion Screen Color Options
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

    #region Methods for methods

    /// <summary>
    /// Methods helpers.
    /// </summary>
    public static partial class HelpConsole
    {
        // Start up beeping frequency.
        private const int _startBeepFreqency = 725;

        // Start up beeping duration.
        private const int _startBeepDuration = 500;

        // Finish up beeping frequency.
        private const int _endBeepDuration = 525;

        // Finish up beeping duration.
        private const int _endBeepFrequency = 500;

        /// <summary>
        /// Method starting with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing the method's name.
            Console.WriteLine($"{memberName} started...");

            // Checks if warning sound is active.
            if (_consoleOptions.WarningSound)
            {
                // Beep sounds.
                Console.Beep(_startBeepFreqency, _startBeepDuration);
            }
        }

        /// <summary>
        /// Method ending with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void EndingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing a method's name.
            Console.WriteLine($"{memberName} ended...");

            // Checks if warning sound is active.
            if (_consoleOptions.WarningSound)
            {
                // Beep sounds.
                Console.Beep(_endBeepFrequency, _endBeepDuration);
            }
        }
    }

    #endregion Methods for methods
}