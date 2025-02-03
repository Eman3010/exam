using exam.inheritance;
using static exam.inheritance.Final_Exam;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer[] trueFalse = new Answer[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        };
            Answer[] mcq = new Answer[]
       {
           new Answer(1, "sql"),
           new Answer(2, "No sql"),
       };

            Question Q1 = new TrueORFalseQuestion("Q1", "JOIN command is used to join two tables in SQL.?", 5, trueFalse, 1);
            Question Q2 = new TrueORFalseQuestion("Q2", "MongoDB is an example of a SQL database.?", 5, trueFalse, 2);
            Question Q3 = new McqQuestion("Q3", "Which one is based on tables and relationships between data?",5, mcq, 1);
            Question Q4 = new McqQuestion("Q4", "Either one is used in databases like MongoDB and Cassandra", 5, mcq, 2);

            FinalExam finalExam = new FinalExam (40, 4, new Question[] { Q1,Q2,Q3,Q4 });
            Practical_Exam practicalExam = new Practical_Exam(20, 2, new Question[] { Q3,Q4  });

            Subject Database = new Subject(1, "database");
            Database.CreateExam(finalExam);


            Database.SubjectExam.ShowExam();

        }
    }
}