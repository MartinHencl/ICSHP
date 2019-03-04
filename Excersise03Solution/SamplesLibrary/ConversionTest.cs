using System;

namespace Excersise03.SamplesLibrary
{
    class ConversionTest
    {
        internal class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Person(int id)
            {
                ID = id;
            }

            public override string ToString()
            {
                return ID + " " + Name;     // u cisla implicitne toString()
            }

            public static implicit operator Person(int v)
            {
                return new Person(v);
            }

            public static implicit operator int(Person osoba)
            {
                return osoba.ID;
            }
        }
        public static void DoIT()
        {
            double realNumber = 3.14;
            realNumber = Math.PI;
            realNumber = 10;
            realNumber = 20;
            realNumber = (double)15;

            int intNumber = 3;
            intNumber = 8;
            intNumber = (int)realNumber;

            Person person1 = new Person(1);
            Person person2 = intNumber;

            Object person3 = new Person(3);
            (person3 as Person).Name = "Karel";
            if (person3 is Person)
            //  if (person3 is Person person4)  //  pokud je person3 Person tak vytvoří person4 (ušetříme řádek)
            //  if (person3.GetType() == typeof(Person))
            {
                // do něco
            }
        }
    }
}
