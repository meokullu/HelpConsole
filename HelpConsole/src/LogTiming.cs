using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        internal static readonly Stopwatch s_stopwatch = new Stopwatch();

        private static List<LogTiming> s_logTimingList = new List<LogTiming>();

        /// <summary>
        /// List of log timings.
        /// </summary>
        public static List<LogTiming> LogTimingList => s_logTimingList;

        /// <summary>
        /// A class holds values to measure execution time of methods.
        /// </summary>
        public class LogTiming
        {
            /// <summary>
            /// Name of methods.
            /// </summary>
            public string MethodName { get; set; }

            /// <summary>
            /// Start time of execution.
            /// </summary>
            public TimeSpan? StartedAt { get; set; }

            /// <summary>
            /// End time of execution.
            /// </summary>
            public TimeSpan? FinishedAt { get; set; }

            /// <summary>
            /// Constructor of LogTiming.
            /// </summary>
            /// <param name="methodName">Name of method.</param>
            /// <param name="startedAt">Start time of execution.</param>
            /// <param name="finishedAt">End time of execution.</param>
            public LogTiming(string methodName, TimeSpan? startedAt, TimeSpan? finishedAt)
            {
                MethodName = methodName;
                StartedAt = startedAt;
                FinishedAt = finishedAt;
            }

            /// <summary>
            /// Override string for LogTiming.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{MethodName} S: {StartedAt} F: {FinishedAt} E: {FinishedAt - StartedAt}";
            }
        }

        /// <summary>
        /// Adds logTiming item into list if it doesn't exists. If method name exists with startTime is not null, it changes first item's finish time with given one.
        /// </summary>
        /// <param name="logTiming"></param>
        public static void AddLogTiming(LogTiming logTiming)
        {
            // Checks if method name exists and start time is not null on the list.
            if (s_logTimingList.Any(p => p.MethodName == logTiming.MethodName && p.StartedAt != null))
            {
                // Sets value of finish time of the item.
                s_logTimingList.Where(p => p.MethodName == logTiming.MethodName && p.StartedAt != null).FirstOrDefault().FinishedAt = logTiming.FinishedAt;
            }
            else
            {
                // Adds item into the list.
                s_logTimingList.Add(logTiming);
            }
        }

        /// <summary>
        /// Print LogTiming list. Method name, start time, finish time and execution time.
        /// </summary>
        public static void ListLogTiming()
        {
            LogTiming logTiming;

            for (int i = 0; i < s_logTimingList.Count(); i++)
            {
                logTiming = s_logTimingList[i];

                Write(logTiming.MethodName);
                Write("   ");
                Write(logTiming.StartedAt);
                Write("   ");
                Write(logTiming.FinishedAt);
                Write("   ");
                Write(logTiming.FinishedAt - logTiming.StartedAt);
                WriteLine("");
            }
        }
    }
}
