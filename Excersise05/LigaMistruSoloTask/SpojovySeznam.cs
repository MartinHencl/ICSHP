using System;
using System.Collections;
using System.Collections.Generic;

namespace LigaMistruSoloTask
{
    public class SpojovySeznam<T> : IEnumerable, ICollection, IList
    {
        private int pocetPrvku;
        private Prvek prvniPrvek;
        private Prvek posledniPrvek;
        private Prvek aktualniPrvek;

        public int PocetPrvku { get => pocetPrvku; set => pocetPrvku = value; }
        internal Prvek PrvniPrvek { get => prvniPrvek; set => prvniPrvek = value; }
        internal Prvek PosledniPrvek { get => posledniPrvek; set => posledniPrvek = value; }
        internal Prvek AktualniPrvek { get => aktualniPrvek; set => aktualniPrvek = value; }

        public int Count => PocetPrvku;

        public object SyncRoot => PrvniPrvek;

        public bool IsSynchronized => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal class Prvek
        {
            private Prvek predchoziPrvek;
            private Prvek dalsiPrvek;
            private T data;

            internal Prvek PredchoziPrvek { get => predchoziPrvek; set => predchoziPrvek = value; }
            internal Prvek DalsiPrvek { get => dalsiPrvek; set => dalsiPrvek = value; }
            internal T Data { get => data; set => data = value; }

            internal Prvek(T data)
            {
                this.Data = data;
                this.PredchoziPrvek = this;
                this.DalsiPrvek = this;
            }

            public override bool Equals(object obj)
            {
                if (this == obj)
                {
                    return true;
                }
                if (obj == null)
                {
                    return false;
                }
                if (object.Equals(this, obj))
                {
                    return false;
                }
                Prvek other = obj as Prvek;
                if (!EqualityComparer<T>.Default.Equals(this.Data, other.Data))
                {
                    return false;
                }
                return true;
            }

            public override int GetHashCode()
            {
                return 1768953197 + EqualityComparer<T>.Default.GetHashCode(data);
            }
        }

        public SpojovySeznam()
        {
            this.AktualniPrvek = null;
            this.PrvniPrvek = null;
            this.PosledniPrvek = null;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Add(object value)
        {
            if (value == null)
            {
                throw new NullReferenceException("Zadna vstupni data");
            }
            Prvek novyPrvek = new Prvek((T)value);
            if (PosledniPrvek == null)
            {
                PrvniPrvek = novyPrvek;
            }
            else
            {
                PosledniPrvek.DalsiPrvek = novyPrvek;
                novyPrvek.PredchoziPrvek = PosledniPrvek;
            }
            PosledniPrvek = novyPrvek;
            PosledniPrvek.DalsiPrvek = PrvniPrvek;
            PrvniPrvek.PredchoziPrvek = PosledniPrvek;
            PocetPrvku++;
            return PocetPrvku;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            PocetPrvku = 0;
            PrvniPrvek = null;
            PosledniPrvek = null;
            AktualniPrvek = null;
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
