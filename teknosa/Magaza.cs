using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknosa
{
    public class Magaza
    {
        public int MagazaID { get; set; }
        public string MagazaAdi { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public List<Urunler> Urunler { get; set; }



    }
}
