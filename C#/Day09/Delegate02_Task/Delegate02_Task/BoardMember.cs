using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02_Task
{
    internal class BoardMember:Employee
    {
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
          
                base.OnEmployeeLayOff(e);           
            
        }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age_Case });
        }
    }
}
