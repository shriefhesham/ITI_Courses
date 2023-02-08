using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Task
{
    public enum Gender
    {
        M , m , F , f 
    }

    [Flags]
    public enum ScurityLevel:byte
    {
        guest             = 1  ,
        Developer         = 2  ,
        secretar          = 4  ,
        DBA               = 8  
    }
    internal struct Employee
    {
        int id;
        decimal salary;
        Hiredate hiredate;
        Gender gender ;
        ScurityLevel scurityLevel;

        public Employee(int _id, decimal _salary, Hiredate _hiredate, int _scurityLevel, string _gender)
        {
            id = _id;
            salary = _salary;
            hiredate = _hiredate;
            gender = (Gender)Enum.Parse(typeof(string), _gender);
            scurityLevel = (ScurityLevel)_scurityLevel;

        }

        public int ID
        {
            set { id = value; }
            get { return id; } 
        }

        public decimal Salary
        {
            set { salary = value; } 
            get { return salary; }
        }
      
        public Hiredate Hiredate 
        {
            set { hiredate = value; }
            get { return hiredate; }
        }
        //public void SetHireDate (Hiredate _hiredate) { hiredate = _hiredate ; }
        //public Hiredate getHireDate() { return  hiredate ; }

        public Gender Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public ScurityLevel ScurityLevel
        {
            set { scurityLevel = value; }
            get { return scurityLevel; }
        }



        public override string ToString()
        {
            {
                return Convert.ToString(salary);
            }
        }
    }

   

    }
