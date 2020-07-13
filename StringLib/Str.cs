using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace StringLib {

    /// <summary>
    /// Library contains methods to show use for libraries.
    /// </summary>
    public class Str {

        /// <summary>
        /// Reverses characters in a passed string.
        /// </summary>
        /// <param name="a"> User passed string. </param>
        /// <returns> Reverse of entered string. </returns>
        public string Reverse(string a) {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return string.Join("",charArray);
        }

        /// <summary>
        /// Manually reverses characters in string w/o .Reverse method.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string Reverse1(string a) {
            string aReversed = "";
            int aLegnth = a.Length;
            for (var i = aLegnth - 1; i >= 0; i--) {
                aReversed += a[i];
            }
            return aReversed;
        }

        /// <summary>
        /// Rotates each character in a string to next alphabetic character.
        /// </summary>
        /// <param name="a"> String to be altered. </param>
        /// <returns> Rotated sstring. </returns>
        public string Rotate(string a) {
            var dict = new Dictionary<string, string>();
            dict.Add("a", "b");
            dict.Add("b", "c");
            dict.Add("c", "d");
            dict.Add("d", "e");
            dict.Add("e", "f");
            dict.Add("f", "g");
            dict.Add("g", "h");
            dict.Add("h", "i");
            dict.Add("i", "j");
            dict.Add("j", "k");
            dict.Add("k", "l");
            dict.Add("l", "m");
            dict.Add("m", "n");
            dict.Add("n", "o");
            dict.Add("o", "p");
            dict.Add("p", "q");
            dict.Add("q", "r");
            dict.Add("r", "s");
            dict.Add("s", "t");
            dict.Add("t", "u");
            dict.Add("u", "v");
            dict.Add("v", "w");
            dict.Add("w", "x");
            dict.Add("x", "y");
            dict.Add("y", "z");
            dict.Add("z", "a");
            var rotated = "";
            foreach (var ch in a.ToCharArray()) {
                rotated += dict[ch.ToString()];
            }
            return rotated;
        }

        /// <summary>
        /// Removes vowels in passed string.
        /// </summary>
        /// <param name="a"> String to be altered. </param>
        /// <returns> Passed string w/o vowels. </returns>
        public string RemoveVowels(string a) {
            var noVowels = "";
            for (var idx = 0; idx < a.Length; idx++) {
                string ch = a[idx].ToString().ToUpper();
                if (ch == "A" || ch == "E" || ch == "I"
                        || ch == "O" || ch == "U") {
                    continue;
                }
                noVowels += a[idx].ToString();
            }
            return noVowels;
        }
        
    }
}
