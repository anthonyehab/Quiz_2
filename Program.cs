using System;
namespace Quiz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());
            Console.Write("Enter subject name: ");
            string subjectName = Console.ReadLine();
            Subject subject = new Subject(subjectId, subjectName);

            Console.Write("Enter exam type (1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());
            Exam exam;
            if (examType == 1)
            {
                exam = new FinalExam(DateTime.Now, 2, subject);
            }
            else
            {
                exam = new PracticalExam(DateTime.Now, 2, subject);
            }

            Console.Write("Enter number of questions: ");
            int numberOfQuestions =int.Parse(Console.ReadLine());
            exam.Questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Write("Enter question type (1 for True/False, 2 for MCQ): ");
                int questionType = int.Parse(Console.ReadLine());
                Question question;
                if (questionType == 1)
                {
                    question = new TrueFalseQuestion("Question " + (i + 1), "Enter question body: ", 1);
                    Console.Write("Enter question body: ");
                    string questionBody = Console.ReadLine();
                    question.Body = questionBody;
                    Console.Write("Enter true answer: ");
                    string trueAnswer = Console.ReadLine();
                    Console.Write("Enter false answer: ");
                    string falseAnswer = Console.ReadLine();
                    question.Answers[0] = new Answer(1, trueAnswer);
                    question.Answers[1] = new Answer(2, falseAnswer);
                    Console.Write("Enter right answer (1 for true, 2 for false): ");
                    int rightAnswer = int.Parse(Console.ReadLine());
                    question.RightAnswer = question.Answers[rightAnswer - 1];
                }
                else
                {
                    question = new MCQQuestion("Question " + (i + 1), "Enter question body: ", 1);
                    Console.Write("Enter question body: ");
                    string questionBody = Console.ReadLine();
                    question.Body = questionBody;
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Enter answer " + (j + 1) + ": ");
                        string answer = Console.ReadLine();
                        question.Answers[j] = new Answer(j + 1, answer);
                    }
                    Console.Write("Enter right answer (1-4): ");
                    int rightAnswer = int.Parse(Console.ReadLine());
                    question.RightAnswer = question.Answers[rightAnswer - 1];
                }
                exam.Questions[i] = question;
            }

            subject.CreateExam(exam);

            Console.WriteLine("Exam created successfully!");

            Console.WriteLine("Showing exam...");
            Console.Clear();
            subject.Exam.ShowExam();
            foreach (Question question in subject.Exam.Questions)
            {
                Console.WriteLine($"Question: {question.Body}");
                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }
                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == question.RightAnswer.AnswerId)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
               
            }
        }
    }
}