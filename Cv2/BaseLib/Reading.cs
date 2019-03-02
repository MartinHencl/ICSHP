using System;
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
                Console.WriteLine($"popis: ");
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
                Console.WriteLine($"popis");
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
                Console.WriteLine($"popis");
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
                Console.WriteLine($"popis");
                string hodnota = Console.ReadLine();
                return hodnota;
            }
        }
    }
}