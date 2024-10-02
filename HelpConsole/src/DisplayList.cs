using System;
using System.Collections.Generic;
using static HelpConsole.HelpConsole;

namespace HelpConsole.DisplayList
{
    /// <summary>
    /// Class to list values on the screen.
    /// </summary>
    public class DisplayList
    {
        #region TreeView

        #region Properties

        /// <summary>
        /// Indent before parent value on the list.
        /// </summary>
        protected static string defaultParentIndent = "    ";

        /// <summary>
        /// Indent before child value on the list.
        /// </summary>
        protected static string defaultChildIndent = "    ";

        /// <summary>
        /// Text color of parent value on the list.
        /// </summary>
        protected static ConsoleColor defaultParentColor = ConsoleColor.Red;

        /// <summary>
        /// Text color of child value on the list.
        /// </summary>
        protected static ConsoleColor defaultChildColor = ConsoleColor.Yellow;

        /// <summary>
        /// Character adding before last element on the list.
        /// </summary>
        protected static string defaultLastElement = "└─";

        /// <summary>
        /// Character adding before first and middle element on the list.
        /// </summary>
        protected static string defaultMiddleElement = "├─";

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Default constructor for DisplayList.
        /// </summary>
        public DisplayList()
        {

        }

        /// <summary>
        /// Constructor to set style of DisplayList.
        /// </summary>
        /// <param name="parentColor">Text color of parent value on the list.</param>
        /// <param name="childColor">Text color of child value on the list.</param>
        public DisplayList(ConsoleColor parentColor, ConsoleColor childColor)
        {
            defaultParentColor = parentColor;
            defaultChildColor = childColor;
        }

        /// <summary>
        /// Constructor to set style of DisplayList.
        /// </summary>
        /// <param name="parentIndent">Indent before parent value on the list.</param>
        /// <param name="childIndent">Indent before child value on the list.</param>
        /// <param name="parentColor">Text color of parent value on the list.</param>
        /// <param name="childColor">Text color of child value on the list.</param>
        public DisplayList(string parentIndent, string childIndent, ConsoleColor parentColor, ConsoleColor childColor)
        {
            defaultParentIndent = parentIndent;
            defaultChildIndent = childIndent;
            defaultParentColor = parentColor;
            defaultChildColor = childColor;            
        }

        #endregion Constructors

        /// <summary>
        /// Class to hold parent-list of child values.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// String to display as parent
            /// </summary>
            public string Parent;

            /// <summary>
            /// List of string to display as child values.
            /// </summary>
            public List<string> ChildList;
        }

        #region Methods

        /// <summary>
        /// Listing values with preset listing style.
        /// </summary>
        /// <param name="values">List of Nodes to write on screen.</param>
        public void ListValues(List<Node> values)
        {
            // Loop for values.
            for (int i = 0; i < values.Count; i++)
            {
                // Writing parent value
                WriteLine($"{defaultParentIndent}{values[i].Parent}", defaultParentColor);

                // Listing child values if exists
                for (int j = 0; j < values[i].ChildList.Count; j++)
                {
                    // Adding indent value for child value.
                    Write(defaultChildIndent);

                    // Checking if current index is the last of list to decide last/rest value before child element.
                    if (j == values[i].ChildList.Count - 1)
                    {
                        // Adding default string value before last element of the list.
                        Write(defaultLastElement);
                    }
                    else
                    {
                        // Adding default string value before rest of elements out of the last one on the list.
                        Write(defaultMiddleElement);
                    }

                    // Writing child value.
                    WriteLine($"{values[i].ChildList[j]}", defaultChildColor);
                }
            }
        }

        #endregion Methods

        #endregion TreeView
    }
}
