using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answers2
    {
      
            string answer;

            public Answers2(string _answer)
            {
                answer = _answer;
            }

            public string Answer
            {
                get { return answer; }
                set { answer = value; }
            }

            public override string ToString()
            {
                return $"{answer}";
            }
        }
    
}
