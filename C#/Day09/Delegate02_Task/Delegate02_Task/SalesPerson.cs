using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02_Task
{
    internal class SalesPerson:Employee
    {
        public int AchievedTarget { get; set; }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if(e.Cause == LayOffCause.Target_Case )
            {
                base.OnEmployeeLayOff(e);
            }
        }
        public bool CheckTarget(int Quota)
        {
            if (Quota > AchievedTarget)
            {
                return true;
            }
            else
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Target_Case });
                return false;
            }
        }
    }
}
