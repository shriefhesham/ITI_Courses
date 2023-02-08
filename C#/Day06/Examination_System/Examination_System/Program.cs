using System.Drawing;
using static Examination_System.Exam;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Answers2[] colorAnswers =
            {
                new Answers2 ("red"),
                new Answers2 ("green"),
                new Answers2 ("black"),
                new Answers2 ("blue")
            };

            Answers2[] BrandAnswers =
            {
                new Answers2 ("Zara"),
                new Answers2 ("H&M"),
                new Answers2 ("Polo"),
                new Answers2 ("LC")
            };

            Answers2[] SportAnswers =
            {
                new Answers2 ("Football"),
                new Answers2 ("Tennies"),
                new Answers2 ("NBA"),
                new Answers2 ("MMA")
            };

            Answers2[] OOPPrincbles =
            {
              new Answers2("abstraction"),
              new Answers2("inheritance"),
              new Answers2("polymerphism"),
              new Answers2("above_all")
            };

            Answers2[] OOP_TF =
            {
              new Answers2("True"),
              new Answers2("False")
 
            };

            Answers2[] OOP_TF2 =
            {
              new Answers2("True"),
              new Answers2("False")
            };

           
            MCQ MCQ_Q1 = new MCQ("what is your OOPPrincbles  ?", 10, "MCQ", OOPPrincbles, "above_all");
            MCQ MCQ_Q2 = new MCQ("what is your favourite Color ?", 10, "MCQ", colorAnswers, "red");
            MCQ MCQ_Q3 = new MCQ("what is your favourite Brand ?",10, "MCQ", BrandAnswers , "Zara");
            MCQ MCQ_Q4 = new MCQ("what is your favourite Sport ?", 10, "MCQ", SportAnswers, "MMA");
            T_F TF_Q1 = new T_F("C# is Fully Oriented ?", 5, "T_F", OOP_TF, "true");
            T_F TF_Q2 = new T_F("c++ is Fully Oriented ?", 5, "T_F", OOP_TF, "false");


            Questions[] q = { MCQ_Q1, MCQ_Q3, MCQ_Q4, TF_Q1 };

            Console.WriteLine("Choose Type of Exam");
            Console.WriteLine("1 ----> FinalExam");
            Console.WriteLine("2 ----> particularExam");
            int Choice =Convert.ToInt32(Console.ReadLine());

            if (Choice == 1)
            {
                FinalExam Final_E1 = new FinalExam(1, 3, 20, "FinalExam", q);
                Final_E1.ShowExam();
                Final_E1.ShowAnswers();
            }
            else
            {
                ParticularExam Patricular_E1 = new ParticularExam(1, 3, 20, "particularExam", q);
                Patricular_E1.ShowExam();
                Patricular_E1.ShowAnswers();
                Patricular_E1.ShowResults();
            }

        

            

         
        }
    }
}