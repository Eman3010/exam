using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
    internal class Final_Exam
    {
        public class FinalExam : Exam
        {


            public FinalExam(int time, int numberOfQuestions, Question[] questions): base(time, numberOfQuestions, questions) { }

            public override void ShowExam()
            {
                Console.WriteLine("Final Exam:");
                foreach (var question in Question)
                {
                    Console.WriteLine($"Header: {question.Header}");
                    Console.WriteLine($"Body: {question.Body}");
                    Console.WriteLine("Answers:");
                    foreach (var answer in question.AnswerList)
                    {
                        Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                    }
                    Console.WriteLine($"question mark:{question.Mark}");
                    Console.WriteLine("----------------------------------");
                }
               
            }
        }
    }
}
