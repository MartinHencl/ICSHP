using System;

namespace Excersise03SoloTask
{
    class Studenti
    {
        private Student[] arrayOfStudents;
        private readonly int ALLOC = 1;
        private int size = 0;
        private int actualIndex = 0;

        public Studenti()
        {
            size = ALLOC;
            arrayOfStudents = new Student[size];
        }

        public Studenti(int size)
        {
            this.size = size;
            arrayOfStudents = new Student[size];
        }

        public void AddStudent(Student student)
        {
            if (actualIndex >= size)
            {
                size += ALLOC;
                Array.Resize(ref arrayOfStudents, size);
            }
            arrayOfStudents[actualIndex] = student;
            actualIndex++;
        }

        public Student GetStudent(int index)
        {
            if (index < size)
            {
                Student tempStudent = arrayOfStudents[index];
                return tempStudent;
            }
            else
            {
                throw new IndexOutOfRangeException("Index mimo pole");
            }
        }

        internal bool isEmpty()
        {
            if (arrayOfStudents.Length == 0 || arrayOfStudents == null || arrayOfStudents[0] == null)
            {
                return true;
            }
            return false;
        }

        internal void PrintAll()
        {
            Console.Write("Soupis studentů: ");
            foreach (Student student in arrayOfStudents)
            {
                if (student != null)
                {
                    Console.Write(student.Jmeno + " " + student.Cislo + " " + student.Fakulta + ";");
                }
            }
            Console.WriteLine();
        }

        internal void SortAllByValue(string value)
        {
            for (int i = 0; i < arrayOfStudents.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfStudents.Length; j++)
                {
                    switch (value)
                    {
                        case "byNumber":
                            if (arrayOfStudents[i].Cislo < arrayOfStudents[j].Cislo)
                            {
                                SwapStudent(arrayOfStudents, i, j);
                            }
                            break;
                        case "byName":
                            if (arrayOfStudents[i].Jmeno.CompareTo(arrayOfStudents[j].Jmeno) < 0)
                            {
                                SwapStudent(arrayOfStudents, i, j);
                            }
                            break;
                        case "byFaculty":
                            if (arrayOfStudents[i].Fakulta < arrayOfStudents[j].Fakulta)
                            {
                                SwapStudent(arrayOfStudents, i, j);
                            }
                            break;
                    }
                    
                }
            }
        }

        private void SwapStudent(Student[] arrayOfStudents, int i, int j)
        {
            Student tempStudent = new Student();
            tempStudent = arrayOfStudents[i];
            arrayOfStudents[i] = arrayOfStudents[j];
            arrayOfStudents[j] = tempStudent;
        }
    }
}
