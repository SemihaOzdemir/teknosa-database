using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teknosa
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        internal string Adi { get; set; }
        internal string SoyAdi { get; set; }

        protected int Telefon { get; set; }
        protected string Adres { get; set; }
        protected string Email { get; set; }
    }
}
