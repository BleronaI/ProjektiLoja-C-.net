using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjektiLoja
{
    public partial class Model22 : DbContext
    {
        public Model22()
            : base("name=Model221")
        {
        }

        public virtual DbSet<Lojtari> Lojtaris { get; set; }
        public virtual DbSet<LuajLojen> LuajLojens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        public virtual DbSet<LojtaretFitue> LojtaretFitues { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Emri)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Mbiemri)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Qyteti)
                .IsUnicode(false);

            modelBuilder.Entity<LojtaretFitue>()
               .Property(e => e.EmriFitues)
               .IsUnicode(false);
        }
    }
}
