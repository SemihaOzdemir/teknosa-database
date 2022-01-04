using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknosa
{
    public class Urunler
    {
        public int UrunID { get; set; }
        public string Isim { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public string Renk { get; set; }
        public int KategoriID { get; set; }
        public int MagazaID { get; set; }
        public Kategoriler Kategoriler { get; set; }
        
        


    }
}
