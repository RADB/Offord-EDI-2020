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
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<ProvinceType> ProvinceType { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Sites> Sites { get; set; }
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<FormConfigurations> FormConfigurations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Provinces)
                .WithOne(e => e.Country)
                .HasForeignKey(e => e.CountryID);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Schools)
                .WithOne(e => e.Countries)
                .HasForeignKey(e => e.CountryId);

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

            //modelBuilder.Entity<Provinces>()
            //    .HasMany(e => e.Schools)
            //    .WithOne(e => e.Provinces)
            //    .HasForeignKey(e => e.ProvinceId);

            modelBuilder.Entity<Sites>()
                .Property(e => e.SiteNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .Property(e => e.SiteName)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .Property(e => e.CoordinatorId)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Sites>()
                .HasMany(e => e.Schools)
                .WithOne(e => e.Sites)
                .HasForeignKey(e => e.SiteId);

            modelBuilder.Entity<Schools>()
                .Property(e => e.SchoolNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Schools>()
                .Property(e => e.SchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<Schools>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Schools>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Schools>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Schools>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
