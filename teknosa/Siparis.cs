using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknosa
{
    public class Siparis
    {
       public int SiparisID { get; set; }
       public int MusteriID { get; set; }
        
       public DateTime Tarih { get; set; }
       public Musteri Musteri { get; set; }
    }
}
