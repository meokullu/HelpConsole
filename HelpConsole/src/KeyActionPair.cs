using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HelpConsole
{
    public partial class HelpConsole
    {        
        #region List of Key-Action pair

        /// <summary>
        /// Key-Action pair list that holds values which will be used by KeyAction(ConsoleKeyInfo cki).
        /// </summary>
        public static List<Tuple<ConsoleKeyInfo, Action>> KeyActionPairList = new List<Tuple<ConsoleKeyInfo, Action>>();

        #endregion List of Key-Action pair

        #region Add, List and Clear of Key-Action pair list.

        /// <summary>
        /// Adds Key-Action pair into KeyActionPairList which will be used by KeyAction(ConsoleKeyInfo cki).
        /// </summary>
        /// <param name="cki">ConsoleKeyInfo constructed by either ConsoleKeyInfo(char keyChar, ConsoleKey consoleKey) or predefined ConsoleKeyInfo(char keyChar, ConsoleKey consoleKey, bool alt, bool shift, bool ctrl)</param>
        /// <param name="action">An action to be called with match of cki.</param>
        public static void AddKeyActionPair(ConsoleKeyInfo cki, Action action)
        {
            // Check pair is already added into the list.
            if (KeyActionPairList.Any(p=> p == new Tuple<ConsoleKeyInfo, Action>(cki, action)))
            {
                Debug.WriteLine("HelpConsole:Key is defined already on Key-Action pair list. Use ListKeyActionPairList()");

                return;
            }

            // Adding given value into the list.
            KeyActionPairList.Add(new Tuple<ConsoleKeyInfo, Action>(cki, action));
        }

        /// <summary>
        /// List Key-Action par list.
        /// </summary>
        public static void ListKeyActionPairList()
        {
            // Variable of cki value.
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            // Loop to print all items.
            for (int i = 0; i < KeyActionPairList.Count; i++)
            {
                // set variable from the list with first element of tuple.
                cki = KeyActionPairList[i].Item1;

                // Checking if KeyChar is empty character.
                if (cki.KeyChar != ' ')
                {
                    // Writing KeyChar value.
                    Write($"KeyChar: {cki.KeyChar} ");
                }

                // Writing rest of the values of ConsoleKeyInfo.
                Write($"Key: {cki.Key} ");

                if (cki.Modifiers != 0)
                {
                    Write($"Mods: {Enum.GetName(typeof(ConsoleModifiers), cki.Modifiers)} ");
                }

                WriteLine($"Action: {KeyActionPairList[i].Item2.Method.Name}");
            }
        }

        /// <summary>
        /// Clear all items of Key-Action pair list.
        /// </summary>
        public static void ClearKeyActionPairList()
        {
            // Calling clear() function of List.
            KeyActionPairList.Clear();
        }

        #endregion Add, List and Clear of Key-Action pair list.

        #region Wait

        /// <summary>
        /// Waits for callers input then calls KeyAction(ConsoleKeyInfo cki) with input. <seealso cref="KeyAction(System.ConsoleKeyInfo)"/>
        /// </summary>
        public static ConsoleKeyInfo WaitKeyAction()
        {
            ConsoleKeyInfo? cki = null;

            while (cki == null)
            {
                // Wait for a key.
                cki = Console.ReadKey();
            }

            // Checking if cki is in Key-Action pair list.            
            if (KeyActionPairList.Select(p => p.Item1).Any(q => q == cki))
            {
                WriteLine("");

                // cki is not null now.
                KeyAction(cki.Value);

                // Returning pressed key.
                return cki.Value;
            }
            else
            {
                Debug.WriteLine("HelpConsole:Key is not defined on Key-Action pair list. Use AddKeyActionPair() or ListKeyActionPairList()");

                // Returning pressed key.
                return cki.Value;
            }
        }

        /// <summary>
        /// Writes given message and calls WaitKeyAction().
        /// </summary>
        /// <param name="message">A message to write for asking caller to press a key.</param>
        public static ConsoleKeyInfo WaitKeyAction(string message)
        {
            Write(message);
            return WaitKeyAction();
        }

        #endregion Wait

        #region Do

        /// <summary>
        /// Call action by predefined on Key-Action pair list.
        /// </summary>
        /// <param name="cki">ConsoleKeyInfo to call predefined Action</param>
        public static void KeyAction(ConsoleKeyInfo cki)
        {
            // Get action for the list.
            Action action = KeyActionPairList.Where(p => p.Item1 == cki).Select(q => q.Item2).SingleOrDefault();

            // Checking if it is null.
            if (action == null)
            {
                // Inform user that action is not defined.
                Debug.WriteLine("HelpConsole: Action is not defined on list.");
            }
            else
            {
                // calling action.
                action();
            }
        }

        #endregion Do
    }
}
