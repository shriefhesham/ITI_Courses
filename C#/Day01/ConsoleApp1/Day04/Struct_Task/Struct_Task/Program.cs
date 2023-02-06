using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Struct_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hiredate Myhire = new Hiredate();
            EmployeeSearch EmpSearch = new EmployeeSearch(3);
            

            int id , salary , day , month , year ;
            string gender , name ;

            void validateId()
            {
                do { Console.WriteLine("Enter ID of Empolyee"); }
                while (int.TryParse(Console.ReadLine(), out id) == false);
            }
            void validateGender()
            {
                do
    {
        Console.WriteLine("Enter Your Gender");
        gender = Console.ReadLine();
    }
    while (gender != "m" && gender != "f" && gender != "M" && gender != "F");
            }
            void validateSalary()
            {
                do
                {
                    Console.WriteLine("Enter Your salary");
                }
                while (int.TryParse(Console.ReadLine(), out salary) == false);
            }
            void validateDay()
            {
                do
                {
                    Console.WriteLine("Enter Your day:");
                }
                while (int.TryParse(Console.ReadLine(), out day) == false || day < 1 || day > 31);
            }
            void validateMonth()
            {
                do
                {
                    Console.WriteLine("Enter Your month:");
                }
                while (int.TryParse(Console.ReadLine(), out month) == false || month < 1 || month > 12);
            }
            void validateYear()
            {
                do
                {
                    Console.WriteLine("Enter Your year:");
                }
                while (int.TryParse(Console.ReadLine(), out year) == false || year < 2000 || year > 2023);

            }


            for (int i = 0; i < EmpSearch.employees.Length ; i++)
            {
                Console.WriteLine($"Enter Data For Employee Number  {i + 1}");
                
                validateId();
                EmpSearch.employees[i].ID = id;

                Console.WriteLine("Enter Name of Empolyee");
                name = Console.ReadLine(); 
                EmpSearch.employees[i].Name = name;

                validateGender();
                EmpSearch.employees[i].Gender = (Gender)Enum.Parse(typeof(Gender), gender);
 
                validateSalary();
                EmpSearch.employees[i].Salary = salary;
  
                Console.WriteLine("Enter Employee Scurity Number");
                string ScurityL = Console.ReadLine();
                EmpSearch.employees[i].ScurityLevel = (ScurityLevel)Enum.Parse(typeof(ScurityLevel), ScurityL);

                validateDay();
                validateMonth();
                validateYear();
                Myhire = new Hiredate(day, month, year);
                EmpSearch.employees[i].Hiredate = Myhire;
            }


            for (int i = 0; i < EmpSearch.employees.Length; i++)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Employee Number {i + 1} is ");
                Console.WriteLine($" EmployeeID          ----> {EmpSearch.employees[i].ID}");
                Console.WriteLine($" EmployeeName        ----> {EmpSearch.employees[i].Name}");
                Console.WriteLine($" Employee_Salary     ----> {EmpSearch.employees[i].Salary}");
                Console.WriteLine($" EmployeeHireDate    ----> {EmpSearch.employees[i].Gender}");
                Console.WriteLine($" Employee_Gender     ----> {EmpSearch.employees[i].Hiredate}");
                Console.WriteLine($" Employee_Position   ----> {EmpSearch.employees[i].ScurityLevel}");
                Console.WriteLine("-----------------------------------------------------------------------");
            }

            Console.WriteLine("Enter ID You Want To search");
            int nationalId = int.Parse(Console.ReadLine());
            Console.WriteLine(EmpSearch[2]);



            Console.WriteLine("Hire Date (1, 1, 2000) ");
            Console.WriteLine(EmpSearch[1, 1, 2000]);

           

            



            //void SortEmp(Employee[] empdata) 
            //{
            //    Employee temp;
            //    for (int i = 0; i < empdata.Length; i++)
            //    {
            //        for (int j = i + 1; j < empdata.Length; j++)
            //        {
            //            if (empdata[i].Hiredate.year < empdata[j].Hiredate.year)
            //            { 
            //                temp = empdata[i];
            //                empdata[i] = empdata[j];
            //                empdata[j]= temp;
            //            }
            //        }
            //        Console.WriteLine(temp[i]);

            //    }
            //}


            //SortEmp(employees);


            //void sortEmp(Employee[] myarr)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 3 - i - 1; j++)
            //        {
            //            if (myarr[j].Hiredate.year < myarr[j + 1].Hiredate.year)
            //            {
            //                Employee temp = myarr[j + 1];
            //                myarr[j + 1] = myarr[j];
            //                myarr[j] = temp;
            //            }
            //        }
            //    }

            //}

            //sortEmp(employees);


            //search.NationalId = nationalId;
            //search.Employees = employees;
            //int idSearch = int.Parse(Console.ReadLine());
            //search[idSearch];
        }
    }
}