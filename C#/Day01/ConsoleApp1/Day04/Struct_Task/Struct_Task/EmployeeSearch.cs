using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Struct_Task
{
    internal class EmployeeSearch
    {
       public int[] nationalIds;
       public Employee[] employees;
       int size;


        public EmployeeSearch(int _size)
        {
            size= _size;
            this.nationalIds = new int[size];
            this.employees = new Employee[size];
        }



        public int[] NationalId
        {
            set { nationalIds = value; }
            get { return nationalIds; }
        }

        public Employee[] Employees
        {
            set { employees = value; }
            get { return employees; }
        }

        public string this[int _nationalid]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].ID == _nationalid)
                        return employees[i].ToString();
                }
                return null;
            }
        }

        public string this[int day , int month , int year]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Hiredate.year == year && employees[i].Hiredate.month == month && employees[i].Hiredate.day == day)
                        return employees[i].ToString();
                }
                return null;
            }
        }


        public string this[string _Name]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Name == _Name)
                        return employees[i].ToString();
                }
                return null;
            }
        }



    }

    
}
