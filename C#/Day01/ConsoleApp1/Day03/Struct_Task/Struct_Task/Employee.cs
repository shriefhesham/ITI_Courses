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
        DBA               = 8  ,
        SecurityOfficer   = 15 ,
    }
    internal struct Employee
    {
        int id;
        decimal salary;
        Hiredate hiredate;
        Gender gender ;
        ScurityLevel ScurityLevel;

        public Employee(int _id, decimal _salary, Hiredate _hiredate, int _scurityLevel, string _gender)
        {
            id = _id;
        
            salary = _salary;
            hiredate = _hiredate;
            gender = (Gender)Enum.Parse(typeof(string), _gender);
            ScurityLevel = (ScurityLevel)_scurityLevel;
        }

        public void SetId(int _id) { id = _id; }
        public int getId() { return id; }
        public void setSalary(decimal _salary) { salary = _salary; }
        public decimal getSalary() { return salary; }
        public void SetHireDate (Hiredate _hiredate) { hiredate = _hiredate ; }
        public Hiredate getHireDate() { return  hiredate ; }
        public void SetGender(string _gender) { gender = (Gender)Enum.Parse(typeof(Gender), _gender); }
        public Gender getGender() { return gender; }
        public void setScurityLevel(int _ScurityLevel) { { ScurityLevel = (ScurityLevel)_ScurityLevel; } }
        public ScurityLevel getScurityLevel() { return ScurityLevel; }
        public override string ToString()
        {
            {
                return Convert.ToString(salary);
            }
        }
    }

   

    }
