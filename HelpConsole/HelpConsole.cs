using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;

namespace HelpConsole
{
    /// <summary>
    /// Percentage helpers.
    /// </summary>
    public static partial class HelpConsole
    {
        /// <summary>
        /// Divides first number to second. Shows results with eight digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage8F(int item1, int item2)
        {
            // Returning dividing with eight digit fractions.
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with eight digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage8F(double item1, double item2)
        {
            // Returning dividing with eight digit fractions.
            return (item1 * 100 / item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with eight digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage8F(short item1, short item2)
        {
            // Returning dividing with eight digit fractions.
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with eight digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage8F(byte item1, byte item2)
        {
            // Returning dividing with eight digit fractions.
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with eight digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage8F(sbyte item1, sbyte item2)
        {
            // Returning dividing with eight digit fractions.
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results without digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string PercentageNoFrac(int item1, int item2)
        {
            // Returning dividing with no fraction.
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results without digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string PercentageNoFrac(double item1, double item2)
        {
            // Returning dividing with no fraction.
            return (item1 * 100 / item2).ToString("0") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results without digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string PercentageNoFrac(short item1, short item2)
        {
            // Returning dividing with no fraction.
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results without digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string PercentageNoFrac(byte item1, byte item2)
        {
            // Returning dividing with no fraction.
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results without digit fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string PercentageNoFrac(sbyte item1, byte item2)
        {
            // Returning dividing with no fraction.
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with two digits fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage2F(int item1, int item2)
        {
            // Returning dividing with two digits fractions.
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with two digits fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result.</returns>
        public static string Percentage2F(double item1, double item2)
        {
            // Returning dividing with two digits fractions.
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with two digits fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String result</returns>
        public static string Percentage2F(short item1, short item2)
        {
            // Returning dividing with two digits fractions.
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with two digits fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String</returns>
        public static string Percentage2F(byte item1, byte item2)
        {
            // Returning dividing with two digits fractions.
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// Divides first number to second. Shows results with two digits fraction.
        /// </summary>
        /// <param name="item1">Dividend number.</param>
        /// <param name="item2">Dividor number.</param>
        /// <returns>String</returns>
        public static string Percentage2F(sbyte item1, byte item2)
        {
            // Returning dividing with two digits fractions.
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }
    }

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

    /// <summary>
    /// Console methods
    /// </summary>
    public static partial class HelpConsole
    {
        // Title's first part text.
        private static string _titleFirstText = "";

        // Title's second part text.
        private static string _titleSecondText = "";

        // Title's third part text.
        private static string _titleThirdText = "";

        /// <summary>
        /// Sets console's title with three text. {f} - {s} - {t}
        /// </summary>
        /// <param name="firstText">First text</param>
        /// <param name="secondText">Second text</param>
        /// <param name="thirdText">Third text</param>
        //[SupportedOSPlatform("windows")]
        public static void SetConsoleTitle(string firstText = "", string secondText = "", string thirdText = "")
        {
            // Checking if firstText is null.
            if (firstText == null)
            {
                // Set first text with default value.
                firstText = _titleFirstText;
            }
            else
            {
                // Set default value with given parameter.
                _titleFirstText = firstText;
            }

            // Checking if secondText is null.
            if (secondText == null)
            {
                // Set second text with default value.
                secondText = _titleSecondText;
            }
            else
            {
                // Set default value with given parameter.
                _titleSecondText = secondText;
            }

            // Checking if thirdText is null.
            if (thirdText == null)
            {
                // Set third text with default value.
                thirdText = _titleThirdText;
            }
            else
            {
                // Set default value with given parameter.
                _titleThirdText = thirdText;
            }

            // Setting console's title with first, second and third text.
            Console.Title = $"{firstText} - {secondText} - {thirdText}";
        }

        /// <summary>
        /// Clears console title.
        /// </summary>
        //[SupportedOSPlatform("windows")]
        public static void ClearConsoleTitle()
        {
            // Set default value null.
            _titleFirstText = null;

            // Set default value null.
            _titleSecondText = null;

            // Set default value null.
            _titleThirdText = null;

            // Set console's title empty.
            Console.Title = "";
        }
    }

    /// <summary>
    /// Audio 
    /// </summary>
    public static partial class HelpConsole
    {
        // Warning beep frequency.
        private const int _warningBeepFrequency = 725;

        /// <summary>
        /// Sleep uses Thread.Sleep, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration">Time in milliseconds.</param>
        //[SupportedOSPlatform("windows")]
        public static void Sleep(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            Console.Title = $"Sleeping {duration} ms";

            // Sleeping.
            Thread.Sleep(duration);

            // Set console title's back.
            Console.Title = tempTitle;
        }

        /// <summary>
        /// Sleep uses Thread.Sleep, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration"></param>
        //[SupportedOSPlatform("windows")]
        public static void SleepWithBeeping(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            Console.Title = $"Sleeping {duration} ms";

            // Beeping. One fourth of duration.
            Console.Beep(_warningBeepFrequency, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // Beeping. One fourth of duration.
            Console.Beep(_warningBeepFrequency, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // // Set console title's back.
            Console.Title = tempTitle;
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