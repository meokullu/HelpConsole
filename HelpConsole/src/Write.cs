using System;
using System.Collections.Generic;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        #region Console Colors

        // ConsoleColor available colors.
        /// <summary>
        /// ConsoleColor Black.
        /// </summary>
        public static readonly ConsoleColor Black = ConsoleColor.Black;
        
        /// <summary>
        /// ConsoleColor DarkBlue.
        /// </summary>
        public static readonly ConsoleColor DarkBlue = ConsoleColor.DarkBlue;

        /// <summary>
        /// ConsoleColor DarkGreen.
        /// </summary>
        public static readonly ConsoleColor DarkGreen = ConsoleColor.DarkGreen;
        
        /// <summary>
        /// ConsoleColor DarkCyan.
        /// </summary>
        public static readonly ConsoleColor DarkCyan = ConsoleColor.DarkCyan;
        
        /// <summary>
        /// ConsoleColor DarkRed.
        /// </summary>
        public static readonly ConsoleColor DarkRed = ConsoleColor.DarkRed;
        
        /// <summary>
        /// ConsoleColor DarkMagenta.
        /// </summary>
        public static readonly ConsoleColor DarkMagenta = ConsoleColor.DarkMagenta;
        
        /// <summary>
        /// ConsoleColor DarkYellow.
        /// </summary>
        public static readonly ConsoleColor DarkYellow = ConsoleColor.DarkYellow;
        
        /// <summary>
        /// ConsoleColor Gray.
        /// </summary>
        public static readonly ConsoleColor Gray = ConsoleColor.Gray;
        
        /// <summary>
        /// ConsoleColor DarkGray.
        /// </summary>
        public static readonly ConsoleColor DarkGray = ConsoleColor.DarkGray;
        
        /// <summary>
        /// ConsoleColor Blue.
        /// </summary>
        public static readonly ConsoleColor Blue = ConsoleColor.Blue;
        
        /// <summary>
        /// ConsoleColor Green.
        /// </summary>
        public static readonly ConsoleColor Green = ConsoleColor.Green;
        
        /// <summary>
        /// ConsoleColor Cyan.
        /// </summary>
        public static readonly ConsoleColor Cyan = ConsoleColor.Cyan;
        
        /// <summary>
        /// ConsoleColor Red.
        /// </summary>
        public static readonly ConsoleColor Red = ConsoleColor.Red;
        
        /// <summary>
        /// ConsoleColor Magenta.
        /// </summary>
        public static readonly ConsoleColor Magenta = ConsoleColor.Magenta;
        
        /// <summary>
        /// ConsoleColor Yellow.
        /// </summary>
        public static readonly ConsoleColor Yellow = ConsoleColor.Yellow;
        
        /// <summary>
        /// ConsoleColor White.
        /// </summary>
        public static readonly ConsoleColor White = ConsoleColor.White;

        #endregion Console Colors

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
        /// Calls <see cref="Console.Write(double)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(double value)
        {
            Console.Write(value: value);
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
        /// Calls <see cref="Console.Write(object)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(object value)
        {
            Console.Write(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.Write(string)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void Write(string value)
        {
            Console.Write(value: value);
        }

        #endregion Write

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
        /// Calls <see cref="Console.WriteLine(double)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(double value)
        {
            //
            Console.WriteLine(value: value);
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
        /// Calls <see cref="Console.WriteLine(object)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(object value)
        {
            //
            Console.WriteLine(value: value);
        }

        /// <summary>
        /// Calls <see cref="Console.WriteLine(string)"/>.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(string value)
        {
            //
            Console.WriteLine(value: value);
        }

        #endregion WriteLine

        /// <summary>
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified text color as ConsoleColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="color">Text color.</param>
        public static void Write<T>(T value, ConsoleColor color)
        {
            // Temporary data for previous color settings.
            ConsoleColor consoleBGColor = Console.BackgroundColor;
            ConsoleColor consoleFGColor = Console.ForegroundColor;

            // Set screen color to specified color. foregroundColor is color for text color.
            SetScreenColors(new ScreenColorOption(foregroundColor: color, backgroundColor: consoleBGColor));

            // Calling Console.Write(object value).
            Write(value: value);

            // Set screen colors back to previous setting.
            SetScreenColors(new ScreenColorOption(foregroundColor: consoleFGColor, backgroundColor: consoleBGColor));
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified <see cref="Melody"/>.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="melody">A melody whose to be played.</param>
        public static void Write<T>(T value, Melody melody)
        {
            // Calling Console.Write(object value).
            Write(value: value);

            // Beep sounds.
            Beep(melody: melody);
        }

        /// <summary>
        /// Writes value into screen via <see cref="Write{T}(T, ConsoleColor)"/> with specified exoectedColor when value is expectedValue, otherwise writes with valueColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueList">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void Write<T>(List<T> valueList, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueList.Count; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueList[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write(value: valueList[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write(value: valueList[i], color: expectedColor);
                }
            }
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified text color as ConsoleColor and beeping specified melody.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueList">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void Write<T>(List<T> valueList, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueList.Count; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueList[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write<T>(value: valueList[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write<T>(value: valueList[i], color: expectedColor);

                    // Beep sounds. 
                    Beep(melody: melody);
                }
            }
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified text color as ConsoleColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="color">Text color.</param>
        public static void WriteLine<T>(T value, ConsoleColor color)
        {
            // Temporary data for previous color settings.
            ConsoleColor consoleFGColor = Console.ForegroundColor;
            ConsoleColor consoleBGColor = Console.BackgroundColor;

            // Set screen color to specified color. foregroundColor is color for text color.
            SetScreenColors(new ScreenColorOption(foregroundColor: color, backgroundColor: consoleBGColor));

            // Calling Console.WriteLine(object value)
            WriteLine(value: value);

            // Set screen colors back to previous setting.
            SetScreenColors(new ScreenColorOption(foregroundColor: consoleFGColor, backgroundColor: consoleBGColor));
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified <see cref="Melody"/>.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="melody">A melody whose to be played.</param>
        public static void WriteLine<T>(T value, Melody melody)
        {
            // Calling Console.Write(object value).
            WriteLine(value: value);

            //Beep sounds.
            Beep(melody: melody);
        }

        /// <summary>
        ///  Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified exoectedColor when value is expectedValue, otherwise writes with valueColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueList">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void WriteLine<T>(List<T> valueList, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)
        {

            // Iteration for all elements of the array.
            for (int i = 0; i < valueList.Count; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueList[i].Equals(expectedValue) == false)
                {
                    // Calling Console.WriteLine(object value)
                    WriteLine(value: valueList[i], color: valueColor);
                   
                }
                else
                {
                    // Calling Console.WriteLine(object value)
                    WriteLine(value: valueList[i], color: expectedColor);                   
                }
            }
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified text color as ConsoleColor and beeping specified melody.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueList">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void WriteLine<T>(List<T> valueList, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueList.Count; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueList[i].Equals(expectedValue) == false)
                {
                    // Calling Console.WriteLine(object value)
                    WriteLine(valueList[i], color: valueColor);
                }
                else
                {
                    // Calling Console.WriteLine(object value)
                    WriteLine(valueList[i], color: expectedColor);

                    // Beep sonuds.
                    Beep(melody: melody);
                }
            }
        }
    }
}
