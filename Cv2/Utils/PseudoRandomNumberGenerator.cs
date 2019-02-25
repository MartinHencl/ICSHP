using System;

namespace Utils
{
    /// <summary>
    /// Generator nahodnych cisel od -10 po 10
    /// </summary>
    public static class PseudoRandomNumberGenerator
    {
        const int MAX = 10;
        const int MIN = -10;
        static Random random = new Random();

        /// <summary>
        /// Pouze vypise nazev kodu projektu bez namespace
        /// </summary>
        public static void GetClassName()
        {
            Console.WriteLine(nameof(PseudoRandomNumberGenerator));
        }
        /// <summary>
        /// Vrati dalsi nahodne cislo z rozsahu [MIN; MAX]
        /// </summary>
        /// <returns>int</returns>
        public static int Next()
        {
            Random random = new Random();
            return random.Next(MIN, MAX);
        }
    }
}
