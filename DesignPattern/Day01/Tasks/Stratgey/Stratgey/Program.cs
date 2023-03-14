namespace Stratgey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context = new Context(new DefendStrategy());
            context.ApplyStartegy();

            context = new Context(new AttackStartegy());
            context.ApplyStartegy();
        }
    }
}