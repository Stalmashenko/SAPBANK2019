namespace SAP_bank.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<ADDRESS> ADDRESS { get; set; }
        public virtual DbSet<BALANCE> BALANCE { get; set; }
        public virtual DbSet<CLIENTS> CLIENTS { get; set; }
        public virtual DbSet<DEPOSIT> DEPOSIT { get; set; }
        public virtual DbSet<TRANSFER> TRANSFER { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADDRESS>()
                .HasMany(e => e.CLIENTS)
                .WithOptional(e => e.ADDRESS)
                .HasForeignKey(e => e.ID_ADDRESS);

            modelBuilder.Entity<BALANCE>()
                .Property(e => e.BALANCE1)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CLIENTS>()
                .Property(e => e.GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTS>()
                .HasMany(e => e.DEPOSIT)
                .WithOptional(e => e.CLIENTS)
                .HasForeignKey(e => e.MYID);

            modelBuilder.Entity<CLIENTS>()
                .HasMany(e => e.TRANSFER)
                .WithOptional(e => e.CLIENTS)
                .HasForeignKey(e => e.MYID);

            modelBuilder.Entity<CLIENTS>()
                .HasMany(e => e.USERS)
                .WithOptional(e => e.CLIENTS)
                .HasForeignKey(e => e.ID_CLIENTS);

            modelBuilder.Entity<DEPOSIT>()
                .Property(e => e.SUMMA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<DEPOSIT>()
                .Property(e => e.STAVKA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TRANSFER>()
                .Property(e => e.SUMMA)
                .HasPrecision(15, 2);
        }
    }
}
