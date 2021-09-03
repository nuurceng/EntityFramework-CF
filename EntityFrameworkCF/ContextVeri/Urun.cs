using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCF.ContextVeri
{
    class Urun : EntityTypeConfiguration<Urun>
    {
        public int urunid { get; set; }
        public int kategoriid { get; set; }
        public int markaid { get; set; }
        [StringLength(30)]
        public string barkodno { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string urunadi { get; set; }
        public int miktari { get; set; }
        public decimal alisfiyati { get; set; }
        public decimal satisfiyati { get; set; }
        public DateTime tarih { get; set; }
        public virtual ICollection<Sepet> sepet { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Marka Marka { get; set; }


        public Urun()
        {
            this.Property(x => x.alisfiyati).HasPrecision(8, 3);
            this.Property(x => x.satisfiyati).HasPrecision(8, 3);
        }
    }
}

