namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            FieldPlayer Fb1 = new FieldPlayer();
            Forward F1 = new Forward();
            Defender D1 = new Defender();

            F1.SetComponent(Fb1);
            D1.SetComponent(F1);

            D1.Functionality();
            


            //FiledPlayer FP = new FiledPlayer();
            //Forward F1 = new Forward();
            //MidFielder M1 = new MidFielder();

            //// Link decorators
            //F1.AssignPlayer(FP);
            //M1.AssignPlayer(F1);

            //M1.PassBall();
        }
    }
}