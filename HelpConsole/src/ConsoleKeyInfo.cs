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

        public static ConsoleKeyInfo KeyA = ConsoleKeyInfo('A', ConsoleKey.A);
        public static ConsoleKeyInfo KeyB = ConsoleKeyInfo('B', ConsoleKey.B);
        public static ConsoleKeyInfo KeyC = ConsoleKeyInfo('C', ConsoleKey.C);
        public static ConsoleKeyInfo KeyD = ConsoleKeyInfo('D', ConsoleKey.D);
        public static ConsoleKeyInfo KeyE = ConsoleKeyInfo('E', ConsoleKey.E);

        public static ConsoleKeyInfo KeyF = ConsoleKeyInfo('F', ConsoleKey.F);
        public static ConsoleKeyInfo KeyG = ConsoleKeyInfo('G', ConsoleKey.G);
        public static ConsoleKeyInfo KeyH = ConsoleKeyInfo('H', ConsoleKey.H);
        public static ConsoleKeyInfo KeyI = ConsoleKeyInfo('I', ConsoleKey.I);
        public static ConsoleKeyInfo KeyJ = ConsoleKeyInfo('J', ConsoleKey.J);

        public static ConsoleKeyInfo KeyK = ConsoleKeyInfo('K', ConsoleKey.K);
        public static ConsoleKeyInfo KeyL = ConsoleKeyInfo('L', ConsoleKey.L);
        public static ConsoleKeyInfo KeyM = ConsoleKeyInfo('M', ConsoleKey.M);
        public static ConsoleKeyInfo KeyN = ConsoleKeyInfo('N', ConsoleKey.N);
        public static ConsoleKeyInfo KeyO = ConsoleKeyInfo('O', ConsoleKey.O);

        public static ConsoleKeyInfo KeyP = ConsoleKeyInfo('P', ConsoleKey.P);
        public static ConsoleKeyInfo KeyQ = ConsoleKeyInfo('Q', ConsoleKey.Q);
        public static ConsoleKeyInfo KeyR = ConsoleKeyInfo('R', ConsoleKey.R);
        public static ConsoleKeyInfo KeyS = ConsoleKeyInfo('S', ConsoleKey.S);
        public static ConsoleKeyInfo KeyT = ConsoleKeyInfo('T', ConsoleKey.T);

        public static ConsoleKeyInfo KeyU = ConsoleKeyInfo('U', ConsoleKey.U);
        public static ConsoleKeyInfo KeyV = ConsoleKeyInfo('V', ConsoleKey.V);
        public static ConsoleKeyInfo KeyW = ConsoleKeyInfo('W', ConsoleKey.W);
        public static ConsoleKeyInfo KeyX = ConsoleKeyInfo('X', ConsoleKey.X);
        public static ConsoleKeyInfo KeyY = ConsoleKeyInfo('Y', ConsoleKey.Y);

        public static ConsoleKeyInfo KeyZ = ConsoleKeyInfo('Z', ConsoleKey.Z);
    }
}
