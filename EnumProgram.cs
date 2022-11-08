using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum electronics
    {
        Lap = 1,
        Mobile = 2,
        Ipad = 3
    }
    class EnumProgram
    {
        static void Main4(string[] args)
        {
            var ele = electronics.Mobile;
            Console.WriteLine((int)ele);
            Console.WriteLine(ele);
            Console.WriteLine(ele.ToString());

            var itemnum = 3;
            Console.WriteLine((electronics)itemnum);

            var elec = "Lap";
            var eletype = (electronics)Enum.Parse(typeof(electronics), elec);
            Console.WriteLine(eletype);
        }
    }
}
