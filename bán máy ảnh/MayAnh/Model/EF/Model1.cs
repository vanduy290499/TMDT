namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<catalog> catalog { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<catalog>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.amount)
                .HasPrecision(15, 4);

            modelBuilder.Entity<order>()
                .Property(e => e.data)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(15, 4);

            modelBuilder.Entity<product>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.user)
                .WithOptional(e => e.Quyen)
                .HasForeignKey(e => e.idquyen);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.user1)
                .WithOptional(e => e.Quyen1)
                .HasForeignKey(e => e.idquyen);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.amuont)
                .HasPrecision(15, 4);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.payment_info)
                .IsUnicode(false);
        }
    }
}
