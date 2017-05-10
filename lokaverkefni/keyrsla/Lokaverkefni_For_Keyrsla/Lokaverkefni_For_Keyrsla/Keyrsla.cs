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

            // býr til Arraya til að geyma upplýsingar um íþróttirnar
            int[] Fotbolti = new int[44];
            int[] Handbolti = new int[44];
            int[] Korfubolti = new int[44];

            // býr til list arraya fyrir stokkinn, stokk notenda og tölvunnar og býr til temporary stokkinn sem er notaður ef það er jafntefli
            List<Ithrottarlid> stokkur = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_not = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_tol = new List<Ithrottarlid>();
            List<Ithrottarlid> stokkur_temp = new List<Ithrottarlid>();

            // string array sem geymir nöfnin og er notaður til að merkja spilin.
            string[] nofn = new string[]{"Afturelding", "Álftanes", "Ármann", "Björk", "Breidablik", "FH", "Fjölnir", "Fram", "FSU", "Fylkir", "Gerpla", "Gnupverjar", "Grindavík", "Grótta", "Grundafjordur",
                "Hamar", "Hamrarnir", "Haukar", "HK", "Höttur", "Hrunamenn", "ÍA", "ÍBV", "IF Mílan", "ÍR", "Íþróttarfélagið Hörður", "Íþróttarfélag Breiðholts", "KR", "Leiknir", "Njardvík",
                "Reykdælir", "Reynir Sandgerði", "Sindri", "Snæfell", "Stál Úlfur", "Stjarnan", "UMF Akureyri", "UMF Hekla", "UMF Kormákur", "UMF Þór", "Valur", "Volsungur", "Þór Akureyri", "Þróttur"};
            

            Random rand = new Random(); // býr til random
    

            for (int i = 0; i < nofn.Length; i++)// setur random tölur í spilin sem verða jafn mörg og nöfnin eru, setur nafnið sem er með sama númer í spilið líka
            {
                stokkur.Add( new Ithrottarlid(Fotbolti[i] = rand.Next(50, 101), Handbolti[i] = rand.Next(50, 101), Korfubolti[i] = rand.Next(50, 101), nofn[i]));
            }

            int lengd = stokkur.Count; // býr til int sem heitir lengd, notað til að næsta for loop runni jafn oft og lengdin á stokkinum.
            for (int i = 0; i < lengd; i++)
            {
                int naestaspil = rand.Next(0, stokkur.Count);// tekur random tölu úr lengd stokksins og geymir það sem naestaspil
                if (i % 2 == 0)// ef afgangurinn er 0
                {
                    stokkur_tol.Add(stokkur[naestaspil]);// setur spil í stokk tölvunnar
                }
                else// annars
                {
                    stokkur_not.Add(stokkur[naestaspil]);// setur spil í stokk notandans
                }
                stokkur.Remove(stokkur[naestaspil]);//removear spilið sem var sett inn í svo að það verði ekki notað aftur.
            }


            Console.WriteLine("Ýttu á 1 til að spila");
            int val1 = Convert.ToInt32(Console.ReadLine());// til að byrja að spila þá þarftu að ýta á 1, annars slekkur á forritinu
            int lok = 0;
            Console.Clear();// hreinsar consolið
            
            while (val1 == 1 && lok != 1)// á meðan að notandinn valdi 1 til að halda áfram eða til að byrja leikinn, og ef leikurinn er ekki búinn að klárast
	        {
                
                
                Console.WriteLine("Þú ert með " + stokkur_not.Count + " spil í stokknum þínum");// sýnir hversu mörg spil notandinn er með í stokkinum sínum
                Console.WriteLine("talvan er með " + stokkur_tol.Count + " spil í stokknum sínum");// sýnir hversu mörg spil talvan er með í stokkinum sínum
                Console.WriteLine("Þetta er spilið þitt");
                Console.WriteLine(stokkur_not[0] + "\n");// sýnir spil notandans
                Console.WriteLine("Veldu 1,2 eða 3");
                Console.WriteLine("1. Fótbolti");
                Console.WriteLine("2. Handbolti");
                Console.WriteLine("3. Körfubolti");
                int val = Convert.ToInt32(Console.ReadLine());// val notandans

                if (val == 1)// ef notandinn valdi 1
                {
                    if (stokkur_not[0].Fotbolti > stokkur_tol[0].Fotbolti)//ef notandinn vann
                    {
                        int stig = stokkur_not[0].Fotbolti - stokkur_tol[0].Fotbolti;// setur stigamun í breytu
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk notandans
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);// bætir þeim við stokk notandans
                            }
                        }
                    }
                    else if (stokkur_tol[0].Fotbolti > stokkur_not[0].Fotbolti)// ef talvan vann
                    {
                        int stig = stokkur_tol[0].Fotbolti - stokkur_not[0].Fotbolti;// setur stigamun í breytu
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk tölvunnar
                        stokkur_tol.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_tol.Add(stokkur_temp[i]);// bætir þeim við stokk tölvunnar
                            }
                        }
                    }
                    else if (stokkur_not[0].Fotbolti == stokkur_tol[0].Fotbolti)// ef það var jafntefli
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);// setur spilinn í temp stokk
                        stokkur_temp.Add(stokkur_tol[0]);
                    }
                    else// ef það var einhver villa
	                {
                        Console.WriteLine("Einhver villa.");
	                }
                    Console.WriteLine("Þetta er spilið hjá tölvuni");
                    Console.WriteLine(stokkur_tol[0] + "\n");// sýnir spilið hjá tölvunni
                    stokkur_not.Remove(stokkur_not[0]);
                    stokkur_tol.Remove(stokkur_tol[0]);

                }
                else if (val == 2)
                {
                    if (stokkur_not[0].Handbolti > stokkur_tol[0].Handbolti)//ef notandinn vann
                    {
                        int stig = stokkur_not[0].Handbolti - stokkur_tol[0].Handbolti;// setur stigamun í breytu
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk notandans
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);// bætir þeim við stokk notandans
                            }
                        }
                    }
                    else if (stokkur_tol[0].Handbolti > stokkur_not[0].Handbolti)//ef talvan vann
                    {
                        int stig = stokkur_tol[0].Handbolti - stokkur_not[0].Handbolti;// setur stigamun í breytu
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk tölvunnar
                        stokkur_tol.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_tol.Add(stokkur_temp[i]);// bætir þeim við stokk notandans
                            }
                        }
                    }
                    else if (stokkur_not[0].Handbolti == stokkur_tol[0].Handbolti)
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);// setur spilinn í temp stokk
                        stokkur_temp.Add(stokkur_tol[0]);
                    }
                    else// ef það var einhver villa
                    {
                        Console.WriteLine("Einhver villa.");
                    }
                    Console.WriteLine("Þetta er spilið hjá tölvuni");
                    Console.WriteLine(stokkur_tol[0] + "\n");// sýnir spilið hjá tölvunni
                    stokkur_not.Remove(stokkur_not[0]);
                    stokkur_tol.Remove(stokkur_tol[0]);
                }
                else if (val == 3)
                {
                    if (stokkur_not[0].Korfubolti > stokkur_tol[0].Korfubolti)//ef notandinn vann
                    {
                        int stig = stokkur_not[0].Korfubolti - stokkur_tol[0].Korfubolti;// setur stigamun í breytu
                        Console.WriteLine("Þú vannst!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_not.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk notandans
                        stokkur_not.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_not.Add(stokkur_temp[i]);// bætir þeim við stokk notandans
                            }
                        }
                    }
                    else if (stokkur_tol[0].Korfubolti > stokkur_not[0].Korfubolti)//ef talvan vann
                    {
                        int stig = stokkur_tol[0].Korfubolti - stokkur_not[0].Korfubolti;// setur stigamun í breytu
                        Console.WriteLine("Þú Tapaðir!");
                        Console.WriteLine("Það munaði " + stig + " stigum!");
                        stokkur_tol.Add(stokkur_not[0]);// bætir spilunum sem voru notuð við stokk tölvunnar
                        stokkur_tol.Add(stokkur_tol[0]);
                        if (stokkur_temp.Count > 0)// ef það voru til aukaspil eftir jafntefli
                        {
                            for (int i = 0; i < stokkur_temp.Count; i++)
                            {
                                stokkur_tol.Add(stokkur_temp[i]);// bætir þeim við stokk notandans
                            }
                        }
                    }
                    else if (stokkur_not[0].Korfubolti == stokkur_tol[0].Korfubolti)
                    {
                        Console.WriteLine("Það var jafntefli!");
                        stokkur_temp.Add(stokkur_not[0]);// setur spilinn í temp stokk
                        stokkur_temp.Add(stokkur_tol[0]);
                    }
                    else
                    {
                        Console.WriteLine("Einhver villa.");
                    }
                    Console.WriteLine("Þetta er spilið hjá tölvuni");
                    Console.WriteLine(stokkur_tol[0] + "\n");// sýnir spilið hjá tölvunni
                    stokkur_not.Remove(stokkur_not[0]);
                    stokkur_tol.Remove(stokkur_tol[0]);
                }
                
                
                Console.ReadLine();
                if (stokkur_not.Count == 0)// ef notandinn á engin spil eftir
                {
                    lok = 1;// enda leikinn, talvan vinnur
                }
                else if (stokkur_tol.Count == 0)// ef talvan á engin spil eftir 
                {
                    lok = 2;// enda leikinn, notandinn vinnur
                }
                Console.WriteLine("Ýttu á 1 til að spila aftur");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
	        }

            if (lok == 1)// ef talva vinnur
            {
                Console.WriteLine("Þú tapaðir!");
            }
            else if (lok == 2)// ef þú vinnur
            {
                Console.WriteLine("Þú vinnur!");
            }
            
        }// endir á main
    }
}
