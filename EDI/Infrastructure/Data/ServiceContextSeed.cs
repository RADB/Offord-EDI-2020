﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.ApplicationCore.Entities;

namespace EDI.Infrastructure.Data
{
    public class ServiceContextSeed
    {
        public static async Task SeedAsync(ServiceContext ServiceContext,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                if (!ServiceContext.Countries.Any())
                {
                    ServiceContext.Countries.AddRange(
                        GetPreconfiguredAllCountries());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.ProvinceType.Any())
                {
                    ServiceContext.ProvinceType.AddRange(
                        GetPreconfiguredAllProvinceTypes());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.Provinces.Any())
                {
                    var provincetypeid = ServiceContext.ProvinceType.Where(t => t.Name == "Province").Select(t => t.Id).FirstOrDefault();
                    var statetypeid = ServiceContext.ProvinceType.Where(t => t.Name == "State").Select(t => t.Id).FirstOrDefault();

                    var countryid = ServiceContext.Countries.Where(t => t.English == "Argentina").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Argentina"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Australia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Australia"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Austria").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Austria"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Belgium").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Belgium"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Brazil").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Brazil"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Bulgaria").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Bulgaria"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Canada").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(provincetypeid, countryid, "Canada"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "China").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "China"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Taiwan, Province of China").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Taiwan, Province of China"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Colombia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Colombia"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Czech Republic").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Czech Republic"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Denmark").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Denmark"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Finland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Finland"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "France").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "France"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Germany").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Germany"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Greece").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Greece"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "India").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "India"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Italy").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Italy"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Japan").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Japan"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Korea, Republic of").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Korea, Republic of"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Malaysia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Malaysia"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Mexico").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Mexico"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Netherlands").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Netherlands"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Norway").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Norway"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Philippines").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Philippines"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Poland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Poland"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Romania").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Romania"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Spain").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Spain"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Sweden").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Sweden"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Switzerland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Switzerland"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Thailand").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Thailand"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "Turkey").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Turkey"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "United Kingdom").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "United Kingdom"));

                    countryid = ServiceContext.Countries.Where(t => t.English == "United States").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(statetypeid, countryid, "United States"));

                    await ServiceContext.SaveChangesAsync();
                }

                //if (!ServiceContext.SystemConfigurations.Any())
                //{
                //    ServiceContext.SystemConfigurations.AddRange(
                //        GetPreconfiguredSystemConfigurations());

                //    await ServiceContext.SaveChangesAsync();
                //}
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<ServiceContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(ServiceContext, loggerFactory, retryForAvailability);
                }
            }
        }

        static IEnumerable<Country> GetPreconfiguredAllCountries()
        {
            return new List<Country>()
            {
                new Country() { English = "Afghanistan", French = "", Code=4, ISO2CountryCode="AF", ISO3CountryCode = "AFG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Albania", French = "", Code=8, ISO2CountryCode="AL", ISO3CountryCode = "ALB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Antarctica", French = "", Code=10, ISO2CountryCode="AQ", ISO3CountryCode = "ATA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Algeria", French = "", Code=12, ISO2CountryCode="DZ", ISO3CountryCode = "DZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "American Samoa", French = "", Code=16, ISO2CountryCode="AS", ISO3CountryCode = "ASM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Andorra", French = "", Code=20, ISO2CountryCode="AD", ISO3CountryCode = "AND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Angola", French = "", Code=24, ISO2CountryCode="AO", ISO3CountryCode = "AGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Antigua and Barbuda", French = "", Code=28, ISO2CountryCode="AG", ISO3CountryCode = "ATG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Azerbaijan", French = "", Code=31, ISO2CountryCode="AZ", ISO3CountryCode = "AZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Argentina", French = "", Code=32, ISO2CountryCode="AR", ISO3CountryCode = "ARG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Australia", French = "", Code=36, ISO2CountryCode="AU", ISO3CountryCode = "AUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Austria", French = "", Code=40, ISO2CountryCode="AT", ISO3CountryCode = "AUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahamas", French = "", Code=44, ISO2CountryCode="BS", ISO3CountryCode = "BHS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahrain", French = "", Code=48, ISO2CountryCode="BH", ISO3CountryCode = "BHR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bangladesh", French = "", Code=50, ISO2CountryCode="BD", ISO3CountryCode = "BGD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Armenia", French = "", Code=51, ISO2CountryCode="AM", ISO3CountryCode = "ARM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Barbados", French = "", Code=52, ISO2CountryCode="BB", ISO3CountryCode = "BRB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belgium", French = "", Code=56, ISO2CountryCode="BE", ISO3CountryCode = "BEL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bermuda", French = "", Code=60, ISO2CountryCode="BM", ISO3CountryCode = "BMU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bhutan", French = "", Code=64, ISO2CountryCode="BT", ISO3CountryCode = "BTN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bolivia", French = "", Code=68, ISO2CountryCode="BO", ISO3CountryCode = "BOL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bosnia and Herzegovina", French = "", Code=70, ISO2CountryCode="BA", ISO3CountryCode = "BIH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Botswana", French = "", Code=72, ISO2CountryCode="BW", ISO3CountryCode = "BWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bouvet Island", French = "", Code=74, ISO2CountryCode="BV", ISO3CountryCode = "BVT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Brazil", French = "", Code=76, ISO2CountryCode="BR", ISO3CountryCode = "BRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belize", French = "", Code=84, ISO2CountryCode="BZ", ISO3CountryCode = "BLZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "British Indian Ocean Territory", French = "", Code=86, ISO2CountryCode="IO", ISO3CountryCode = "IOT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Solomon Islands", French = "", Code=90, ISO2CountryCode="SB", ISO3CountryCode = "SLB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "British Virgin Islands", French = "", Code=92, ISO2CountryCode="VG", ISO3CountryCode = "VGB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Brunei Darussalam", French = "", Code=96, ISO2CountryCode="BN", ISO3CountryCode = "BRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bulgaria", French = "", Code=100, ISO2CountryCode="BG", ISO3CountryCode = "BGR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Myanmar", French = "", Code=104, ISO2CountryCode="MM", ISO3CountryCode = "MMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Burundi", French = "", Code=108, ISO2CountryCode="BI", ISO3CountryCode = "BDI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belarus", French = "", Code=112, ISO2CountryCode="BY", ISO3CountryCode = "BLR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cambodia", French = "", Code=116, ISO2CountryCode="KH", ISO3CountryCode = "KHM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cameroon", French = "", Code=120, ISO2CountryCode="CM", ISO3CountryCode = "CMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cape Verde", French = "", Code=132, ISO2CountryCode="CV", ISO3CountryCode = "CPV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cayman Islands", French = "", Code=136, ISO2CountryCode="KY", ISO3CountryCode = "CYM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Central African Republic", French = "", Code=140, ISO2CountryCode="CF", ISO3CountryCode = "CAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sri Lanka", French = "", Code=144, ISO2CountryCode="LK", ISO3CountryCode = "LKA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Canada", French = "", Code=124, ISO2CountryCode="CA", ISO3CountryCode = "CAN", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new Country() { English = "Chad", French = "", Code=148, ISO2CountryCode="TD", ISO3CountryCode = "TCD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Chile", French = "", Code=152, ISO2CountryCode="CL", ISO3CountryCode = "CHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "China", French = "", Code=156, ISO2CountryCode="CN", ISO3CountryCode = "CHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Taiwan, Province of China", French = "", Code=158, ISO2CountryCode="TW", ISO3CountryCode = "TWN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Christmas Island", French = "", Code=162, ISO2CountryCode="CX", ISO3CountryCode = "CXR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cocos (Keeling) Islands", French = "", Code=166, ISO2CountryCode="CC", ISO3CountryCode = "CCK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Colombia", French = "", Code=170, ISO2CountryCode="CO", ISO3CountryCode = "COL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Comoros", French = "", Code=174, ISO2CountryCode="KM", ISO3CountryCode = "COM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mayotte", French = "", Code=175, ISO2CountryCode="YT", ISO3CountryCode = "MYT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo", French = "", Code=178, ISO2CountryCode="CG", ISO3CountryCode = "COG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo, The Democratic Republic Of The (Zaire)", French = "", Code=180, ISO2CountryCode="CD", ISO3CountryCode = "COD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cook Islands", French = "", Code=184, ISO2CountryCode="CK", ISO3CountryCode = "COK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Costa Rica", French = "", Code=188, ISO2CountryCode="CR", ISO3CountryCode = "CRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Croatia", French = "", Code=191, ISO2CountryCode="HR", ISO3CountryCode = "HRV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cuba", French = "", Code=192, ISO2CountryCode="CU", ISO3CountryCode = "CUB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cyprus", French = "", Code=196, ISO2CountryCode="CY", ISO3CountryCode = "CYP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Czech Republic", French = "", Code=203, ISO2CountryCode="CZ", ISO3CountryCode = "CZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Benin", French = "", Code=204, ISO2CountryCode="BJ", ISO3CountryCode = "BEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Denmark", French = "", Code=208, ISO2CountryCode="DK", ISO3CountryCode = "DNK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominica", French = "", Code=212, ISO2CountryCode="DM", ISO3CountryCode = "DMA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominican Republic", French = "", Code=214, ISO2CountryCode="DO", ISO3CountryCode = "DOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ecuador", French = "", Code=218, ISO2CountryCode="EC", ISO3CountryCode = "ECU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "El Salvador", French = "", Code=222, ISO2CountryCode="SV", ISO3CountryCode = "SLV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Equatorial Guinea", French = "", Code=226, ISO2CountryCode="GQ", ISO3CountryCode = "GNQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ethiopia", French = "", Code=231, ISO2CountryCode="ET", ISO3CountryCode = "ETH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Eritrea", French = "", Code=232, ISO2CountryCode="ER", ISO3CountryCode = "ERI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Estonia", French = "", Code=233, ISO2CountryCode="EE", ISO3CountryCode = "EST",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Faroe Islands", French = "", Code=234, ISO2CountryCode="FO", ISO3CountryCode = "FRO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Falkland Islands (Malvinas)", French = "", Code=238, ISO2CountryCode="FK", ISO3CountryCode = "FLK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "South Georgia and the South Sandwich Islands", French = "", Code=239, ISO2CountryCode="GS", ISO3CountryCode = "SGS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Fiji", French = "", Code=242, ISO2CountryCode="FJ", ISO3CountryCode = "FJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Finland", French = "", Code=246, ISO2CountryCode="FI", ISO3CountryCode = "FIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Aland Islands", French = "", Code=248, ISO2CountryCode="AX", ISO3CountryCode = "ALA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "France", French = "", Code=250, ISO2CountryCode="FR", ISO3CountryCode = "FRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Guiana", French = "", Code=254, ISO2CountryCode="GF", ISO3CountryCode = "GUF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Polynesia", French = "", Code=258, ISO2CountryCode="PF", ISO3CountryCode = "PYF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Southern Territories", French = "", Code=260, ISO2CountryCode="TF", ISO3CountryCode = "ATF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Djibouti", French = "", Code=262, ISO2CountryCode="DJ", ISO3CountryCode = "DJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gabon", French = "", Code=266, ISO2CountryCode="GA", ISO3CountryCode = "GAB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Georgia", French = "", Code=268, ISO2CountryCode="GE", ISO3CountryCode = "GEO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gambia", French = "", Code=270, ISO2CountryCode="GM", ISO3CountryCode = "GMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Palestinian Territory, Occupied", French = "", Code=275, ISO2CountryCode="PS", ISO3CountryCode = "PSE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Germany", French = "", Code=276, ISO2CountryCode="DE", ISO3CountryCode = "DEU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ghana", French = "", Code=288, ISO2CountryCode="GH", ISO3CountryCode = "GHA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gibraltar", French = "", Code=292, ISO2CountryCode="GI", ISO3CountryCode = "GIB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kiribati", French = "", Code=296, ISO2CountryCode="KI", ISO3CountryCode = "KIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Greece", French = "", Code=300, ISO2CountryCode="GR", ISO3CountryCode = "GRC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Greenland", French = "", Code=304, ISO2CountryCode="GL", ISO3CountryCode = "GRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Grenada", French = "", Code=308, ISO2CountryCode="GD", ISO3CountryCode = "GRD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guadeloupe", French = "", Code=312, ISO2CountryCode="GP", ISO3CountryCode = "GLP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guam", French = "", Code=316, ISO2CountryCode="GU", ISO3CountryCode = "GUM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guatemala", French = "", Code=320, ISO2CountryCode="GT", ISO3CountryCode = "GTM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea", French = "", Code=324, ISO2CountryCode="GN", ISO3CountryCode = "GIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guyana", French = "", Code=328, ISO2CountryCode="GY", ISO3CountryCode = "GUY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Haiti", French = "", Code=332, ISO2CountryCode="HT", ISO3CountryCode = "HTI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Heard Island and McDonald Islands", French = "", Code=334, ISO2CountryCode="HM", ISO3CountryCode = "HMD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Holy See (Vatican City State)", French = "", Code=336, ISO2CountryCode="VA", ISO3CountryCode = "VAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Honduras", French = "", Code=340, ISO2CountryCode="HN", ISO3CountryCode = "HND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Hong Kong", French = "", Code=344, ISO2CountryCode="HK", ISO3CountryCode = "HKG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Hungary", French = "", Code=348, ISO2CountryCode="HU", ISO3CountryCode = "HUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iceland", French = "", Code=352, ISO2CountryCode="IS", ISO3CountryCode = "ISL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "India", French = "", Code=356, ISO2CountryCode="IN", ISO3CountryCode = "IND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Indonesia", French = "", Code=360, ISO2CountryCode="ID", ISO3CountryCode = "IDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iran, Islamic Republic of ", French = "", Code=364, ISO2CountryCode="IR", ISO3CountryCode = "IRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iraq", French = "", Code=368, ISO2CountryCode="IQ", ISO3CountryCode = "IRQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ireland", French = "", Code=372, ISO2CountryCode="IE", ISO3CountryCode = "IRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Israel", French = "", Code=376, ISO2CountryCode="IL", ISO3CountryCode = "ISR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Italy", French = "", Code=380, ISO2CountryCode="IT", ISO3CountryCode = "ITA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ivory Coast", French = "", Code=384, ISO2CountryCode="CI", ISO3CountryCode = "CIV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Jamaica", French = "", Code=388, ISO2CountryCode="JM", ISO3CountryCode = "JAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Japan", French = "", Code=392, ISO2CountryCode="JP", ISO3CountryCode = "JPN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kazakstan", French = "", Code=398, ISO2CountryCode="KZ", ISO3CountryCode = "KAZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Jordan", French = "", Code=400, ISO2CountryCode="JO", ISO3CountryCode = "JOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kenya", French = "", Code=404, ISO2CountryCode="KE", ISO3CountryCode = "KEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Democratic Peoples Republic of ", French = "", Code=408, ISO2CountryCode="KP", ISO3CountryCode = "PRK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Republic of", French = "", Code=410, ISO2CountryCode="KR", ISO3CountryCode = "KOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kuwait", French = "", Code=414, ISO2CountryCode="KW", ISO3CountryCode = "KWT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kyrgyzstan", French = "", Code=417, ISO2CountryCode="KG", ISO3CountryCode = "KGZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lao Peoples Deomcratic Republic", French = "", Code=418, ISO2CountryCode="LA", ISO3CountryCode = "LAO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lebanon", French = "", Code=422, ISO2CountryCode="LB", ISO3CountryCode = "LBN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lesotho", French = "", Code=426, ISO2CountryCode="LS", ISO3CountryCode = "LSO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Latvia", French = "", Code=428, ISO2CountryCode="LV", ISO3CountryCode = "LVA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Liberia", French = "", Code=430, ISO2CountryCode="LR", ISO3CountryCode = "LBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Libyan Arab Jamahiriya", French = "", Code=434, ISO2CountryCode="LY", ISO3CountryCode = "LBY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Liechtenstein", French = "", Code=438, ISO2CountryCode="LI", ISO3CountryCode = "LIE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lithuania", French = "", Code=440, ISO2CountryCode="LT", ISO3CountryCode = "LTU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Luxembourg", French = "", Code=442, ISO2CountryCode="LU", ISO3CountryCode = "LUX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Macau", French = "", Code=446, ISO2CountryCode="MO", ISO3CountryCode = "MAC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Madagascar", French = "", Code=450, ISO2CountryCode="MG", ISO3CountryCode = "MDG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malawi", French = "", Code=454, ISO2CountryCode="MW", ISO3CountryCode = "MWI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malaysia", French = "", Code=458, ISO2CountryCode="MY", ISO3CountryCode = "MYS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Maldives", French = "", Code=462, ISO2CountryCode="MV", ISO3CountryCode = "MDV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mali", French = "", Code=466, ISO2CountryCode="ML", ISO3CountryCode = "MLI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malta", French = "", Code=470, ISO2CountryCode="MT", ISO3CountryCode = "MLT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Martinique", French = "", Code=474, ISO2CountryCode="MQ", ISO3CountryCode = "MTQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritania", French = "", Code=478, ISO2CountryCode="MR", ISO3CountryCode = "MRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritius", French = "", Code=480, ISO2CountryCode="MU", ISO3CountryCode = "MUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mexico", French = "", Code=484, ISO2CountryCode="MX", ISO3CountryCode = "MEX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Monaco", French = "", Code=492, ISO2CountryCode="MC", ISO3CountryCode = "MCO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mongolia", French = "", Code=496, ISO2CountryCode="MN", ISO3CountryCode = "MNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Moldova, Republic of ", French = "", Code=498, ISO2CountryCode="MD", ISO3CountryCode = "MDA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Montserrat", French = "", Code=500, ISO2CountryCode="MS", ISO3CountryCode = "MSR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Morocco", French = "", Code=504, ISO2CountryCode="MA", ISO3CountryCode = "MAR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mozambique", French = "", Code=508, ISO2CountryCode="MZ", ISO3CountryCode = "MOZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Oman", French = "", Code=512, ISO2CountryCode="OM", ISO3CountryCode = "OMN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Namibia", French = "", Code=516, ISO2CountryCode="NA", ISO3CountryCode = "NAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nauru", French = "", Code=520, ISO2CountryCode="NR", ISO3CountryCode = "NRU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nepal", French = "", Code=524, ISO2CountryCode="NP", ISO3CountryCode = "NPL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands", French = "", Code=528, ISO2CountryCode="NL", ISO3CountryCode = "NLD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands Antilles", French = "", Code=530, ISO2CountryCode="AN", ISO3CountryCode = "ANT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Aruba", French = "", Code=533, ISO2CountryCode="AW", ISO3CountryCode = "ABW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "New Caledonia", French = "", Code=540, ISO2CountryCode="NC", ISO3CountryCode = "NCL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Vanuatu", French = "", Code=548, ISO2CountryCode="VU", ISO3CountryCode = "VUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "New Zealand", French = "", Code=554, ISO2CountryCode="NZ", ISO3CountryCode = "NZL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nicaragua", French = "", Code=558, ISO2CountryCode="NI", ISO3CountryCode = "NIC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Niger", French = "", Code=562, ISO2CountryCode="NE", ISO3CountryCode = "NER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nigeria", French = "", Code=566, ISO2CountryCode="NG", ISO3CountryCode = "NGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Niue", French = "", Code=570, ISO2CountryCode="NU", ISO3CountryCode = "NIU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Norfolk Island", French = "", Code=574, ISO2CountryCode="NF", ISO3CountryCode = "NFK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Norway", French = "", Code=578, ISO2CountryCode="NO", ISO3CountryCode = "NOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Northern Mariana Islands", French = "", Code=580, ISO2CountryCode="MP", ISO3CountryCode = "MNP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United States Minor Outlying Islands", French = "", Code=581, ISO2CountryCode="UM", ISO3CountryCode = "UMI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Micronesia, Federated States of ", French = "", Code=583, ISO2CountryCode="FM", ISO3CountryCode = "FSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Marshall Islands", French = "", Code=584, ISO2CountryCode="MH", ISO3CountryCode = "MHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Palau", French = "", Code=585, ISO2CountryCode="PW", ISO3CountryCode = "PLW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Pakistan", French = "", Code=586, ISO2CountryCode="PK", ISO3CountryCode = "PAK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Panama", French = "", Code=591, ISO2CountryCode="PA", ISO3CountryCode = "PAN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Papua New Guinea", French = "", Code=598, ISO2CountryCode="PG", ISO3CountryCode = "PNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Paraguay", French = "", Code=600, ISO2CountryCode="PY", ISO3CountryCode = "PRY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Peru", French = "", Code=604, ISO2CountryCode="PE", ISO3CountryCode = "PER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Philippines", French = "", Code=608, ISO2CountryCode="PH", ISO3CountryCode = "PHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Pitcairn", French = "", Code=612, ISO2CountryCode="PN", ISO3CountryCode = "PCN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Poland", French = "", Code=616, ISO2CountryCode="PL", ISO3CountryCode = "POL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Portugal", French = "", Code=620, ISO2CountryCode="PT", ISO3CountryCode = "PRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea-Bissau", French = "", Code=624, ISO2CountryCode="GW", ISO3CountryCode = "GNB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Timor-Leste", French = "", Code=626, ISO2CountryCode="TL", ISO3CountryCode = "TLS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Puerto Rico", French = "", Code=630, ISO2CountryCode="PR", ISO3CountryCode = "PRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Qatar", French = "", Code=634, ISO2CountryCode="QA", ISO3CountryCode = "QAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Reunion", French = "", Code=638, ISO2CountryCode="RE", ISO3CountryCode = "REU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Romania", French = "", Code=642, ISO2CountryCode="RO", ISO3CountryCode = "ROM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Russian Federation", French = "", Code=643, ISO2CountryCode="RU", ISO3CountryCode = "RUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Rwanda", French = "", Code=646, ISO2CountryCode="RW", ISO3CountryCode = "RWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Helena", French = "", Code=654, ISO2CountryCode="SH", ISO3CountryCode = "SHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Kitts and Nevis", French = "", Code=659, ISO2CountryCode="KN", ISO3CountryCode = "KNA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Anguilla", French = "", Code=660, ISO2CountryCode="AI", ISO3CountryCode = "AIA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Lucia", French = "", Code=662, ISO2CountryCode="LC", ISO3CountryCode = "LCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Pierre and Miquelon", French = "", Code=666, ISO2CountryCode="PM", ISO3CountryCode = "SPM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Vincent and the Grenadines", French = "", Code=670, ISO2CountryCode="VC", ISO3CountryCode = "VCT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "San Marino", French = "", Code=674, ISO2CountryCode="SM", ISO3CountryCode = "SMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sao Tome and Principe", French = "", Code=678, ISO2CountryCode="ST", ISO3CountryCode = "STP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saudi Arabia", French = "", Code=682, ISO2CountryCode="SA", ISO3CountryCode = "SAU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Senegal", French = "", Code=686, ISO2CountryCode="SN", ISO3CountryCode = "SEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Seychelles", French = "", Code=690, ISO2CountryCode="SC", ISO3CountryCode = "SYC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sierra Leone", French = "", Code=694, ISO2CountryCode="SL", ISO3CountryCode = "SLE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Singapore", French = "", Code=702, ISO2CountryCode="SG", ISO3CountryCode = "SGP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovakia", French = "", Code=703, ISO2CountryCode="SK", ISO3CountryCode = "SVK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Viet Nam", French = "", Code=704, ISO2CountryCode="VN", ISO3CountryCode = "VNM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovenia", French = "", Code=705, ISO2CountryCode="SI", ISO3CountryCode = "SVN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Somalia", French = "", Code=706, ISO2CountryCode="SO", ISO3CountryCode = "SOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "South Africa", French = "", Code=710, ISO2CountryCode="ZA", ISO3CountryCode = "ZAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Zimbabwe", French = "", Code=716, ISO2CountryCode="ZW", ISO3CountryCode = "ZWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Spain", French = "", Code=724, ISO2CountryCode="ES", ISO3CountryCode = "ESP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Western Sahara", French = "", Code=732, ISO2CountryCode="EH", ISO3CountryCode = "ESH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sudan", French = "", Code=736, ISO2CountryCode="SD", ISO3CountryCode = "SDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Suriname", French = "", Code=740, ISO2CountryCode="SR", ISO3CountryCode = "SUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Svalbard and Jan Mayen", French = "", Code=744, ISO2CountryCode="SJ", ISO3CountryCode = "SJM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Swaziland", French = "", Code=748, ISO2CountryCode="SZ", ISO3CountryCode = "SWZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sweden", French = "", Code=752, ISO2CountryCode="SE", ISO3CountryCode = "SWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Switzerland", French = "", Code=756, ISO2CountryCode="CH", ISO3CountryCode = "CHE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Syrian Arab Republic", French = "", Code=760, ISO2CountryCode="SY", ISO3CountryCode = "SYR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tajikistan", French = "", Code=762, ISO2CountryCode="TJ", ISO3CountryCode = "TJK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Thailand", French = "", Code=764, ISO2CountryCode="TH", ISO3CountryCode = "THA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Togo", French = "", Code=768, ISO2CountryCode="TG", ISO3CountryCode = "TGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tokelau", French = "", Code=772, ISO2CountryCode="TK", ISO3CountryCode = "TKL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tonga", French = "", Code=776, ISO2CountryCode="TO", ISO3CountryCode = "TON",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Trinidad and Tobago", French = "", Code=780, ISO2CountryCode="TT", ISO3CountryCode = "TTO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United Arab Emirates", French = "", Code=784, ISO2CountryCode="AE", ISO3CountryCode = "ARE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tunisia", French = "", Code=788, ISO2CountryCode="TN", ISO3CountryCode = "TUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkey", French = "", Code=792, ISO2CountryCode="TR", ISO3CountryCode = "TUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkmenistan", French = "", Code=795, ISO2CountryCode="TM", ISO3CountryCode = "TKM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turks and Caicos Islands", French = "", Code=796, ISO2CountryCode="TC", ISO3CountryCode = "TCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tuvalu", French = "", Code=798, ISO2CountryCode="TV", ISO3CountryCode = "TUV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uganda", French = "", Code=800, ISO2CountryCode="UG", ISO3CountryCode = "UGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ukraine", French = "", Code=804, ISO2CountryCode="UA", ISO3CountryCode = "UKR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Macedonia, The former Yugoslav Republic of ", French = "", Code=807, ISO2CountryCode="MK", ISO3CountryCode = "MKD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Egypt", French = "", Code=818, ISO2CountryCode="EG", ISO3CountryCode = "EGY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United Kingdom", French = "", Code=826, ISO2CountryCode="GB", ISO3CountryCode = "GBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United States", French = "", Code=840, ISO2CountryCode="US", ISO3CountryCode = "USA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tanzania, United Republic of ", French = "", Code=834, ISO2CountryCode="TZ", ISO3CountryCode = "TZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "U.S. Virgin Islands", French = "", Code=850, ISO2CountryCode="VI", ISO3CountryCode = "VIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Burkina Faso", French = "", Code=854, ISO2CountryCode="BF", ISO3CountryCode = "BFA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uruguay", French = "", Code=858, ISO2CountryCode="UY", ISO3CountryCode = "URY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uzbekistan", French = "", Code=860, ISO2CountryCode="UZ", ISO3CountryCode = "UZB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Venezuela", French = "", Code=862, ISO2CountryCode="VE", ISO3CountryCode = "VEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Wallis and Futuna", French = "", Code=876, ISO2CountryCode="WF", ISO3CountryCode = "WLF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Samoa", French = "", Code=882, ISO2CountryCode="WS", ISO3CountryCode = "WSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Yemen", French = "", Code=887, ISO2CountryCode="YE", ISO3CountryCode = "YEM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Serbia and Montenegro (Yugoslavia)", French = "", Code=891, ISO2CountryCode="CS", ISO3CountryCode = "SCG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Zambia", French = "", Code=894, ISO2CountryCode="ZM", ISO3CountryCode = "ZMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
            }.OrderBy(t => t.English);
        }

        static IEnumerable<ProvinceType> GetPreconfiguredAllProvinceTypes()
        {
            return new List<ProvinceType>()
            {
                new ProvinceType() { Name = "Province", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new ProvinceType() { Name = "State", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new ProvinceType() { Name = "District", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new ProvinceType() { Name = "Outlying Areas of the United States ", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new ProvinceType() { Name = "Countries", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
            }.OrderBy(t => t.Name);
        }

        static IEnumerable<Province> GetPreconfiguredAllProvinces(int provincetypeid, int countryid, string countryName)
        {
            if (countryName == "Argentina")
            {
                return new List<Province>()
                {
                    new Province() { English = "Buenos Aires Province", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capital Federal", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catamarca", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaco", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chubut", French = "", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrientes", French = "", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Entre Ríos", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Formosa", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jujuy", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Pampa", French = "", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", French = "", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mendoza", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misiones", French = "", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuquén", French = "", Code = "Q", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Río Negro", French = "", Code = "R", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salta", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Juan", French = "", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis", French = "", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Fe", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santiago del Estero", French = "", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tierra del Fuego", French = "", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tucumán", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "COR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", French = "", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Australia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Australian Capital Territory", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Territory", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Queensland", French = "", Code = "QL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Australia", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tasmania", French = "", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Victoria", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Australia", French = "", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New South Wales", French = "", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Austria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Burgenland", French = "", Code = "Burgenland", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carinthia", French = "", Code = "Kärnten", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Austria", French = "", Code = "Niederösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salzburg", French = "", Code = "Salzburg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Styria", French = "", Code = "Steiermark", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tyrol", French = "", Code = "Tirol", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Upper Austria", French = "", Code = "Oberösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienna", French = "", Code = "Wien", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vorarlberg", French = "", Code = "Vorarlberg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Belgium")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antwerpen", French = "", Code = "VAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brabant Wallon", French = "", Code = "WBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brussels", French = "", Code = "BRU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flanders", French = "", Code = "VLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainaut", French = "", Code = "WHT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liège", French = "", Code = "WLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", French = "", Code = "VLI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luxembourg", French = "", Code = "WLX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Namur", French = "", Code = "WNA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oost-Vlaanderen", French = "", Code = "VOV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vlaams Brabant", French = "", Code = "VBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallonia", French = "", Code = "WAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West-Vlaanderen", French = "", Code = "VWV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Brazil")
            {
                return new List<Province>()
                {
                    new Province() { English = "Acre", French = "", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alagoas", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amapá", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", French = "", Code = "AM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bahia", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceará", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", French = "", Code = "DF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Espírito Santo", French = "", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goiás", French = "", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maranhão", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso", French = "", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso do Sul", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minas Gerais", French = "", Code = "MG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pará", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraíba", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraná", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernambuco", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piauí", French = "", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio de Janeiro", French = "", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Norte", French = "", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Sul", French = "", Code = "RS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rondônia", French = "", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roraima", French = "", Code = "RR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Catarina", French = "", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "São Paulo", French = "", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sergipe", French = "", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tocantins", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", French = "", Code = "AMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", French = "", Code = "DIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Bulgaria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blagoevgrad", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgas", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dobrich", French = "", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gabrovo", French = "", Code = "EB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haskovo", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kardzhali", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyustendil", French = "", Code = "KH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lovech", French = "", Code = "OB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Montana", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pazardzhik", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernik", French = "", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pleven", French = "", Code = "EH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plovdiv", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Razgrad", French = "", Code = "PP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ruse", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shumen", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Silistra", French = "", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sliven", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Smolyan", French = "", Code = "CM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia Province", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stara Zagora", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Targovishte", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varna", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veliko Tarnovo", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vidin", French = "", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vratsa", French = "", Code = "BP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yambol", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Canada")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alberta", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "British Columbia", French = "", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Manitoba", French = "", Code = "MB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Brunswick", French = "", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Newfoundland and Labrador", French = "", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northwest Territories", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Nova Scotia", French = "", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nunavut", French = "", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Ontario", French = "", Code = "ON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prince Edward Island", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Quebec", French = "", Code = "QC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saskatchewan", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Yukon Territory", French = "", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Anhui", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Beijing", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chongqing", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fujian", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gansu", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangdong", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangxi", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guizhou", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainan", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hebei", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heilongjiang", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Henan", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hong Kong", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hubei", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunan", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangsu", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangxi", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jilin", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liaoning", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macau", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nei Mongol", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ningxia", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Qinghai", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shaanxi", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shandong", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanghai", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanxi", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sichuan", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taiwan †", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tianjin", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xinjiang", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xizang", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunnan", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zhejiang", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Taiwan, Province of China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Changhua", French = "", Code = "CHA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", French = "", Code = "CYI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", French = "", Code = "CYQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", French = "", Code = "HSQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", French = "", Code = "HSZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hualien", French = "", Code = "HUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilan", French = "", Code = "ILA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", French = "", Code = "KHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", French = "", Code = "KHQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Keelung", French = "", Code = "KEE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miaoli", French = "", Code = "MIA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nantou", French = "", Code = "NAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Penghu", French = "", Code = "PEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pingtung", French = "", Code = "PIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", French = "", Code = "TXG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", French = "", Code = "TXQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", French = "", Code = "TNN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", French = "", Code = "TNQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taipei", French = "", Code = "TPE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taipei", French = "", Code = "TPQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taitung", French = "", Code = "TTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taoyuan", French = "", Code = "TAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunlin", French = "", Code = "YUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Colombia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antioquia", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arauca", French = "", Code = "ARA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Atlántico", French = "", Code = "ATL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bogotá D.C.", French = "", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolívar", French = "", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boyacá", French = "", Code = "BOY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caldas", French = "", Code = "CAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caquetá", French = "", Code = "CAQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Casanare", French = "", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cauca", French = "", Code = "CAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cesar", French = "", Code = "CES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chocó", French = "", Code = "CHO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cundinamarca", French = "", Code = "CUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guainía", French = "", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guaviare", French = "", Code = "GUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huila", French = "", Code = "HUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Guajira", French = "", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magdalena", French = "", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meta", French = "", Code = "MET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nariño", French = "", Code = "NAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norte de Santander", French = "", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putumayo", French = "", Code = "PUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quindío", French = "", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Risaralda", French = "", Code = "RIS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Andrés and Providencia", French = "", Code = "SAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santander", French = "", Code = "SAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sucre", French = "", Code = "SUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tolima", French = "", Code = "TOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valle del Cauca", French = "", Code = "VAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaupés", French = "", Code = "VAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vichada", French = "", Code = "VID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Czech Republic")
            {
                return new List<Province>()
                {
                    new Province() { English = "Carlsbad Region", French = "", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Bohemian Region", French = "", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hradec Králové Region", French = "", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liberec Region", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moravian-Silesian Region", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olomouc Region", French = "", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pardubice Region", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plzen Region", French = "", Code = "PL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prague, the Capital", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Bohemian Region", French = "", Code = "JC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Moravian Region", French = "", Code = "JM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ústí nad Labem Region", French = "", Code = "US", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vysocina Region", French = "", Code = "VY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zlín Region", French = "", Code = "ZL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Denmark")
            {
                return new List<Province>()
                {
                    new Province() { English = "Århus", French = "", Code = "070", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bornholm", French = "", Code = "040", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen", French = "", Code = "015", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen City", French = "", Code = "101", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksberg", French = "", Code = "147", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksborg", French = "", Code = "020", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fyn", French = "", Code = "042", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Jutland", French = "", Code = "080", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ribe", French = "", Code = "055", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ringkøbing", French = "", Code = "065", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roskilde", French = "", Code = "025", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Jutland", French = "", Code = "050", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Storstrøm", French = "", Code = "035", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vejle", French = "", Code = "060", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestsjælland", French = "", Code = "030", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viborg", French = "", Code = "076", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Finland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aland Islands", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Finland", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lapland", French = "", Code = "LL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oulu", French = "", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Finland", French = "", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Finland", French = "", Code = "LS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "France")
            {
                return new List<Province>()
                {
                    new Province() { English = "Ain", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aisne", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Allier", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-de-Haute-Provence", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-Maritimes", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardèche", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardennes", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ariège", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aube", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aude", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aveyron", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bas-Rhin", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bouches-du-Rhône", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calvados", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantal", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente-Maritime", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cher", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrèze", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corse-du-Sud", French = "", Code = "2A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côte-d'Or", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côtes-d'Armor", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Creuse", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Deux-Sèvres", French = "", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dordogne", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doubs", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drôme", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essonne", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure-et-Loir", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finistère", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Polynesia", French = "", Code = "PF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Southern Territories", French = "", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gard", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gers", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gironde", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Corse", French = "", Code = "2B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Garonne", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Loire", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Marne", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Alpes", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Saône", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Savoie", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Pyrénées", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Vienne", French = "", Code = "87", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haut-Rhin", French = "", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hauts-de-Seine", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hérault", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ille-et-Vilaine", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre-et-Loire", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isère", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Landes", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire-Atlantique", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loiret", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loir-et-Cher", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot-et-Garonne", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lozère", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine-et-Loire", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manche", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marne", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayenne", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayotte", French = "", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meurthe-et-Moselle", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meuse", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morbihan", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moselle", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Caledonia", French = "", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nièvre", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oise", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orne", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paris", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pas-de-Calais", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puy-de-Dôme", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Atlantiques", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Orientales", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhône", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saint-Pierre and Miquelon", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saône-et-Loire", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarthe", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savoie", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-et-Marne", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Maritime", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Saint-Denis", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somme", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn-et-Garonne", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Territoire-de-Belfort", French = "", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-de-Marne", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-d'Oise", French = "", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Var", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaucluse", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vendée", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienne", French = "", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vosges", French = "", Code = "88", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallis and Futuna", French = "", Code = "WF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yonne", French = "", Code = "89", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yvelines", French = "", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", French = "", Code = "JU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Germany")
            {
                return new List<Province>()
                {
                    new Province() { English = "Baden-Württemberg", French = "", Code = "BW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bavaria", French = "", Code = "BY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Berlin", French = "", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brandenburg", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bremen", French = "", Code = "HB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hamburg", French = "", Code = "HH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hesse", French = "", Code = "HE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Saxony", French = "", Code = "NI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mecklenburg-Western Pomerania", French = "", Code = "MV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Rhine-Westphalia", French = "", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhineland-Palatinate", French = "", Code = "RP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saarland", French = "", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony", French = "", Code = "SN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony-Anhalt", French = "", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schleswig-Holstein", French = "", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thuringia", French = "", Code = "TH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Greece")
            {
                return new List<Province>()
                {
                    new Province() { English = "Achaea", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aetolia-Acarnania", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arcadia", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argolis", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arta", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Attica", French = "", Code = "A1", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boeotia", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chalcidice", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chania", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chios", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corfu", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corinthia", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cyclades", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dodecanese", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drama", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Euboea", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evros", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evrytania", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florina", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grevena", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heraklion", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilia", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imathia", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ioannina", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karditsa", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastoria", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kavala", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kefallinia", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilkis", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kozani", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laconia", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larissa", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lasithi", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lefkada", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lesbos", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magnesia", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messinia", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mount Athos", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pella", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phocis", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phthiotis", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pieria", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Preveza", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rethymno", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhodope", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samos", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Serres", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thesprotia", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thessaloniki", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trikala", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xanthi", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zakynthos", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "India")
            {
                return new List<Province>()
                {
                    new Province() { English = "Andaman and Nicobar Islands", French = "", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Andhra Pradesh", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arunachal Pradesh", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Assam", French = "", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihar", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chandigarh", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chhattisgarh", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dadra and Nagar Haveli", French = "", Code = "DN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daman and Diu", French = "", Code = "DD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delhi", French = "", Code = "DL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goa", French = "", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gujarat", French = "", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haryana", French = "", Code = "HR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Himachal Pradesh", French = "", Code = "HP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jammu and Kashmir", French = "", Code = "JK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jharkhand", French = "", Code = "JH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karnataka", French = "", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kerala", French = "", Code = "KL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lakshadweep", French = "", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madhya Pradesh", French = "", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maharashtra", French = "", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manipur", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meghalaya", French = "", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mizoram", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagaland", French = "", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orissa", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pondicherry", French = "", Code = "PY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Punjab", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rajasthan", French = "", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sikkim", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamil Nadu", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tripura", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttar Pradesh", French = "", Code = "UP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaranchal", French = "", Code = "UL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Bengal", French = "", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Italy")
            {
                return new List<Province>()
                {
                    new Province() { English = "Agrigento", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alessandria", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ancona", French = "", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aosta", French = "", Code = "AO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arezzo", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ascoli Piceno", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asti", French = "", Code = "AT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Avellino", French = "", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bari", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barletta-Andria-Trani", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belluno", French = "", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benevento", French = "", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bergamo", French = "", Code = "BG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biella", French = "", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bologna", French = "", Code = "BO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolzano", French = "", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brescia", French = "", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brindisi", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagliari", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caltanissetta", French = "", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campobasso", French = "", Code = "CB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carbonia-Iglesias", French = "", Code = "CI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caserta", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catania", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanzaro", French = "", Code = "CZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chieti", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Como", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cosenza", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cremona", French = "", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Crotone", French = "", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuneo", French = "", Code = "CN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enna", French = "", Code = "EN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermo", French = "", Code = "FM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ferrara", French = "", Code = "FE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Firenze (Florence)", French = "", Code = "FI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Foggia", French = "", Code = "FG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Forlì-Cesena", French = "", Code = "FO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frosinone", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Genova (Genoa)", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorizia", French = "", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grosseto", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imperia", French = "", Code = "IM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isernia", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Spezia", French = "", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "L'Aquila", French = "", Code = "AQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Latina", French = "", Code = "LT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecce", French = "", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecco", French = "", Code = "LC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Livorno", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lodi", French = "", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucca", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macerata", French = "", Code = "MC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mantova (Mantua)", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massa-Carrara", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Matera", French = "", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medio Campidano", French = "", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messina", French = "", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milano (Milan)", French = "", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Modena", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monza", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Napoli (Naples)", French = "", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Novara", French = "", Code = "NO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuoro", French = "", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ogliastra", French = "", Code = "OG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olbia-Tempio", French = "", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oristano", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Padova (Padua)", French = "", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palermo", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Parma", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pavia", French = "", Code = "PV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perugia", French = "", Code = "PG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pesaro e Urbino", French = "", Code = "PS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pescara", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piacenza", French = "", Code = "PC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pisa", French = "", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pistoia", French = "", Code = "PT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pordenone", French = "", Code = "PN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Potenza", French = "", Code = "PZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prato", French = "", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ragusa", French = "", Code = "RG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ravenna", French = "", Code = "RA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Calabria", French = "", Code = "RC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Emilia", French = "", Code = "RE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rieti", French = "", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rimini", French = "", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roma (Rome)", French = "", Code = "RM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rovigo", French = "", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salerno", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sassari", French = "", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savona", French = "", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siena", French = "", Code = "SI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siracusa (Syracuse)", French = "", Code = "SR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sondrio", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taranto", French = "", Code = "TA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teramo", French = "", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terni", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torino (Turin)", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trapani", French = "", Code = "TP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trento", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Treviso", French = "", Code = "TV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trieste", French = "", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udine", French = "", Code = "UD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varese", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Venezia (Venice)", French = "", Code = "VE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verbano-Cusio-Ossola", French = "", Code = "VB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vercelli", French = "", Code = "VC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verona", French = "", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vibo Valentia", French = "", Code = "VV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vicenza", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viterbo", French = "", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Japan")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aiti (Aichi)", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Akita", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aomori", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ehime", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gihu (Gifu)", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gunma", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hirosima (Hiroshima)", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hokkaido", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukui (Fukui)", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukuoka (Fukuoka)", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukusima (Fukushima)", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hyogo", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ibaraki", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isikawa (Ishikawa)", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iwate", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagawa", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagosima (Kagoshima)", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanagawa", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Koti (Kochi)", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kumamoto", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyoto", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mie", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyagi", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyazaki", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagano", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagasaki", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nara", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Niigata", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oita", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okayama", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okinawa", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osaka", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saga", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saitama", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siga (Shiga)", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Simane (Shimane)", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sizuoka (Shizuoka)", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tiba (Chiba)", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokusima (Tokushima)", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokyo", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Totigi (Tochigi)", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tottori", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toyama", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakayama", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamagata", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamaguti (Yamaguchi)", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamanasi (Yamanashi)", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Korea, Republic of")
            {
                return new List<Province>()
                {
                    new Province() { English = "Busan (M)", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongbuk-do", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongnam-do", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daegu (M)", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daejeon (M)", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gangwon-do", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwangju (M)", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeonggi-do", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangbuk-do", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangnam-do", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Incheon (M)", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeju-do", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollabuk-do", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollanam-do", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seoul (S)", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ulsan (M)", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Malaysia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Johor", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kedah", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kelantan", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kuala Lumpur", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Labuan", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melaka", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negeri Sembilan", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pahang", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perak", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perlis", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pulau Pinang", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putrajaya", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sabah", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarawak", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Selangor", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terengganu", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Mexico")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aguascalientes", French = "", Code = "AGU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California", French = "", Code = "BCN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California Sur", French = "", Code = "BCS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campeche", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiapas", French = "", Code = "CHP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chihuahua", French = "", Code = "CHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coahuila", French = "", Code = "COA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colima", French = "", Code = "COL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durango", French = "", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guanajuato", French = "", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guerrero", French = "", Code = "GRO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hidalgo", French = "", Code = "HID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jalisco", French = "", Code = "JAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mexico", French = "", Code = "MEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michoacán", French = "", Code = "MIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morelos", French = "", Code = "MOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nayarit", French = "", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuevo León", French = "", Code = "NLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oaxaca", French = "", Code = "OAX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puebla", French = "", Code = "PUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Querétaro", French = "", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quintana Roo", French = "", Code = "ROO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis Potosí", French = "", Code = "SLP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinaloa", French = "", Code = "SIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sonora", French = "", Code = "SON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tabasco", French = "", Code = "TAB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamaulipas", French = "", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tlaxcala", French = "", Code = "TLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veracruz", French = "", Code = "VER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yucatán", French = "", Code = "YUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zacatecas", French = "", Code = "ZAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Netherlands")
            {
                return new List<Province>()
                {
                    new Province() { English = "Drenthe", French = "", Code = "DR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flevoland", French = "", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Friesland", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gelderland", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Groningen", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Brabant", French = "", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Holland", French = "", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Overijssel", French = "", Code = "OV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utrecht", French = "", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zeeland", French = "", Code = "ZE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zuid Holland", French = "", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Norway")
            {
                return new List<Province>()
                {
                    new Province() { English = "Akershus", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aust-Agder", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buskerud", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finnmark", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hedmark", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hordaland", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Møre og Romsdal", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nordland", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord-Trøndelag", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oppland", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oslo", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Østfold", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rogaland", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sogn og Fjordane", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sør-Trøndelag", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telemark", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Troms", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vest-Agder", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestfold", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Philippines")
            {
                return new List<Province>()
                {
                    new Province() { English = "Abra", French = "", Code = "ABR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Norte", French = "", Code = "AGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Sur", French = "", Code = "AGS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aklan", French = "", Code = "AKL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albay", French = "", Code = "ALB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antique", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Apayao", French = "", Code = "APA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aurora", French = "", Code = "AUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Autonomous Region in Muslim Mindanao (ARMM)", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basilan", French = "", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bataan", French = "", Code = "BAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batanes", French = "", Code = "BTN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batangas", French = "", Code = "BTG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benguet", French = "", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bicol", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biliran", French = "", Code = "BIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bohol", French = "", Code = "BOH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bukidnon", French = "", Code = "BUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bulacan", French = "", Code = "BUL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan", French = "", Code = "CAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan Valley", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Norte", French = "", Code = "CAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Sur", French = "", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camiguin", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capiz", French = "", Code = "CAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "CARAGA", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanduanes", French = "", Code = "CAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cavite", French = "", Code = "CAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cebu", French = "", Code = "CEB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Luzon", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Mindanao", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Visayas", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Compostela Valley", French = "", Code = "COM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cordillera Administrative Region (CAR)", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cotabato (North Cotabato)", French = "", Code = "NCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Norte", French = "", Code = "DAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Sur", French = "", Code = "DAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao Oriental", French = "", Code = "DAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Samar", French = "", Code = "EAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Visayas", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guimaras", French = "", Code = "GUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ifugao", French = "", Code = "IFU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Norte", French = "", Code = "ILN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Sur", French = "", Code = "ILS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iloilo", French = "", Code = "ILI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isabela", French = "", Code = "ISA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalinga", French = "", Code = "KAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Union", French = "", Code = "LUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laguna", French = "", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Norte", French = "", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Sur", French = "", Code = "LAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leyte", French = "", Code = "LEY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maguindanao", French = "", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marinduque", French = "", Code = "MAD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Masbate", French = "", Code = "MAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Occidental", French = "", Code = "MDC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Oriental", French = "", Code = "MDR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Occidental", French = "", Code = "MSC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Oriental", French = "", Code = "MSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mountain Province", French = "", Code = "MOU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "National Capital Region (Manila)", French = "", Code = "00", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Occidental", French = "", Code = "NEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Oriental", French = "", Code = "NER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mindanao", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Samar", French = "", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Ecija", French = "", Code = "NUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Vizcaya", French = "", Code = "NUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palawan", French = "", Code = "PLW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pampanga", French = "", Code = "PAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pangasinan", French = "", Code = "PAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quezon", French = "", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quirino", French = "", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rizal", French = "", Code = "RIZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Romblon", French = "", Code = "ROM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samar (Western Samar)", French = "", Code = "WSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarangani", French = "", Code = "SAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siquijor", French = "", Code = "SIG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sorsogon", French = "", Code = "SOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Cotabato", French = "", Code = "SCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Leyte", French = "", Code = "SLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Mindanao", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Tagalog", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sultan Kudarat", French = "", Code = "SUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sulu", French = "", Code = "SLU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Norte", French = "", Code = "SUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Sur", French = "", Code = "SUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarlac", French = "", Code = "TAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tawi-Tawi", French = "", Code = "TAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Mindanao", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Visayas", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zambales", French = "", Code = "ZMB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Norte", French = "", Code = "ZAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Sur", French = "", Code = "ZAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga Sibugay", French = "", Code = "ZSI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Poland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Dolnoslaskie", French = "", Code = "DS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kujawsko-pomorskie", French = "", Code = "KP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lódzkie", French = "", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubelskie", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubuskie", French = "", Code = "LB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malopolskie", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mazowieckie", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Opolskie", French = "", Code = "OP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podkarpackie", French = "", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podlaskie", French = "", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pomorskie", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slaskie", French = "", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swietokrzyskie", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warminsko-mazurskie", French = "", Code = "WN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wielkopolskie", French = "", Code = "WP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zachodniopomorskie", French = "", Code = "ZP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Romania")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alba", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arad", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arges", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bacau", French = "", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihor", French = "", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bistrita-Nasaud", French = "", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Botosani", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Braila", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brasov", French = "", Code = "BV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bucuresti", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buzau", French = "", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calarasi", French = "", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caras-Severin", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cluj", French = "", Code = "CJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Constanta", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Covasna", French = "", Code = "CV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dâmbovita", French = "", Code = "DB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dolj", French = "", Code = "DJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Galati", French = "", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giurgiu", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorj", French = "", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harghita", French = "", Code = "HG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunedoara", French = "", Code = "HD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ialomita", French = "", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iasi", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilfov", French = "", Code = "IF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maramures", French = "", Code = "MM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mehedinti", French = "", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mures", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neamt", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olt", French = "", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prahova", French = "", Code = "PH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salaj", French = "", Code = "SJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satu Mare", French = "", Code = "SM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sibiu", French = "", Code = "SB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suceava", French = "", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teleorman", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Timis", French = "", Code = "TM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tulcea", French = "", Code = "TL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vâlcea", French = "", Code = "VL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaslui", French = "", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vrancea", French = "", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Spain")
            {
                return new List<Province>()
                {
                    new Province() { English = "A Coruña", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Álava", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albacete", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alicante", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Almería", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asturias", French = "", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ávila", French = "", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Badajoz", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baleares", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barcelona", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgos", French = "", Code = "BU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cáceres", French = "", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cádiz", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantabria", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castellón", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceuta", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ciudad Real", French = "", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuenca", French = "", Code = "CU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Girona", French = "", Code = "GI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Granada", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guadalajara", French = "", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guipúzcoa", French = "", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huelva", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huesca", French = "", Code = "HU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jaén", French = "", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Las Palmas", French = "", Code = "GC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "León", French = "", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lleida", French = "", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lugo", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madrid", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Málaga", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melilla", French = "", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Murcia", French = "", Code = "MU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Navarre", French = "", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ourense", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palencia", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pontevedra", French = "", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salamanca", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz De Tenerife", French = "", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Segovia", French = "", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seville", French = "", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Soria", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarragona", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teruel", French = "", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toledo", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valencia", French = "", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valladolid", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vizcaya", French = "", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamora", French = "", Code = "ZA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zaragoza", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Sweden")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blekinge", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dalarna", French = "", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gävleborg", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gotland", French = "", Code = "I", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halland", French = "", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jämtland", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jönköping", French = "", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalmar", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kronoberg", French = "", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norrbotten", French = "", Code = "BD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Örebro", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Östergötland", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Skåne", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Södermanland", French = "", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockholm", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uppsala", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Värmland", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västerbotten", French = "", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västernorrland", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västmanland", French = "", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västra Götaland", French = "", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Switzerland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aargau (Argovia)", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Ausserrhoden (Outer Rhodes)", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Innerrhoden (Inner Rhodes)", French = "", Code = "AI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Landschaft (Basle-Country)", French = "", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Stadt (Basle-City)", French = "", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bern (Berne)", French = "", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fribourg", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Geneva", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glarus", French = "", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Graubünden (Grisons)", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucerne", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuchâtel", French = "", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nidwalden (Nidwald)", French = "", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Obwalden (Obwald)", French = "", Code = "OW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schaffhausen", French = "", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schwyz", French = "", Code = "SZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solothurn", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "St. Gallen (St. Gall)", French = "", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurgau (Thurgovia)", French = "", Code = "TG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ticino", French = "", Code = "TI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uri", French = "", Code = "UR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valais", French = "", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaud", French = "", Code = "VD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zug", French = "", Code = "ZG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zürich (Zurich)", French = "", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Thailand")
            {
                return new List<Province>()
                {
                    new Province() { English = "Amnat Charoen", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ang Thong", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bangkok", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buri Ram", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chachoengsao", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chai Nat", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaiyaphum", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chanthaburi", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Mai", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Rai", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chon Buri", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chumpon", French = "", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalasin", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kamphaeng Phet", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanchanaburi", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Khon Kaen", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Krabi", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lampang", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lamphun", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loei", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lop Buri", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mae Hong Son", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maha Sarakham", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mukdahan", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Nayok", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Pathom", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Phanom", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Ratchasima", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Sawan", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Si Thammarat", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nan", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Narathiwat", French = "", Code = "96", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Bua Lam Phu", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Khai", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nonthaburi", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pathum Thani", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattani", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattaya", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phang Nga", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phattalung", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phayao", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchabun", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchaburi", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phichit", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phitsanulok", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phra Nakhon Si Ayutthaya", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phrae", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phuket", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachin Buri", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachuap Khiri Khan", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ranong", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ratchaburi", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rayong", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roi Et", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sa Kaeo", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakon Nakhon", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Prakan", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Sakhon", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Songkhram", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saraburi", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satun", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Si Sa Ket", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sing Buri", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Songkhla", French = "", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sukhothai", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suphanburi", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surat Thani", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surin", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tak", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trang", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trat", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ubon Ratchathani", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udon Thani", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uthai Thani", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaradit", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yala", French = "", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yasothon", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Turkey")
            {
                return new List<Province>()
                {
                    new Province() { English = "Adana", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Adiyaman", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Afyonkarahisar", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agri", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aksaray", French = "", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amasya", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ankara", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antalya", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardahan", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Artvin", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aydin", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Balikesir", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bartin", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batman", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bayburt", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bilecik", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bingöl", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bitlis", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolu", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burdur", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bursa", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çanakkale", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çankiri", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çorum", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denizli", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Diyarbakir", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Düzce", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edirne", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Elazig", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzincan", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzurum", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eskisehir", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gaziantep", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giresun", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gümüshane", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hakkari", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hatay", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Igdir", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isparta", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Istanbul", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Izmir", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kahramanmaras", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karabük", French = "", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karaman", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kars", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastamonu", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kayseri", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilis", French = "", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirikkale", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklareli", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirsehir", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kocaeli", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Konya", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kütahya", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malatya", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manisa", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mardin", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mersin", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mugla", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mus", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevsehir", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nigde", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ordu", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osmaniye", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rize", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakarya", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samsun", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sanliurfa", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siirt", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinop", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sirnak", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sivas", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tekirdag", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokat", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trabzon", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tunceli", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Usak", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Van", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yalova", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yozgat", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zonguldak", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United Kingdom")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aberdeen", French = "", Code = "ABE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aberdeenshire", French = "", Code = "ABD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Angus", French = "", Code = "ANS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antrim", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ards", French = "", Code = "ARD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argyll and Bute", French = "", Code = "AGB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Armagh", French = "", Code = "ARM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymena", French = "", Code = "BLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymoney", French = "", Code = "BLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Banbridge", French = "", Code = "BNB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barking and Dagenham (London borough)", French = "", Code = "BDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnet (London borough)", French = "", Code = "BNE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnsley (South Yorkshire district)", French = "", Code = "BNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bath and North East Somerset (unitary authority)", French = "", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bedfordshire (county)", French = "", Code = "BDF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belfast", French = "", Code = "BFS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bexley (London borough)", French = "", Code = "BEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Birmingham (West Midlands district)", French = "", Code = "BIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackburn with Darwen (unitary authority)", French = "", Code = "BBD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackpool (unitary authority)", French = "", Code = "BPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blaenau Gwent", French = "", Code = "BGW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolton (Greater Manchester district)", French = "", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bournemouth (unitary authority)", French = "", Code = "BMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bracknell Forest (unitary authority)", French = "", Code = "BRC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bradford (West Yorkshire district)", French = "", Code = "BRD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brent (London borough)", French = "", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bridgend", French = "", Code = "BGE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brighton and Hove (unitary authority)", French = "", Code = "BNH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bristol, City of (unitary authority)", French = "", Code = "BST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bromley (London borough)", French = "", Code = "BRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buckinghamshire (county)", French = "", Code = "BKM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bury (Greater Manchester district)", French = "", Code = "BUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caerphilly", French = "", Code = "CAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calderdale (West Yorkshire district)", French = "", Code = "CLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cambridgeshire (county)", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camden (London borough)", French = "", Code = "CMD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cardiff", French = "", Code = "CRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carmarthenshire", French = "", Code = "CMN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carrickfergus", French = "", Code = "CKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castelreagh", French = "", Code = "CSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceredigion", French = "", Code = "CGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cheshire (county)", French = "", Code = "CHS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Clackmannanshire", French = "", Code = "CLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coleraine", French = "", Code = "CLR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Conwy", French = "", Code = "CWY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cookstown", French = "", Code = "CKT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cornwall (county)", French = "", Code = "CON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coventry (West Midlands district)", French = "", Code = "COV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Craigavon", French = "", Code = "CGV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Croydon (London borough)", French = "", Code = "CRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cumbria (county)", French = "", Code = "CMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Darlington (unitary authority)", French = "", Code = "DAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denbighshire", French = "", Code = "DEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derby (unitary authority)", French = "", Code = "DER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derbyshire (county)", French = "", Code = "DBY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derry", French = "", Code = "DRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Devon (county)", French = "", Code = "DEV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doncaster (South Yorkshire district)", French = "", Code = "DNC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dorset (county)", French = "", Code = "DOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Down", French = "", Code = "DOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dudley (West Midlands district)", French = "", Code = "DUD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dumfries and Galloway", French = "", Code = "DGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dundee", French = "", Code = "DND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dungannon and South Tyrone", French = "", Code = "DGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durham (county)", French = "", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ealing (London borough)", French = "", Code = "EAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Ayrshire", French = "", Code = "EAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Dunbartonshire", French = "", Code = "EDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Lothian", French = "", Code = "ELN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Renfrewshire", French = "", Code = "ERW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Riding of Yorkshire (unitary authority)", French = "", Code = "ERY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Sussex (county)", French = "", Code = "ESX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edinburgh", French = "", Code = "EDH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eilean Siar", French = "", Code = "ELS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enfield (London borough)", French = "", Code = "ENF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essex (county)", French = "", Code = "ESS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Falkirk", French = "", Code = "FAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermanagh", French = "", Code = "FER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fife", French = "", Code = "FIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flintshire", French = "", Code = "FLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gateshead (Tyne & Wear district)", French = "", Code = "GAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glasgow", French = "", Code = "GLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gloucestershire (county)", French = "", Code = "GLS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Greenwich (London borough)", French = "", Code = "GRE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guernsey", French = "", Code = "GSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwynedd", French = "", Code = "GWN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hackney (London borough)", French = "", Code = "HCK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halton (unitary authority)", French = "", Code = "HAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hammersmith and Fulham (London borough)", French = "", Code = "HMF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hampshire (county)", French = "", Code = "HAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haringey (London borough)", French = "", Code = "HRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harrow (London borough)", French = "", Code = "HRW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hartlepool (unitary authority)", French = "", Code = "HPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Havering (London borough)", French = "", Code = "HAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Herefordshire, County of (unitary authority)", French = "", Code = "HEF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hertfordshire (county)", French = "", Code = "HRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Highland", French = "", Code = "HLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hillingdon (London borough)", French = "", Code = "HIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hounslow (London borough)", French = "", Code = "HNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Inverclyde", French = "", Code = "IVC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Anglesey", French = "", Code = "AGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Wight (unitary authority)", French = "", Code = "IOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isles of Scilly (special area)", French = "", Code = "IOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Islington (London borough)", French = "", Code = "ISL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jersey", French = "", Code = "JSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kensington and Chelsea (London borough)", French = "", Code = "KEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kent (county)", French = "", Code = "KEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Hull, City of (unitary authority)", French = "", Code = "KHL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Thames (London borough)", French = "", Code = "KTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklees (West Yorkshire district)", French = "", Code = "KIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Knowsley (Merseyside district)", French = "", Code = "KWL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lambeth (London borough)", French = "", Code = "LBH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lancashire (county)", French = "", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larne", French = "", Code = "LRN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leeds (West Yorkshire district)", French = "", Code = "LDS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicester (unitary authority)", French = "", Code = "LCE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicestershire (county)", French = "", Code = "LEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lewisham (London borough)", French = "", Code = "LEW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limavady", French = "", Code = "LMV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lincolnshire (county)", French = "", Code = "LIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lisburn", French = "", Code = "LSB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liverpool (Merseyside district)", French = "", Code = "LIV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "London, City of (London borough)", French = "", Code = "LND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luton (unitary authority)", French = "", Code = "LUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magherafelt", French = "", Code = "MFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manchester (Greater Manchester district)", French = "", Code = "MAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medway (unitary authority)", French = "", Code = "MDW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merthyr Tydfil", French = "", Code = "MTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merton (London borough)", French = "", Code = "MRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Middlesbrough (unitary authority)", French = "", Code = "MDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Midlothian", French = "", Code = "MLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milton Keynes (unitary authority)", French = "", Code = "MIK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monmouthshire", French = "", Code = "MON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moray", French = "", Code = "MRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moyle", French = "", Code = "MYL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neath Port Talbot", French = "", Code = "NTL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newcastle upon Tyne (Tyne & Wear district)", French = "", Code = "NET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newham (London borough)", French = "", Code = "NWM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newport", French = "", Code = "NWP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newry and Mourne", French = "", Code = "NYM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newtownabbey", French = "", Code = "NTA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norfolk (county)", French = "", Code = "NFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Ayrshire", French = "", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Down", French = "", Code = "NDN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North East Lincolnshire (unitary authority)", French = "", Code = "NEL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lanarkshire", French = "", Code = "NLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lincolnshire (unitary authority)", French = "", Code = "NLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Somerset (unitary authority)", French = "", Code = "NSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Tyneside (Tyne & Wear district)", French = "", Code = "NTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Yorkshire (county)", French = "", Code = "NYK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northamptonshire (county)", French = "", Code = "NTH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northumberland (county)", French = "", Code = "NBL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottingham (unitary authority)", French = "", Code = "NGM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottinghamshire (county)", French = "", Code = "NTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oldham (Greater Manchester district)", French = "", Code = "OLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Omagh", French = "", Code = "OMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orkney Islands", French = "", Code = "ORK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oxfordshire (county)", French = "", Code = "OXF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pembrokeshire", French = "", Code = "PEM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perth and Kinross", French = "", Code = "PKN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Peterborough (unitary authority)", French = "", Code = "PTE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plymouth (unitary authority)", French = "", Code = "PLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Poole (unitary authority)", French = "", Code = "POL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Portsmouth (unitary authority)", French = "", Code = "POR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Powys", French = "", Code = "POW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reading (unitary authority)", French = "", Code = "RDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redbridge (London borough)", French = "", Code = "RDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redcar and Cleveland (unitary authority)", French = "", Code = "RCC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Renfrewshire", French = "", Code = "RFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhondda Cynon Taf", French = "", Code = "RCT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Richmond upon Thames (London borough)", French = "", Code = "RIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rochdale (Greater Manchester district)", French = "", Code = "RCH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rotherham (South Yorkshire district)", French = "", Code = "ROT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rutland (unitary authority)", French = "", Code = "RUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salford (Greater Manchester district)", French = "", Code = "SLF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sandwell (West Midlands district)", French = "", Code = "SAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Scottish Borders, The", French = "", Code = "SCB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sefton (Merseyside district)", French = "", Code = "SFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sheffield (South Yorkshire district)", French = "", Code = "SHF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shetland Islands", French = "", Code = "ZET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shropshire (county)", French = "", Code = "SHR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slough (unitary authority)", French = "", Code = "SLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solihull (West Midlands district)", French = "", Code = "SOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somerset (county)", French = "", Code = "SOM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Ayrshire", French = "", Code = "SAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Gloucestershire (unitary authority)", French = "", Code = "SGC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Lanarkshire", French = "", Code = "SLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Tyneside (Tyne & Wear district)", French = "", Code = "STY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southampton (unitary authority)", French = "", Code = "STH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southend-on-Sea (unitary authority)", French = "", Code = "SOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southwark (London borough)", French = "", Code = "SWK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "St Helens (Merseyside district)", French = "", Code = "SHN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Staffordshire (county)", French = "", Code = "STS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stirling", French = "", Code = "STG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockport (Greater Manchester district)", French = "", Code = "SKP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockton-on-Tees (unitary authority)", French = "", Code = "STT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stoke-on-Trent (unitary authority)", French = "", Code = "STE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Strabane", French = "", Code = "STB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suffolk (county)", French = "", Code = "SFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sunderland (Tyne & Wear district)", French = "", Code = "SND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surrey (county)", French = "", Code = "SRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sutton (London borough)", French = "", Code = "STN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swansea", French = "", Code = "SWA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swindon (unitary authority)", French = "", Code = "SWD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tameside (Greater Manchester district)", French = "", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telford and Wrekin (unitary authority)", French = "", Code = "TFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurrock (unitary authority)", French = "", Code = "THR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torbay (unitary authority)", French = "", Code = "TOB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torfaen", French = "", Code = "TOF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tower Hamlets (London borough)", French = "", Code = "TWH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trafford (Greater Manchester district)", French = "", Code = "TRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vale of Glamorgan", French = "", Code = "VGL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakefield (West Yorkshire district)", French = "", Code = "WKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Walsall (West Midlands district)", French = "", Code = "WLL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Waltham Forest (London borough)", French = "", Code = "WFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wandsworth (London borough)", French = "", Code = "WND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warrington (unitary authority)", French = "", Code = "WRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warwickshire (county)", French = "", Code = "WAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Berkshire (unitary authority)", French = "", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Dunbartonshire", French = "", Code = "WDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Lothian", French = "", Code = "WLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Sussex (county)", French = "", Code = "WSX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Westminster (London borough)", French = "", Code = "WSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wigan (Greater Manchester district)", French = "", Code = "WGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wiltshire (county)", French = "", Code = "WIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Windsor and Maidenhead (unitary authority)", French = "", Code = "WNM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wirral (Merseyside district)", French = "", Code = "WRL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wokingham (unitary authority)", French = "", Code = "WOK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wolverhampton (West Midlands district)", French = "", Code = "WLV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Worcestershire (county)", French = "", Code = "WOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wrexham", French = "", Code = "WRX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "York (unitary authority)", French = "", Code = "YOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United States")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alabama", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alaska", French = "", Code = "AK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "American Samoa", French = "", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arizona", French = "", Code = "AZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arkansas", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "California", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colorado", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Connecticut", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delaware", French = "", Code = "DE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "District of Columbia", French = "", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florida", French = "", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Georgia", French = "", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guam", French = "", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hawaii", French = "", Code = "HI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Idaho", French = "", Code = "ID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Illinois", French = "", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indiana", French = "", Code = "IN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iowa", French = "", Code = "IA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kansas", French = "", Code = "KS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kentucky", French = "", Code = "KY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Louisiana", French = "", Code = "LA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine", French = "", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maryland", French = "", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massachusetts", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michigan", French = "", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minnesota", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mississippi", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Missouri", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nebraska", French = "", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevada", French = "", Code = "NV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Hampshire", French = "", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Jersey", French = "", Code = "NJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Mexico", French = "", Code = "NM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New York", French = "", Code = "NY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Carolina", French = "", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Dakota", French = "", Code = "ND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mariana Islands", French = "", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ohio", French = "", Code = "OH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oklahoma", French = "", Code = "OK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oregon", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pennsylvania", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puerto Rico", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhode Island", French = "", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Carolina", French = "", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Dakota", French = "", Code = "SD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tennessee", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Texas", French = "", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "U.S. Minor Outlying Islands", French = "", Code = "UM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utah", French = "", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vermont", French = "", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virgin Islands of the U.S.", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virginia", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Washington", French = "", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Virginia", French = "", Code = "WV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wisconsin", French = "", Code = "WI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wyoming", French = "", Code = "WY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
                }.OrderBy(t => t.English);
            }
            else
            {
                return new List<Province>()
                {
                }.OrderBy(t => t.English);
            }
        }

        static IEnumerable<SystemConfigurations> GetPreconfiguredSystemConfigurations()
        {
            return new List<SystemConfigurations>()
            {
                new SystemConfigurations() { FieldName = "Host", FieldValue = @"https://romedev.lab.phri.ca/purchaseorders/", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new SystemConfigurations() { FieldName = "InvoiceURL", FieldValue = @"https://romedev.lab.phri.ca/purchaseorders/download/invoices/", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
            }.OrderBy(t => t.FieldName);
        }
    }
}
