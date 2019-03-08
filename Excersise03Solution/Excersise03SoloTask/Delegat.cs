using Fei.BaseLib;
using System;

namespace Excersise03SoloTask
{
    class Delegat
    {
        private int MenuDraw()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Načtení studenta z klávesnice");
            Console.WriteLine("2) Výpis studentů na obrazovku");
            Console.WriteLine("3) Seřazení studentů podle čísla");
            Console.WriteLine("4) Seřazení studentů podle jména");
            Console.WriteLine("5) Seřazení studentů podle fakulty");
            Console.WriteLine("0) Konec programu");
            return Reading.ReadInt("Zvolte číslo z nabídky");
        }
        private void ArrayReading(Studenti arrayOfStudents)
        {
            string jmeno = Reading.ReadString("Jméno");
            int cislo = Reading.ReadInt("Číslo");
            string fakulta = Reading.ReadString("Fakulta");
            Student tempStudent = new Student(jmeno, cislo, fakulta);
            arrayOfStudents.AddStudent(tempStudent);
        }
        private void ArrayPrint(Studenti arrayOfStudents)
        {
            if (arrayOfStudents.isEmpty())
            {
                ArrayPreFill(arrayOfStudents);
            }
            arrayOfStudents.PrintAll();
        }

        private void ArrayPreFill(Studenti arrayOfStudents)
        {
            arrayOfStudents.AddStudent(new Student("Karel", 5, "FEI"));
            arrayOfStudents.AddStudent(new Student("Pepa", 6, "FES"));
            arrayOfStudents.AddStudent(new Student("tonda", 3, "FF"));
            arrayOfStudents.AddStudent(new Student("NIkdo", 2, "FCHT"));
            arrayOfStudents.AddStudent(new Student("někdo", 1, "FEI"));
        }

        private void ArraySort(Studenti arrayOfStudents, string value)
        {
            arrayOfStudents.SortAllByValue(value);
        }
        static void Main(string[] args)
        {
            Delegat delegat = new Delegat();
            Studenti arrayOfStudents = new Studenti();
            while (true)
            {
                int menuReturnNumber = delegat.MenuDraw();
                switch (menuReturnNumber)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        delegat.ArrayReading(arrayOfStudents);
                        break;
                    case 2:
                        delegat.ArrayPrint(arrayOfStudents);
                        break;
                    case 3:
                        delegat.ArraySort(arrayOfStudents, "byNumber");
                        break;
                    case 4:
                        delegat.ArraySort(arrayOfStudents, "byName");
                        break;
                    case 5:
                        delegat.ArraySort(arrayOfStudents, "byFaculty");
                        break;
                }

            }
        }
    }
}
