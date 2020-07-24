using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using EDI.ApplicationCore.Entities;

namespace EDI.Infrastructure.Data
{

    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {
        }        
       
        public virtual DbSet<DateDimension> DateDimension { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<ProvinceType> ProvinceType { get; set; }
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<FormConfigurations> FormConfigurations { get; set; }
        public virtual DbSet<CustomerAccess> CustomerAccess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<CustomerAccess>();

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Country)
                .HasForeignKey(e => e.BillingCountryID);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Customers1)
                .WithOne(e => e.Country1)
                .HasForeignKey(e => e.ShippingCountryID);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Province)
                .WithOne(e => e.Country)
                .HasForeignKey(e => e.CountryID);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.BillingAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.BillingAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.BillingCity)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ShippingAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ShippingAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ShippingCity)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.DeliveryInstructions)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.InternalNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.BillingAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.BillingAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.BillingCity)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.ShippingAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.ShippingAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.ShippingCity)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.DeliveryInstructions)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.InternalNotes)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAccess>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DateDimension>()
                .Property(e => e.DaySuffix)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DateDimension>()
                .Property(e => e.WeekDayName)
                .IsUnicode(false);

            modelBuilder.Entity<DateDimension>()
                .Property(e => e.HolidayText)
                .IsUnicode(false);

            modelBuilder.Entity<DateDimension>()
                .Property(e => e.MonthName)
                .IsUnicode(false);

            modelBuilder.Entity<DateDimension>()
                .Property(e => e.QuarterName)
                .IsUnicode(false);

            modelBuilder.Entity<FormConfigurations>()
                .Property(e => e.FormName)
                .IsUnicode(false);

            modelBuilder.Entity<FormConfigurations>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<FormConfigurations>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FormConfigurations>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigurations>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigurations>()
                .Property(e => e.FieldValue)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigurations>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigurations>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Province)
                .HasForeignKey(e => e.BillingProvinceID);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Customers1)
                .WithOne(e => e.Province1)
                .HasForeignKey(e => e.ShippingProvinceID);
        }
    }
}
