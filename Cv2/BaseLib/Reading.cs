using System;
using System.Collections.Generic;

namespace Fei
{
    namespace BaseLib
    {
        public static class Reading
        {
            /// <summary>
            /// Pokusi se nacist int
            /// </summary>
            /// <param name="popis">Text co se zobrazi pred nacitanim</param>
            /// <returns>Nactene cislo</returns>
            public static int ReadInt(string popis)
            {
                Console.Write($"{popis}: ");
                int.TryParse(Console.ReadLine(), out int hodnota);
                return hodnota;
            }
            /// <summary>
            /// Pokusi se nacist double
            /// </summary>
            /// <param name="popis">Text co se zobrazi pred nacitanim</param>
            /// <returns>Nactene cislo</returns>
            public static double ReadDouble(string popis)
            {
                Console.Write($"{popis}: ");
                double.TryParse(Console.ReadLine(), out double hodnota);
                return hodnota;
            }
            /// <summary>
            /// Pokusi se nacist char
            /// </summary>
            /// <param name="popis">Text co se zobrazi pred nacitanim</param>
            /// <returns>Nacteny znak</returns>
            public static char ReadChar(string popis)
            {
                Console.Write($"{popis}: ");
                char.TryParse(Console.ReadLine(), out char hodnota);
                return hodnota;
            }
            /// <summary>
            /// nacte string
            /// </summary>
            /// <param name="popis">Text co se zobrazi pred nacitanim</param>
            /// <returns>Nacteny string</returns>
            public static string ReadString(string popis)
            {
                Console.Write($"{popis}: ");
                string hodnota = Console.ReadLine();
                return hodnota;
            }
        }
        public class ExtraMath
        {
            public static bool SolveQuadraticEquation(double a, double b, double c, out double x1, out double x2)
            {
                double d = b * b - 4 * a * c;
                if (d == 0)
                {
                    Console.Write("Both roots are equal.\n");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root Root2= {0}\n", x2);
                    return true;
                }
                else if (d > 0)
                {
                    Console.Write("Both roots are real and diff-2\n");
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root root2= {0}\n", x2);
                    return true;
                }
                else
                {
                    Console.Write("Root are imeainary;\nNo Solution. \n\n");
                    x1 = 0;
                    x2 = 0;
                    return false;
                }
            }

            public static double RandomDouble(Random random, int min, int max)
            {
                return ((random.NextDouble() * (max - min)) + min);
            }
        }
        public class MathConvertor
        {
            public static int ConvertDecToBin(int input)
            {
                string number = input.ToString();
                int fromBase = 10;
                int toBase = 2;
                string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
                int tempOut;
                int.TryParse(result, out tempOut);
                return tempOut;
            }
            public static int ConvertBinToDec(int input)
            {
                string number = input.ToString();
                int fromBase = 2;
                int toBase = 10;
                string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
                int tempOut;
                int.TryParse(result, out tempOut);
                return tempOut;
            }
            public static string ConvertDecToRome(int number)
            {
                if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
                if (number < 1) return string.Empty;
                if (number >= 1000) return "M" + ConvertDecToRome(number - 1000);
                if (number >= 900) return "CM" + ConvertDecToRome(number - 900);
                if (number >= 500) return "D" + ConvertDecToRome(number - 500);
                if (number >= 400) return "CD" + ConvertDecToRome(number - 400);
                if (number >= 100) return "C" + ConvertDecToRome(number - 100);
                if (number >= 90) return "XC" + ConvertDecToRome(number - 90);
                if (number >= 50) return "L" + ConvertDecToRome(number - 50);
                if (number >= 40) return "XL" + ConvertDecToRome(number - 40);
                if (number >= 10) return "X" + ConvertDecToRome(number - 10);
                if (number >= 9) return "IX" + ConvertDecToRome(number - 9);
                if (number >= 5) return "V" + ConvertDecToRome(number - 5);
                if (number >= 4) return "IV" + ConvertDecToRome(number - 4);
                if (number >= 1) return "I" + ConvertDecToRome(number - 1);
                throw new ArgumentOutOfRangeException("something bad happened");
            }

            private static Dictionary<char, int> _romanMap = new Dictionary<char, int>
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
            };
            public static int ConvertRomeToDec(string text)
            {
                int totalValue = 0, prevValue = 0;
                foreach (var c in text)
                {
                    if (!_romanMap.ContainsKey(c))
                        return 0;
                    var crtValue = _romanMap[c];
                    totalValue += crtValue;
                    if (prevValue != 0 && prevValue < crtValue)
                    {
                        if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
                            || prevValue == 10 && (crtValue == 50 || crtValue == 100)
                            || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
                            totalValue -= 2 * prevValue;
                        else
                            return 0;
                    }
                    prevValue = crtValue;
                }
                return totalValue;
            }
        }
    }
}