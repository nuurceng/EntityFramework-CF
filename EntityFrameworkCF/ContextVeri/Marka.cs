using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCF.ContextVeri
{
    class Marka
    {
        public int markaid { get; set; }
        public int kategoriid { get; set; }
        public string markaadi { get; set; }
        public virtual ICollection<Urun> urun { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
