using System;

namespace PR4Assignment
{
    public class Program
    {
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("Not a valid roman numeral");
        }

        public static int ToArabic(string number)
        {
            if (number == string.Empty) return 0;
            if (number.StartsWith("M")) return 1000 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("CM")) return 900 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("D")) return 500 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("CD")) return 400 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("C")) return 100 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("XC")) return 90 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("L")) return 50 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("XL")) return 40 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("X")) return 10 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("IX")) return 9 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("V")) return 5 + ToArabic(number.Remove(0, 1));
            if (number.StartsWith("IV")) return 4 + ToArabic(number.Remove(0, 2));
            if (number.StartsWith("I")) return 1 + ToArabic(number.Remove(0, 1));
            throw new ArgumentOutOfRangeException("Not a valid roman numeral");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Roman Numeral: ");
            string roman1 = Console.ReadLine();
            Console.WriteLine("Integer: {0}", ToArabic(roman1));
            Console.WriteLine("Enter Second Roman Numeral: ");
            string roman2 = Console.ReadLine();
            Console.WriteLine("Integer: {0}", ToArabic(roman2));
            int sum = ToArabic(roman1) + ToArabic(roman2);
            Console.WriteLine("sum: {0}", sum);
            Console.WriteLine("Sum: {0}", ToRoman(sum));
        }
    }
}
