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
        /// Beep for welcome.
        /// </summary>
        public static Melody Welcome = new Melody { Notes = new int[] { 640, 200, 100, 530, 200, 100, 520, 200, 100 } };

        /// <summary>
        /// Beep for warning.
        /// </summary>
        public static Melody Warning = new Melody { Notes = new int[] { 660, 250, 90, 660, 250, 90, 660, 250, 60} };

        /// <summary>
        /// 
        /// </summary>
        public static Melody Error = new Melody { Notes = new int[] { 554, 750, 250, 554, 750, 250, 554, 250, 558} };

        /// <summary>
        /// Beep for success. 
        /// </summary>
        public static Melody Success = new Melody { Notes = new int[] { 800, 200, 100, 800, 250, 150, 800, 250, 200} };

        /// <summary>
        /// Beep for fail.
        /// </summary>
        public static Melody Fail = new Melody { Notes = new int[] { 340, 750, 500, 340, 750, 500} };


        #region Melodies

        /// <summary>
        /// Start up beeping frequency and duration.
        /// </summary>
        public static Melody StartingUp = new Melody { Notes = new int[] { 440, 190, 60, 660, 190, 60 } };

        /// <summary>
        /// Finish up beeping frequency and duration.
        /// </summary>
        public static Melody FinishingUp = new Melody { Notes = new int[] { 720, 400, 100, 720, 400, 100 } };

        #endregion Melodies
    }
}
