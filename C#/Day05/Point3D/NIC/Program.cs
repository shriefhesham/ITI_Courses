namespace NIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC nic;
            nic = NIC.Single_Tone_Nic;
            Console.WriteLine(nic.ToString());
            NIC nic2;
            nic2 = NIC.Single_Tone_Nic;
            Console.WriteLine(nic2.ToString());
            Console.WriteLine(nic.GetHashCode());
            Console.WriteLine(nic2.GetHashCode());
        }
    }
}