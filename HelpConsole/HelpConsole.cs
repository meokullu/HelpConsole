using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HelpConsole
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage8F(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string PercentageNoFrac(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string PercentageNoFrac(double item1, double item2)
        {
            return (item1 * 100 / item2).ToString("0") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string PercentageNoFrac(short item1, short item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string PercentageNoFrac(byte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string PercentageNoFrac(sbyte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage2F(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage2F(double item1, double item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage2F(short item1, short item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage2F(byte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static string Percentage2F(sbyte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }
    }

    public static partial class HelpConsole
    {
        //
        private static string _appName = "";
        private static string _titleFirstText = "";
        private static string _titleSecondText = "";
        private static string _titleThirdText = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstText"></param>
        /// <param name="secondText"></param>
        /// <param name="thirdText"></param>
        public static void SetConsoleTitle(string firstText = "", string secondText = "", string thirdText = "")
        {
            // First Text
            if (firstText == null)
            {
                //
                firstText = _titleFirstText;
            }
            else
            {
                //
                _titleFirstText = firstText;
            }

            // Second Text
            if (secondText == null)
            {
                //
                secondText = _titleSecondText;
            }
            else
            {
                //
                _titleSecondText = secondText;
            }

            // Third Text
            if (thirdText == null)
            {
                //
                thirdText = _titleThirdText;
            }
            else
            {
                //
                _titleThirdText = thirdText;
            }

            //
            Console.Title = $"{firstText} - {secondText} - {thirdText}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appName"></param>
        public static void StartUp(string appName)
        {
            //
            _appName = appName;

            //
            Console.Title = _appName;

            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;

            //
            Console.Beep(475, 75);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FinishingUp()
        {
            //
            Console.Title = "Done...";

            //
            Console.WriteLine("");
            Console.WriteLine("Done...");

            //
            Console.Beep(575, 250);
        }

        /// <summary>
        /// Sleep uses Thread.Sleep, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration"></param>
        public static void Sleep(int duration)
        {
            //
            string tempTitle = Console.Title;

            //
            Console.Title = $"Sleeping {duration} ms";

            //
            Thread.Sleep(duration);

            //
            Console.Title = tempTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="duration"></param>
        public static void SleepWithBeeping(int duration)
        {
            //
            string tempTitle = Console.Title;

            //
            Console.Title = $"Sleeping {duration} ms";

            //
            Console.Beep(325, duration / 4);

            //
            Thread.Sleep(duration / 4);

            //
            Console.Beep(435, duration / 4);

            //
            Thread.Sleep(duration / 4);

            //
            Console.Title = tempTitle;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static partial class HelpConsole
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberName"></param>
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            //
            Console.WriteLine("");

            //
            Console.WriteLine($"{memberName} started...");

            //
            Console.Beep(725, 250);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberName"></param>
        public static void EndingMethod([CallerMemberName] string memberName = "")
        {
            //
            Console.WriteLine("");

            //
            Console.WriteLine($"{memberName} ended...");

            //
            Console.Beep(725, 250);
        }
    }
}