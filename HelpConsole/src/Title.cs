using System;

namespace HelpConsole
{
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
}
