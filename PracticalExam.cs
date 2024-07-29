using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(DateTime time, int numberOfQuestions, Subject subject)
            : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.ToString());
                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(answer.ToString());
                }
                Console.WriteLine($"Right answer: {question.RightAnswer.ToString()}");
            }
        }
    }
}
