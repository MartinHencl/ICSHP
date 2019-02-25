using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ComplexNumber
    {
        public int First { set; get; }
        public int Second { set; get; }
        public int? Third { set; get; }

        public ComplexNumber()
        {
        }

        public ComplexNumber(ComplexNumber source)
        {
            this.First = source.First;
            this.Second = source.Second;
            this.Third = source.Third;
        }

        public ComplexNumber(int first, int second, int? third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public override string ToString()
        {
            return "[" + First.ToString() + "; " + Second.ToString() + "; " + this.Third + "]";
        }
    }
}
