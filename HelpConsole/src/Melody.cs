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
        /// Beep for warning. Total duration: 500 ms.
        /// </summary>
        public static Melody Warning = new Melody { Notes = new int[] { 440, 190, 60, 440, 190, 60 } };

        /// <summary>
        /// Beep for welcome. Total duration: 1.500 ms.
        /// </summary>
        public static Melody Welcome = new Melody { Notes = new int[] { 2000, 400, 100, 1750, 400, 100, 1500, 400, 100 } };

        /// <summary>
        /// Beep for success. 
        /// </summary>
        public static Melody Success = new Melody { Notes = new int[] { 750, 225, 75, 650, 225, 75, 850, 225, 275, 450, 225, 75 } };
    }
}
