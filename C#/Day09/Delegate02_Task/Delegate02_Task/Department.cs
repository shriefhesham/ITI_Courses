using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02_Task
{
    internal class Department
    {
       public List<Employee> staff = new List<Employee>();
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff { get; set; }
        public void AddStaff(Employee E)
        {
            if (E != null)
            {
                 staff.Add(E);

                 E.EmployeeLayOff += RemoveStaff;
            }
        }

        public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee E) && (sender != null) && (staff.Contains(E)) )
            {
                staff.Remove(E);
                E.EmployeeLayOff -= RemoveStaff;
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("One Employee Removed From Department");
                for (int i = 0; i < staff.Count; i++)
                    Console.WriteLine($" Employee Number  {i+1} :: {staff[i]}");
            }
        }

    }
}
