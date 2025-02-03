using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
  abstract class Exam
    {
        public int Time { get; set; } 
        public int NumofQuestion { get; set; }
        public Question[] Question { get; set; }

        public Exam(int _time ,int _NumofQuestion, Question[] _Questions) { 
        
            Time = _time;
            NumofQuestion = _NumofQuestion;
            Question = _Questions;
        }   
        public Exam() { }
        public abstract void ShowExam();
    }
}
