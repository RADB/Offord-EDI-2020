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
//        public virtual DbSet<Reports> Reports { get; set; }
        
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

                entity.Property(e => e.PercentComplete).HasDefaultValueSql("((0))");

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
                    new FileImportStatus() {Id=4, Code = "4", English = "Invalid Province", French = "Province non valide", Sequence = 4, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new FileImportStatus() { Id = 5, Code = "5", English = "Invalid Questionnaire", French = "Questionnaire non valide", Sequence = 5, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
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
                entity.HasMany(d => d.LookupSetOptions).WithOne(p => p.LookupSet).HasForeignKey(d => d.LookupSetId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_LookupSet_Lookup ");
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
                    new LookupSet() { Id = 25, LookupName = "ClassTypeNS", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 26, LookupName = "StatusNS", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 27, LookupName = "EFSL", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 28, LookupName = "CareArrangement", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 29, LookupName = "Transportation", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 30, LookupName = "ClassAssignmentON", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 31, LookupName = "ClassTypeON", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 32, LookupName = "FullPartDontknow", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 33, LookupName = "RaceEthnicity", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 34, LookupName = "ClassTime", YearId = 1, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 69, LookupName = "Education", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 70, LookupName = "YesNoWellBeing", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 71, LookupName = "NegativePositive", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 72, LookupName = "BetterWorse", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 73, LookupName = "InstructionFormat", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 74, LookupName = "OnlineChallenges", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 75, LookupName = "ELL", YearId = 2, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 119, LookupName = "TimesCompleted", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 120, LookupName = "YesNoDidntUse", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 121, LookupName = "NFLDLanguageStatus", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 122, LookupName = "LanguageImmersion", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 123, LookupName = "PEIClassType", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 124, LookupName = "MBClassType", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSet() { Id = 125, LookupName = "MBAdditionalLanguage", YearId = 3, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }                    
                    );

            });

            modelBuilder.Entity<LookupSetOption>(entity =>
            {
                entity.ToTable("LookupSetOptions", "LUData");

                entity.Property(e => e.CreatedBy).IsRequired().HasMaxLength(256).IsUnicode(false);

                entity.Property(e => e.English).IsRequired().HasMaxLength(200);

                entity.Property(e => e.French).HasMaxLength(200);                

                entity.Property(e => e.ModifiedBy).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.HasData
                (
                    new LookupSetOption() { Id = 281, LookupSetId = 33, English = "Multiracial", French = "Multiracial", Value = 1, Sequence = 10, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 282, LookupSetId = 33, English = "American Indian/Alaskan Native", French = "American Indian/Alaskan Native", Value = 2, Sequence = 20,CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 283, LookupSetId = 33, English = "African American/Black", French = "African American/Black", Value = 3, Sequence = 30, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 284, LookupSetId = 33, English = "Asian", French = "Asian", Value = 4, Sequence = 40, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 285, LookupSetId = 33, English = "Native Hawaiian or other Pacific Islander", French = "Native Hawaiian or other Pacific Islander", Value = 5, Sequence = 50, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 286, LookupSetId = 33, English = "Hispanic, Latino/a", French = "Hispanic, Latino/a", Value = 6, Sequence = 60, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 287, LookupSetId = 33, English = "White", French = "White", Value = 7, Sequence = 70, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 288, LookupSetId = 33, English = "Other", French = "Other", Value = 8, Sequence = 80, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 289, LookupSetId = 34, English = "AM", French = "AM", Value = 1, Sequence = 10, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 290, LookupSetId = 34, English = "PM", French = "PM", Value = 2, Sequence = 20, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 291, LookupSetId = 34, English = "All Day", French = "All Day", Value = 3, Sequence = 30, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new LookupSetOption() { Id = 292, LookupSetId = 34, English = "Other", French = "Other", Value = 4, Sequence = 40, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    // 2022 Data Additions - Teacher Profile
                    new LookupSetOption() { Id = 585, YearId = 2, English = "Some coursework towards a Bachelor's degree", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Quelques cours en vue de l'obtention d'un baccalauréat", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 586, YearId = 2, English = "Teaching certificate, diploma, or license", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un certi􀁼cat, un diplômeu une license d'enseignement", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 587, YearId = 2, English = "Bachelor's degree", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un baccalauréat", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 588, YearId = 2, English = "Bachelor of Education degree", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un baccalauréat en éducation", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 589, YearId = 2, English = "Some post-baccalaureate coursework", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Quelques cours après le baccalauréat", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 590, YearId = 2, English = "Post-baccalaureate diploma or certificate", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un diplômeu un certi􀁼cat supérieur au baccalauréat", Value = 6, Sequence = 60 },
                    new LookupSetOption() { Id = 591, YearId = 2, English = "Some coursework towards a Master's degree", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Quelques cours en vue de l'obtention d'une maîtrise", Value = 7, Sequence = 70 },
                    new LookupSetOption() { Id = 592, YearId = 2, English = "Master's degree", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Une maîtrise", Value = 8, Sequence = 80 },
                    new LookupSetOption() { Id = 593, YearId = 2, English = "Some coursework towards a Doctorate", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Quelques cours en vue de l'obtention d'un doctorat", Value = 9, Sequence = 90 },
                    new LookupSetOption() { Id = 594, YearId = 2, English = "Doctorate", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un doctorat", Value = 10, Sequence = 100 },
                    new LookupSetOption() { Id = 595, YearId = 2, English = "Other", LookupSetId = 69, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Autre", Value = 11, Sequence = 110 },
                    new LookupSetOption() { Id = 596, YearId = 2, English = "Yes", LookupSetId = 70, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Oui", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 597, YearId = 2, English = "No - my overall well-being was about the same", LookupSetId = 70, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Non, mon bien-être général fut à peu près pareil", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 598, YearId = 2, English = "Negatively", LookupSetId = 71, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Négativement", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 599, YearId = 2, English = "Somewhat negatively", LookupSetId = 71, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un peu négativement", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 600, YearId = 2, English = "Both negatively and positively", LookupSetId = 71, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Négativement et positivement", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 601, YearId = 2, English = "Somewhat positively", LookupSetId = 71, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Un peu positivement", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 602, YearId = 2, English = "Positively", LookupSetId = 71, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Positivement", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 603, YearId = 2, English = "Much better than earlier cohorts", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Beaucoup meilleures que les cohortes précédentes", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 604, YearId = 2, English = "Better than earlier cohorts", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Meilleures que les cohortes précédentes", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 605, YearId = 2, English = "About the same", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "À peu près pareilles", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 606, YearId = 2, English = "Lower than earlier cohorts", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Moins bonnes que les cohortes précédentes", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 607, YearId = 2, English = "Much lower than earlier cohorts", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Beaucoup moins bonnes que les cohortes précédentes", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 608, YearId = 2, English = "Don't know ", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Je ne le sais [as", Value = 6, Sequence = 60 },
                    new LookupSetOption() { Id = 609, YearId = 2, English = "Not applicable", LookupSetId = 72, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Not applicable", Value = 7, Sequence = 70 },

                    // demographics additions
                    new LookupSetOption() { Id = 610, YearId = 2, English = "All in person, normal school hours", LookupSetId = 73, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "En présentiel avec un nombre d'heures de classe normal", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 611, YearId = 2, English = "Hybrid instruction, some in person, some online instruction", LookupSetId = 73, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Format hybride avec un certain montant d'enseignement en présentiel et d'autre en virtuel", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 612, YearId = 2, English = "All online instruction, regular online meetings with students (daily or weekly)", LookupSetId = 73, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Enseignement virtuel avec des rencontres quotidiennes ou hebdomadaires en ligne avec les élèves", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 613, YearId = 2, English = "All online, independent study student/family paced, no regular virtual meetings", LookupSetId = 73, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Enseignement virtuel asynchrone, au rythme de l'élève/la famille, aucune rencontre en ligne sur une base régulière", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 614, YearId = 2, English = "Other", LookupSetId = 73, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Autre", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 615, YearId = 2, English = "Not applicable (no online learning took place or child opted out all together)", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Not applicable (no online learning took place or child opted out all together)", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 616, YearId = 2, English = "Limited or no internet access", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Limited or no internet access", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 617, YearId = 2, English = "Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 618, YearId = 2, English = "No adult available to support the child during instruction time", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "No adult available to support the child during instruction time", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 619, YearId = 2, English = "Child uninterested in participating/short attention span", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Child uninterested in participating/short attention span", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 620, YearId = 2, English = "Child did not have setting/space appropriate for learning", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Child did not have setting/space appropriate for learning", Value = 6, Sequence = 60 },
                    new LookupSetOption() { Id = 621, YearId = 2, English = "Child did not have access to needed school supplies (other than technology) to fully participate in activities", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Child did not have access to needed school supplies (other than technology) to fully participate in activities", Value = 7, Sequence = 70 },
                    new LookupSetOption() { Id = 622, YearId = 2, English = "Other", LookupSetId = 74, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Autre", Value = 8, Sequence = 80 },
                    new LookupSetOption() { Id = 623, YearId = 2, English = "ELL", LookupSetId = 75, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "ELL", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 624, YearId = 2, English = "FLL", LookupSetId = 75, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "FLL", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 625, YearId = 2, English = "No", LookupSetId = 75, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "No", Value = 3, Sequence = 30 },
                    // 2023 Data Additions - Teacher Profile - Demographics Section E
                    new LookupSetOption() { Id = 965, YearId = 3, English = "No previous experience", LookupSetId = 119, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = " No previous experience", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 966, YearId = 3, English = "1-2 times", LookupSetId = 119, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "1-2 times", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 967, YearId = 3, English = "3 or more times", LookupSetId = 119, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "3 or more times", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 968, YearId = 3, English = "Yes", LookupSetId = 120, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Oui", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 969, YearId = 3, English = "No", LookupSetId = 120, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Non", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 970, YearId = 3, English = "Didn't Use", LookupSetId = 120, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Didn't Use", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 971, YearId = 3, English = "ESL", LookupSetId = 121, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "ESL", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 972, YearId = 3, English = "FSL", LookupSetId = 121, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "FSL", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 973, YearId = 3, English = "No", LookupSetId = 121, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Non", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 974, YearId = 3, English = "French Immersion", LookupSetId = 122, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "French Immersion", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 975, YearId = 3, English = "Other Immersion", LookupSetId = 122, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Other Immersion", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 976, YearId = 3, English = "No", LookupSetId = 122, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Non", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 977, YearId = 3, English = "JK", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "JK", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 978, YearId = 3, English = "SK", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "SK", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 979, YearId = 3, English = "JK/SK", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "JK/SK", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 980, YearId = 3, English = "JK/SK/q", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "JK/SK/q", Value = 4, Sequence = 40 },
                    new LookupSetOption() { Id = 981, YearId = 3, English = "SK/1", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "SK/1", Value = 5, Sequence = 50 },
                    new LookupSetOption() { Id = 982, YearId = 3, English = "Other", LookupSetId = 123, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Other", Value = 6, Sequence = 60 },
                    new LookupSetOption() { Id = 983, YearId = 3, English = "K", LookupSetId = 124, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "K", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 984, YearId = 3, English = "K/1", LookupSetId = 124, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "K/1", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 985, YearId = 3, English = "Other", LookupSetId = 124, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Other", Value = 3, Sequence = 30 },
                    new LookupSetOption() { Id = 986, YearId = 3, English = "EAL", LookupSetId = 125, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "EAL", Value = 1, Sequence = 10 },
                    new LookupSetOption() { Id = 987, YearId = 3, English = "FAL", LookupSetId = 125, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "FAL", Value = 2, Sequence = 20 },
                    new LookupSetOption() { Id = 988, YearId = 3, English = "No", LookupSetId = 125, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Non", Value = 3, Sequence = 30 }
                );
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
                    new Questionnaire() { Id = 1, English = "Teacher Feedback", QuestionnaireName = "Teacher Feedback", YearId = 1, EntityName = "Questionnaires.Data.TeacherProfile", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Teacher Feedback", DescriptionEnglish = "Teacher Feedback", DescriptionFrench = "Teacher Feedback", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = true, IsChildQuestionnaire = false, Sequence = 10, NorthwestTerritories = true, NovaScotia = true, Ontario = true, NewYork = true},
                    new Questionnaire() {Id=2, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NorthwestTerritories = true },
                    new Questionnaire() {Id =3, English = "Section A", QuestionnaireName = "Section A", YearId = 1, EntityName = "Questionnaires.Data.SectionA", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section A", DescriptionEnglish = "Section A", DescriptionFrench = "Section A", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 20, NorthwestTerritories = true, NovaScotia = true, Ontario = true, NewYork=true },
                    new Questionnaire() {Id =4, English = "Section B", QuestionnaireName = "Section B", YearId = 1, EntityName = "Questionnaires.Data.SectionB", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section B", DescriptionEnglish = "Section B", DescriptionFrench = "Section B", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 30, NorthwestTerritories = true, NovaScotia = true, Ontario = true, NewYork = true },
                    new Questionnaire() {Id =5, English = "Section C", QuestionnaireName = "Section C", YearId = 1, EntityName = "Questionnaires.Data.SectionC", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section C", DescriptionEnglish = "Section C", DescriptionFrench = "Section C", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 40, NorthwestTerritories = true, NovaScotia = true, Ontario = true, NewYork = true },
                    new Questionnaire() {Id =6, English = "Section D", QuestionnaireName = "Section D", YearId = 1, EntityName = "Questionnaires.Data.SectionD", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section D", DescriptionEnglish = "Section D", DescriptionFrench = "Section D", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 50, NorthwestTerritories = true },
                    new Questionnaire() {Id =7, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NorthwestTerritories = true },                    
                    new Questionnaire() {Id =8, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NovaScotia = true },                    
                    new Questionnaire() {Id =9, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NovaScotia = true },
                    new Questionnaire() { Id = 10, English = "Section D", QuestionnaireName = "Section D", YearId = 1, EntityName = "Questionnaires.Data.SectionD", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section D", DescriptionEnglish = "Section D", DescriptionFrench = "Section D", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 50, NovaScotia = true, Ontario = true, NewYork = true },
                    new Questionnaire() { Id = 11, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, Ontario = true },
                    new Questionnaire() { Id = 12, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, Ontario = true },
                    new Questionnaire() { Id = 13, English = "Demographics", QuestionnaireName = "Demographics", YearId = 1, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NewYork = true },
                    new Questionnaire() { Id = 14, English = "Section E", QuestionnaireName = "Section E", YearId = 1, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NewYork = true },
                    // adding newfoundland 2022 and PEI
                    new Questionnaire() { Id = 29, English = "Demographics", QuestionnaireName = "Demographics", YearId = 2, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, NewfoundlandandLabrador = true },
                    new Questionnaire() { Id = 30, English = "Section E", QuestionnaireName = "Section E", YearId = 2, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, NewfoundlandandLabrador = true },
                    new Questionnaire() { Id = 31, English = "Demographics", QuestionnaireName = "Demographics", YearId = 2, EntityName = "Questionnaires.Data.Demographics", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Demographics", DescriptionEnglish = "Demographics", DescriptionFrench = "Demographics", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 10, PrinceEdwardIsland = true },
                    new Questionnaire() { Id = 32, English = "Section E", QuestionnaireName = "Section E", YearId = 2, EntityName = "Questionnaires.Data.SectionE", CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, French = "Section E", DescriptionEnglish = "Section E", DescriptionFrench = "Section E", ShowProgressBar = true, ShowQuestionNumbers = true, IsTeacherQuestionnaire = false, IsChildQuestionnaire = true, Sequence = 60, PrinceEdwardIsland = true }
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

                entity.Property(e => e.NewYork).HasDefaultValueSql("((0))");

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
                    new Year() {Id = 1, Ediyear = 2021, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, NorthwestTerritories=true,NovaScotia=true, Ontario=true,NewYork=true },
                    new Year() {Id = 2, Ediyear = 2022, CreatedBy = "admin", CreatedDate = DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now, NorthwestTerritories = true, NovaScotia = true, Ontario = true, NewYork = true }
                    );

                //entity.HasMany(e => e.LookupSetOptions).WithOne(e => e.Year).HasForeignKey(d => d.YearId).HasConstraintName("FK_Years_LookupSetOptions");
                //entity.HasOne(d => d.Year).WithMany(p => p.Sites).HasForeignKey(d => d.YearId).HasConstraintName("FK_Sites_Years");
                //entity.HasOne(d => d.Year).WithMany(p => p.Teachers).HasForeignKey(d => d.YearId).HasConstraintName("FK_Teachers_Years");

                // example - how to write the relationship 
                // From Countries model
                //entity.HasMany(e => e.Schools).WithOne(e => e.Countries).HasForeignKey(e => e.CountryId);
                //entity.HasOne(d => d.Countries).WithMany(p => p.Schools).HasForeignKey(d => d.CountryId);                
            });

            //modelBuilder.Entity<Report>(entity =>
            //{
            //    entity.HasNoKey();
            //    entity.Property(e => e.Schema).IsUnicode(false);
            //    entity.Property(e => e.ObjectName).IsUnicode(false);
            //    entity.Property(e => e.ParameterDataType).IsUnicode(false);
            //    entity.Property(e => e.ParameterName).IsUnicode(false);
            //    entity.Property(e => e.ParameterStringValue).IsUnicode(false);
            //});
        }
    }
}
