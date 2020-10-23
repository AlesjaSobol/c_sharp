using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_9
{
    /// <summary>
    /// Using a jagged array
    /// </summary>
    class Student
    {
        private int StudentID;
        private string StudentName;
        private string StudentGroupe;
        private int StudentAge;
        private int[][] StudentMarks = new int[3][];
        public void StudentInit(int studentid, string studentname, string studentgroupe, int studentage)
        {
            StudentID = studentid;
            StudentName = studentname;
            StudentGroupe = studentgroupe;
            StudentAge = studentage;
        }
        public void StudentMarksInit()
        {
            StudentMarks[0] = new int[15]; //programming scores
            StudentMarks[1] = new int[10]; //administration ratings
            StudentMarks[2] = new int[8]; //design ratings

            Random rnd = new Random();

            Console.Write("Programming scores:\t");
            for (int i = 0; i < 15; i++)
            {
                StudentMarks[0][i] = rnd.Next(8) + 2;
                Console.Write(StudentMarks[0][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Administration ratings:\t");
            for (int i = 0; i < 10; i++)
            {
                StudentMarks[1][i] = rnd.Next(8) + 2;
                Console.Write(StudentMarks[1][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Design ratings:\t\t");
            for (int i = 0; i < 8; i++)
            {
                StudentMarks[2][i] = rnd.Next(8) + 2;
                Console.Write(StudentMarks[2][i] + " ");
            }
            Console.WriteLine();
        }
        public double AverageMark1()//average score on programming
        {
            double average_mark;
            average_mark = StudentMarks[0].Average();
            return average_mark;
        }
        public double AverageMark2()//average score on administration
        {
            double average_mark;
            average_mark = StudentMarks[1].Average();
            return average_mark;
        }
        public double AverageMark3()//average score on design
        {
            double average_mark;
            average_mark = StudentMarks[2].Average();
            return average_mark;
        }
        public void StudentPrint()
        {
            Console.WriteLine($"ID student - {StudentID}\nfirst and last name student - {StudentName}");
            Console.WriteLine($"group - {StudentGroupe}\naje student - {StudentAge}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.StudentInit(1, "Ivanov Mihail Romanovich", "A-3452", 21);
            st.StudentPrint();
            st.StudentMarksInit();
            double sb;
            sb = st.AverageMark1();
            Console.WriteLine($"Average score on programming - {String.Format("{0:0.#}", sb)}");
            sb = st.AverageMark2();
            Console.WriteLine($"Average score on administration - {String.Format("{0:0.#}", sb)}");
            sb = st.AverageMark3();
            Console.WriteLine($"Average score on design - {String.Format("{0:0.#}", sb)}");
            Console.WriteLine("==========================================================");
            Student st2 = new Student();
            st.StudentInit(2, "Sidorov Vladimir Ostafevich", "A-4029", 23);
            st.StudentPrint();
            st.StudentMarksInit();
            double sb2;
            sb2 = st.AverageMark1();
            Console.WriteLine($"Average score on programming - {String.Format("{0:0.#}", sb2)}");
            sb2 = st.AverageMark2();
            Console.WriteLine($"Average score on administration - {String.Format("{0:0.#}", sb2)}");
            sb2 = st.AverageMark3();
            Console.WriteLine($"Average score on design - {String.Format("{0:0.#}", sb2)}");
        }
    }
}