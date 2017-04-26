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
            Ithrottarlid[] lid = new Ithrottarlid[7]; 
            string[] nofn = new string[]{"Breiðablik", "HK", "KR", "Stjarnan", "Hamar", "Grótta", "FH"};
            
            Random rand = new Random();
            for (int i = 0; i < lid.Length; i++)
            {
                lid[i] = new Ithrottarlid(rand.Next(50, 101), rand.Next(50, 101), rand.Next(50, 101), nofn[i]);
                Console.WriteLine(lid[i]+"\n");
            }
            
            Console.ReadLine();
        }// endir á main
    }
}
