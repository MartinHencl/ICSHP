using Fei.BaseLib;
using System;
using System.Linq;

namespace Cv2_samostatne
{
    class Program
    {
        private static int[] NacteniPoleInt()
        {
            int pocetOpakovani = Reading.ReadInt("Pocet cteni");
            int[] pole = new int[pocetOpakovani];
            for (int i = 0; i < pocetOpakovani; i++)
            {
                Reading.ReadInt("Prvek číslo " + pocetOpakovani);
            }
            Console.WriteLine("");
            return pole;
        }
        private static void VypisPole(int[] pole)
        {
            pole.ToList().ForEach(Console.WriteLine);
        }
        private static void UtriditPoleVzestupne(int[] pole)
        {
            Array.Sort(pole);
        }
        private static void NajitNejmensi(int[] pole)
        {
            int nejmensi = int.MaxValue;
            for (int i = 0; i < pole.Length; i++) 
            {
                if (pole[i] < nejmensi)
                {
                    nejmensi = pole[i];
                }
            }
            Console.WriteLine("Nejmensi prvek {0}", nejmensi);
        }
        private static void NajitPrvniVyskyt(int[] pole)
        {
            int hledane = Reading.ReadInt("Hledane cislo");
            for (int i = 0; i < pole.Length; i++)
            {
                if (hledane == pole[i])
                {
                    Console.WriteLine("Hledane cislo je na indexu {0}", i);
                    return;
                }
            }
        }
        private static void NajitPosledniVyskyt(int[] pole)
        {
            int hledane = Reading.ReadInt("Hledane cislo");
            for (int i = pole.Length-1; i >= 0; i--)
            {
                if (hledane == pole[i])
                {
                    Console.WriteLine("Hledane cislo je na indexu {0}", i);
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] pole = NacteniPoleInt();
            VypisPole(pole);
            UtriditPoleVzestupne(pole);
            VypisPole(pole);
            NajitNejmensi(pole);
            VypisPole(pole);
            NajitPrvniVyskyt(pole);
            VypisPole(pole);
            NajitPosledniVyskyt(pole);
            VypisPole(pole);
        }
    }
}