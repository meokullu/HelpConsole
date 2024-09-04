using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        #region List of Key-Func pair

        /// <summary>
        /// Key-Func pair list that holds values which will be used by KeyFunc(ConsoleKeyInfo cki).
        /// </summary>
        public static List<Tuple<ConsoleKeyInfo, Func<object>>> KeyFuncPairList = new List<Tuple<ConsoleKeyInfo, Func<object>>>();

        #endregion List of Key-Func pair

        #region Add, List and Clear of Key-Func pair list.

        /// <summary>
        /// Adds Key-Func pair into KeyFuncPairList which will be used by KeyFunc(ConsoleKeyInfo cki).
        /// </summary>
        /// <param name="cki">ConsoleKeyInfo constructed by either ConsoleKeyInfo(char keyChar, ConsoleKey consoleKey) or predefined ConsoleKeyInfo(char keyChar, ConsoleKey consoleKey, bool alt, bool shift, bool ctrl)</param>
        /// <param name="func">An func to be called with match of cki. Object is a result type.</param>
        public static void AddKeyFuncPair(ConsoleKeyInfo cki, Func<object> func)
        {
            // Check pair is already added into the list.
            if (KeyFuncPairList.Any(p => p == new Tuple<ConsoleKeyInfo, Func<object>>(cki, func)))
            {
                Debug.WriteLine("HelpConsole:Key is defined already on Key-Func pair list. Use ListKeyFuncPairList()");

                return;
            }

            KeyFuncPairList.Add(new Tuple<ConsoleKeyInfo, Func<object>>(cki, func));
        }

        /// <summary>
        /// List Key-Func par list.
        /// </summary>
        public static void ListKeyFuncPairList()
        {
            // Variable of cki value.
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            // Loop to print all items.
            for (int i = 0; i < KeyFuncPairList.Count; i++)
            {
                // set variable from the list with first element of tuple.
                cki = KeyFuncPairList[i].Item1;

                // Checking if KeyChar is empty character.
                if (cki.KeyChar != ' ')
                {
                    // Writing KeyChar value.
                    Write($"KeyChar: {cki.KeyChar} ");
                }

                // Writing rest of the values of ConsoleKeyInfo.
                Write($"Key: {cki.Key} ");

                WriteLine(cki.Modifiers);

                if (cki.Modifiers != 0)
                {
                    Write($"Mods: {Enum.GetName(typeof(ConsoleModifiers), cki.Modifiers)} ");
                }

                WriteLine($"Func: {KeyFuncPairList[i].Item2.Method.Name}");                
            }
        }

        /// <summary>
        /// Clear all items of Key-Func pair list.
        /// </summary>
        public static void ClearKeyFuncPairList()
        {
            KeyFuncPairList.Clear();
        }

        #endregion Add, List and Clear of Key-Func pair list.

        #region Wait

        /// <summary>
        /// Waits for callers input then calls KeyFunc(ConsoleKeyInfo cki) with input. <seealso cref="KeyFunc(System.ConsoleKeyInfo)"/>
        /// </summary>
        public static ConsoleKeyInfo WaitKeyFunc()
        {
            ConsoleKeyInfo? cki = null;

            while (cki == null)
            {
                // Wait for a key.
                cki = Console.ReadKey();
            }

            // Checking if cki is in Key-Action pair list.
            if (KeyFuncPairList.Select(p => p.Item1).Any(q => q == cki))
            {
                // cki is not null now.
                KeyFunc(cki.Value);

                // Returning pressed key.
                return cki.Value;
            }
            else
            {
                Debug.WriteLine("HelpConsole:Key is not defined on Key-Func pair list. Use AddKeyFuncPair() or ListKeyFuncPairList()");

                // Returning pressed key.
                return cki.Value;
            }
        }

        /// <summary>
        /// Writes given message and calls WaitKeyFunc().
        /// </summary>
        /// <param name="message">A message to write for asking caller to press a key.</param>
        public static ConsoleKeyInfo WaitKeyFunc(string message)
        {
            Write(message);
            return WaitKeyFunc();
        }

        #endregion Wait

        #region Do

        /// <summary>
        /// Call func by predefined on Key-Func pair list.
        /// </summary>
        /// <param name="cki">ConsoleKeyInfo to call predefined Func</param>
        public static object KeyFunc(ConsoleKeyInfo cki)
        {
            // Get func for the list.
            Func<object> func = KeyFuncPairList.Where(p => p.Item1 == cki).Select(q => q.Item2).SingleOrDefault();

            // Checking if it is null.
            if (func == null)
            {
                // Inform user that func is not defined.
                Debug.WriteLine("HelpConsole: Func is not defined on list.");

                return null;
            }
            else
            {
                // calling func.
                return func();
            }
        }

        #endregion Do
    }
}