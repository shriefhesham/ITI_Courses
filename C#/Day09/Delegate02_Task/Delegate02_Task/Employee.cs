using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02_Task
{
    public enum LayOffCause
    {
        Vacation_stock_Case = 0,
        Age_Case = 1 ,
        Target_Case = 2 ,
        Resign_Case = 4
    }
    internal class Employee
    {
      
      public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
      protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
      {
      EmployeeLayOff?.Invoke(this, e);
      }

         public int EmployeeID { get; set; }
         public DateTime BirthDate { get; set; }
         public int VacationStock { set; get; }


         public bool RequestVacation(DateTime From, DateTime To)
         {
 
         int Calc_Days = Convert.ToInt32((To - From).TotalDays);
             if (Calc_Days < VacationStock)
                 {
                     VacationStock -= Calc_Days;
                     return true;
                 }
             else
                 {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Vacation_stock_Case});
                 }
         return false;
         }

         public void EndOfYearOperation()
         {
            if ((this.BirthDate.Year - DateTime.Now.Year ) <= 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age_Case});
            }
         }

        public override string ToString()
        {
            return $"{EmployeeID},{BirthDate},{VacationStock}";
        }

    }
    

    
}
