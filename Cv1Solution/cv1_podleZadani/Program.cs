using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1_podleZadani
{
    class Program
    {
        static void FunkceRodneCislo()
        {
            Console.WriteLine("Příklad 3 RČ");
            StringBuilder rcBuilder = new StringBuilder("911213/1234");
            StringBuilder mesic = new StringBuilder();
            mesic.Append(rcBuilder[2]);
            mesic.Append(rcBuilder[3]);
            if (int.Parse(mesic.ToString()) - 50 >= 0)
            {
                Console.WriteLine(rcBuilder.Append(" je žena"));
            }
            else
            {
                Console.WriteLine(rcBuilder.Append(" je muž"));
            }
            Console.WriteLine("");
            Console.WriteLine("*********************");
        }

        private static bool HadaniCisla(int pocetHadani)
        {
            Random nahoda = new Random();
            int nahodneCislo = nahoda.Next(101);
            int hadaneCislo = -1;
            int iteraceHadani = 0;
            while (true)
            {
                iteraceHadani++;
                Console.Write("Pokus č. {0} z {1}:", iteraceHadani, pocetHadani);
                int.TryParse(Console.ReadLine(), out hadaneCislo);
                if (hadaneCislo < nahodneCislo)
                {
                    Console.WriteLine("Hadane cislo je vetsi nez tipnute {0}", hadaneCislo);
                }
                else if (hadaneCislo > nahodneCislo)
                {
                    Console.WriteLine("Hadane cislo je mensi nez tipnute {0}", hadaneCislo);
                }
                else if (hadaneCislo == nahodneCislo)
                {
                    Console.WriteLine("Bingo! Cislo je {0}", nahodneCislo);
                    return true;
                }
                if (iteraceHadani > pocetHadani)
                {
                    Console.WriteLine("Prekroceny pocet pokusu, prohra!");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            /*  pr 1 formatovani adresy */
            Console.WriteLine("Příklad 1 adresa");
            Console.Write("Josef");
            Console.Write(" ");
            Console.Write("Novák");
            Console.Write('\n');
            Console.WriteLine("Jindřišská 16");
            Console.WriteLine("111 50, Praha 1");
            Console.WriteLine("*********************");


            /* pr 2 abeceda */
            Console.WriteLine("Příklad 2 abeceda");
            for (int i = 97; i < 97 + 26; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("*********************");

            /* pr 3 Rč */
            FunkceRodneCislo();

            /* pr 4 hadani cisla    */
            while (true)
            {
                HadaniCisla(10);
                Console.Write("Opakovat? [ano/ne] ('ne' pri prazdnem vstupu)");
                string nactene = Console.ReadLine();
                if (nactene.Equals("ne") || nactene.Equals(""))
                {
                    break;
                }
            }
        }
    }
}
