﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityModel.Extensions
{
    /// <summary>
    /// Helper class to write out colored messages to the console
    /// </summary>
    public static class ConsoleExtensions
    {
        /// <summary>
        /// Writes green text to the console.
        /// </summary>
        /// <param name="text">The text.</param>
        public static void ConsoleGreen(this string text)
        {
            text.ColoredWriteLine(ConsoleColor.Green);
        }

        /// <summary>
        /// Writes red text to the console.
        /// </summary>
        /// <param name="text">The text.</param>
        public static void ConsoleRed(this string text)
        {
            text.ColoredWriteLine(ConsoleColor.Red);
        }

        /// <summary>
        /// Writes yellow text to the console.
        /// </summary>
        /// <param name="text">The text.</param>
        public static void ConsoleYellow(this string text)
        {
            text.ColoredWriteLine(ConsoleColor.Yellow);
        }

        /// <summary>
        /// Writes out text with the specified ConsoleColor.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="color">The color.</param>
        public static void ColoredWriteLine(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
