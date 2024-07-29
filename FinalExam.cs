using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    internal class FinalExam : Exam
    {
        public FinalExam(DateTime time, int numberOfQuestions, Subject subject)
            : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.ToString());
                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(answer.ToString());
                }
            }
        }
    }

}
