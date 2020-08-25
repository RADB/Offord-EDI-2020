﻿// <auto-generated />
using System;
using EDI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EDI.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ServiceContext))]
    [Migration("20200806152441_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISO2CountryCode")
                        .IsRequired()
                        .HasColumnName("ISO2CountryCode")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ISO3CountryCode")
                        .IsRequired()
                        .HasColumnName("ISO3CountryCode")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<int>("ISO3DigitCountry")
                        .HasColumnName("ISO3DigitCountry")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.DateDimension", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<byte>("DOWInMonth")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Day")
                        .HasColumnType("tinyint");

                    b.Property<short>("DayOfYear")
                        .HasColumnType("smallint");

                    b.Property<string>("DaySuffix")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<DateTime>("FirstDayOfMonth")
                        .HasColumnType("date");

                    b.Property<DateTime>("FirstDayOfNextMonth")
                        .HasColumnType("date");

                    b.Property<DateTime>("FirstDayOfNextYear")
                        .HasColumnType("date");

                    b.Property<DateTime>("FirstDayOfQuarter")
                        .HasColumnType("date");

                    b.Property<DateTime>("FirstDayOfYear")
                        .HasColumnType("date");

                    b.Property<int>("FiscalYear")
                        .HasColumnType("int");

                    b.Property<int>("FiscalYearMonth")
                        .HasColumnType("int");

                    b.Property<int>("FiscalYearMonthOrder")
                        .HasColumnType("int");

                    b.Property<string>("HolidayText")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<byte>("ISOWeekOfYear")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsHoliday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWeekend")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastDayOfMonth")
                        .HasColumnType("date");

                    b.Property<DateTime>("LastDayOfQuarter")
                        .HasColumnType("date");

                    b.Property<DateTime>("LastDayOfYear")
                        .HasColumnType("date");

                    b.Property<byte>("Month")
                        .HasColumnType("tinyint");

                    b.Property<string>("MonthName")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<byte>("Quarter")
                        .HasColumnType("tinyint");

                    b.Property<string>("QuarterName")
                        .IsRequired()
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("WeekDayName")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<byte>("WeekOfMonth")
                        .HasColumnType("tinyint");

                    b.Property<byte>("WeekOfYear")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Weekday")
                        .HasColumnType("tinyint");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("YearMonth")
                        .HasColumnType("int");

                    b.HasKey("Date");

                    b.ToTable("DateDimension");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.FormConfigurations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("FormName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FormConfigurations");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("English")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("French")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Languages","EDI");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CountryID")
                        .HasColumnName("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ProvinceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.HasIndex("ProvinceTypeId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.ProvinceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ProvinceType");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<bool?>("Elpschool")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("SchoolName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("SiteId");

                    b.ToTable("Schools","EDI");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoordinatorId")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiteName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("SiteNumber")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Sites","EDI");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.SpecialProblem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Sequence")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("English")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("French")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("SpecialProblems","EDI");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.SystemConfigurations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("FieldValue")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SystemConfigurations");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Province", b =>
                {
                    b.HasOne("EDI.ApplicationCore.Entities.Country", "Country")
                        .WithMany("Provinces")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDI.ApplicationCore.Entities.ProvinceType", "ProvinceType")
                        .WithMany("Province")
                        .HasForeignKey("ProvinceTypeId");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.School", b =>
                {
                    b.HasOne("EDI.ApplicationCore.Entities.Country", "Countries")
                        .WithMany("Schools")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDI.ApplicationCore.Entities.Site", "Sites")
                        .WithMany("Schools")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
