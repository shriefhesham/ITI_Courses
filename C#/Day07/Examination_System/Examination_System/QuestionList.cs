using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;


namespace Examination_System
{
    internal class QuestionList : List<Questions>
    {
        internal void Add(QuestionList q) 
        {
            string logpath = ConfigurationManager.AppSettings["logpath"];
            using (StreamWriter writer = new StreamWriter(logpath, true))
            { 
                for(int i=0; i<q.Count; i++)
                {
                    writer.WriteLine($"{DateTime.Now} , {q[i].header}");
                }
            }
        }
        public int CompareTo(QuestionList? other)
        {
            throw new NotImplementedException();
        }

    }
}
