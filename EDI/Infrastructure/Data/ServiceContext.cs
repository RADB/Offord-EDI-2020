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
        /*Lookup Data*/
        public virtual DbSet<DateDimension> DateDimension { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<FileImportStatus> FileImportStatuses { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ProvinceType> ProvinceType { get; set; }
        public virtual DbSet<SpecialProblem> SpecialProblems { get; set; }
        public virtual DbSet<Year> Years { get; set; }

        /* Staging Data*/
        public virtual DbSet<FileImport> FileImports { get; set; }

        /*Configuration Data*/
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<FormConfigurations> FormConfigurations { get; set; }

        /*EDI Data*/
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Coordinator> Coordinators { get; set; }
        public virtual DbSet<Child> Children { get; set; }

        /*EDI Form Data*/
        public virtual DbSet<TeacherParticipationForm> TeacherParticipationForms { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Country>().HasMany(e => e.Provinces).WithOne(e => e.Country).HasForeignKey(e => e.CountryID);
           
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
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Countries", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256);

                entity.Property(e => e.ISO2CountryCode).IsRequired().HasColumnName("ISO2CountryCode").HasMaxLength(2);

                entity.Property(e => e.ISO3CountryCode).IsRequired().HasColumnName("ISO3CountryCode").HasMaxLength(3);

                entity.Property(e => e.Code).HasColumnName("Code");

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256);

                entity.Property(e => e.English).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).IsRequired().HasMaxLength(100);

                entity.HasMany(e => e.Schools).WithOne(e => e.Country).HasForeignKey(e => e.CountryId);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Provinces", "LUData");

                entity.HasIndex(e => e.CountryID);

                entity.HasIndex(e => e.ProvinceTypeId);

                entity.Property(e => e.Code).IsRequired().HasMaxLength(50);

                entity.Property(e => e.CountryID).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.English).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).IsRequired().HasMaxLength(100);

                entity.HasOne(d => d.Country).WithMany(p => p.Provinces).HasForeignKey(d => d.CountryID);

                entity.HasOne(d => d.ProvinceType).WithMany(p => p.Provinces).HasForeignKey(d => d.ProvinceTypeId);

                entity.HasMany(e => e.Schools).WithOne(e => e.Province).HasForeignKey(e => e.ProvinceId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Schools_Provinces");
                entity.HasMany(e => e.FileImports).WithOne(e => e.Province).HasForeignKey(e => e.SchoolProvinceId).HasConstraintName("FK_FileImports_Provinces");
            });

            modelBuilder.Entity<ProvinceType>(entity =>
            {
                entity.ToTable("ProvinceType","LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("Sites", "EDI");

                entity.HasIndex(e => e.YearId);

                entity.Property(e => e.CoordinatorId).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SiteNumber).IsUnicode(false);

                entity.HasMany(e => e.Schools).WithOne(e => e.Site).HasForeignKey(e => e.SiteId);

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
            });

             modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("Schools", "EDI");

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.SiteId);

                entity.HasIndex(e => e.YearId);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.SchoolName).IsUnicode(false);

                entity.Property(e => e.SchoolNumber).IsUnicode(false);
                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");
                

                //entity.HasOne(d => d.Year).WithMany(p => p.Schools).HasForeignKey(d => d.YearId).HasConstraintName("FK_Schools_Years");
                //can be done in this table definition or in foreign key - from here one --> many | from there many --> one
                //entity.HasOne(d => d.Countries).WithMany(p => p.Schools).HasForeignKey(d => d.CountryId);

                //entity.HasOne(d => d.Sites).WithMany(p => p.Schools).HasForeignKey(d => d.SiteId);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Languages", "LUData");

                //entity.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.English).IsRequired().HasMaxLength(50);

                entity.Property(e => e.French).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);
            });

            modelBuilder.Entity<SpecialProblem>(entity =>
            {
                entity.ToTable("SpecialProblems", "LUData");

                //entity.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teachers", "EDI");
                entity.HasIndex(e => e.SchoolId);

                entity.HasIndex(e => e.YearId);
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasMaxLength(14);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.TeacherName).HasMaxLength(100);
                
                entity.Property(e => e.TeacherNumber).HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID").HasMaxLength(40).HasComment("Links to user in EDI.Identity database");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                entity.HasOne(d => d.School).WithMany(p => p.Teachers).HasForeignKey(d => d.SchoolId).HasConstraintName("FK_Teachers_Schools");

                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");                             
            });
                     
            modelBuilder.Entity<Coordinator>(entity =>
            {
                entity.ToTable("Coordinators", "EDI");

                entity.Property(e => e.CoordinatorName).HasMaxLength(100);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(14);

                entity.Property(e => e.UserId).HasColumnName("UserID").HasMaxLength(40);

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");                
            });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.ToTable("Children", "EDI");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Dob).HasColumnName("DOB").HasColumnType("smalldatetime");

                entity.Property(e => e.Ediid).HasColumnName("EDIID").HasMaxLength(15);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LocalId).HasColumnName("LocalID").HasMaxLength(40);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.PostalCodeZip).HasMaxLength(10);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                entity.HasOne(d => d.Gender).WithMany(p => p.Children).HasForeignKey(d => d.GenderId).HasConstraintName("FK_Children_Gender");

                entity.HasOne(d => d.Teacher).WithMany(p => p.Children).HasForeignKey(d => d.TeacherId).HasConstraintName("FK_Children_Teachers");

                entity.HasOne(d => d.Year).WithMany(p => p.Children).HasForeignKey(d => d.YearId).HasConstraintName("FK_Children_Years");
            });

            modelBuilder.Entity<FileImportStatus>(entity =>
            {
                entity.ToTable("FileImportStatus", "LUData");

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.ToTable("Years", "LUData");
                //entity.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Ediyear).HasColumnName("EDIYear");

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.HasMany(e => e.Sites).WithOne(d => d.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Sites");
                entity.HasMany(e => e.Schools).WithOne(d => d.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Schools");
                entity.HasMany(e => e.Teachers).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Teachers");
                entity.HasMany(e => e.Coordinators).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Coordinators");
                entity.HasMany(e => e.Children).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Children");
                entity.HasMany(e => e.TeacherParticipationForms).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_TeacherParticipationForms");

                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");

                // example - how to write the relationship 
                // From Countries model
                //entity.HasMany(e => e.Schools).WithOne(e => e.Countries).HasForeignKey(e => e.CountryId);
                //entity.HasOne(d => d.Countries).WithMany(p => p.Schools).HasForeignKey(d => d.CountryId);                
            });

            modelBuilder.Entity<FileImport>(entity =>
            {
                entity.ToTable("FileImports", "Staging");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChildDob).HasColumnName("ChildDOB").HasColumnType("smalldatetime");

                entity.Property(e => e.ChildEdiid).HasColumnName("ChildEDIID").HasMaxLength(15);

                entity.Property(e => e.ChildPostalCodeZip).HasMaxLength(10);

                entity.Property(e => e.CoordinatorEmail).HasMaxLength(100);

                entity.Property(e => e.CoordinatorName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.FileImportStatusId).HasColumnName("FileImportStatusID");

                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LocalId).HasColumnName("LocalID").HasMaxLength(40);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.SchoolProvinceId).HasColumnName("SchoolProvinceID");

                entity.Property(e => e.TeacherEmail).HasMaxLength(100);

                entity.Property(e => e.TeacherName).HasMaxLength(100);

                entity.HasOne(d => d.Gender).WithMany(p => p.FileImports).HasForeignKey(d => d.GenderId).HasConstraintName("FK_FileImports_Gender");
                entity.HasOne(d => d.FileImportStatus).WithMany(p => p.FileImports).HasForeignKey(d => d.FileImportStatusId).HasConstraintName("FK_FileImports_FileImportStatus");
            });

            modelBuilder.Entity<TeacherParticipationForm>(entity =>
            {
                entity.ToTable("TeacherParticipationForms", "EDI_Forms");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.EducationOtherComment).HasMaxLength(255);

                entity.Property(e => e.EducationPhd).HasColumnName("EducationPHD");

                entity.Property(e => e.EducationPhdcourses).HasColumnName("EducationPHDCourses");

                entity.Property(e => e.FirstTimeCompletingEdi).HasColumnName("FirstTimeCompletingEDI");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GuideOtherComment).HasMaxLength(255);

                entity.Property(e => e.LanguageCompleted).HasMaxLength(20).HasComment("English or French");

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TimesCompletedEdi).HasColumnName("TimesCompletedEDI").HasComment("1-4 or more");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherParticipationForms).HasForeignKey(d => d.TeacherId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TeacherParticipation_Teachers");
                entity.HasOne(d => d.Gender).WithMany(p => p.TeacherParticipationForms).HasForeignKey(d => d.GenderId).HasConstraintName("FK_TeacherParticipationForms_Gender");

            });
        }
    }
}
