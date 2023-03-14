namespace BuilderDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ground ground;
            GroundDirector groundDirector = new GroundDirector();



            // Construct and display Ground

            Ground1 ground1 = new Ground1();
            ground = groundDirector.MakeGround(ground1);
            ground.DisplayGround();

            
            
        }
    }
}