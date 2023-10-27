using System;
using System.Runtime.CompilerServices;

namespace HelpConsole
{

    /// <summary>
    /// Methods helpers.
    /// </summary>
    public static partial class HelpConsole
    {
        // Start up beeping frequency.
        private const int _startBeepFreqency = 725;

        // Start up beeping duration.
        private const int _startBeepDuration = 500;

        // Finish up beeping frequency.
        private const int _endBeepDuration = 525;

        // Finish up beeping duration.
        private const int _endBeepFrequency = 500;

        /// <summary>
        /// Method starting with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing the method's name.
            Console.WriteLine($"{memberName} started...");

            // Checks if warning sound is active.
            if (_consoleOptions.WarningSound)
            {
                // Beep sounds.
                Console.Beep(_startBeepFreqency, _startBeepDuration);
            }
        }

        /// <summary>
        /// Method ending with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void EndingMethod([CallerMemberName] string memberName = "")
        {
            // Skipping line.
            Console.WriteLine("");

            // Writing a method's name.
            Console.WriteLine($"{memberName} ended...");

            // Checks if warning sound is active.
            if (_consoleOptions.WarningSound)
            {
                // Beep sounds.
                Console.Beep(_endBeepFrequency, _endBeepDuration);
            }
        }
    }
}
