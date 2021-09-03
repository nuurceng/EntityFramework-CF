using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCF.ContextVeri
{
    class Kategori
    {
        public int kategoriid { get; set; }
        public string kategoriadi { get; set; }
        public virtual ICollection<Urun> urun { get; set; }
        public virtual ICollection<Marka> Markas { get; set; }
    }
}
