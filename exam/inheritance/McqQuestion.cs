using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
    internal class McqQuestion : Question
    {
        public McqQuestion(string header, string body, int mark, Answer[] AnswerList, int rightAnswerId): base(header, body, mark, AnswerList, rightAnswerId)
         { }
    }
}
