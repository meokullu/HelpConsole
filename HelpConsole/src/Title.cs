using System;

namespace HelpConsole
{
    /// <summary>
    /// Methods to set console title.
    /// </summary>
    public partial class HelpConsole
    {
        #region Private variables

        // Title's first part text.
        private static string s_titleFirstText = "";

        // Title's second part text.
        private static string s_titleSecondText = "";

        // Title's third part text.
        private static string s_titleThirdText = "";

        // Title's fourth part text.
        private static string s_titleFourthText = "";

        // Title's fifth part text.
        private static string s_titleFifthText = "";

        // Title's sixth part text.
        private static string s_titleSixthText = "";

        // Title's seventh part text.
        private static string s_titleSeventhText = "";

        // Title's eighth part text.
        private static string s_titleEighthText = "";

        // Title's seperator between first, second and third text.
        private static string s_titleSeperator = " - ";

        #endregion Private variables

        #region Text seperator

        /// <summary>
        /// Sets console's title seperator for better liability between parameters.
        /// </summary>
        /// <param name="seperator">A string adding between parameters</param>
        public static void SetConsoleTitleSeperator(string seperator)
        {
            // Sets default variable with provided value.
            s_titleSeperator = seperator;
        }

        #endregion Text seperator

        #region Set text

        private static string SetFirstText(string firstText)
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

            //
            return firstText;
        }

        private static string SetSecondText(string secondText)
        {
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

            //
            return secondText;
        }

        private static string SetThirdText(string thirdText)
        {
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

            //
            return thirdText;
        }

        private static string SetFourthText(string fourthText)
        {
            // Checking if fourthText is null.
            if (fourthText == null)
            {
                // Set fourth text with default value.
                fourthText = s_titleFourthText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleFourthText = fourthText;
            }

            //
            return fourthText;
        }

        private static string SetFifthText(string fifthText)
        {
            // Checking if fifthText is null.
            if (fifthText == null)
            {
                // Set fifth text with default value.
                fifthText = s_titleFifthText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleFifthText = fifthText;
            }

            //
            return fifthText;
        }

        private static string SetSixthText(string sixthText)
        {
            // Checking if sixthText is null.
            if (sixthText == null)
            {
                // Set sixth text with default value.
                sixthText = s_titleSixthText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleSixthText = sixthText;
            }

            //
            return sixthText;
        }

        private static string SetSeventhText(string seventhText)
        {
            // Checking if seventhText is null.
            if (seventhText == null)
            {
                // Set seventh text with default value.
                seventhText = s_titleSeventhText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleSeventhText = seventhText;
            }

            //
            return seventhText;
        }

        private static string SetEigthText(string eigthText)
        {
            // Checking if eighth is null.
            if (eigthText == null)
            {
                // Set eighth text with default value.
                eigthText = s_titleEighthText;
            }
            else
            {
                // Set default value with given parameter.
                s_titleEighthText = eigthText;
            }

            //
            return eigthText;
        }

        #endregion Set text

        #region Set Console Title

        /// <summary>
        /// Sets console's title with one text. {f} Calls <see cref="SetConsoleTitle(string, string, string)"/>.
        /// </summary>
        /// <param name="firstText">First text.</param>
        public static void SetConsoleTitle(string firstText)
        {
            //
            SetConsoleTitle(firstText: firstText, secondText: null, thirdText: null);
        }

        /// <summary>
        ///  Sets console's title with two text. {f} - {s} Calls <see cref="SetConsoleTitle(string, string, string)"/>.
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        public static void SetConsoleTitle(string firstText, string secondText)
        {
            //
            SetConsoleTitle(firstText: firstText, secondText: secondText, thirdText: null);
        }

