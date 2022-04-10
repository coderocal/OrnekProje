using Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class OrnekProjeContext : DbContext
    {
        public OrnekProjeContext()
            : base("name=OrnekProjeContext")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
                .Property(e => e.Adi)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.Soyadi)
                .IsUnicode(false);
        }
    }
}
