using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class T_F : Questions
    {
        public T_F(string _header, int _marks, string _type, List<Answers2> answers, string _correct_answer) : base(_header, _marks, _type, answers, _correct_answer)
        {
        }

        public string Header 
        {
            set { header = value; }
            get { return header; }
        }

        public int Marks 
        {
            set { marks = value; }
            get { return marks; }
        }

        public string Type
        {
            set { type = (QusType)Enum.Parse(typeof(QusType), value ); }
            get { return Convert.ToString(type);}
        }

        public List<Answers2> Answers
        {
            set { answers = value; }
            get { return answers; }
        }

    }
}
