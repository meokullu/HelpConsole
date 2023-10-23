using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelpConsole
{
    /// <summary>
    /// Beep.
    /// </summary>
    public partial class HelpConsole
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public class Melody
        //{
        //    /// <summary>
        //    /// 
        //    /// </summary>
        //    public int[] Notes;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="melody"></param>
        //public static void Beep(Melody melody)
        //{
        //    // Checking if melody is null.
        //    if (melody == null)
        //    {
        //        // Throwing null exception to indicate provided value is null.
        //        throw new ArgumentNullException("Melody is null");
        //    }

        //    // Checking if melody is null.
        //    if (melody.Notes.Length == 0)
        //    {
        //        // Throwing null exception to indicate provided value is null.
        //        throw new ArgumentNullException("Melody content is null");
        //    }
        //}

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