        /// <summary>
        /// Sets console's title with three text. {f} - {s} - {t}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>        
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);

            // Setting console's title with first, second and third text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"{firstText}{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}";
        }

        /// <summary>
        /// Sets console's title with four text. {first text}{seperator}...{last text}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>
        /// <param name="fourthText">Fourth text.</param>
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null, string fourthText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);
            fourthText = SetFourthText(fourthText);

            // Setting console's title with first, second, third and fourth text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"" +
                $"{firstText}" +
                $"{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}" +
                $"{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}" +
                $"{(string.IsNullOrEmpty(fourthText) ? "" : s_titleSeperator)}{fourthText}";
        }

        /// <summary>
        /// Sets console's title with five text. {first text}{seperator}...{last text}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>
        /// <param name="fourthText">Fourth text.</param>
        /// <param name="fifthText">Fifth text.</param>
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null, string fourthText = null, string fifthText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);
            fourthText = SetFourthText(fourthText);
            fifthText = SetFifthText(fifthText);

            // Setting console's title with first, second, third, fourth and fifth text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"" +
                $"{firstText}" +
                $"{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}" +
                $"{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}" +
                $"{(string.IsNullOrEmpty(fourthText) ? "" : s_titleSeperator)}{fourthText}" +
                $"{(string.IsNullOrEmpty(fifthText) ? "" : s_titleSeperator)}{fifthText}";
        }

        /// <summary>
        /// Sets console's title with six text. {first text}{seperator}...{last text}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>
        /// <param name="fourthText">Fourth text.</param>
        /// <param name="fifthText">Fifth text.</param>
        /// <param name="sixthText">Sixth text.</param>
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null, string fourthText = null, string fifthText = null, string sixthText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);
            fourthText = SetFourthText(fourthText);
            fifthText = SetFifthText(fifthText);
            sixthText = SetSixthText(sixthText);

            // Setting console's title with first, second, third, fourth, fifth and sixth text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"" +
                $"{firstText}" +
                $"{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}" +
                $"{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}" +
                $"{(string.IsNullOrEmpty(fourthText) ? "" : s_titleSeperator)}{fourthText}" +
                $"{(string.IsNullOrEmpty(fifthText) ? "" : s_titleSeperator)}{fifthText}" +
                $"{(string.IsNullOrEmpty(sixthText) ? "" : s_titleSeperator)}{sixthText}";
        }

        /// <summary>
        /// Sets console's title with seven text. {first text}{seperator}...{last text}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>
        /// <param name="fourthText">Fourth text.</param>
        /// <param name="fifthText">Fifth text.</param>
        /// <param name="sixthText">Sixth text.</param>
        /// <param name="seventhText">Seventh text.</param>
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null, string fourthText = null, string fifthText = null, string sixthText = null, string seventhText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);
            fourthText = SetFourthText(fourthText);
            fifthText = SetFifthText(fifthText);
            sixthText = SetSixthText(sixthText);
            seventhText = SetSeventhText(seventhText);

            // Setting console's title with first, second, third, fourth, fifth, sixth and seventh text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"" +
                $"{firstText}" +
                $"{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}" +
                $"{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}" +
                $"{(string.IsNullOrEmpty(fourthText) ? "" : s_titleSeperator)}{fourthText}" +
                $"{(string.IsNullOrEmpty(fifthText) ? "" : s_titleSeperator)}{fifthText}" +
                $"{(string.IsNullOrEmpty(sixthText) ? "" : s_titleSeperator)}{sixthText}" +
                $"{(string.IsNullOrEmpty(seventhText) ? "" : s_titleSeperator)}{seventhText}";
        }

        /// <summary>
        /// Sets console's title with eigth text. {first text}{seperator}...{last text}
        /// </summary>
        /// <param name="firstText">First text.</param>
        /// <param name="secondText">Second text.</param>
        /// <param name="thirdText">Third text.</param>
        /// <param name="fourthText">Four text.</param>
        /// <param name="fifthText">Fifth text.</param>
        /// <param name="sixthText">Sixth text.</param>
        /// <param name="seventhText">Seven text.</param>
        /// <param name="eigthText">Eight text.</param>
        public static void SetConsoleTitle(string firstText = null, string secondText = null, string thirdText = null, string fourthText = null, string fifthText = null, string sixthText = null, string seventhText = null, string eigthText = null)
        {
            firstText = SetFirstText(firstText);
            secondText = SetSecondText(secondText);
            thirdText = SetThirdText(thirdText);
            fourthText = SetFourthText(fourthText);
            fifthText = SetFifthText(fifthText);
            sixthText = SetSixthText(sixthText);
            seventhText = SetSeventhText(seventhText);
            eigthText = SetEigthText(eigthText);

            // Setting console's title with first, second, third, fourth, fifth, sixth, seventh and eighth text. Adds provided title seperator if parameter parameter is provided.
            Console.Title = $"" +
                $"{firstText}" +
                $"{(string.IsNullOrEmpty(secondText) ? "" : s_titleSeperator)}{secondText}" +
                $"{(string.IsNullOrEmpty(thirdText) ? "" : s_titleSeperator)}{thirdText}" +
                $"{(string.IsNullOrEmpty(fourthText) ? "" : s_titleSeperator)}{fourthText}" +
                $"{(string.IsNullOrEmpty(fifthText) ? "" : s_titleSeperator)}{fifthText}" +
                $"{(string.IsNullOrEmpty(sixthText) ? "" : s_titleSeperator)}{sixthText}" +
                $"{(string.IsNullOrEmpty(seventhText) ? "" : s_titleSeperator)}{seventhText}" +
                $"{(string.IsNullOrEmpty(eigthText) ? "" : s_titleSeperator)}{eigthText}";
        }

        #endregion Set Console Title

        #region Clear text

        /// <summary>
        /// Clears console title.
        /// </summary>
        public static void ClearConsoleTitle()
        {
            // Set default value null.
            s_titleFirstText = null;

            // Set default value null.
            s_titleSecondText = null;

            // Set default value null.
            s_titleThirdText = null;

            // Set default value null.
            s_titleFourthText = null;

            // Set default value null.
            s_titleFifthText = null;

            // Set default value null.
            s_titleSixthText = null;

            // Set default value null.
            s_titleSeventhText = null;

            // Set default value null.
            s_titleEighthText = null;

            // Set console's title empty.
            Console.Title = "";
        }

        #endregion Clear text
    }
}