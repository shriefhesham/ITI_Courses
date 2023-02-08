namespace Point3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D P = new Point3D(10,20,30);
            Console.WriteLine(P.ToString());

            Console.Write(" ----------------------------------------------------- \n ");

            int x, y, z , x1, y1, z1;
            do { Console.Write("X :"); }
            while (int.TryParse(Console.ReadLine(), out x) == false);
            do { Console.Write("Y :"); }
            while (int.TryParse(Console.ReadLine(), out y) == false);
            do { Console.Write("Z :"); }
            while (int.TryParse(Console.ReadLine(), out z) == false);

            do { Console.Write("X1 :"); }
            while (int.TryParse(Console.ReadLine(), out x1) == false);
            do { Console.Write("Y2 :"); }
            while (int.TryParse(Console.ReadLine(), out y1) == false);
            do { Console.Write("Z3 :"); }
            while (int.TryParse(Console.ReadLine(), out z1) == false);

            Point3D P1 = new Point3D(x, y, z);
            Point3D P2 = new Point3D(x1,y1,z1);

            Console.Write(" ----------------------------------------------------- \n ");

            Console.Write("is P1 == P2 ? ");
            if (P1 == P2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


            Console.Write(" ----------------------------------------------------- \n ");

            Console.Write("is P1.Equals(P2) ? ");
            if (P1.Equals(P2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");



        }
    }
}