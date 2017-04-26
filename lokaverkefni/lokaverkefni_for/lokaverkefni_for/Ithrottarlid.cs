using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokaverkefni_for
{
    public class Ithrottarlid : Reglur
    {
        public Ithrottarlid(int fotbolti, int handbolti, int korfubolti, string nafn)
            : base(fotbolti, handbolti, korfubolti)
        {
            Nafn = nafn;
        }// endir á public

        public string Nafn { get; set; }

        public override string ToString()
        {
            return base.ToString()
                + string.Format("\nNafn{3} Fótbolti {0} Handbolti {1} Korfubolti {2}", Fotbolti, Handbolti, Korfubolti, Nafn);
        }
    }// endir á main
}
