using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokaverkefni_for
{
    public class Reglur
    {
        public Reglur(int fotbolti, int handbolti, int korfubolti)
        {
            Fotbolti = fotbolti;
            Handbolti = handbolti;
            Korfubolti = korfubolti;
        }// endir á public Reglur

        public int Fotbolti { get; set; }
        public int Handbolti { get; set; }
        public int Korfubolti { get; set; }

        public override string ToString()
        {
            return string.Format("Fótbolti {0} Handbolti {1} Korfubolti {2}", Fotbolti, Handbolti, Korfubolti);
        }
    }// endir á main
}
