using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02_Task
{
    internal class Club
    {

        public int ClubID { get; set; }
        public String ClubName { get; set; }


        List<Employee> Members =new List<Employee>();
        public void AddMember(Employee E)
        {
            if (E != null)
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;
            }
        }

        public void RemoveMember(object sender,EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee E) && (sender != null) && (Members.Contains(E)))
            {
                if ( e.Cause != LayOffCause.Age_Case)
                {
                    Members.Remove(E);
                    E.EmployeeLayOff -= RemoveMember;
                    Console.WriteLine("One Employee Removed From Club");
                    for (int i = 0; i < Members.Count; i++)
                        Console.WriteLine($" Employee Number  {i + 1} :: {Members[i]}");
                }

            }
        }

    }
}
