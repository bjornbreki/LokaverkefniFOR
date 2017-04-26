using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lokaverkefni_for;

namespace Lokaverkefni_For_Keyrsla
{
    class Keyrsla
    {
        /* Björn Breki og Róbert Atli
         * Tækniskólinn
         * Lokaverkefni Forritun
         * 4 önn
         * FOR2C3U
         */
        static void Main(string[] args)
        {
            Ithrottarlid lid_1 = new Ithrottarlid(7, 5, 8, "Þróttur");
            Console.WriteLine(lid_1);
            Console.ReadLine();
        }// endir á main
    }
}
