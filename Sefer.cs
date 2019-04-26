using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formlar
{
   public class Sefer
    {
        public int SeferID { get; set; }
        public int UcakID { get; set; }
        public int KalkisSehirID { get; set; }
        public int VarisSehirID { get; set; }

      //  public virtual Bilet Bilet { get; set; }
      //  public virtual Ucak Ucak { get; set; }
        public virtual Sehir Sehir { get; set; }




    }
}
