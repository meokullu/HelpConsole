using System;

namespace HelpConsole
{
    /// <summary>
    /// Calls Console.WriteLine().
    /// </summary>
    public partial class HelpConsole
    {
        #region WriteLine

        /// <summary>
        /// Calls <see cref="Console.WriteLine(bool)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(bool value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(char)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(char value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(char[])"/>.
        /// </summary>
        /// <param name="buffer">Value to write.</param>
        public static void WriteLine(char[] buffer)
        {
            //
            Console.WriteLine(buffer: buffer);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(char[], int, int)"/>.
        /// </summary>
        /// <param name="buffer">Value to write.</param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public static void WriteLine(char[] buffer, int index, int count)
        {
            //
            Console.WriteLine(buffer: buffer, index: index, count: count);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(decimal)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(decimal value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(double)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(double value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(float)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(float value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(int)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(int value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(uint)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(uint value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(long)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(long value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(ulong)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(ulong value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(object value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(string value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        public static void WriteLine(string format, object arg0)
        {
            Console.WriteLine(format: format, arg0: arg0);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string, object, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        /// <param name="arg1">Object to write on format.</param>
        public static void WriteLine(string format, object arg0, object arg1)
        {
            Console.WriteLine(format: format, arg0: arg0, arg1: arg1);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string, object, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        /// <param name="arg1">Object to write on format.</param>
        /// <param name="arg2">Object to write on format.</param>
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format: format, arg0: arg0, arg1: arg1, arg2: arg2);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string, object[])"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg">Object list to write on format.</param>
        public static void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format: format, arg: arg);
        }

        #endregion WriteLine
    }
}
