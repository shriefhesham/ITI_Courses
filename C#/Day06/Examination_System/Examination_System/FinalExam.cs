using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _numOfTf, int _numOfMCQ, int _time, string _type, Questions[] _questions) : base(_numOfTf, _numOfMCQ, _time, _type, _questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine($"----------------------------{type}-----------------------------------");
            Console.WriteLine();
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{i + 1} {questions[i].Header}");
                if (Convert.ToString(questions[i].type) == "MCQ")
                {
                    for (int j = 0; j < 4; j++)
                        Console.WriteLine($" *  {questions[i].Answers[j]}");
                }
                else
                {
                    for (int j = 0; j < 2; j++)
                        Console.WriteLine($" *  {questions[i].Answers[j]}");
                }
            }
        }


        public override void ShowAnswers()
        {
            Console.WriteLine();

            Console.WriteLine("-----------------------------------Ruselts---------------------------------------");
            for (int j = 0; j < questions.Length; j++)
                Console.WriteLine($"Answer Of Question{j + 1} -----> {questions[j].CorrectAnswer}");
        }
   
    }
}
