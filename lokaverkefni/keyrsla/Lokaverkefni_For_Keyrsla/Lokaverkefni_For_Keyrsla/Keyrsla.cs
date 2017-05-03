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


            int[] Fotbolti = new int[45];
            int[] Handbolti = new int[45];
            int[] Korfubolti = new int[45];


            List<Ithrottarlid> stokkur = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_not = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_tol = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_temp = new List<Ithrottarlid>();


            string[] nofn = new string[]{"Afturelding", "Álftanes", "Ármann", "Björk", "Breidablik", "FH", "Fjölnir", "Fram", "FSU", "Fylkir", "Gerpla", "Gnupverjar", "Grindavík", "Grótta", "Grundafjordur",
                "Hamar", "Hamrarnir", "Haukar", "HK", "Höttur", "Hrunamenn", "ÍA", "ÍBV", "IF Mílan", "ÍG", "ÍR", "Íþróttarfélagið Hörður", "Íþróttarfélag Breiðholts", "KR", "Leiknir", "Njardvík",
                "Reykdælir", "Reynir Sandgerði", "Sindri", "Snæfell", "Stál Úlfur", "Stjarnan", "UMF Akureyri", "UMF Hekla", "UMF Kormákur", "UMF Þór", "Valur", "Volsungur", "Þór Akureyri", "Þróttur"};
            

            Random rand = new Random();
    

            for (int i = 0; i < nofn.Length; i++)
            {
                stokkur.Add( new Ithrottarlid(Fotbolti[i] = rand.Next(50, 101), Handbolti[i] = rand.Next(50, 101), Korfubolti[i] = rand.Next(50, 101), nofn[i]));
            }
            Console.WriteLine("Ýttu á 1 til að spila");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (val1 == 1)
	        {
	         

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
                Console.WriteLine(stokkur_not[0]+"\n");
                Console.WriteLine("Veldu 1,2 eða 3");
                Console.WriteLine("1. Fótbolti");
                Console.WriteLine("2. Handbolti");
                Console.WriteLine("3. Körfubolti");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    if (stokkur_not[0].Fotbolti > stokkur_tol[0].Fotbolti)
                    {
                        int stig = stokkur_not[0].Fotbolti - stokkur_tol[0].Fotbolti;
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);
                            }
                        }
                    }
                    else if (stokkur_tol[0].Fotbolti > stokkur_not[0].Fotbolti)
                    {
                        int stig = stokkur_tol[0].Fotbolti - stokkur_not[0].Fotbolti;
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);
                        stokkur_tol.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_tol.Add(stokkur_temp[i]);
                            }
                        }
                    }
                    else if (stokkur_not[0].Fotbolti == stokkur_tol[0].Fotbolti)
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);
                        stokkur_temp.Add(stokkur_tol[0]);
                        stokkur_not.Remove(stokkur_not[0]);
                        stokkur_tol.Remove(stokkur_tol[0]);
                    }
                    else
	                {
                        Console.WriteLine("Einhver villa.");
	                }
                }
                else if (val == 2)
                {
                    if (stokkur_not[0].Handbolti > stokkur_tol[0].Handbolti)
                    {
                        int stig = stokkur_not[0].Handbolti - stokkur_tol[0].Handbolti;
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);
                            }
                        }
                    }
                    else if (stokkur_tol[0].Handbolti > stokkur_not[0].Handbolti)
                    {
                        int stig = stokkur_tol[0].Handbolti - stokkur_not[0].Handbolti;
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);
                        stokkur_tol.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_tol.Add(stokkur_temp[i]);
                            }
                        }
                    }
                    else if (stokkur_not[0].Handbolti == stokkur_tol[0].Handbolti)
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);
                        stokkur_temp.Add(stokkur_tol[0]);
                        stokkur_not.Remove(stokkur_not[0]);
                        stokkur_tol.Remove(stokkur_tol[0]);
                    }
                    else
                    {
                        Console.WriteLine("Einhver villa.");
                    }
                }
                else if (val == 3)
                {
                    if (stokkur_not[0].Korfubolti > stokkur_tol[0].Korfubolti)
                    {
                        int stig = stokkur_not[0].Korfubolti - stokkur_tol[0].Korfubolti;
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);
                            }
                        }
                    }
                    else if (stokkur_tol[0].Korfubolti > stokkur_not[0].Korfubolti)
                    {
                        int stig = stokkur_tol[0].Korfubolti - stokkur_not[0].Korfubolti;
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);
                        stokkur_tol.Add(stokkur_tol[0]);
                    }
                    else if (stokkur_not[0].Korfubolti == stokkur_tol[0].Korfubolti)
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);
                        stokkur_temp.Add(stokkur_tol[0]);
                        stokkur_not.Remove(stokkur_not[0]);
                        stokkur_tol.Remove(stokkur_tol[0]);
                    }
                    else
                    {
                        Console.WriteLine("Einhver villa.");
                    }
                }
                
                Console.WriteLine("Þetta er spilið hjá tölvuni");
                Console.WriteLine(stokkur_tol[0]+"\n");
                Console.ReadLine();
                Console.WriteLine("Ýttu á 1 til að spila aftur");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
	        }
            
        }// endir á main
    }
}
