using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examination_System
{
    internal abstract class Questions
    {
        public enum QusType { MCQ, T_F };

        internal int id;
        internal string header;
        internal int marks;
        internal string correct_answer;
        internal Answers2[] answers;
        internal QusType type;

    
        public Questions(string _header , int _marks, string _type, Answers2[] answers, string _correct_answer )
        
        {
            this.id = id;
            this.header = _header;
            this.correct_answer = _correct_answer;
            this.marks = _marks;
            this.type = (QusType)Enum.Parse(typeof(QusType), _type);
            this.answers = answers;
        }


        //public virtual void Show() { }
        public int ID
        { 
             set { this.id = value; }
             get { return this.id; }
        }
        public string Header
        {
            set { this.header = value; }
            get { return this.header; }
        }

        public int Marks
        {
            set { this.marks = value; }
            get { return this.marks; }
        }
        public string CorrectAnswer
        {
            set { this.correct_answer = value; }
            get { return correct_answer; }
        }

        public string Type
        {
            set { type = (QusType)Enum.Parse(typeof(QusType), value); }
            get { return Convert.ToString(type); } 
        }

        public Answers2[] Answers
        {
            set { answers = value; }
            get { return  answers; }
        }

        public override string ToString()
        {
            return $"{header} , {marks} , {answers}, {correct_answer} , {type}";
        }


    }
}
