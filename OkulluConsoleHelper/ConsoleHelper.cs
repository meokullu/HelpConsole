namespace OkulluConsoleHelper
{
    public static partial class Helper
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

        public static string PercentageNoFram(short item1, short item2)
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

    public static partial class Helper
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
}