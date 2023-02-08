using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class ParticularExam : Exam
    {
        internal static int Counter = 0;
        public ParticularExam(int _numOfTf, int _numOfMCQ, int _time, string _type, Questions[] _questions) : base(_numOfTf, _numOfMCQ, _time, _type, _questions)
        {
        }
        string[] Arr_Answers = new string[4];
        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine($" ---------------------------------- {type} --------------------------------------- ");
            Console.WriteLine();
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{i + 1} {questions[i].Header}");
                    if (Convert.ToString(questions[i].type) == "MCQ")
                    {
                        for (int j = 0; j < questions.Length; j++)
                        Console.WriteLine($" *  {questions[i].Answers[j]}");
                    }
                    else
                    {
                        for (int j = 0; j < questions.Length-2; j++)
                        Console.WriteLine($" *  {questions[i].Answers[j]}");
                    }
                Console.Write("Enter Your Answer :");
                string TempAnswer = Console.ReadLine();
                if (TempAnswer == questions[i].CorrectAnswer)
                    counter += questions[i].marks;
                Arr_Answers[i]= TempAnswer;
                Console.WriteLine();
            }

        }

        public override void ShowAnswers()
        {
            Console.WriteLine();

            Console.WriteLine(" ----------------------------------- Answers --------------------------------------- ");
            for (int i = 0; i < Arr_Answers.Length; i++)
                Console.WriteLine($" Answer Of Question {i+1} - {Arr_Answers[i]}");


        }

        public void ShowResults()
        {

            Console.WriteLine(" ----------------------------------- Results --------------------------------------- ");

            Console.WriteLine($"Final Results of your Particular Exam : {counter}");     
        }
    }
}
