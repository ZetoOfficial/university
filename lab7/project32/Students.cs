using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project32
{
    class Student
    {
        public int StudNumber { get; set; }
        public string StudFIO { get; set; }
        public int[] Score { get; set; }

        public Student(int studNumber, string studFIO, int[] score)
        {
            StudNumber = studNumber;
            StudFIO = studFIO;
            Score = score;
        }
    }

    class StudentResult : Student
    {
        public double Result { get; set; }

        public StudentResult(int studNumber, string studFIO, int[] score, double result) : base(studNumber, studFIO, score)
        {
            Result = result;
        }
    }
}
