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
    class Sepet : EntityTypeConfiguration<Sepet>
    {
        public int sepetid { get; set; }
        public int urunid { get; set; }
        public int kategoriid { get; set; }
        public int markaid { get; set; }
        [StringLength(30)]
        public string barkodno { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string urunadi { get; set; }
        public int miktari { get; set; }
        public decimal birimfiyati { get; set; }
        public decimal toplamfiyati { get; set; }
        public DateTime tarih { get; set; }
        public virtual Urun urun { get; set; }
        public Sepet()
        {
            this.Property(x => x.birimfiyati).HasPrecision(8, 3);
            this.Property(x => x.toplamfiyati).HasPrecision(8, 3);
        }

    }
}
