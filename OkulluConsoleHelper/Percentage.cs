namespace OkulluConsoleHelper
{
    public static class Helper
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
}