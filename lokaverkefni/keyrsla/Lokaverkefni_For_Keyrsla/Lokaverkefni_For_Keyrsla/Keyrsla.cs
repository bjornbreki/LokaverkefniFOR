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
            //Ithrottarlid[] lid = new Ithrottarlid[45];
            int[] Fotbolti = new int[45];
            int[] Handbolti = new int[45];
            int[] Korfubolti = new int[45];

            List<Ithrottarlid> stokkur = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_not = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_tol = new List<Ithrottarlid>();
            string[] nofn = new string[]{"Afturelding", "Álftanes", "Ármann", "Björk", "Breidablik", "FH", "Fjölnir", "Fram", "FSU", "Fylkir", "Gerpla", "Gnupverjar", "Grindavík", "Grótta", "Grundafjordur",
                "Hamar", "Hamrarnir", "Haukar", "HK", "Höttur", "Hrunamenn", "ÍA", "ÍBV", "IF Mílan", "ÍG", "ÍR", "Íþróttarfélagið Hörður", "Íþróttarfélag Breiðholts", "KR", "Leiknir", "Njardvík",
                "Reykdælir", "Reynir Sandgerði", "Sindri", "Snæfell", "Stál Úlfur", "Stjarnan", "UMF Akureyri", "UMF Hekla", "UMF Kormákur", "UMF Þór", "Valur", "Volsungur", "Þór Akureyri", "Þróttur"};
            
            Random rand = new Random();

            int tala1 = rand.Next(0, 45);
            int tala2 = rand.Next(0, 45);

            
            
            for (int i = 0; i < nofn.Length; i++)
            {
                stokkur.Add( new Ithrottarlid(Fotbolti[i] = rand.Next(50, 101), Handbolti[i] = rand.Next(50, 101), Korfubolti[i] = rand.Next(50, 101), nofn[i]));
                //lid[i] = new Ithrottarlid(Fotbolti[i] = rand.Next(50, 101), Handbolti[i] = rand.Next(50, 101), Korfubolti[i] = rand.Next(50, 101), nofn[i]);
            }

            for (int i = 0; i < stokkur.Count; i++)
            {
                int naestaspil = rand.Next(0,stokkur.Count);
                if (i%2==0)
                {
                    stokkur_tol.Add(stokkur[naestaspil]);
                }
                else
                {
                    stokkur_not.Add(stokkur[naestaspil]);
                }
                stokkur.Remove(stokkur[naestaspil]);
            }
                Console.WriteLine("Þetta er spilið þitt");
                //Console.WriteLine(lid[tala1] + "\n");
                Console.WriteLine("Veldu 1,2 eða 3");
                Console.WriteLine("1. Fótbolti");
                Console.WriteLine("2. Handbolti");
                Console.WriteLine("3. Körfubolti");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    if (Fotbolti[tala1] > Fotbolti[tala2])
                    {
                        int stig = Fotbolti[tala1] - Fotbolti[tala2];
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Fotbolti[tala2] > Fotbolti[tala1])
                    {
                        int stig = Fotbolti[tala2] - Fotbolti[tala1];
                        Console.WriteLine("Þú tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Fotbolti[tala1] == Fotbolti[tala2])
                    {
                        Console.WriteLine("Það var jafntefli!");
                    }
                    else
	                {
                        Console.WriteLine("Einhver villa.");
	                }
                }
                else if (val == 2)
                {
                    if (Handbolti[tala1] > Handbolti[tala2])
                    {
                        int stig = Handbolti[tala1] - Handbolti[tala2];
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Handbolti[tala2] > Handbolti[tala1])
                    {
                        int stig = Handbolti[tala2] - Handbolti[tala1];
                        Console.WriteLine("Þú tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Handbolti[tala1] == Handbolti[tala2])
                    {
                        Console.WriteLine("Það var jafntefli!");
                    }
                    else
	                {
                        Console.WriteLine("Einhver villa.");
	                }
                }
                else if (val == 3)
                {
                    if (Korfubolti[tala1] > Korfubolti[tala2])
                    {
                        int stig = Korfubolti[tala1] - Korfubolti[tala2];
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Korfubolti[tala2] > Korfubolti[tala1])
                    {
                        int stig = Korfubolti[tala2] - Korfubolti[tala1];
                        Console.WriteLine("Þú tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                    }
                    else if (Korfubolti[tala1] == Korfubolti[tala2])
                    {
                        Console.WriteLine("Það var jafntefli!");
                    }
                    else
	                {
                        Console.WriteLine("Einhver villa.");
	                }
                }
                
                Console.WriteLine("Þetta er spilið hjá tölvuni");
                Console.WriteLine(lid[tala2] + "\n");
                Console.ReadLine();
        }// endir á main
    }
}
