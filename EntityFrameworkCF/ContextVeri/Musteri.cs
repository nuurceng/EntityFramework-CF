using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCF.ContextVeri
{
    class Musteri
    {
        public int musteriid { get; set; }
        public string adisoyadi { get; set; }
        public string telefon { get; set; }
        //public string adres { get; set; }
        public string sehir { get; set; }
        public string email { get; set; }
        public DateTime tarih { get; set; }

    }
}
