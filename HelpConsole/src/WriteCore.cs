using System;

namespace HelpConsole
{
    /// <summary>
    /// Calls Console.Write().
    /// </summary>
    public partial class HelpConsole
    {
        #region Write

        /// <summary>
        /// Calls <see cref="Console.Write(bool)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(bool value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(char)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(char value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(char[])"/>.
        /// </summary>
        /// <param name="buffer">Value to write.</param>
        public static void Write(char[] buffer)
        {
            Console.Write(buffer: buffer);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(char[], int, int)"/>.
        /// </summary>
        /// <param name="buffer">Value to write.</param>
        /// <param name="index">Starting index.</param>
        /// <param name="count">Count of specified array length.</param>
        public static void Write(char[] buffer, int index, int count)
        {
            Console.Write(buffer: buffer, index: index, count: count);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(decimal)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(decimal value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(double)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(double value)
        {
            Console.Write(value: value);
        }
         
        /// <summary>
        /// Calls <see cref="Console.Write(float)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(float value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(int)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(int value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(uint)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(uint value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(long)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(long value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(ulong)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(ulong value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(object value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(string value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        public static void Write(string format, object arg0)
        {
            Console.Write(format: format, arg0: arg0);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string, object, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        /// <param name="arg1">Object to write on format.</param>
        public static void Write(string format, object arg0, object arg1)
        {
            Console.Write(format: format, arg0: arg0, arg1: arg1);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string, object, object)"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg0">Object to write on format.</param>
        /// <param name="arg1">Object to write on format.</param>
        /// <param name="arg2">Object to write on format.</param>
        public static void Write(string format, object arg0, object arg1, object arg2)
        {
            Console.Write(format: format, arg0: arg0, arg1: arg1, arg2: arg2);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string, object[])"/>. Parameter is not nullable.
        /// </summary>
        /// <param name="format">String format.</param>
        /// <param name="arg">Object list to write on format.</param>
        public static void Write(string format, params object[] arg)
        {
            Console.Write(format: format, arg: arg);
        }

        #endregion Write
    }
}
