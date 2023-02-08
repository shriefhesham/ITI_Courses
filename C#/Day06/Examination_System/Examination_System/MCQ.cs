using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MCQ : Questions
    {
        public MCQ(string _header, int _marks, string _type, Answers2[] answers, string _correct_answer) : base(_header, _marks, _type, answers, _correct_answer)
        {
        }
    }
}
