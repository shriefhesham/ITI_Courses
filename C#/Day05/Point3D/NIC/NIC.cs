using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIC
{
    enum type
    {
        Ethernet,
        token_ring
    }
    class NIC
    {
        static int Manufacture;
        static int MAC_address;
        type T;
        static NIC obj;
        NIC(int manufacture, int mAC_address, type number)
        {
            Manufacture = manufacture;
            MAC_address = mAC_address;
            T = number;
        }
        static NIC()
        {
            Console.WriteLine("---------> Ctor Created");
            obj = new NIC(10, 20, 0);
        }
        public static NIC Single_Tone_Nic
        {
            get
            {
                return obj;
            }
        }

        public override string ToString()
        {
            return $"{MAC_address} ----> {Manufacture} ---> {T}";
        }
    }
}