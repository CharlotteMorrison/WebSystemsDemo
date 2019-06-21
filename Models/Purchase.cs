namespace OspreyOlympiansGold.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Purchase : DbContext
    {
        public Purchase()
            : base("name=Purchase")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Plan)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);
        }
    }
}
