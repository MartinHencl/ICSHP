using System;

namespace Excersise03SoloTask
{
    class Student
    {
        public string Jmeno { get; set; }
        public int Cislo { get; set; }
        public Fakulta Fakulta { get; set; }

        public Student() { }

        public Student(string jmeno, int cislo, string fakulta)
        {
            Jmeno = jmeno;
            Cislo = cislo;
            Fakulta = parseFakulta(fakulta);
        }

        public Fakulta parseFakulta(string value)
        {
            if (Enum.TryParse(value, out Fakulta fakulta))
            {
                switch (fakulta)
                {
                    case Fakulta.FES:
                        return Fakulta.FES;
                    case Fakulta.FEI:
                        return Fakulta.FEI;
                    case Fakulta.FF:
                        return Fakulta.FF;
                    case Fakulta.FCHT:
                        return Fakulta.FCHT;
                }
            }
            else
            {
                throw new InvalidCastException("Spatna fakulta");
            }
            return Fakulta.FEI;
        }
    }
}
