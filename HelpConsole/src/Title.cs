using System;

namespace HelpConsole
{
    /// <summary>
    /// Console methods
    /// </summary>
    public partial class HelpConsole
    {
        // Title's first part text.
        private static string s_titleFirstText = "";

        // Title's second part text.
        private static string s_titleSecondText = "";

        // Title's third part text.
        private static string s_titleThirdText = "";

        // Title's seperator between first, second and third text.
        private static string s_titleSeperator = " - ";

        /// <summary>
        /// Sets console's title seperator for better liability between parameters.
        /// </summary>
        /// <param name="seperator">A string adding between parameters</param>
        public static void SetConsoleTitleSeperator(string seperator)
        {
            // Sets default variable with provided value.
            s_titleSeperator = seperator;
        }

        /// <summary>
        /// Sets console's title with one text. {f} Calls <see cref="SetConsoleTitle(string, string, string)"/>
        /// </summary>
        /// <param name="firstText">First text</param>
        public static void SetConsoleTitle(string firstText)
        {
            //
            SetConsoleTitle(firstText: firstText, secondText: "", thirdText: "");
        }

        /// <summary>
        ///  Sets console's title with two text. {f} - {s} Calls <see cref="SetConsoleTitle(string, string, string)"/>
        /// </summary>
        /// <param name="firstText">First text</param>
        /// <param name="secondText">Second text</param>
        public static void SetConsoleTitle(string firstText, string secondText)
        {
            //
            SetConsoleTitle(firstText: firstText, secondText: secondText, thirdText: "");
        }

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
                firstText = s_titleFirstText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleFirstText = firstText;
            }

            // Checking if secondText is null.
            if (secondText == null)
            {
                // Set second text with default value.
                secondText = s_titleSecondText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleSecondText = secondText;
            }

            // Checking if thirdText is null.
            if (thirdText == null)
            {
                // Set third text with default value.
                thirdText = s_titleThirdText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleThirdText = thirdText;
            }

            // Setting console's title with first, second and third text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"{firstText}{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}";
        }

        /// <summary>
        /// Clears console title.
        /// </summary>
        //[SupportedOSPlatform("windows")]
        public static void ClearConsoleTitle()
        {
            // Set default value null.
            s_titleFirstText = null;

            // Set default value null.
            s_titleSecondText = null;

            // Set default value null.
            s_titleThirdText = null;

            // Set console's title empty.
            Console.Title = "";
        }
    }
}
