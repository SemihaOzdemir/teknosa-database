using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknosa
{
    public class Kategoriler
    {
        public int KategoriID { get; set; }
        public string Isim { get; set; }
        public string Descriptions { get; set; }
      

        public List<Urunler> Urunler { get; set; }
    }
}
