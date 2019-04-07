using System;
using System.Collections;
using System.Collections.Generic;

namespace LigaMistruSoloTask
{
    public class SpojovySeznam<T> : IEnumerable<T>, ICollection, IList
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

        public object SyncRoot => this;

        public bool IsSynchronized => false;

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public object this[int index] {
            get
            {
                T[] tempArray = new T[PocetPrvku];
                try
                {
                    tempArray = CreateArrayOfDataFromList();
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                return tempArray[index];
            }
            set
            {
                AddToIndex(index, value);
            }
        }

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

        public void CopyTo(Array array, int index)
        {
            try
            {
                T[] tempArray = CreateArrayOfDataFromList();
                T[] noveArray = new T[PocetPrvku - index];
                uint indexNovy = 0;
                for (int i = index; i < PocetPrvku; i++)
                {
                    noveArray[indexNovy] = tempArray[index];
                }
                array = noveArray;
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
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
            return ContainsElementInList(value);
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
            AddToIndex(index, value);
        }

        public void Remove(object value)
        {
            RemoveItem(value);
        }

        public void RemoveAt(int index)
        {
            RemoveFromIndex(index);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vsude je potreba pole, tak si ho tady delam z listu
        /// </summary>
        /// <returns>Pole dat T</returns>
        public T[] CreateArrayOfDataFromList()
        {
            T[] tempArray = new T[PocetPrvku];
            if (PocetPrvku == 0)
            {
                throw new IndexOutOfRangeException("Prazdny list");
            }
            AktualniPrvek = null;
            uint indexer = 0;
            while (AktualniPrvek != PosledniPrvek)
            {
                if (AktualniPrvek == null)
                {
                    AktualniPrvek = PrvniPrvek;
                } else
                {
                    AktualniPrvek = AktualniPrvek.DalsiPrvek;
                }
                tempArray[indexer] = AktualniPrvek.Data;
            }
            return tempArray;
        }

        /// <summary>
        /// Vloží prvek do seznamu a 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void AddToIndex(int index, object value)
        {
            if (value == null)
            {
                throw new NullReferenceException("Zadna vstupni data");
            }
            if (index >= PocetPrvku || index < 0)
            {
                throw new IndexOutOfRangeException("Mimo rozsah listu");
            }
            Prvek novyPrvek = new Prvek((T)value);
            AktualniPrvek = PrvniPrvek;
            for (int i = 0; i < index; i++)
            {
                AktualniPrvek = AktualniPrvek.DalsiPrvek;
            }
            var tempPrvekDalsi = AktualniPrvek.DalsiPrvek;
            var tempPrvekPredchozi = AktualniPrvek;
            AktualniPrvek = novyPrvek;
            aktualniPrvek.DalsiPrvek = tempPrvekDalsi;
            aktualniPrvek.PredchoziPrvek = tempPrvekPredchozi;
            PocetPrvku++;
        }

        private bool ContainsElementInList(object value)
        {
            if (value == null)
            {
                throw new NullReferenceException("Zadna vstupni data");
            }
            Prvek tempPrvek = new Prvek((T)value);
            AktualniPrvek = PrvniPrvek;
            uint indexer = 0;
            while (AktualniPrvek.Data.Equals(tempPrvek.Data))
            {
                AktualniPrvek = AktualniPrvek.DalsiPrvek;
                indexer++;
                if (indexer >= PocetPrvku)
                {
                    break;
                }
            }
            if (indexer < PocetPrvku)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RemoveItem(object value)
        {
            if (value == null)
            {
                throw new NullReferenceException("Zadna vstupni data");
            }
            if (ContainsElementInList(value))
            {
                var tempPrvekDalsi = AktualniPrvek.DalsiPrvek;
                var tempPrvekPredchozi = AktualniPrvek.PredchoziPrvek;
                aktualniPrvek = null;
                aktualniPrvek = tempPrvekDalsi;
                aktualniPrvek.PredchoziPrvek = tempPrvekPredchozi;
                PocetPrvku--;
            } else
            {
                throw new InvalidOperationException("Žádaný prvek nenalezen");
            }
        }

        /// <summary>
        /// Odroluje pocet prvku podle index a ten smaze, a svaze zpatky seznam
        /// </summary>
        /// <param name="index"></param>
        private void RemoveFromIndex(int index)
        {
            if (index >= PocetPrvku || index < 0)
            {
                throw new IndexOutOfRangeException("Mimo rozsah listu");
            }
            AktualniPrvek = PrvniPrvek;
            for (int i = 0; i < index; i++)
            {
                AktualniPrvek = AktualniPrvek.DalsiPrvek;
            }
            var tempPrvekDalsi = AktualniPrvek.DalsiPrvek;
            var tempPrvekPredchozi = AktualniPrvek.PredchoziPrvek;
            aktualniPrvek = null;
            aktualniPrvek = tempPrvekDalsi;
            aktualniPrvek.PredchoziPrvek = tempPrvekPredchozi;
            PocetPrvku--;
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class TEnumerator<T> : IEnumerator
    {
        public T[] _array;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public TEnumerator(T[] list)
        {
            _array = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return _array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
