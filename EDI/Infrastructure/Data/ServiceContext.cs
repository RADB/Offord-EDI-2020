using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using EDI.ApplicationCore.Entities;
using System;

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
        public virtual DbSet<ChildStatus> ChildStatuses { get; set; }
        public virtual DbSet<TeacherStatus> TeacherStatuses { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<InputType> InputTypes { get; set; }
        public virtual DbSet<LookupSet> LookupSets { get; set; }
        public virtual DbSet<LookupSetOption> LookupSetOptions { get; set; }
        public virtual DbSet<Orientation> Orientations { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ProvinceType> ProvinceType { get; set; }
        
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        

        /* Staging Data*/
        public virtual DbSet<FileImport> FileImports { get; set; }

        /*Configuration Data*/
        public virtual DbSet<FormConfigurations> FormConfigurations { get; set; }
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<MenuConfigurations> MenuConfigurations { get; set; }
        public virtual DbSet<UserSessions> UserSessions { get; set; }


        /*EDI Data*/
        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<Coordinator> Coordinators { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<NewsFeed> NewsFeeds { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
        public virtual DbSet<QuestionnairesDataDemographic> QuestionnairesDataDemographics { get; set; }
        public virtual DbSet<QuestionnairesDataSectionA> QuestionnairesDataSectionAs { get; set; }
        public virtual DbSet<QuestionnairesDataSectionB> QuestionnairesDataSectionBs { get; set; }
        public virtual DbSet<QuestionnairesDataSectionC> QuestionnairesDataSectionCs { get; set; }
        public virtual DbSet<QuestionnairesDataSectionD> QuestionnairesDataSectionDs { get; set; }
        public virtual DbSet<QuestionnairesDataSectionE> QuestionnairesDataSectionEs { get; set; }
        public virtual DbSet<QuestionnairesDataTeacherProfile> QuestionnairesDataTeacherProfiles { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        
        

        /*EDI Form Data*/
//        public virtual DbSet<TeacherFeedbackForm> TeacherFeedbackForms { get; set; }
  //      public virtual DbSet<TeacherParticipationForm> TeacherParticipationForms { get; set; }



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

            modelBuilder.Entity<UserSessions>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<UserSessions>()
                .Property(e => e.FieldValue)
                .IsUnicode(false);

            modelBuilder.Entity<UserSessions>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserSessions>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UserSessions>()
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

                entity.Property(e => e.Dob).HasColumnType("smalldatetime");

                entity.Property(e => e.Ediid).HasMaxLength(15);

                entity.Property(e => e.LocalId).HasMaxLength(40);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.ChildNumber).HasMaxLength(15);

                entity.Property(e => e.YearId).HasComment("Year of the EDI implementation");

                entity.HasMany(e => e.QuestionnairesDataDemographics).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.Demographics");
                entity.HasMany(e => e.QuestionnairesDataSectionAs).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.SectionAs");
                entity.HasMany(e => e.QuestionnairesDataSectionBs).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.SectionBs");
                entity.HasMany(e => e.QuestionnairesDataSectionCs).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.SectionCs");
                entity.HasMany(e => e.QuestionnairesDataSectionDs).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.SectionDs");
                entity.HasMany(e => e.QuestionnairesDataSectionEs).WithOne(d => d.Child).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.ChildId).HasConstraintName("FK_Children_Questionnaires.Data.SectionEs");

            });            
            modelBuilder.Entity<ChildStatus>(entity =>
            {
                entity.ToTable("ChildStatus", "LUData");

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);
                entity.HasMany(d => d.Children).WithOne(p => p.ChildStatus).HasForeignKey(d => d.ChildStatusId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_ChildStatus_Children");
                entity.HasData
                (
                    new ChildStatus() {Id = 2, Code = "1", English = "New", French = "Nouveau", Sequence = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new ChildStatus() {Id = 1, Code = "2", English = "In Progress", French = "En cours", Sequence = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new ChildStatus() {Id = 3, Code = "3", English = "Complete", French = "Achevé", Sequence = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new ChildStatus() {Id = 4, Code = "4", English = "Locked", French = "Fermé à clé", Sequence = 4, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                );
            });

            modelBuilder.Entity<Coordinator>(entity =>
            {
                entity.ToTable("Coordinators", "EDI");

                entity.Property(e => e.CoordinatorName).HasMaxLength(100);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(14);

                entity.Property(e => e.UserId).HasMaxLength(40);

                entity.Property(e => e.YearId).HasComment("Year of the EDI implementation");

                entity.HasMany(e => e.Sites).WithOne(d => d.Coordinator).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.CoordinatorId).HasConstraintName("FK_Coordinators_Sites");
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Countries", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256);

                entity.Property(e => e.ISO2CountryCode).IsRequired().HasMaxLength(2);

                entity.Property(e => e.ISO3CountryCode).IsRequired().HasMaxLength(3);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256);

                entity.Property(e => e.English).IsRequired().HasMaxLength(100);

                entity.Property(e => e.French).IsRequired().HasMaxLength(100);

                entity.HasMany(e => e.Schools).WithOne(e => e.Country).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.CountryId).HasConstraintName("FK_Country_Schools");
                entity.HasMany(e => e.Provinces).WithOne(e => e.Country).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.CountryID).HasConstraintName("FK_Country_Provinces");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);



                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

            });

            modelBuilder.Entity<FileImport>(entity =>
            {
                entity.ToTable("FileImports", "Staging");

                entity.Property(e => e.ChildDob).HasColumnType("smalldatetime");

                entity.Property(e => e.ChildEdiid).HasMaxLength(15);

                entity.Property(e => e.ChildPostalCode).HasMaxLength(10);

                entity.Property(e => e.CoordinatorEmail).HasMaxLength(100);

                entity.Property(e => e.CoordinatorName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).IsUnicode(false);


                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.LocalId).HasMaxLength(40);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);


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
                entity.HasData
                (
                    new FileImportStatus() {Id=1, Code = "1", English = "Imported", French = "Importé", Sequence = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new FileImportStatus() {Id=2, Code = "2", English = "Processed", French = "Traité", Sequence = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new FileImportStatus() {Id=3, Code = "3", English = "Duplicate", French = "Dupliquer", Sequence = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new FileImportStatus() {Id=4, Code = "4", English = "Invalid Province", French = "Province non valide", Sequence = 4, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                );
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
                entity.HasMany(d => d.QuestionnairesDataDemographics).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Gender_QuestionnaireDemographics");
                entity.HasMany(d => d.FileImports).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Gender_FileImports");
                //entity.HasMany(d => d.TeacherParticipationForms).WithOne(p => p.Gender).HasForeignKey(d => d.GenderId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Gender_TeacherParticipationForms");
                entity.HasData
                    (
                        new Gender() {Id=1, Code = "1", English = "Male", French = "Mâle", Sequence = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                        new Gender() {Id=2, Code = "2", English = "Female", French = "Femelle", Sequence = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                    );
            });

            modelBuilder.Entity<InputType>(entity =>
            {
                entity.ToTable("InputTypes", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(50);

                entity.Property(e => e.French).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.InputType).HasForeignKey(e => e.InputTypeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_InputType_QuestionnairesConfigurations");
                entity.HasData
                (
                    new InputType() {Id=14, French = "Hidden", English = "Hidden", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=13, French = "NumberBoxDouble", English = "NumberBoxDouble", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=12, French = "Toggle", English = "Toggle", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=11, French = "GroupHeader", English = "GroupHeader", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=10, French = "QuestionHeader", English = "QuestionHeader", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=9, French = "Header", English = "Header", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=8, French = "TextBox", English = "TextBox", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=7, French = "SelectBox", English = "SelectBox", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=6, French = "CheckBox", English = "CheckBox", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=5, French = "DatePicker", English = "DatePicker", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=4, French = "NumberBox", English = "NumberBox", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=3, French = "RadioButtons", English = "RadioButtons", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=2, French = "RadioMatrix", English = "RadioMatrix", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new InputType() {Id=1, French = "TextArea", English = "TextArea", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                );
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.ToTable("Links", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<LookupSet>(entity =>
            {
                entity.ToTable("LookupSets", "LUData");
                //entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.LookupName).IsRequired().HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasMany(d => d.LookupSetOptions).WithOne(p => p.LookupSet).HasForeignKey(d => d.LookupSetId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_LookupSet_LookupSetOptions");
                entity.HasMany(p => p.QuestionnairesConfigurations).WithOne(p => p.LookupSet).HasForeignKey(d => d.LookupEntityId).HasConstraintName("FK_LookupSet_QuestionnaireConfiguration");
                //entity.HasOne(d => d.Id).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.LookupEntityId).HasConstraintName("FK_Questionnaires.Configuration_LookupSets");
                entity.HasData
                (
                    new LookupSet() { Id = 1, LookupName = "YesNo", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 2, LookupName = "YesNoDontKnow", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 3, LookupName = "GoodAvgPoorDontKnow", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 4, LookupName = "OftenSometimesNeverDontKnow", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 5, LookupName = "ObservedDiagnosisBoth", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 6, LookupName = "FullPartDontknowNO", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 7, LookupName = "Status", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 8, LookupName = "ClassAssignment", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 9, LookupName = "ClassType", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 10, LookupName = "Gender", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 11, LookupName = "ConsideredESL", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 12, LookupName = "EthnicStatus", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 13, LookupName = "NWTLanguages", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 14, LookupName = "LandAgreements", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 15, LookupName = "Languages", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 16, LookupName = "SpecialProblems", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 17, LookupName = "MainCare", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 18, LookupName = "MainCareJK", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 19, LookupName = "Participation", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 20, LookupName = "AgeRange", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 21, LookupName = "TeacherGender", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 22, LookupName = "VerySomewhatNot", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 23, LookupName = "GuideUsefulness", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 24, LookupName = "ClassAssignmentNS", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 25, LookupName = "ClassTypeNS", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                    );

            });

            modelBuilder.Entity<LookupSetOption>(entity =>
            {
                entity.ToTable("LookupSetOptions", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired().HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);                

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

             });
            modelBuilder.Entity<Orientation>(entity =>
            {
                entity.ToTable("Orientations", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(50);

                entity.Property(e => e.French).IsRequired().HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Orientation).HasForeignKey(e => e.OrientationId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Orientation_QuestionnairesConfigurations");
                entity.HasData
                (
                    new Orientation() {Id=2, YearId = 1, English = "Horizontal", French = "Horizontal", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Orientation() {Id=1, YearId = 1, English = "Vertical", French = "Vertical", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                );
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Provinces", "LUData");

                entity.HasIndex(e => e.CountryID);

                entity.HasIndex(e => e.ProvinceTypeId);

                entity.Property(e => e.Code).IsRequired().HasMaxLength(50);

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

                entity.Property(e => e.DescriptionEnglish);

                entity.Property(e => e.DescriptionFrench);

                entity.Property(e => e.English).IsRequired();

                entity.Property(e => e.French);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.QuestionnaireName).IsRequired().HasMaxLength(100);

                entity.Property(e => e.ShowProgressBar).HasComment("Answered x of y Questions");

                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Questionnaire).HasForeignKey(e => e.QuestionnaireId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Questionnaire_QuestionnairesConfigurations");
                entity.HasMany(e => e.QuestionnairesDataDemographics).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.Demographics");
                entity.HasMany(e => e.QuestionnairesDataSectionAs).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.SectionAs");
                entity.HasMany(e => e.QuestionnairesDataSectionBs).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.SectionBs");
                entity.HasMany(e => e.QuestionnairesDataSectionCs).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.SectionCs");
                entity.HasMany(e => e.QuestionnairesDataSectionDs).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.SectionDs");
                entity.HasMany(e => e.QuestionnairesDataSectionEs).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.SectionEs");
                entity.HasMany(e => e.QuestionnairesDataTeacherProfiles).WithOne(e => e.Questionnaire).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.QuestionnaireId).HasConstraintName("FK_Questionnaires_Questionnaires.Data.TeacherProfiles");
                entity.HasData
                (
                    new Questionnaire() { Id = 1, English = "Teacher Feedback", QuestionnaireName = "Teacher Feedback", YearId = 1, EntityName = "Questionnaires.Data.TeacherProfile", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Teacher Feedback", DescriptionEnglish = "Teacher Feedback", DescriptionFrench = "Teacher Feedback", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = true, IsChildQuestionnaire = false, Sequence = 10, NorthwestTerritories = true, NovaScotia = true },
                    new Questionnaire() {Id=2, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NorthwestTerritories = true },
                    new Questionnaire() {Id =3, English = "Section A", QuestionnaireName = "Section A", YearId = 1, EntityName = "Questionnaires.Data.SectionA", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section A", DescriptionEnglish = "Section A", DescriptionFrench = "Section A", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 20, NorthwestTerritories = true },
                    new Questionnaire() {Id =4, English = "Section B", QuestionnaireName = "Section B", YearId = 1, EntityName = "Questionnaires.Data.SectionB", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section B", DescriptionEnglish = "Section B", DescriptionFrench = "Section B", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 30, NorthwestTerritories = true },
                    new Questionnaire() {Id =5, English = "Section C", QuestionnaireName = "Section C", YearId = 1, EntityName = "Questionnaires.Data.SectionC", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section C", DescriptionEnglish = "Section C", DescriptionFrench = "Section C", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 40, NorthwestTerritories = true },
                    new Questionnaire() {Id =6, English = "Section D", QuestionnaireName = "Section D", YearId = 1, EntityName = "Questionnaires.Data.SectionD", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section D", DescriptionEnglish = "Section D", DescriptionFrench = "Section D", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 50, NorthwestTerritories = true },
                    new Questionnaire() {Id =7, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NorthwestTerritories = true },                    
                    new Questionnaire() {Id =8, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NovaScotia = true },
                    new Questionnaire() {Id =9, English = "Section A", QuestionnaireName = "Section A", YearId = 1, EntityName = "Questionnaires.Data.SectionA", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section A", DescriptionEnglish = "Section A", DescriptionFrench = "Section A", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 20, NovaScotia = true },
                    new Questionnaire() {Id =10, English = "Section B", QuestionnaireName = "Section B", YearId = 1, EntityName = "Questionnaires.Data.SectionB", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section B", DescriptionEnglish = "Section B", DescriptionFrench = "Section B", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 30, NovaScotia = true },
                    new Questionnaire() {Id =11, English = "Section C", QuestionnaireName = "Section C", YearId = 1, EntityName = "Questionnaires.Data.SectionC", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section C", DescriptionEnglish = "Section C", DescriptionFrench = "Section C", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 40, NovaScotia = true },
                    new Questionnaire() {Id =12, English = "Section D", QuestionnaireName = "Section D", YearId = 1, EntityName = "Questionnaires.Data.SectionD", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section D", DescriptionEnglish = "Section D", DescriptionFrench = "Section D", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 50, NovaScotia = true },
                    new Questionnaire() {Id =13, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NovaScotia = true }
                );
            });

            modelBuilder.Entity<QuestionnairesConfiguration>(entity =>
            {
                entity.ToTable("Questionnaires.Configuration", "EDI");

                entity.Property(e => e.Condition).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired();

                entity.Property(e => e.EntityField).HasMaxLength(100);

                entity.Property(e => e.EntityName).HasMaxLength(100);

                entity.Property(e => e.French);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LookupEntity).HasMaxLength(100);

                entity.Property(e => e.Mask).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.Notification).HasMaxLength(500);

                entity.Property(e => e.NotificationCondition).HasMaxLength(200);

                entity.Property(e => e.QuestionNumber).HasMaxLength(5);

                entity.Property(e => e.VariableName).HasMaxLength(50).HasComment("Variable Name for data dictionary");       
                
                 entity.Property(e => e.Alberta).HasDefaultValueSql("((0))");

                entity.Property(e => e.BritishColumbia).HasDefaultValueSql("((0))");

                entity.Property(e => e.ColumnSpan).HasDefaultValueSql("((1))");

                entity.Property(e => e.Columns).HasDefaultValueSql("((10))");

                entity.Property(e => e.Condition).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('Renner')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

               entity.Property(e => e.HasHelp).IsRequired().HasDefaultValueSql("((1))");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRequired).IsRequired().HasDefaultValueSql("((1))");
                                
                entity.Property(e => e.Manitoba).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('Renner')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewBrunswick).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewfoundlandandLabrador).HasDefaultValueSql("((0))");

                entity.Property(e => e.NorthwestTerritories).HasDefaultValueSql("((0))");

                entity.Property(e => e.NovaScotia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nunavut).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ontario).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrinceEdwardIsland).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quebec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saskatchewan).HasDefaultValueSql("((0))");

                //entity.Property(e => e.YearId).HasDefaultValueSql("((1))");

                entity.Property(e => e.YukonTerritory).HasDefaultValueSql("((0))");


                //entity.HasOne(d => d.InputType).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.InputTypeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Questionnaires.Configuration_InputTypes");

                //entity.HasOne(d => d.Orientation).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.OrientationId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Questionnaires.Configuration_Orientation");

                //entity.HasOne(d => d.Questionnaire).WithMany(p => p.QuestionnairesConfigurations).HasForeignKey(d => d.QuestionnaireId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Questionnaires.Configuration_Questionnaires");

            });
   

            modelBuilder.Entity<QuestionnairesDataDemographic>(entity =>
            {                
                entity.ToTable("Questionnaires.Data.Demographics", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob).HasColumnType("smalldatetime");

                entity.Property(e => e.PostalCode).HasMaxLength(10);
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

            });

            modelBuilder.Entity<QuestionnairesDataSectionA>(entity =>
            {
                entity.ToTable("Questionnaires.Data.SectionA", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<QuestionnairesDataSectionB>(entity =>
            {
                entity.ToTable("Questionnaires.Data.SectionB", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");
                //entity.Property(e => e.SpecialPblskills).HasColumnName("SpecialPBLskills");
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");
            });
            modelBuilder.Entity<QuestionnairesDataSectionC>(entity =>
            {
                entity.ToTable("Questionnaires.Data.SectionC", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<QuestionnairesDataSectionD>(entity =>
            {
                entity.ToTable("Questionnaires.Data.SectionD", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<QuestionnairesDataSectionE>(entity =>
            {
                entity.ToTable("Questionnaires.Data.SectionE", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

            });

            modelBuilder.Entity<QuestionnairesDataTeacherProfile>(entity =>
            {
                entity.ToTable("Questionnaires.Data.TeacherProfile", "EDI");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageCompleted).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false).HasDefaultValueSql("('admin')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsComplete).IsRequired().HasDefaultValueSql("((0))");
                entity.Property(e => e.CompletedQuestions).IsRequired().HasDefaultValueSql("((0))");

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
                entity.Property(e => e.YearId).HasComment("Year of the EDI implementation");

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

                entity.Property(e => e.YearId).HasComment("Year of the EDI implementation");

                
                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
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


                entity.Property(e => e.TeacherName).HasMaxLength(100);
                
                entity.Property(e => e.TeacherNumber).HasMaxLength(15);

                entity.Property(e => e.UserId).HasMaxLength(40).HasComment("Links to user in EDI.Identity database");

                entity.Property(e => e.YearId).HasComment("Year of the EDI implementation");

                //entity.HasOne(d => d.School).WithMany(p => p.Teachers).HasForeignKey(d => d.SchoolId).HasConstraintName("FK_Teachers_Schools");

                entity.HasMany(e => e.Children).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_Children");

                //entity.HasMany(e => e.TeacherFeedbackForms).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_TeacherFeedbackForms");

                //entity.HasMany(e => e.TeacherParticipationForms).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_TeacherParticipationForms");
                entity.HasMany(e => e.QuestionnairesDataTeacherProfiles).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.Cascade).HasForeignKey(e => e.TeacherId).HasConstraintName("FK_Teachers_QuestionnairesDataTeacherProfiles");

                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");                             
            });

            modelBuilder.Entity<TeacherStatus>(entity =>
            {
                entity.ToTable("TeacherStatus", "LUData");

                entity.Property(e => e.Code).IsRequired().HasMaxLength(3);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.English).HasMaxLength(150);

                entity.Property(e => e.French).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);
                entity.HasMany(d => d.Teachers).WithOne(p => p.TeacherStatus).HasForeignKey(d => d.TeacherStatusId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_TeacherStatus_Children");
                entity.HasData
                    (
                        new TeacherStatus() { Id = 2, Code = "1", English = "New", French = "Nouveau", Sequence = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                        new TeacherStatus() { Id = 1, Code = "2", English = "In Progress", French = "En cours", Sequence = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                        new TeacherStatus() { Id = 3, Code = "3", English = "Complete", French = "Achevé", Sequence = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                        new TeacherStatus() { Id = 4, Code = "4", English = "Locked", French = "Fermé à clé", Sequence = 4, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
                    );
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
                entity.HasIndex(e => e.Ediyear, "IX_Years").IsUnique();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.HasMany(e => e.Sites).WithOne(d => d.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Sites");
                entity.HasMany(e => e.Schools).WithOne(d => d.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Schools");
                entity.HasMany(e => e.Teachers).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Teachers");
                entity.HasMany(e => e.Coordinators).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Coordinators");
                entity.HasMany(e => e.Children).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Children");
                entity.HasMany(e => e.Links).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Links");
                entity.HasMany(e => e.NewsFeeds).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_NewsFeeds");
                entity.HasMany(e => e.Faqs).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_FAQ");
                entity.HasMany(e => e.LookupSets).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_LookupSets");
                entity.HasMany(e => e.InputTypes).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_InputTypes");
                entity.HasMany(e => e.Orientations).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Orientations");
                entity.HasMany(e => e.Questionnaires).WithOne(e => e.Year).OnDelete(DeleteBehavior.Cascade).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires");
                entity.HasMany(e => e.QuestionnairesConfigurations).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Configurations");
                entity.HasMany(e => e.QuestionnairesDataDemographics).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.Demographics");
                entity.HasMany(e => e.QuestionnairesDataSectionAs).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.SectionA");
                entity.HasMany(e => e.QuestionnairesDataSectionBs).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.SectionB");
                entity.HasMany(e => e.QuestionnairesDataSectionCs).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.SectionC");
                entity.HasMany(e => e.QuestionnairesDataSectionDs).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.SectionD");
                entity.HasMany(e => e.QuestionnairesDataSectionEs).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.SectionE");
                entity.HasMany(e => e.QuestionnairesDataTeacherProfiles).WithOne(e => e.Year).OnDelete(DeleteBehavior.NoAction).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_Questionnaires.Data.TeacherProfile");

                entity.HasData
                (
                    new Year() {Id=1, Ediyear = 2021, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, NorthwestTerritories=true,NovaScotia=true }
                    );

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
