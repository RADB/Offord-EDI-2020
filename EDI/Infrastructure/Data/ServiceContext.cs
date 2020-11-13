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

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DateDimension> DateDimension { get; set; }
        public virtual DbSet<FileImportStatus> FileImportStatuses { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<InputType> InputTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LookupSet> LookupSets { get; set; }
        public virtual DbSet<LookupSetOption> LookupSetOptions { get; set; }
        public virtual DbSet<Orientation> Orientations { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ProvinceType> ProvinceType { get; set; }
        public virtual DbSet<SpecialProblem> SpecialProblems { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        

        /* Staging Data*/
        public virtual DbSet<FileImport> FileImports { get; set; }

        /*Configuration Data*/
        public virtual DbSet<FormConfigurations> FormConfigurations { get; set; }
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<MenuConfigurations> MenuConfigurations { get; set; }


        /*EDI Data*/
        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<Coordinator> Coordinators { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<NewsFeed> NewsFeeds { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        
        

        /*EDI Form Data*/
        public virtual DbSet<TeacherFeedbackForm> TeacherFeedbackForms { get; set; }
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

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.NodeId)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.English)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.French)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.IconCss)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.PID)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MenuConfigurations>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

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

                entity.Property(e => e.ChildNumber).HasMaxLength(15);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                //entity.HasOne(d => d.Gender).WithMany(p => p.Children).HasForeignKey(d => d.GenderId).HasConstraintName("FK_Children_Gender");

                //entity.HasOne(d => d.Teacher).WithMany(p => p.Children).HasForeignKey(d => d.TeacherId).HasConstraintName("FK_Children_Teachers");

                //entity.HasOne(d => d.Year).WithMany(p => p.Children).HasForeignKey(d => d.YearId).HasConstraintName("FK_Children_Years");
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

                entity.HasMany(e => e.Sites).WithOne(d => d.Coordinator).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.CoordinatorId).HasConstraintName("FK_Coordinators_Sites");
            });
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

                entity.HasMany(e => e.Schools).WithOne(e => e.Country).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.CountryId).HasConstraintName("FK_Country_Schools");
                entity.HasMany(e => e.Provinces).WithOne(e => e.Country).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.CountryID).HasConstraintName("FK_Country_Provinces");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ", "EDI");

                entity.Property(e => e.Answer).HasMaxLength(4000);

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.IsAdministratorFaq).HasColumnName("IsAdministratorFAQ");

                entity.Property(e => e.IsCoordinatorFaq).HasColumnName("IsCoordinatorFAQ");

                entity.Property(e => e.IsTeacherFaq).HasColumnName("IsTeacherFAQ");

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Question);

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<FileImport>(entity =>
            {
                entity.ToTable("FileImports", "Staging");

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

                //entity.Property(e => e.SchoolProvinceId).HasColumnName("SchoolProvinceID");

                entity.Property(e => e.TeacherEmail).HasMaxLength(100);

                entity.Property(e => e.TeacherName).HasMaxLength(100);

                //entity.HasOne(d => d.Gender).WithMany(p => p.FileImports).HasForeignKey(d => d.GenderId).HasConstraintName("FK_FileImports_Gender");
                //entity.HasOne(d => d.FileImportStatus).WithMany(p => p.FileImports).HasForeignKey(d => d.FileImportStatusId).HasConstraintName("FK_FileImports_FileImportStatus");
            });

            modelBuilder.Entity<FileImportStatus>(entity =>
            {
                entity.ToTable("FileImportStatus", "LUData");

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);
                entity.HasMany(d => d.FileImports).WithOne(p => p.FileImportStatus).HasForeignKey(d => d.FileImportStatusId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_FileImportStatus_FileImports");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Genders", "LUData");

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.HasMany(d => d.Children).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Gender_Children");
                entity.HasMany(d => d.FileImports).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Gender_FileImports");
                entity.HasMany(d => d.TeacherParticipationForms).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Gender_TeacherParticipationForms");
            });

            modelBuilder.Entity<InputType>(entity =>
            {
                entity.ToTable("InputTypes", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(50);

                entity.Property(e => e.French).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.InputType).HasForeignKey(e => e.InputTypeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_InputType_QuestionnairesConfigurations");
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

            modelBuilder.Entity<Link>(entity =>
            {
                entity.ToTable("Links", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Description);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Url).HasColumnName("URL").HasMaxLength(255);

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<LookupSet>(entity =>
            {
                entity.ToTable("LookupSets", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.LookupName).IsRequired().HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.YearId).HasColumnName("YearID");
                entity.HasMany(d => d.LookupSetOptions).WithOne(p => p.LookupSet).HasForeignKey(d => d.LookupId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_LookupSet_LookupSetOptions");
            });

            modelBuilder.Entity<LookupSetOption>(entity =>
            {
                entity.ToTable("LookupSetOptions", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired().HasMaxLength(140);

                entity.Property(e => e.French).HasMaxLength(140);

                entity.Property(e => e.LookupId).HasColumnName("LookupID");

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                //entity.Property(e => e.YearId).HasColumnName("YearID");

                //entity.HasOne(d => d.LookupSet).WithMany(p => p.LookupSetOptions).HasForeignKey(d => d.LookupId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_LookupSetOptions_LookupSets");
            });
            modelBuilder.Entity<Orientation>(entity =>
            {
                entity.ToTable("Orientations", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(50);

                entity.Property(e => e.French).IsRequired().HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Orientation).HasForeignKey(e => e.OrientationId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Orientation_QuestionnairesConfigurations");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Provinces", "LUData");

                entity.HasIndex(e => e.CountryID);

                entity.HasIndex(e => e.ProvinceTypeId);

                entity.Property(e => e.Code).IsRequired().HasMaxLength(50);

                entity.Property(e => e.CountryID).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.EDICode);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.English).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).IsRequired().HasMaxLength(100);

                //entity.HasOne(d => d.Country).WithMany(p => p.Provinces).HasForeignKey(d => d.CountryID);

                //entity.HasOne(d => d.ProvinceType).WithMany(p => p.Provinces).HasForeignKey(d => d.ProvinceTypeId);

                entity.HasMany(e => e.Schools).WithOne(e => e.Province).HasForeignKey(e => e.ProvinceId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Schools_Provinces");
                //entity.HasMany(e => e.FileImports).WithOne(e => e.SchoolProvince).HasForeignKey(e => e.SchoolProvinceId).HasConstraintName("FK_FileImports_Provinces");
            });

            modelBuilder.Entity<ProvinceType>(entity =>
            {
                entity.ToTable("ProvinceType","LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(64);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.HasMany(e => e.Provinces).WithOne(e => e.ProvinceType).HasForeignKey(e => e.ProvinceTypeId).HasConstraintName("FK_ProvinceType_Provinces");                
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.ToTable("Questionnaires", "EDI");              

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.DescriptionEnglish).HasMaxLength(255);

                entity.Property(e => e.DescriptionFrench).HasMaxLength(255);

                entity.Property(e => e.English).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.QuestionnaireName).IsRequired().HasMaxLength(100);

                entity.Property(e => e.ShowProgressBar).HasComment("Answered x of y Questions");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Questionnaire).HasForeignKey(e => e.QuestionnaireId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Questionnaire_QuestionnairesConfigurations");

            });

            modelBuilder.Entity<QuestionnairesConfiguration>(entity =>
            {
                entity.ToTable("Questionnaires.Configuration", "EDI");

                entity.Property(e => e.Condition).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired().HasMaxLength(255);

                entity.Property(e => e.EntityField).IsRequired().HasMaxLength(100);

                entity.Property(e => e.EntityName).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(10);

                entity.Property(e => e.InputTypeId).HasColumnName("InputTypeId");

                entity.Property(e => e.LookupEntity).HasMaxLength(100);

                entity.Property(e => e.LookupEntityId).HasColumnName("LookupEntityID");

                entity.Property(e => e.Mask).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Notification).HasMaxLength(500);

                entity.Property(e => e.NotificationCondition).HasMaxLength(200);

                entity.Property(e => e.NorthwestTerritories).HasColumnName("NorthwestTerritories");

                entity.Property(e => e.OrientationId).HasColumnName("OrientationID");

                entity.Property(e => e.PrinceEdwardIsland).HasColumnName("PrinceEdwardIsland");

                entity.Property(e => e.QuestionNumber).HasMaxLength(5);

                entity.Property(e => e.QuestionnaireId).HasColumnName("QuestionnaireID");

                entity.Property(e => e.VariableName).HasMaxLength(50).HasComment("Variable Name for data dictionary");                

                //entity.HasOne(d => d.InputType).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.InputTypeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Questionnaires.Configuration_InputTypes");

                //entity.HasOne(d => d.Orientation).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.OrientationId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Questionnaires.Configuration_Orientation");

                //entity.HasOne(d => d.Questionnaire).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.QuestionnaireId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Questionnaires.Configuration_Questionnaires");

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

                //entity.HasOne(d => d.Site).WithMany(p => p.Schools).HasForeignKey(d => d.SiteId).HasConstraintName("FK_Schools_Sites");

                entity.HasMany(e => e.Teachers).WithOne(e => e.School).HasForeignKey(e => e.SchoolId).HasConstraintName("FK_Schools_Teachers").OnDelete(DeleteBehavior.Cascade);

                //entity.HasOne(d => d.Year).WithMany(p => p.Schools).HasForeignKey(d => d.YearId).HasConstraintName("FK_Schools_Years");
                //can be done in this table definition or in foreign key - from here one --> many | from there many --> one
                //entity.HasOne(d => d.Countries).WithMany(p => p.Schools).HasForeignKey(d => d.CountryId);

                //entity.HasOne(d => d.Sites).WithMany(p => p.Schools).HasForeignKey(d => d.SiteId);
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

                entity.HasMany(e => e.Schools).WithOne(e => e.Site).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.SiteId).HasConstraintName("FK_Sites_Schools");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                
                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
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

                //entity.HasOne(d => d.School).WithMany(p => p.Teachers).HasForeignKey(d => d.SchoolId).HasConstraintName("FK_Teachers_Schools");

                entity.HasMany(e => e.Children).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_Children");

                entity.HasMany(e => e.TeacherFeedbackForms).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_TeacherFeedbackForms");

                entity.HasMany(e => e.TeacherParticipationForms).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_TeacherParticipationForms");

                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");                             
            });
                     
       
            modelBuilder.Entity<TeacherFeedbackForm>(entity =>
            {
                entity.ToTable("TeacherFeedbackForms", "EDI_Forms");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.FirstTimeCompletingEdi).HasColumnName("FirstTimeCompletingEDI");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(20).HasComment("English or French");

                entity.Property(e => e.MaterialsOtherSpecify).HasMaxLength(250);

                entity.Property(e => e.MaterialsPastEdi).HasColumnName("MaterialsPastEDI");

                entity.Property(e => e.MaterialsPpt).HasColumnName("MaterialsPPT");

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.YearId).HasColumnName("YearID").HasComment("Year of the EDI implementation");

                //entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherFeedbackForms).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.TeacherId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TeacherFeedback_Teachers");

               // entity.HasOne(d => d.Year).WithMany(p => p.TeacherFeedbackForms).HasForeignKey(d => d.YearId).HasConstraintName("FK_TeacherFeedback_Years");
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

                //entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherParticipationForms).HasForeignKey(d => d.TeacherId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TeacherParticipation_Teachers");
                //entity.HasOne(d => d.Gender).WithMany(p => p.TeacherParticipationForms).HasForeignKey(d => d.GenderId).HasConstraintName("FK_TeacherParticipationForms_Gender");

            });
            modelBuilder.Entity<Translation>(entity =>
            {
                entity.ToTable("Translations", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired();

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.ToTable("Years", "LUData");
                //entity.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Ediyear).HasColumnName("EDIYear");

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.HasMany(e => e.Sites).WithOne(d => d.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Sites");
                entity.HasMany(e => e.Schools).WithOne(d => d.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Schools");
                entity.HasMany(e => e.Teachers).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Teachers");
                entity.HasMany(e => e.Coordinators).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Coordinators");
                entity.HasMany(e => e.Children).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Children");
                entity.HasMany(e => e.TeacherFeedbackForms).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_TeacherFeedbackForms");
                entity.HasMany(e => e.TeacherParticipationForms).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_TeacherParticipationForms");
                entity.HasMany(e => e.Links).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Links");
                entity.HasMany(e => e.NewsFeeds).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_NewsFeeds");
                entity.HasMany(e => e.Faqs).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_FAQ");
                entity.HasMany(e => e.LookupSets).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_LookupSets");
                entity.HasMany(e => e.InputTypes).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_InputTypes");
                entity.HasMany(e => e.Orientations).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Orientations");
                entity.HasMany(e => e.Questionnaires).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires");
                //entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Configurations");
                //entity.HasMany(e => e.LookupSetOptions).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_LookupSetOptions");
                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");

                // example - how to write the relationship 
                // From Countries model
                //entity.HasMany(e => e.Schools).WithOne(e => e.Countries).HasForeignKey(e => e.CountryId);
                //entity.HasOne(d => d.Countries).WithMany(p => p.Schools).HasForeignKey(d => d.CountryId);                
            });

        }
    }
}
