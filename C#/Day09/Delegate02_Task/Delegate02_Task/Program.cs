namespace Delegate02_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee() { EmployeeID = 1 , VacationStock = 10 , BirthDate = new DateTime(2000,3,10)};
            Employee E2 = new Employee() { EmployeeID = 2 , VacationStock = 20 , BirthDate = new DateTime(1960,3,30)};

            Department D1 = new Department() { DeptID = 10, DeptName = "SD"};

            Club c1 = new Club() { ClubID = 100 , ClubName = "AlAhly.sc"  };

            SalesPerson Sales1 = new SalesPerson() { EmployeeID = 10, VacationStock = 10, BirthDate = new DateTime(1950, 1, 1), AchievedTarget = 5000 };
            BoardMember B_Member1 = new BoardMember() { EmployeeID = 10, VacationStock = 1, BirthDate = new DateTime(1956, 1, 1) };

            D1.AddStaff(E1);
            D1.AddStaff(E2);
            D1.AddStaff(Sales1);
            D1.AddStaff(B_Member1);


            c1.AddMember(E1);
            c1.AddMember(E2);
            c1.AddMember(Sales1);
            c1.AddMember(B_Member1);


            Console.WriteLine("List Before Any Update");
            for (int i = 0; i < D1.staff.Count; i++)
                Console.WriteLine($" Employee Number {i+1} ::: {D1.staff[i]}");


            #region Register All Objects for EmployeeLayOff Here
            //E1.EmployeeLayOff += D1.RemoveStaff;
            //E1.EmployeeLayOff += c1.RemoveMember;

            //E2.EmployeeLayOff += D1.RemoveStaff;
            //E2.EmployeeLayOff += c1.RemoveMember;

            //Sales1.EmployeeLayOff += D1.RemoveStaff;
            //Sales1.EmployeeLayOff += c1.RemoveMember;

            //B_Member1.EmployeeLayOff += D1.RemoveStaff;
            //B_Member1.EmployeeLayOff += c1.RemoveMember;
            #endregion

            //E1.EndOfYearOperation();

            //E2.RequestVacation(new DateTime(2023, 3, 10), new DateTime(2023, 3, 30));
            //E2.EndOfYearOperation();

            //Sales1.CheckTarget(4000);
            //Sales1.RequestVacation(new DateTime(2023, 3, 10), new DateTime(2023, 3, 30));
            //Sales1.EndOfYearOperation();

            //B_Member1.RequestVacation(new DateTime(2023, 3, 10), new DateTime(2023, 3, 30));
            //B_Member1.EndOfYearOperation();
            B_Member1.Resign();




        }
    }
}