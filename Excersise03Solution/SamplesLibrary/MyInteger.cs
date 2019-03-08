using System;

namespace SamplesLibrary
{
    internal class MyInteger
    {
        //public uint Value { get; set; }
        public uint Value
        {
            get
            {
                return Value;
            }
            set
            {
                Value = value;
            }
        }

        private uint value2;
        public int Value2
        {
            get { return (int)value2; }
            set
            {
                if (value > 1000000)
                {
                    throw new ArgumentOutOfRangeException("Větší jak 1000000");
                }
                value2 = (uint)value;
            }
        }
        public bool Signed { get; private set; }

        public MyInteger()
        {
            
        }

        public MyInteger(uint value, bool signed)
        {
            this.Value = value;
            this.Signed = signed;
        }

        public static implicit operator MyInteger(int v)
        {
            return new MyInteger() { Value = (uint)Math.Abs(v), Signed = v < 0 };
        }
    }

    public class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger1 = new MyInteger() { Value = 33 };
            MyInteger myInteger2 = new MyInteger(33, true);
            //myInteger1.Signed = true;
            myInteger1.Value = 10;

            MyInteger myInteger3 = 125;
        }
    }
}
