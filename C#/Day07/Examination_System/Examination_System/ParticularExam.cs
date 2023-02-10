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
        public ParticularExam(int _numOfTf, int _numOfMCQ, int _time, string _type, QuestionList _questions/*, Dictionary<string, string> dic_Lis*/) : base(_numOfTf, _numOfMCQ, _time, _type, _questions /*, dic_Lis*/)
        {
        }

        string[] Arr_Answers = new string[4];
        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine($" ---------------------------------- {type} --------------------------------------- ");
            Console.WriteLine();

            Dictionary<string, string> Dic_Lis = new Dictionary<string, string>();
            Dic_Lis.Add(questions[0].header, questions[0].correct_answer);
            Dic_Lis.Add(questions[1].header, questions[1].correct_answer);
            Dic_Lis.Add(questions[2].header, questions[2].correct_answer);
            Dic_Lis.Add(questions[3].header, questions[3].correct_answer);

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1} {questions[i].header}");
                    if (Convert.ToString(questions[i].type) == "MCQ")
                    {
                        for (int j = 0; j < questions.Count; j++)
                        Console.WriteLine($" *  {questions[i].answers[j]}");
                    }
                Console.Write("Enter Your Answer :");
                string TempAnswer = Console.ReadLine();
                string WrongAnswer = "Wrong Answer";
                if (TempAnswer == Dic_Lis[questions[i].header])
                {
                    counter += questions[i].marks;
                    Arr_Answers[i] = TempAnswer;
                }
                else 
                {
                    Arr_Answers[i] = WrongAnswer;
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------");
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

        public override int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}

                //for(int k = 0; k < dic_Lis.Count; k ++)
                //{ }
                //if (TempAnswer == dic_Lis[1]) ;
                //foreach (string value in dic_Lis.Values)
                //    if (value.Contains("TempAnswer"))

                //if (dic_Lis.ContainsValue(TempAnswer))
                //{
