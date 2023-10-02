using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HelpConsole
{
    public static partial class HelpConsole
    {
        public static string Percentage8F(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00000000") + "%";
        }

        public static string PercentageNoFrac(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        public static string PercentageNoFrac(double item1, double item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        public static string PercentageNoFrac(short item1, short item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        public static string PercentageNoFrac(byte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        public static string PercentageNoFrac(sbyte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0") + "%";
        }

        public static string Percentage2F(int item1, int item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        public static string Percentage2F(double item1, double item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        public static string Percentage2F(short item1, short item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        public static string Percentage2F(byte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }

        public static string Percentage2F(sbyte item1, byte item2)
        {
            return (item1 * 100 / (double)item2).ToString("0.00") + "%";
        }
    }

    public static partial class HelpConsole
    {
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
    }

    public static partial class HelpConsole
    {
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            //
            Console.WriteLine("");

            //
            Console.WriteLine($"{memberName} started...");

            //
            Console.Beep(725, 250);
        }

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