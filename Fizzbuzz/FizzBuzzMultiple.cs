using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fizzbuzz
{
    public class FizzBuzzMultiple
    {
        public const string Str3 = "Fizz";
        public const string Str5 = "Buzz";

        public object Transform(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return input;

            if ("0" == input)
                return input;

            if (IsMultiple3And5(input))
                return Str3 + Str5;

            if (IsMultiple3(input))
                return Str3;

            if (IsMultiple5(input))
                return Str5;

            return input;
        }

        private static bool IsMultiple3And5(string input)
        {
            return IsMultiple3(input) && IsMultiple5(input);
        }

        private static bool IsMultiple5(string input)
        {
            return int.Parse(input) % 5 == 0;
        }

        private static bool IsMultiple3(string input)
        {
            return int.Parse(input) % 3 == 0;
        }
    }
}
