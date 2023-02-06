using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Task
{
    internal struct Hiredate
    {
        internal int day;
        internal int month;
        internal int year;

        public Hiredate(int _day , int _month , int _year  )
        {
            day = _day;
            month = _month;
            year = _year;
        }

  
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }


    }
}
