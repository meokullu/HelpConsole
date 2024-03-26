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
        /// Beep for beeping method. <see cref="SleepWithBeeping(int)"/>
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static Melody Beeping(int duration)
        {
            return new Melody { Notes = new int[] { 725, duration, duration } };
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
                throw new ArgumentNullException(nameof(melody), "melody is null.");
            }

            // Checking if melody's notes is null.
            if (melody.Notes == null)
            {
                // Throwing null exception to indicate provided value is null.
                throw new ArgumentNullException(nameof(melody), "melody notes is null.");
            }

            // Checking if melody is null.
            if (melody.Notes.Length == 0)
            {
                // Throwing null exception to indicate provided value is null.
                throw new ArgumentNullException(nameof(melody), "melody doesn't have notes.");
            }

            // Loop for notes array.
            for (int i = 0; i < melody.Notes.Length; i = i + 3)
            {
                // Checking if the frequency is in range. [frequency-beeping duration-waiting duration]
                if (melody.Notes[i] < 37 || melody.Notes[i] > 32767)
                {
                    //
                    WriteLine($"Error on notes. Note at index: {i} {(melody.Notes[i] < 37 ? "should be greater than 37" : "")} {(melody.Notes[i] > 32767 ? "should be lower than 32767" : "")}");

                    //
                    continue;
                }

                // Checking if the beeping duration or waitin duration are positive values.
                if (melody.Notes[i + 1] <= 0 || melody.Notes[i + 2] <= 0)
                {
                    //
                    WriteLine($"Error on notes. Notes at index: {i + 1}/{i + 2} {(melody.Notes[i + 1] <= 0 ? "beeping duration should be greater than 0" : "")} {(melody.Notes[i + 2] <= 0 ? "waiting duration should be greater than 0" : "")}");

                    //
                    continue;
                }

                // Beeping from Console.
                Console.Beep(melody.Notes[i], melody.Notes[i + 1]);

                //
                if (melody.Notes[i + 2] != 0)
                {
                    //
                    Thread.Sleep(melody.Notes[i + 2]);
                }
            }
        }        
    }
}
