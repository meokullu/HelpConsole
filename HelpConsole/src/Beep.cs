using System;
using System.Threading;

namespace HelpConsole
{
    /// <summary>
    /// Beep.
    /// </summary>
    public partial class HelpConsole
    {
        /// <summary>
        /// Beep for warning.
        /// </summary>
        public static Melody Warning = new Melody { Notes = new int[]{ 250, 250, 0 } };

        /// <summary>
        /// Beep for welcome.
        /// </summary>
        public static Melody Welcome = new Melody { Notes = new int[] { 2000, 400, 25, 1750, 400, 25, 1650, 400, 25 } };

        /// <summary>
        /// Beep for success.
        /// </summary>
        public static Melody Success = new Melody { Notes = new int[] { 750, 200, 100, 650, 250, 100, 850, 150, 65, 450, 450, 0 } };

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
        /// Plays provided melody.
        /// </summary>
        /// <param name="melody">Array of frequency, duration of beeping and waiting list.</param>
        public static void Beep(Melody melody)
        {
            // Checking if melody is null.
            if (melody == null)
            {
                // Throwing null exception to indicate provided value is null.
                throw new ArgumentNullException("Melody is null");
            }

            // Checking if melody is null.
            if (melody.Notes.Length == 0)
            {
                // Throwing null exception to indicate provided value is null.
                throw new ArgumentNullException("Melody content is null");
            }

            // Loop for notes array.
            for (int i = 0; i < melody.Notes.Length; i = i + 3)
            {
                // Checking if frequency of note is in range, it
                if (melody.Notes[i] < 37 || melody.Notes[i] > 32767 || melody.Notes[i + 1] < 0 || melody.Notes[i + 2] < 0 )
                {
                    //
                    Console.WriteLine("Error on notes");

                    //
                    continue;
                }

                //
                Console.Beep(melody.Notes[i], melody.Notes[i + 1]);

                //
                if (melody.Notes[i + 2] != 0)
                {
                    //
                    Thread.Sleep(melody.Notes[i + 2]);
                }

                //
                Console.WriteLine(i);
            }
        }

        // Warning beep frequency.
        private const int _warningBeepFrequency = 725;

        /// <summary>
        /// Sleep uses Thread.Sleep, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration">Time in milliseconds.</param>
        //[SupportedOSPlatform("windows")]
        public static void Sleep(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            Console.Title = $"Sleeping {duration} ms";

            // Sleeping.
            Thread.Sleep(duration);

            // Set console title's back.
            Console.Title = tempTitle;
        }

        /// <summary>
        /// Sleep uses Thread.Sleep, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration"></param>
        //[SupportedOSPlatform("windows")]
        public static void SleepWithBeeping(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            Console.Title = $"Sleeping {duration} ms";

            // Beeping. One fourth of duration.
            Console.Beep(_warningBeepFrequency, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // Beeping. One fourth of duration.
            Console.Beep(_warningBeepFrequency, duration / 4);

            // Sleeping. One fourth of duration.
            Thread.Sleep(duration / 4);

            // // Set console title's back.
            Console.Title = tempTitle;
        }
    }
}
