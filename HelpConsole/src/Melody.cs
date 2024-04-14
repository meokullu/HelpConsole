namespace HelpConsole
{
    public partial class HelpConsole
    {
        /// <summary>
        /// Melody holds integer array with an order of sound frequency, duuration of sound and waiting.
        /// </summary>
        public class Melody
        {
            /// <summary>
            /// Pairs of (frequency between 38 and 32767, duration of beep, waiting).
            /// </summary>
            public int[] Notes;
        }

        /// <summary>
        /// Beep for warning.
        /// </summary>
        public static Melody Warning = new Melody { Notes = new int[] { 440, 250, 5, 440, 250, 50 } };

        /// <summary>
        /// Beep for welcome.
        /// </summary>
        public static Melody Welcome = new Melody { Notes = new int[] { 2000, 400, 25, 1750, 400, 25, 1500, 400, 25 } };

        /// <summary>
        /// Beep for success.
        /// </summary>
        public static Melody Success = new Melody { Notes = new int[] { 750, 200, 25, 650, 200, 25, 850, 200, 25, 450, 200, 25 } };
    }
}
