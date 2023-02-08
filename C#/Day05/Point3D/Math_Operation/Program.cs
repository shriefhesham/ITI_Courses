namespace Math_Operation

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());

            int Add = Math.AddOp(num1, num2);
            double devide = Math.DevideOp(num1, num2);
            int multible = Math.MultubelOp(num1, num2);
            int sub = Math.SubtractOp(num1, num2);


            Console.WriteLine($"Add      : {Add}");
            Console.WriteLine($"Devide   : {devide}");
            Console.WriteLine($"Multible : {multible}");
            Console.WriteLine($"Sub      : {sub}");
        }
    }
}