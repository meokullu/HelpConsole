namespace HelpConsole
{
    /// <summary>
    /// Percentage helpers.
    /// </summary>
    public partial class HelpConsole
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
}
