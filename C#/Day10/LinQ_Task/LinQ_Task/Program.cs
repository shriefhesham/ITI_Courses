using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static LinQ_Task.ListGenerators;
namespace LinQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            //Console.WriteLine();
            //Console.WriteLine("--------------------------Find all products that are out of stock.----------------------------");
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var Unit in Result) { Console.WriteLine(Unit); }

            //Console.WriteLine();

            //Console.WriteLine("------------------- Find all products that are in stock and cost more than 3.00 per unit.---------------------");
            //var Result2 = ProductList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);
            //foreach (var Unit in Result2) { Console.WriteLine(Unit); }

            //Console.WriteLine("------------------------ Returns digits whose name is shorter than their value  ---------------------");

            #endregion

            #region Element Operators
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------- Get first Product out of Stock -------------------------------");

            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);

            //Console.WriteLine();

            //Console.WriteLine("------ Return the first product whose Price > 1000, unless there is no match, in which case null is returned -----");
            //Console.WriteLine();
            //var Result2 = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);
            //Console.WriteLine();

            //Console.WriteLine("-------------------------  Retrieve the second number greater than 5 ---------------------------");
            //Console.WriteLine();
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Array.Sort(Arr);
            //var Result3 = Arr.Where(P => P > 5).ElementAt(1);
            //Console.WriteLine(Result3);
            #endregion

            #region Set Operators

            //Console.WriteLine("--------------------------------- Find the unique Category names from Product List ------------------------------");
            //Console.WriteLine();
            //var Result = ProductList.Select(P => P.Category).Distinct();
            //foreach (var R1 in Result) Console.WriteLine(R1);
            //Console.WriteLine();

            //Console.WriteLine("------------ Produce a Sequence containing the unique first letter from both product and customer names ------------");
            //Console.WriteLine();
            //var productFirstChars =
            //(from p in ProductList
            // select p.ProductName[0]).Distinct();
            //foreach (var R2 in productFirstChars) Console.WriteLine(R2);
            //var CatgeroyFirstChars =
            //(from p in ProductList
            // select p.Category[0]).Distinct();
            //foreach (var R3 in CatgeroyFirstChars) Console.WriteLine(R3);
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------- Solution 2 ---------------------------------------------");
            //var Result2 = ProductList.Select(p => p.ProductName.Concat(p.Category).ElementAtOrDefault(0)).Distinct();
            //foreach (var R4 in Result2) Console.WriteLine(R4);
            //Console.WriteLine();
            //Console.WriteLine("------------ . Create one sequence that contains the common first letter from both product and customer names ------------");

            //Console.WriteLine();
            //var Result3 = ProductList.Select(P => P.ProductName.Intersect(P.Category).ElementAtOrDefault(0));
            //foreach (var R5 in Result3) Console.WriteLine(R5);
            //Console.WriteLine();

            //Console.WriteLine(" Create one sequence that contains the first letters of product names that are not also first letters of customer names ");

            //Console.WriteLine();
            //var Result4 = (ProductList.Select(P => P.ProductName.ElementAtOrDefault(0))).Except(CustomerList.Select(C => C.CompanyName.ElementAtOrDefault(0)));
            //foreach (var R6 in Result4) Console.WriteLine(R6);
            //Console.WriteLine();

            //Console.WriteLine(" Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates ");
            //Console.WriteLine();
            //var Result5 = (ProductList.Select(P => P.ProductName.ElementAtOrDefault(0)).TakeLast(3)).Concat(CustomerList.Select(C => C.CompanyName.ElementAtOrDefault(0)).TakeLast(3));
            //foreach (var R7 in Result5) Console.WriteLine(R7);
            //Console.WriteLine();


            #endregion

            #region Aggregate Operators

            //Console.WriteLine("Uses Count to get the number of odd numbers in the array");

            //Console.WriteLine();
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result1 = Arr.Count(P => P % 2 == 1);
            //Console.WriteLine($"Number of ood Numbers : {Result1}");
            //Console.WriteLine();

            //Console.WriteLine(" Return a list of customers and how many orders each has ");

            //Console.WriteLine();
            //var Result2 = from c in CustomerList
            //              select new { c.CustomerID, c.CompanyName, OrderCount = c.Orders.Count() };
            //foreach (var R1 in Result2) { Console.WriteLine(R1); }
            //Console.WriteLine();

            //Console.WriteLine(" Return a list of categories and how many products each has ");

            //Console.WriteLine();
            //var Result3 = from P in ProductList
            //              select new { P.Category, ProductCount = P.ProductID };
            //foreach (var R2 in Result3) { Console.WriteLine(R2); }
            //Console.WriteLine();

            //Console.WriteLine("  Get the total of the numbers in an array  ");

            //Console.WriteLine();
            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result4 = Arr2.Aggregate((element1, element2) => element1 + element2);
            //var Result5 = Arr2.Sum();
            //Console.WriteLine(Result4);
            //Console.WriteLine(Result5);
            //Console.WriteLine();

            //Console.WriteLine(" ----------------------- Get the total number of characters of all words in dictionary_english ------------------- ");

            //Console.WriteLine();
            //var stringArray = File.ReadAllLines("dictionary_english.txt");
            //for (int i = 0; i < stringArray.Length; i++)
            //{ var fields = stringArray[i].Split(' '); }
            //var Result6 = stringArray.SelectMany(segment => segment.Split(' ')).Count();
            //Console.WriteLine($"total number of characters :{Result6}");
            //Console.WriteLine();

            //Console.WriteLine(" -----------------------  Get the total units in stock for each product category  -----------------------");

            //Console.WriteLine();
            //var Result7 = from p in ProductList
            //              where p.UnitsInStock > 0
            //              group p by p.Category into Catg
            //              select new { Catg.Key, NumOfUnitStock = Catg.Sum(P => P.UnitsInStock) };
            //foreach (var R7 in Result7)
            //{ Console.WriteLine(R7); }
            //Console.WriteLine();

            //Console.WriteLine(" ---------------------  Get the length of the shortest word in dictionary_english --------------------");

            //Console.WriteLine();
            //string[] stringArray2 = File.ReadAllLines("dictionary_english.txt");
            //Console.WriteLine(stringArray2[0]);
            //var Result8 = stringArray2.Min(P => P.Length);
            //Console.WriteLine(Result8);
            //Console.WriteLine();

            //Console.WriteLine(" ---------------------  Get the cheapest price among each category's products --------------------");

            //var Result9 = from p in ProductList
            //              where p.UnitsInStock > 0
            //              group p by p.Category into Catg
            //              select new { Catg.Key, cheapest_price = Catg.Min(P => P.UnitPrice) };
            //foreach (var R7 in Result9)
            //{ Console.WriteLine(R7); }
            //Console.WriteLine();

            //Console.WriteLine(" --------------------- Get the products with the cheapest price in each category (Use Let)s --------------------");

            //var Result10 = from p in ProductList
            //               group p by p.Category into g
            //               let minPrice = g.Min(p => p.UnitPrice)
            //               let minPro = g.Where(a => a.UnitPrice == minPrice)
            //               select new { g.Key, MostExpensive = minPro.ToString() };

            //foreach (var R7 in Result10)
            //{ Console.WriteLine(R7); }

            //Console.WriteLine(" --------------------- Get the length of the longest word in dictionary_english --------------------");

            //Console.WriteLine();
            //string[] stringArray3 = File.ReadAllLines("dictionary_english.txt");
            //var Result11 = stringArray3.Max(P => P.Length);
            //Console.WriteLine(Result11);
            //Console.WriteLine();

            //Console.WriteLine(" --------------------- Get the most expensive price among each category's products  --------------------");

            //Console.WriteLine();
            //var Result12 = from p in ProductList
            //              where p.UnitsInStock > 0
            //              group p by p.Category into Catg
            //              select new { Catg.Key, cheapest_price = Catg.Max(P => P.UnitPrice) };
            //foreach (var R12 in Result12)
            //{ Console.WriteLine(R12); }
            //Console.WriteLine();

            //Console.WriteLine(" --------------------- Get the average length of the words in dictionary  --------------------");

            //Console.WriteLine();
            //var stringArray4 = File.ReadAllLines("dictionary_english.txt");
            //var Result13 = stringArray4.Average(segment => segment.Length);
            //Console.WriteLine($"Average number of characters :{Result13}");
            //Console.WriteLine();

            //Console.WriteLine(" --------------------- Get the average price of each category's products.  --------------------");

            //Console.WriteLine();
            //var Result14 = from p in ProductList
            //               where p.UnitsInStock > 0
            //               group p by p.Category into Catg
            //               select new { Catg.Key, cheapest_price = Catg.Average(P => P.UnitPrice) };
            //foreach (var R14 in Result14)
            //{ Console.WriteLine(R14); }
            //Console.WriteLine();

            #endregion

            #region Ordering Operators

            //Console.WriteLine();
            //Console.WriteLine("-------------------------- Sort a list of products by name ---------------------------------");

            //Console.WriteLine();
            //var Result1 = ProductList.OrderBy(P => P.ProductName);
            //foreach (var R1 in Result1)
            //    Console.WriteLine(R1.ToString());
            //Console.WriteLine();

            //Console.WriteLine("------------------ Uses a custom comparer to do a case-insensitive sort of the words in an array -----------------");

            //Console.WriteLine();
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result2 = Arr.OrderBy(a => a, new CaseInsensitiveComparer());
            //foreach(var R2 in Result2)
            //    Console.WriteLine(R2.ToString());
            //Console.WriteLine();

            //Console.WriteLine("------------------Sort a list of products by units in stock from highest to lowest. -----------------");

            //Console.WriteLine();
            //var Result3 = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var R3 in Result3)
            //    Console.WriteLine(R3.ToString());
            //Console.WriteLine();

            //Console.WriteLine("-------- Sort a list of digits, first by length of their name, and then alphabetically by the name itself --------");

            //Console.WriteLine();
            //string[] Arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result4 = Arr2.OrderBy(a => a.Length).ThenByDescending(a=>a ,new CaseInsensitiveComparer());
            //foreach (var R4 in Result4)
            //    Console.WriteLine(R4.ToString());
            //Console.WriteLine();    

            //Console.WriteLine("----------- Sort first by word length and then by a case-insensitive sort of the words in an array. --------");

            //Console.WriteLine();
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result5 = Arr2.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
            //foreach (var R5 in Result5)
            //    Console.WriteLine(R5.ToString());
            //Console.WriteLine();


            //Console.WriteLine("----------- Sort a list of products, first by category, and then by unit price, from highest to lowest --------");

            //Console.WriteLine();
            //var Result6 = ProductList.OrderBy(p => p.Category).ThenByDescending(p=>p.UnitPrice);
            //foreach (var R6 in Result6)
            //    Console.WriteLine(R6.ToString());
            //Console.WriteLine();

            //Console.WriteLine("-----. Sort first by word length and then by a case-insensitive descending sort of the words in an array. ---");

            //Console.WriteLine();
            //string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result7 = Arr2.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
            //foreach (var R7 in Result7)
            //    Console.WriteLine(R7.ToString());
            //Console.WriteLine();

            //Console.WriteLine("-Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array. -");

            //Console.WriteLine();
            //string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result8 = Arr4.Where(P => P.ElementAt(1).ToString() == "i").Reverse();
            //foreach (var R8 in Result8)
            //    Console.WriteLine(R8.ToString());
            //Console.WriteLine();


            #endregion

            #region Partitioning Operators

            //Console.WriteLine();
            //Console.WriteLine(" --------------------- Get the first 3 orders from customers in Washington ------------------------------");

            //Console.WriteLine();
            //var Result1 = CustomerList.Take(3).Where(x => x.Address == "Washington").ToList();
            //foreach (var R in Result1)
            //    Console.WriteLine(Result1);
            //Console.WriteLine();

            //Console.WriteLine(" --------------------- Get all but the first 2 orders from customers in Washington.------------------------------");

            //Console.WriteLine();
            //var Result2 = CustomerList.Skip(2).Where(x => x.Address == "Washington").ToList();
            //foreach (var R in Result2)
            //    Console.WriteLine(Result2);
            //Console.WriteLine();

            //Console.WriteLine(" Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.");

            //Console.WriteLine();
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result3 = numbers.TakeWhile((n, index) => n >= index);
            //foreach (var n in Result3)
            //    Console.WriteLine(n);
            //Console.WriteLine();

            //Console.WriteLine(" ---------------- Get the elements of the array starting from the first element divisible by 3  --------------------");

            //Console.WriteLine();
            //var Result4 = numbers.SkipWhile(p => p % 3 != 0);
            //foreach (var n in Result4)  
            //     Console.WriteLine(n);
            //Console.WriteLine();


            #endregion

            #region Projection Operators

            //Console.WriteLine();
            //Console.WriteLine("------------------- Return a sequence of just the names of a list of products.---------------------------");
            //Console.WriteLine();
            //var Result1 = ProductList.Select(p => p.ProductName);
            //foreach (var i in Result1)
            //    Console.WriteLine(i);
            //Console.WriteLine();

            //Console.WriteLine("----- Produce a sequence of the uppercase and lowercase versions of each word in the original array --------");
            //Console.WriteLine();
            //var Result2 = ProductList.Select(p => new { UpperCase = p.ProductName.ToUpper(), lowercase = p.ProductName.ToLower() });
            //foreach (var i in Result2)
            //    Console.WriteLine(i);
            //Console.WriteLine();

            //Console.WriteLine("------------ Determine if the value of ints in an array match their position in the array -------------");
            //Console.WriteLine();
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result3 = Arr.TakeWhile((n, index) => n >= index);
            //foreach (var i in Result3)
            //    Console.WriteLine(i);
            //Console.WriteLine();



            #endregion
        }



    }
}
