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
    /// Console methods
    /// </summary>
    public static partial class HelpConsole
    {
        // App's name
        private static string _appName = "";

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

        /// <summary>
        /// Starting up.
        /// </summary>
        /// <param name="appName">Application name</param>
        //[SupportedOSPlatform("windows")]
        public static void StartUp(string appName)
        {
            // Set default app name value with parameter value.
            _appName = appName;

            // Set console title with default value.
            Console.Title = _appName;

            // Set console background color with default color value.
            Console.BackgroundColor = ConsoleColor.Black;

            // Set console background color with default color value.
            Console.ForegroundColor = ConsoleColor.Green;
            
            // Set cursor visible false on console.
            Console.CursorVisible = false;

            // Beep sound.
            Console.Beep(475, 75);
        }

        /// <summary>
        /// Ending up.
        /// </summary>
        //[SupportedOSPlatform("windows")]
        public static void FinishingUp()
        {
            // Setting console title.
            Console.Title = "Done...";

            // Giving a new line.
            Console.WriteLine("");

            // Writing a end text.
            Console.WriteLine("Done...");

            // Beep sound.
            Console.Beep(575, 250);
        }

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
            Console.Beep(325, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // Beeping. One fourth of duration.
            Console.Beep(435, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // // Set console title's back.
            Console.Title = tempTitle;
        }
    }

    /// <summary>
    /// Methods helpers.
    /// </summary>
    public static partial class HelpConsole
    {
        /// <summary>
        /// Method starting with writing its name and beeping.
        /// </summary>
        /// <param name="memberName"></param>
        //[SupportedOSPlatform("windows")]
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing the method's name.
            Console.WriteLine($"{memberName} started...");

            // Beeping.
            Console.Beep(725, 250);
        }

        /// <summary>
        /// Method ending with writing its name and beeping.
        /// </summary>
        /// <param name="memberName"></param>
        //[SupportedOSPlatform("windows")]
        public static void EndingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing a method's name.
            Console.WriteLine($"{memberName} ended...");

            // Beeping.
            Console.Beep(725, 250);
        }
    }
}