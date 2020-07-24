﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EDI.Infrastructure.Data;

namespace EDI.Infrastructure.DaEDI.Migrations
{
    [DbContext(typeof(ServiceContext))]
    partial class ServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ISO3CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<int>("ISO3DigitCountry")
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

                    b.ToTable("Country");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Currency", b =>
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

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.CustomerAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BillingAddress1")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("BillingAddress2")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("BillingCity")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("BillingCountry")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("BillingCountryID")
                        .HasColumnType("int");

                    b.Property<string>("BillingPostal")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BillingProvince")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("BillingProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryInstructions")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("HasShippingAddress")
                        .HasColumnType("bit");

                    b.Property<string>("InternalNotes")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingAddress1")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingAddress2")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingCity")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingCountry")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ShippingCountryID")
                        .HasColumnType("int");

                    b.Property<string>("ShippingPhone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingPostal")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingProvince")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ShippingProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("TollFree")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CustomerAccess");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BillingAddress1")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("BillingAddress2")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("BillingCity")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("BillingCountryID")
                        .HasColumnType("int");

                    b.Property<string>("BillingPostal")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("BillingProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryInstructions")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("HasShippingAddress")
                        .HasColumnType("bit");

                    b.Property<string>("InternalNotes")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("LastSentDate")
                        .HasColumnType("date");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingAddress1")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingAddress2")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingCity")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ShippingContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShippingCountryID")
                        .HasColumnType("int");

                    b.Property<string>("ShippingPhone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShippingPostal")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ShippingProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("TollFree")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BillingCountryID");

                    b.HasIndex("BillingProvinceID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("ShippingCountryID");

                    b.HasIndex("ShippingProvinceID");

                    b.ToTable("Customers");
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

                    b.ToTable("Province");
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

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Customers", b =>
                {
                    b.HasOne("EDI.ApplicationCore.Entities.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("BillingCountryID");

                    b.HasOne("EDI.ApplicationCore.Entities.Province", "Province")
                        .WithMany("Customers")
                        .HasForeignKey("BillingProvinceID");

                    b.HasOne("EDI.ApplicationCore.Entities.Currency", "Currency")
                        .WithMany("Customers")
                        .HasForeignKey("CurrencyID");

                    b.HasOne("EDI.ApplicationCore.Entities.Country", "Country1")
                        .WithMany("Customers1")
                        .HasForeignKey("ShippingCountryID");

                    b.HasOne("EDI.ApplicationCore.Entities.Province", "Province1")
                        .WithMany("Customers1")
                        .HasForeignKey("ShippingProvinceID");
                });

            modelBuilder.Entity("EDI.ApplicationCore.Entities.Province", b =>
                {
                    b.HasOne("EDI.ApplicationCore.Entities.Country", "Country")
                        .WithMany("Province")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDI.ApplicationCore.Entities.ProvinceType", "ProvinceType")
                        .WithMany("Province")
                        .HasForeignKey("ProvinceTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
