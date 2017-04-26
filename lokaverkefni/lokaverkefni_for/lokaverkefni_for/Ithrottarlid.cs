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
            return string.Format("\nNafn {0} ", Nafn) + base.ToString();
        }
    }// endir á main
}
