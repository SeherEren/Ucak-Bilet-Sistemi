using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formlar
{
    public class Sehir
    {
        public int SehirID { get; set; }
        public string SehirAdi { get; set; }
        public string HavaalaniAdi { get; set; }

        public virtual List<Sefer> Sefers { get; set; }
        
        

    }
}
