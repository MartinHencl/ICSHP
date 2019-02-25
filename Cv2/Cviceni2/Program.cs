using System;
using Utils;

namespace Cviceni2
{
    class Program
    {
        private static void WorkWithStaticTypes()
        {
            PseudoRandomNumberGenerator.GetClassName();

            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(PseudoRandomNumberGenerator.Next());
            }
        }

        private static void WorkWithDataTypes()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"x: {x}; y: {y}");

            //ComplexNumber cNumber1 = new ComplexNumber(1, 2);
            ComplexNumber cNumber1 = new ComplexNumber() { First = 1, Second = 2};
            //ComplexNumber cNumber2 = cNumber1;
            ComplexNumber cNumber2 = new ComplexNumber(cNumber1);
            cNumber2.First += 2;
            cNumber1.Second++;
            Console.WriteLine(cNumber1);
            Console.WriteLine(cNumber2);

        }

        private static int GetMagicWand (string text)
        {
            if (text.Length == 0)
            {
                return -1;
            }
            return text.Length;
        }
        private static bool TryParse(string text, out int result)
        {
            // parsovani
            result = 0;
            return false;
        }

        private static void WorkWithNullableTypes ()
        {
            int number1 = 3;
            int? number2 = null;
            ComplexNumber cNumber3 = null;
            if (number2.HasValue)
            {
                int number4 = number2.Value;
            }
            cNumber3?.Third.GetType();
            ComplexNumber cNumber5 = new ComplexNumber(1, 2, null);
            cNumber5?.Third?.GetType();
        }

        static void Main(string[] args)
        {
            //WorkWithStaticTypes();
            //WorkWithDataTypes();
            WorkWithNullableTypes();
        }
    }
}
