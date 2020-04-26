namespace WpfTaxi.Model
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

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Dispatcher> Dispatcher { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<status_orders> status_orders { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.phone_number_client)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.client_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Client_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Color_name)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Color)
                .HasForeignKey(e => e.Color_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dispatcher>()
                .Property(e => e.Dispatcher_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Dispatcher>()
                .Property(e => e.password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Dispatcher>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Dispatcher)
                .HasForeignKey(e => e.Dipatcher_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.number_car)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Driver_phone_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Driver_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Driver)
                .HasForeignKey(e => e.Driver_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.Model_name)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.Model_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.mesto_otpravleniya)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.mesto_naznacheniya)
                .IsUnicode(false);

            modelBuilder.Entity<status_orders>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<status_orders>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.status_orders)
                .HasForeignKey(e => e.status_orders_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
