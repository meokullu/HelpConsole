using System;
using System.Collections.Generic;

namespace HelpConsole
{
    public partial class HelpConsole
    {
        #region Write<T>

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
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified text color as ConsoleColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="bgColor">Background color.</param>
        /// <param name="fgColor">Text color.</param>
        public static void Write<T>(T value, ConsoleColor bgColor, ConsoleColor fgColor)
        {
            // Temporary data for previous color settings.
            ConsoleColor consoleBGColor = Console.BackgroundColor;
            ConsoleColor consoleFGColor = Console.ForegroundColor;

            // Set screen color to specified background and foregorund color. ForegroundColor is color for text color.
            SetScreenColors(new ScreenColorOption(foregroundColor: fgColor, backgroundColor: bgColor));

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
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified text color as ConsoleColor and beep specified <see cref="Melody"/>.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="color">Text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        public static void Write<T>(T value, ConsoleColor color, Melody melody)
        {
            // Calls Write(T value, ConsoleColor color)
            Write(value: value, color: color);

            // Beep sounds.
            Beep(melody);
        }

        /// <summary>
        /// Writes value into screen via <see cref="Write{T}(T, ConsoleColor)"/> with specified expectedColor when value is expectedValue, otherwise writes with valueColor.
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
        /// Writes value into screen via <see cref="Write{T}(T, ConsoleColor)"/> with specified expectedColor when value is expectedValue, otherwise writes with valueColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void Write<T>(T[] valueArray, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueArray[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write(value: valueArray[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write(value: valueArray[i], color: expectedColor);
                }
            }
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.Write(object)"/> with specified text color as ConsoleColor and beeping specified melody.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void Write<T>(T[] valueArray, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueArray[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write<T>(value: valueArray[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    Write<T>(value: valueArray[i], color: expectedColor);

                    // Beep sounds. 
                    Beep(melody: melody);
                }
            }
        }

        /// <summary>
        /// Writes value into screen from value array via <see cref="Console.Write(object)"/> with specified text color as given with given color list array.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="colorList">Color array.</param>
        public static void Write<T>(T[] valueArray, ConsoleColor[] colorList)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Calling Write(T value, ConsoleColor color).
                Write(valueArray[i], colorList[i % colorList.Length]);
            }
        }

        #endregion Write<T>

        #region WriteLine<T>

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
        /// Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified text color as ConsoleColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="bgColor">Background color.</param>
        /// <param name="fgColor">Text color.</param>
        public static void WriteLine<T>(T value, ConsoleColor bgColor, ConsoleColor fgColor)
        {
            // Temporary data for previous color settings.
            ConsoleColor consoleFGColor = Console.ForegroundColor;
            ConsoleColor consoleBGColor = Console.BackgroundColor;

            // Set screen color to specified color. foregroundColor is color for text color.
            SetScreenColors(new ScreenColorOption(foregroundColor: fgColor, backgroundColor: bgColor));

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
        /// Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified text color as ConsoleColor and beep specified <see cref="Melody"/>.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="value">Value to write.</param>
        /// <param name="color">Text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        public static void WriteLine<T>(T value, ConsoleColor color, Melody melody)
        {
            // Calls Writte(T value, ConsoleColor color)
            WriteLine(value: value, color: color);

            // Beep sounds.
            Beep(melody);
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

        /// <summary>
        /// Writes value into screen via <see cref="WriteLine{T}(T, ConsoleColor)"/> with specified expectedColor when value is expectedValue, otherwise writes with valueColor.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void WriteLine<T>(T[] valueArray, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueArray[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    WriteLine(value: valueArray[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    WriteLine(value: valueArray[i], color: expectedColor);
                }
            }
        }

        /// <summary>
        /// Writes value into screen via <see cref="Console.WriteLine(object)"/> with specified text color as ConsoleColor and beeping specified melody.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="expectedValue">Value to specify text color.</param>
        /// <param name="melody">A melody whose to be played.</param>
        /// <param name="valueColor">Text color for elements of array when it is not expected value.</param>
        /// <param name="expectedColor">Text color for elements of array when it is expected value.</param>
        public static void WriteLine<T>(T[] valueArray, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expectedColor)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Comparasion expectedValue on current iteration of array.
                if (valueArray[i].Equals(expectedValue) == false)
                {
                    // Calling Write(T value, ConsoleColor color).
                    WriteLine<T>(value: valueArray[i], color: valueColor);
                }
                else
                {
                    // Calling Write(T value, ConsoleColor color).
                    WriteLine<T>(value: valueArray[i], color: expectedColor);

                    // Beep sounds. 
                    Beep(melody: melody);
                }
            }
        }

        /// <summary>
        /// Writes value into screen from value array via <see cref="Console.WriteLine(object)"/> with specified text color as given with given color list array.
        /// </summary>
        /// <typeparam name="T">Generic type of data.</typeparam>
        /// <param name="valueArray">Value array.</param>
        /// <param name="colorList">Color array.</param>
        public static void WriteLine<T>(T[] valueArray, ConsoleColor[] colorList)
        {
            // Iteration for all elements of the array.
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Calling Write(T value, ConsoleColor color).
                WriteLine(valueArray[i], colorList[i % colorList.Length]);
            }
        }

        #endregion WriteLine<T>
    }
}
