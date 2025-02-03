using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.inheritance
{
    internal class TrueORFalseQuestion:Question{

     public TrueORFalseQuestion(string header, string body, int mark, Answer[] AnswerLis, int rightAnswerId) : base(header, body, mark, AnswerLis, rightAnswerId)
          { }
    }      
    }

