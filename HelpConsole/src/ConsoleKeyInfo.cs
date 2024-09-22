using System;

namespace HelpConsole
{
    /// <summary>
    /// ConsoleKeyInfo.
    /// </summary>
    public partial class HelpConsole
    {
        #region Transition of charKey to ConsoleKey

        //private static ConsoleKey ToConsoleKeyInfo(char charKey)
        //{
        //    return (ConsoleKey)System.Enum.Parse(typeof(ConsoleKey), charKey.ToString());
        //}

        #endregion Transition of charKey to ConsoleKey

        #region Additional constructors

        //public static ConsoleKeyInfo ConsoleKeyInfo(char keyChar) => new ConsoleKeyInfo(keyChar: keyChar, ToConsoleKeyInfo(keyChar), false, false, false);

        /// <summary>
        /// ConsoleKeyInfo consructor works with keyChar and key, all modes are false.
        /// </summary>
        /// <param name="keyChar">A character on keybord represented by a char.</param>
        /// <param name="key">A key that is defined on ConsoleKey enum. Integere value of key must be between 0 and 255.</param>
        /// <returns>ConsoleKeyInfo consists keyChar, key and mods.</returns>
        public static ConsoleKeyInfo ConsoleKeyInfo(char keyChar, ConsoleKey key) => new ConsoleKeyInfo(keyChar: keyChar, key: key, shift: false, alt: false, control: false);

        #endregion Additional constructors
    }
}
