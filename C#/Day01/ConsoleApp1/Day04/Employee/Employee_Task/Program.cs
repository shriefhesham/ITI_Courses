using System;
using System.Reflection;

namespace Struct_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hiredate Myhire = new Hiredate();
            Employee[] employees = new Employee[3];
           

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Data For Employee Number  {i + 1}");
                Console.WriteLine(" Enter Employee id Number ");
                int id = int.Parse(Console.ReadLine());
                employees[i].ID = id;

                Console.WriteLine("Enter Your Gender");
                string gender =Console.ReadLine();
                employees[i].Gender = (Gender)Enum.Parse(typeof(Gender),gender);

                Console.WriteLine("Enter Employee salary Number");
                int salary = int.Parse(Console.ReadLine());
                employees[i].Salary= salary;

                Console.WriteLine("Enter Employee Scurity Number");
                string ScurityL = Console.ReadLine();
                employees[i].ScurityLevel = (ScurityLevel)Enum.Parse(typeof(ScurityLevel), ScurityL);


                Console.WriteLine("Enter your day");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your month");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your year");
                int year = int.Parse(Console.ReadLine());

                Myhire = new Hiredate(day, month, year);
                employees[i].Hiredate= Myhire;
            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Employee Number {i+1} is ");
                Console.WriteLine($" EmployeeID          ----> {employees[i].ID}");
                Console.WriteLine($" Employee_Salary     ----> {employees[i].Salary}");
                Console.WriteLine($" EmployeeHireDate    ----> {employees[i].Hiredate}");
                Console.WriteLine($" Employee_Gender     ----> {employees[i].Hiredate}");
                Console.WriteLine($" Employee_Position   ----> {employees[i].ScurityLevel}");
                Console.WriteLine("-----------------------------------------------------------------------"); 
            }
        }
    }
}