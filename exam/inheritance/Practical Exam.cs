using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
    internal class Practical_Exam : Exam
    {

        public Practical_Exam(int time, int numberOfQuestions, Question[] questions) : base(time, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            foreach (var question in Question)
            {
               
                Console.WriteLine($"Right Answer: {question.RightAnswer}");
            }
           
        }
    }
}
