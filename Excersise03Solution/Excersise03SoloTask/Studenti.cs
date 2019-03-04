using System;

namespace Excersise03SoloTask
{
    class Studenti
    {
        private Student[] arrayOfStudents;
        private readonly int ALLOC = 10;
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

        public void addStudent(Student student)
        {
            actualIndex++;
            if (actualIndex >= size)
            {
                size += ALLOC;
                Array.Resize(ref arrayOfStudents, size);
            }
            arrayOfStudents[actualIndex] = student;
        }

        public Student getStudent(int index)
        {
            if (index < size)
            {
                Student tempStudent = arrayOfStudents[index];
                return tempStudent;
            } else
            {
                throw new IndexOutOfRangeException("Index mimo pole");
            }
        }
    }
}
