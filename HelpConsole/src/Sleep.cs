﻿using System;
using System.Threading;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        /// <summary>
        /// Sleep uses <see cref="Thread.Sleep(int)"/>.
        /// </summary>
        /// <param name="duration">Time in milliseconds.</param>
        //[SupportedOSPlatform("windows")]
        public static void Sleep(int duration)
        {
            // Sleeping.
            Thread.Sleep(duration);
        }

        /// <summary>
        /// Sleep uses <see cref="Thread.Sleep(int)"/>, writes Sleeping {duration} s/ms to console's title via <see cref="SetConsoleTitle(string)"/>.
        /// </summary>
        /// <param name="duration">Time in milliseconds.</param>
        //[SupportedOSPlatform("windows")]
        public static void SleepWithTitle(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            SetConsoleTitle($"Sleeping {NameDuration(duration)}");

            // Sleeping.
            Sleep(duration);

            // Set console title's back.
            SetConsoleTitle(tempTitle);
        }

        /// <summary>
        /// Sleep uses <see cref="Thread.Sleep(int)"/>, writes Sleeping {duration} ms to console's title.
        /// </summary>
        /// <param name="duration"></param>
        //[SupportedOSPlatform("windows")]
        public static void SleepWithBeeping(int duration)
        {
            // Save console title into temporary variable.
            string tempTitle = Console.Title;

            // Set console title specified with duration to indicate sleeping.
            SetConsoleTitle($"Sleeping {NameDuration(duration)}");

            // Beeping.  
            Beep(Beeping(duration));

            // Set console title's back.
            SetConsoleTitle(firstText: tempTitle);
        }

        private static string NameDuration(int duration)
        {
            if (duration < 1000)
            {
                return $"{duration} ms";
            }
            else if (duration < 60000)
            {
                return $"{duration / 1000} s";
            }
            else if (duration < 360000)
            {
                return $"{duration / 60000} m";
            }
            else
            {
                return $"{duration / (1000 * 60 * 60)} h";
            }
        }
    }
}
