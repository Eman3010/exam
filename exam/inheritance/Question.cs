using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
      class Question
    {    //properties
        public string Header { get; set; }
        public string Body { get; set; }   
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int RightAnswer { get; set; }

        //constructor
        public Question( string _Header, string _Body,int _Mark, Answer[] _AnswerList, int _RightAnswer)
            {
            Header = _Header;
            Body = _Body;
            Mark = _Mark;
            AnswerList = _AnswerList;
            RightAnswer = _RightAnswer;
        }
        public  void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: {Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
        public Question() {
        }


    }
}
