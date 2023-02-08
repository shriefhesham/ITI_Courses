namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------  new Duration (1,10,15)  -----------------------------------");
            Duration duration1 = new Duration(1, 50, 30);
            Console.WriteLine(duration1.ToString());
            Console.WriteLine("--------------------------------  new Duration (3600)  --------------------------------------");
            Duration duration2 = new Duration(3510);
            Console.WriteLine(duration2.ToString());
            Console.WriteLine("--------------------------------  new Duration (7800)  -----------------------------------");
            Duration duration3 = new Duration(7800);
            Console.WriteLine(duration3.ToString());
            Console.WriteLine("--------------------------------  new Duration (666)  -----------------------------------");
            Duration duration4 = new Duration(666);
            Console.WriteLine(duration4.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------  Operator OverLoading  -----------------------------------");

            Console.WriteLine($"D3 = D1 + D2      ---->  {duration1 + duration2}");
            Console.WriteLine($"D3 = D1 + 7800    ---->  {duration1 + 7800}");
            Console.WriteLine($"D3 = 666 + D3     ---->  {666 + duration3}");
            Console.WriteLine($"D3 = D1++         ---->  {duration1++}");
            Console.WriteLine($"D3 = --D2         ---->  {--duration2}");
            Console.WriteLine($"D3-= D4           ---->  {duration1 -= duration4}");
            Console.WriteLine($"If ( D1 > D2 );   ---->  {duration1 >  duration4}");
            Console.WriteLine($"If ( D1 < D2 );   ---->  {duration1 <  duration4}");
            Duration test = new Duration();
            test = default;


            if (duration1)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            DateTime Obj = (DateTime)duration3;
            Console.WriteLine(Obj);

        }

    }
}