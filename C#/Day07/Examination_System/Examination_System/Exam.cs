using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Examination_System
{
    internal abstract  class Exam : IComparable
    {
        public enum ExamType { particularExam, FinalExam };


        internal int id;
        internal int numOfTf, numOfMCQ ,time ;
        internal ExamType type;
        internal QuestionList questions;
        internal string question;
        //internal Dictionary<string, string> dic_Lis;
        internal static int counter = 0;
        private string type1;

        public Exam(int _numOfTf , int _numOfMCQ , int _time , string _type , QuestionList _questions/*, Dictionary<string, string> _dic_Lis*/)
        {
            numOfTf = _numOfTf;
            numOfMCQ = _numOfMCQ;
            time= _time;
            type = (ExamType)Enum.Parse(typeof(ExamType) ,_type);
            questions = _questions;
            //dic_Lis = _dic_Lis; 
        }



        public abstract void ShowExam();

        public abstract void ShowAnswers();

        public abstract int CompareTo(object? obj);
   
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public int NumOf_TF 
        {
            set { numOfTf = value; }
            get { return numOfTf; }
        }

        public int NumOf_MCQ
        { 
         set { numOfMCQ = value; }
         get { return numOfMCQ; }
        }

        public string Type
        {
            set { type = (ExamType)Enum.Parse(typeof(ExamType), value); }
            get { return Convert.ToString(type); }
        }
    
        public QuestionList Questions 
        {
            set { questions = value; }
            get { return questions; }
        }
    }
}
