using System;
using System.Runtime.CompilerServices;

namespace HelpConsole
{
    /// <summary>
    /// Methods helpers.
    /// </summary>
    public static partial class HelpConsole
    {
        #region Melodies

        /// <summary>
        /// Melody whose played when <see cref="StartingMethod(string)"/> is called.
        /// </summary>
        private static Melody s_startMethodMelody = new Melody { Notes = new int[] { 725, 500, 0 } };

        /// <summary>
        /// Sets melody that is played when <see cref="StartingMethod(string)"/> is called.
        /// </summary>
        /// <param name="melody"></param>
        public static void SetStartMethodMelody(Melody melody)
        {
            // Sets default value with melody.
            s_startMethodMelody = melody;
        }

        /// <summary>
        /// Melody whose played when <see cref="EndingMethod(string)"/> is called.
        /// </summary>
        private static Melody s_endMethodMelody = new Melody { Notes = new int[] { 525, 500, 0 } };

        /// <summary>
        /// Sets melody that is played when <see cref="EndingMethod(string)"/> is called.
        /// </summary>
        /// <param name="melody"></param>
        public static void SetEndingMethodMelody(Melody melody)
        {
            // Sets default value with melody.
            s_endMethodMelody = melody;
        }

        #endregion Melodies

        /// <summary>
        /// Method starting with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void StartingMethod([CallerMemberName] string memberName = "")
        {
            // Writing the method's name.
            Console.WriteLine($"{memberName} started...");

            // Checks if warning sound is active.
            if (s_consoleOptions.WarningSound)
            {
                // Beep sounds
                Beep(s_startMethodMelody);
            }
        }

        /// <summary>
        /// Method ending with writing its name and beeping.
        /// </summary>
        /// <param name="memberName">Catches method's name.</param>
        //[SupportedOSPlatform("windows")]
        public static void EndingMethod([CallerMemberName] string memberName = "")
        {
            // Writing a method's name.
            Console.WriteLine($"{memberName} ended...");

            // Checks if warning sound is active.
            if (s_consoleOptions.WarningSound)
            {
                // Beep sounds.
                Beep(s_endMethodMelody);
            }
        }
    }
}
