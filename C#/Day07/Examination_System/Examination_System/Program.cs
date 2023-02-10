using System.Collections.Generic;
using System.Drawing;
using static Examination_System.Exam;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Answers2> coloranswers = new List<Answers2>();
            coloranswers.Add(new Answers2("red"));
            coloranswers.Add(new Answers2("green"));
            coloranswers.Add(new Answers2("black"));
            coloranswers.Add(new Answers2("blue"));

            List<Answers2> BrandAnswers = new List<Answers2>();
            BrandAnswers.Add(new Answers2("Zara"));
            BrandAnswers.Add(new Answers2("H&M"));
            BrandAnswers.Add(new Answers2("Polo"));
            BrandAnswers.Add(new Answers2("LC"));

            List<Answers2> SportAnswers = new List<Answers2>();
            SportAnswers.Add(new Answers2("Football"));
            SportAnswers.Add(new Answers2("Tennies"));
            SportAnswers.Add(new Answers2("NBA"));
            SportAnswers.Add(new Answers2("MMA"));

            List<Answers2> OOPPrincbles = new List<Answers2>();
            OOPPrincbles.Add(new Answers2("abstraction"));
            OOPPrincbles.Add(new Answers2("inheritance"));
            OOPPrincbles.Add(new Answers2("polymerphism"));
            OOPPrincbles.Add(new Answers2("above_all"));

            List<Answers2> OOP_TF = new List<Answers2>();
            OOPPrincbles.Add(new Answers2("True"));
            OOPPrincbles.Add(new Answers2("False"));

            MCQ MCQ_Q1 = new MCQ("what is your OOPPrincbles  ?"  , 10, "MCQ", OOPPrincbles, "above_all");
            MCQ MCQ_Q2 = new MCQ("what is your favourite Color ?", 10, "MCQ", coloranswers, "red");
            MCQ MCQ_Q3 = new MCQ("what is your favourite Brand ?", 10, "MCQ", BrandAnswers, "Zara");
            MCQ MCQ_Q4 = new MCQ("what is your favourite Sport ?", 10, "MCQ", SportAnswers, "MMA");
            T_F TF_Q1 = new T_F("C# is Fully Oriented ?", 5, "T_F", OOP_TF, "true");
            T_F TF_Q2 = new T_F("c++ is Fully Oriented ?", 5, "T_F", OOP_TF, "false");

            //Questions[] q = { MCQ_Q1, MCQ_Q3, MCQ_Q4, MCQ_Q2 };

            Console.WriteLine("Choose Type of Exam");
            Console.WriteLine("1 ----> FinalExam");
            Console.WriteLine("2 ----> particularExam");
            int Choice = Convert.ToInt32(Console.ReadLine());

            QuestionList Q_L1 = new QuestionList();
            Q_L1.Add(MCQ_Q1);
            Q_L1.Add(MCQ_Q3);
            Q_L1.Add(TF_Q1);
            Q_L1.Add(MCQ_Q2);
            Q_L1.Add(Q_L1);

            //QuestionList Q_L2 = new QuestionList();
            //Q_L2.Add(MCQ_Q4);
            //Q_L2.Add(MCQ_Q2);
            //Q_L2.Add(MCQ_Q3);
            //Q_L2.Add(MCQ_Q1);

            //QuestionList Q_L3 = new QuestionList();
            //Q_L3.Add(MCQ_Q1);
            //Q_L3.Add(MCQ_Q4);
            //Q_L3.Add(MCQ_Q3);
            //Q_L3.Add(MCQ_Q2);

            //Dictionary<string, string> Dic_Lis = new Dictionary<string, string>();
            //Dic_Lis.Add(Q_L1[0].header, "above_all");
            //Dic_Lis.Add(Q_L1[1].header, "red");
            //Dic_Lis.Add(Q_L1[2].header, "Zara");
            //Dic_Lis.Add(Q_L1[3].header, "MMA");



            //Console.WriteLine(Dic_Lis[Q_L1[0].header]);

            if (Choice == 1)
            {
                FinalExam Final_E1 = new FinalExam(1, 3, 20, "FinalExam", Q_L1);
                Final_E1.ShowExam();
                Final_E1.ShowAnswers();
                
            }
            else
            {
                ParticularExam Patricular_E1 = new ParticularExam(1, 3, 20, "particularExam", Q_L1 );
                Patricular_E1.ShowExam();
                Patricular_E1.ShowAnswers();
                Patricular_E1.ShowResults();
            }


        }
    }
}
