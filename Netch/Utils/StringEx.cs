﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Netch.Utils
{
    static class StringEx
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool BeginWithAny(this string s, IEnumerable<char> chars)
        {
            if (s.IsNullOrEmpty()) return false;
            return chars.Contains(s[0]);
        }

        public static bool IsWhiteSpace(this string value)
        {
            foreach (var c in value)
            {
                if (char.IsWhiteSpace(c)) continue;

                return false;
            }
            return true;
        }

        public static IEnumerable<string> NonWhiteSpaceLines(this TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.IsWhiteSpace()) continue;
                yield return line;
            }
        }
    }
}
