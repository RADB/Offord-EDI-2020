using Microsoft.Extensions.Logging;
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

                    var countryid = ServiceContext.Countries.Where(t => t.Name == "Argentina").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Argentina"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Australia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Australia"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Austria").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Austria"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Belgium").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Belgium"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Brazil").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Brazil"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Bulgaria").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Bulgaria"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Canada").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(provincetypeid, countryid, "Canada"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "China").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "China"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Taiwan, Province of China").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Taiwan, Province of China"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Colombia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Colombia"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Czech Republic").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Czech Republic"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Denmark").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Denmark"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Finland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Finland"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "France").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "France"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Germany").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Germany"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Greece").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Greece"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "India").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "India"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Italy").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Italy"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Japan").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Japan"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Korea, Republic of").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Korea, Republic of"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Malaysia").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Malaysia"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Mexico").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Mexico"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Netherlands").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Netherlands"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Norway").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Norway"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Philippines").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Philippines"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Poland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Poland"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Romania").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Romania"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Spain").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Spain"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Sweden").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Sweden"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Switzerland").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Switzerland"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Thailand").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Thailand"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "Turkey").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "Turkey"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "United Kingdom").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(1, countryid, "United Kingdom"));

                    countryid = ServiceContext.Countries.Where(t => t.Name == "United States").Select(t => t.Id).FirstOrDefault();

                    ServiceContext.Provinces.AddRange(
                        GetPreconfiguredAllProvinces(statetypeid, countryid, "United States"));

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.SystemConfigurations.Any())
                {
                    ServiceContext.SystemConfigurations.AddRange(
                        GetPreconfiguredSystemConfigurations());

                    await ServiceContext.SaveChangesAsync();
                }
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

        static IEnumerable<Countries> GetPreconfiguredAllCountries()
        {
            return new List<Countries>()
            {
                new Countries() { Name = "Afghanistan", ISO3DigitCountry=4, ISO2CountryCode="AF", ISO3CountryCode = "AFG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Albania", ISO3DigitCountry=8, ISO2CountryCode="AL", ISO3CountryCode = "ALB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Antarctica", ISO3DigitCountry=10, ISO2CountryCode="AQ", ISO3CountryCode = "ATA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Algeria", ISO3DigitCountry=12, ISO2CountryCode="DZ", ISO3CountryCode = "DZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "American Samoa", ISO3DigitCountry=16, ISO2CountryCode="AS", ISO3CountryCode = "ASM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Andorra", ISO3DigitCountry=20, ISO2CountryCode="AD", ISO3CountryCode = "AND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Angola", ISO3DigitCountry=24, ISO2CountryCode="AO", ISO3CountryCode = "AGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Antigua and Barbuda", ISO3DigitCountry=28, ISO2CountryCode="AG", ISO3CountryCode = "ATG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Azerbaijan", ISO3DigitCountry=31, ISO2CountryCode="AZ", ISO3CountryCode = "AZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Argentina", ISO3DigitCountry=32, ISO2CountryCode="AR", ISO3CountryCode = "ARG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Australia", ISO3DigitCountry=36, ISO2CountryCode="AU", ISO3CountryCode = "AUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Austria", ISO3DigitCountry=40, ISO2CountryCode="AT", ISO3CountryCode = "AUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bahamas", ISO3DigitCountry=44, ISO2CountryCode="BS", ISO3CountryCode = "BHS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bahrain", ISO3DigitCountry=48, ISO2CountryCode="BH", ISO3CountryCode = "BHR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bangladesh", ISO3DigitCountry=50, ISO2CountryCode="BD", ISO3CountryCode = "BGD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Armenia", ISO3DigitCountry=51, ISO2CountryCode="AM", ISO3CountryCode = "ARM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Barbados", ISO3DigitCountry=52, ISO2CountryCode="BB", ISO3CountryCode = "BRB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Belgium", ISO3DigitCountry=56, ISO2CountryCode="BE", ISO3CountryCode = "BEL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bermuda", ISO3DigitCountry=60, ISO2CountryCode="BM", ISO3CountryCode = "BMU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bhutan", ISO3DigitCountry=64, ISO2CountryCode="BT", ISO3CountryCode = "BTN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bolivia", ISO3DigitCountry=68, ISO2CountryCode="BO", ISO3CountryCode = "BOL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bosnia and Herzegovina", ISO3DigitCountry=70, ISO2CountryCode="BA", ISO3CountryCode = "BIH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Botswana", ISO3DigitCountry=72, ISO2CountryCode="BW", ISO3CountryCode = "BWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bouvet Island", ISO3DigitCountry=74, ISO2CountryCode="BV", ISO3CountryCode = "BVT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Brazil", ISO3DigitCountry=76, ISO2CountryCode="BR", ISO3CountryCode = "BRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Belize", ISO3DigitCountry=84, ISO2CountryCode="BZ", ISO3CountryCode = "BLZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "British Indian Ocean Territory", ISO3DigitCountry=86, ISO2CountryCode="IO", ISO3CountryCode = "IOT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Solomon Islands", ISO3DigitCountry=90, ISO2CountryCode="SB", ISO3CountryCode = "SLB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "British Virgin Islands", ISO3DigitCountry=92, ISO2CountryCode="VG", ISO3CountryCode = "VGB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Brunei Darussalam", ISO3DigitCountry=96, ISO2CountryCode="BN", ISO3CountryCode = "BRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Bulgaria", ISO3DigitCountry=100, ISO2CountryCode="BG", ISO3CountryCode = "BGR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Myanmar", ISO3DigitCountry=104, ISO2CountryCode="MM", ISO3CountryCode = "MMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Burundi", ISO3DigitCountry=108, ISO2CountryCode="BI", ISO3CountryCode = "BDI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Belarus", ISO3DigitCountry=112, ISO2CountryCode="BY", ISO3CountryCode = "BLR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cambodia", ISO3DigitCountry=116, ISO2CountryCode="KH", ISO3CountryCode = "KHM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cameroon", ISO3DigitCountry=120, ISO2CountryCode="CM", ISO3CountryCode = "CMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cape Verde", ISO3DigitCountry=132, ISO2CountryCode="CV", ISO3CountryCode = "CPV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cayman Islands", ISO3DigitCountry=136, ISO2CountryCode="KY", ISO3CountryCode = "CYM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Central African Republic", ISO3DigitCountry=140, ISO2CountryCode="CF", ISO3CountryCode = "CAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Sri Lanka", ISO3DigitCountry=144, ISO2CountryCode="LK", ISO3CountryCode = "LKA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Canada", ISO3DigitCountry=124, ISO2CountryCode="CA", ISO3CountryCode = "CAN", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new Countries() { Name = "Chad", ISO3DigitCountry=148, ISO2CountryCode="TD", ISO3CountryCode = "TCD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Chile", ISO3DigitCountry=152, ISO2CountryCode="CL", ISO3CountryCode = "CHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "China", ISO3DigitCountry=156, ISO2CountryCode="CN", ISO3CountryCode = "CHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Taiwan, Province of China", ISO3DigitCountry=158, ISO2CountryCode="TW", ISO3CountryCode = "TWN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Christmas Island", ISO3DigitCountry=162, ISO2CountryCode="CX", ISO3CountryCode = "CXR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cocos (Keeling) Islands", ISO3DigitCountry=166, ISO2CountryCode="CC", ISO3CountryCode = "CCK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Colombia", ISO3DigitCountry=170, ISO2CountryCode="CO", ISO3CountryCode = "COL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Comoros", ISO3DigitCountry=174, ISO2CountryCode="KM", ISO3CountryCode = "COM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mayotte", ISO3DigitCountry=175, ISO2CountryCode="YT", ISO3CountryCode = "MYT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Congo", ISO3DigitCountry=178, ISO2CountryCode="CG", ISO3CountryCode = "COG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Congo, The Democratic Republic Of The (Zaire)", ISO3DigitCountry=180, ISO2CountryCode="CD", ISO3CountryCode = "COD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cook Islands", ISO3DigitCountry=184, ISO2CountryCode="CK", ISO3CountryCode = "COK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Costa Rica", ISO3DigitCountry=188, ISO2CountryCode="CR", ISO3CountryCode = "CRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Croatia", ISO3DigitCountry=191, ISO2CountryCode="HR", ISO3CountryCode = "HRV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cuba", ISO3DigitCountry=192, ISO2CountryCode="CU", ISO3CountryCode = "CUB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Cyprus", ISO3DigitCountry=196, ISO2CountryCode="CY", ISO3CountryCode = "CYP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Czech Republic", ISO3DigitCountry=203, ISO2CountryCode="CZ", ISO3CountryCode = "CZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Benin", ISO3DigitCountry=204, ISO2CountryCode="BJ", ISO3CountryCode = "BEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Denmark", ISO3DigitCountry=208, ISO2CountryCode="DK", ISO3CountryCode = "DNK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Dominica", ISO3DigitCountry=212, ISO2CountryCode="DM", ISO3CountryCode = "DMA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Dominican Republic", ISO3DigitCountry=214, ISO2CountryCode="DO", ISO3CountryCode = "DOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ecuador", ISO3DigitCountry=218, ISO2CountryCode="EC", ISO3CountryCode = "ECU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "El Salvador", ISO3DigitCountry=222, ISO2CountryCode="SV", ISO3CountryCode = "SLV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Equatorial Guinea", ISO3DigitCountry=226, ISO2CountryCode="GQ", ISO3CountryCode = "GNQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ethiopia", ISO3DigitCountry=231, ISO2CountryCode="ET", ISO3CountryCode = "ETH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Eritrea", ISO3DigitCountry=232, ISO2CountryCode="ER", ISO3CountryCode = "ERI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Estonia", ISO3DigitCountry=233, ISO2CountryCode="EE", ISO3CountryCode = "EST",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Faroe Islands", ISO3DigitCountry=234, ISO2CountryCode="FO", ISO3CountryCode = "FRO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Falkland Islands (Malvinas)", ISO3DigitCountry=238, ISO2CountryCode="FK", ISO3CountryCode = "FLK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "South Georgia and the South Sandwich Islands", ISO3DigitCountry=239, ISO2CountryCode="GS", ISO3CountryCode = "SGS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Fiji", ISO3DigitCountry=242, ISO2CountryCode="FJ", ISO3CountryCode = "FJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Finland", ISO3DigitCountry=246, ISO2CountryCode="FI", ISO3CountryCode = "FIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Aland Islands", ISO3DigitCountry=248, ISO2CountryCode="AX", ISO3CountryCode = "ALA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "France", ISO3DigitCountry=250, ISO2CountryCode="FR", ISO3CountryCode = "FRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "French Guiana", ISO3DigitCountry=254, ISO2CountryCode="GF", ISO3CountryCode = "GUF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "French Polynesia", ISO3DigitCountry=258, ISO2CountryCode="PF", ISO3CountryCode = "PYF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "French Southern Territories", ISO3DigitCountry=260, ISO2CountryCode="TF", ISO3CountryCode = "ATF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Djibouti", ISO3DigitCountry=262, ISO2CountryCode="DJ", ISO3CountryCode = "DJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Gabon", ISO3DigitCountry=266, ISO2CountryCode="GA", ISO3CountryCode = "GAB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Georgia", ISO3DigitCountry=268, ISO2CountryCode="GE", ISO3CountryCode = "GEO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Gambia", ISO3DigitCountry=270, ISO2CountryCode="GM", ISO3CountryCode = "GMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Palestinian Territory, Occupied", ISO3DigitCountry=275, ISO2CountryCode="PS", ISO3CountryCode = "PSE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Germany", ISO3DigitCountry=276, ISO2CountryCode="DE", ISO3CountryCode = "DEU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ghana", ISO3DigitCountry=288, ISO2CountryCode="GH", ISO3CountryCode = "GHA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Gibraltar", ISO3DigitCountry=292, ISO2CountryCode="GI", ISO3CountryCode = "GIB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Kiribati", ISO3DigitCountry=296, ISO2CountryCode="KI", ISO3CountryCode = "KIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Greece", ISO3DigitCountry=300, ISO2CountryCode="GR", ISO3CountryCode = "GRC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Greenland", ISO3DigitCountry=304, ISO2CountryCode="GL", ISO3CountryCode = "GRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Grenada", ISO3DigitCountry=308, ISO2CountryCode="GD", ISO3CountryCode = "GRD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guadeloupe", ISO3DigitCountry=312, ISO2CountryCode="GP", ISO3CountryCode = "GLP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guam", ISO3DigitCountry=316, ISO2CountryCode="GU", ISO3CountryCode = "GUM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guatemala", ISO3DigitCountry=320, ISO2CountryCode="GT", ISO3CountryCode = "GTM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guinea", ISO3DigitCountry=324, ISO2CountryCode="GN", ISO3CountryCode = "GIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guyana", ISO3DigitCountry=328, ISO2CountryCode="GY", ISO3CountryCode = "GUY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Haiti", ISO3DigitCountry=332, ISO2CountryCode="HT", ISO3CountryCode = "HTI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Heard Island and McDonald Islands", ISO3DigitCountry=334, ISO2CountryCode="HM", ISO3CountryCode = "HMD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Holy See (Vatican City State)", ISO3DigitCountry=336, ISO2CountryCode="VA", ISO3CountryCode = "VAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Honduras", ISO3DigitCountry=340, ISO2CountryCode="HN", ISO3CountryCode = "HND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Hong Kong", ISO3DigitCountry=344, ISO2CountryCode="HK", ISO3CountryCode = "HKG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Hungary", ISO3DigitCountry=348, ISO2CountryCode="HU", ISO3CountryCode = "HUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Iceland", ISO3DigitCountry=352, ISO2CountryCode="IS", ISO3CountryCode = "ISL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "India", ISO3DigitCountry=356, ISO2CountryCode="IN", ISO3CountryCode = "IND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Indonesia", ISO3DigitCountry=360, ISO2CountryCode="ID", ISO3CountryCode = "IDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Iran, Islamic Republic of ", ISO3DigitCountry=364, ISO2CountryCode="IR", ISO3CountryCode = "IRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Iraq", ISO3DigitCountry=368, ISO2CountryCode="IQ", ISO3CountryCode = "IRQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ireland", ISO3DigitCountry=372, ISO2CountryCode="IE", ISO3CountryCode = "IRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Israel", ISO3DigitCountry=376, ISO2CountryCode="IL", ISO3CountryCode = "ISR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Italy", ISO3DigitCountry=380, ISO2CountryCode="IT", ISO3CountryCode = "ITA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ivory Coast", ISO3DigitCountry=384, ISO2CountryCode="CI", ISO3CountryCode = "CIV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Jamaica", ISO3DigitCountry=388, ISO2CountryCode="JM", ISO3CountryCode = "JAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Japan", ISO3DigitCountry=392, ISO2CountryCode="JP", ISO3CountryCode = "JPN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Kazakstan", ISO3DigitCountry=398, ISO2CountryCode="KZ", ISO3CountryCode = "KAZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Jordan", ISO3DigitCountry=400, ISO2CountryCode="JO", ISO3CountryCode = "JOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Kenya", ISO3DigitCountry=404, ISO2CountryCode="KE", ISO3CountryCode = "KEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Korea, Democratic Peoples Republic of ", ISO3DigitCountry=408, ISO2CountryCode="KP", ISO3CountryCode = "PRK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Korea, Republic of", ISO3DigitCountry=410, ISO2CountryCode="KR", ISO3CountryCode = "KOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Kuwait", ISO3DigitCountry=414, ISO2CountryCode="KW", ISO3CountryCode = "KWT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Kyrgyzstan", ISO3DigitCountry=417, ISO2CountryCode="KG", ISO3CountryCode = "KGZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Lao Peoples Deomcratic Republic", ISO3DigitCountry=418, ISO2CountryCode="LA", ISO3CountryCode = "LAO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Lebanon", ISO3DigitCountry=422, ISO2CountryCode="LB", ISO3CountryCode = "LBN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Lesotho", ISO3DigitCountry=426, ISO2CountryCode="LS", ISO3CountryCode = "LSO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Latvia", ISO3DigitCountry=428, ISO2CountryCode="LV", ISO3CountryCode = "LVA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Liberia", ISO3DigitCountry=430, ISO2CountryCode="LR", ISO3CountryCode = "LBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Libyan Arab Jamahiriya", ISO3DigitCountry=434, ISO2CountryCode="LY", ISO3CountryCode = "LBY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Liechtenstein", ISO3DigitCountry=438, ISO2CountryCode="LI", ISO3CountryCode = "LIE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Lithuania", ISO3DigitCountry=440, ISO2CountryCode="LT", ISO3CountryCode = "LTU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Luxembourg", ISO3DigitCountry=442, ISO2CountryCode="LU", ISO3CountryCode = "LUX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Macau", ISO3DigitCountry=446, ISO2CountryCode="MO", ISO3CountryCode = "MAC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Madagascar", ISO3DigitCountry=450, ISO2CountryCode="MG", ISO3CountryCode = "MDG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Malawi", ISO3DigitCountry=454, ISO2CountryCode="MW", ISO3CountryCode = "MWI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Malaysia", ISO3DigitCountry=458, ISO2CountryCode="MY", ISO3CountryCode = "MYS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Maldives", ISO3DigitCountry=462, ISO2CountryCode="MV", ISO3CountryCode = "MDV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mali", ISO3DigitCountry=466, ISO2CountryCode="ML", ISO3CountryCode = "MLI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Malta", ISO3DigitCountry=470, ISO2CountryCode="MT", ISO3CountryCode = "MLT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Martinique", ISO3DigitCountry=474, ISO2CountryCode="MQ", ISO3CountryCode = "MTQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mauritania", ISO3DigitCountry=478, ISO2CountryCode="MR", ISO3CountryCode = "MRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mauritius", ISO3DigitCountry=480, ISO2CountryCode="MU", ISO3CountryCode = "MUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mexico", ISO3DigitCountry=484, ISO2CountryCode="MX", ISO3CountryCode = "MEX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Monaco", ISO3DigitCountry=492, ISO2CountryCode="MC", ISO3CountryCode = "MCO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mongolia", ISO3DigitCountry=496, ISO2CountryCode="MN", ISO3CountryCode = "MNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Moldova, Republic of ", ISO3DigitCountry=498, ISO2CountryCode="MD", ISO3CountryCode = "MDA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Montserrat", ISO3DigitCountry=500, ISO2CountryCode="MS", ISO3CountryCode = "MSR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Morocco", ISO3DigitCountry=504, ISO2CountryCode="MA", ISO3CountryCode = "MAR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Mozambique", ISO3DigitCountry=508, ISO2CountryCode="MZ", ISO3CountryCode = "MOZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Oman", ISO3DigitCountry=512, ISO2CountryCode="OM", ISO3CountryCode = "OMN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Namibia", ISO3DigitCountry=516, ISO2CountryCode="NA", ISO3CountryCode = "NAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Nauru", ISO3DigitCountry=520, ISO2CountryCode="NR", ISO3CountryCode = "NRU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Nepal", ISO3DigitCountry=524, ISO2CountryCode="NP", ISO3CountryCode = "NPL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Netherlands", ISO3DigitCountry=528, ISO2CountryCode="NL", ISO3CountryCode = "NLD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Netherlands Antilles", ISO3DigitCountry=530, ISO2CountryCode="AN", ISO3CountryCode = "ANT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Aruba", ISO3DigitCountry=533, ISO2CountryCode="AW", ISO3CountryCode = "ABW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "New Caledonia", ISO3DigitCountry=540, ISO2CountryCode="NC", ISO3CountryCode = "NCL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Vanuatu", ISO3DigitCountry=548, ISO2CountryCode="VU", ISO3CountryCode = "VUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "New Zealand", ISO3DigitCountry=554, ISO2CountryCode="NZ", ISO3CountryCode = "NZL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Nicaragua", ISO3DigitCountry=558, ISO2CountryCode="NI", ISO3CountryCode = "NIC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Niger", ISO3DigitCountry=562, ISO2CountryCode="NE", ISO3CountryCode = "NER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Nigeria", ISO3DigitCountry=566, ISO2CountryCode="NG", ISO3CountryCode = "NGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Niue", ISO3DigitCountry=570, ISO2CountryCode="NU", ISO3CountryCode = "NIU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Norfolk Island", ISO3DigitCountry=574, ISO2CountryCode="NF", ISO3CountryCode = "NFK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Norway", ISO3DigitCountry=578, ISO2CountryCode="NO", ISO3CountryCode = "NOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Northern Mariana Islands", ISO3DigitCountry=580, ISO2CountryCode="MP", ISO3CountryCode = "MNP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "United States Minor Outlying Islands", ISO3DigitCountry=581, ISO2CountryCode="UM", ISO3CountryCode = "UMI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Micronesia, Federated States of ", ISO3DigitCountry=583, ISO2CountryCode="FM", ISO3CountryCode = "FSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Marshall Islands", ISO3DigitCountry=584, ISO2CountryCode="MH", ISO3CountryCode = "MHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Palau", ISO3DigitCountry=585, ISO2CountryCode="PW", ISO3CountryCode = "PLW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Pakistan", ISO3DigitCountry=586, ISO2CountryCode="PK", ISO3CountryCode = "PAK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Panama", ISO3DigitCountry=591, ISO2CountryCode="PA", ISO3CountryCode = "PAN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Papua New Guinea", ISO3DigitCountry=598, ISO2CountryCode="PG", ISO3CountryCode = "PNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Paraguay", ISO3DigitCountry=600, ISO2CountryCode="PY", ISO3CountryCode = "PRY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Peru", ISO3DigitCountry=604, ISO2CountryCode="PE", ISO3CountryCode = "PER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Philippines", ISO3DigitCountry=608, ISO2CountryCode="PH", ISO3CountryCode = "PHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Pitcairn", ISO3DigitCountry=612, ISO2CountryCode="PN", ISO3CountryCode = "PCN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Poland", ISO3DigitCountry=616, ISO2CountryCode="PL", ISO3CountryCode = "POL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Portugal", ISO3DigitCountry=620, ISO2CountryCode="PT", ISO3CountryCode = "PRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Guinea-Bissau", ISO3DigitCountry=624, ISO2CountryCode="GW", ISO3CountryCode = "GNB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Timor-Leste", ISO3DigitCountry=626, ISO2CountryCode="TL", ISO3CountryCode = "TLS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Puerto Rico", ISO3DigitCountry=630, ISO2CountryCode="PR", ISO3CountryCode = "PRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Qatar", ISO3DigitCountry=634, ISO2CountryCode="QA", ISO3CountryCode = "QAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Reunion", ISO3DigitCountry=638, ISO2CountryCode="RE", ISO3CountryCode = "REU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Romania", ISO3DigitCountry=642, ISO2CountryCode="RO", ISO3CountryCode = "ROM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Russian Federation", ISO3DigitCountry=643, ISO2CountryCode="RU", ISO3CountryCode = "RUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Rwanda", ISO3DigitCountry=646, ISO2CountryCode="RW", ISO3CountryCode = "RWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saint Helena", ISO3DigitCountry=654, ISO2CountryCode="SH", ISO3CountryCode = "SHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saint Kitts and Nevis", ISO3DigitCountry=659, ISO2CountryCode="KN", ISO3CountryCode = "KNA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Anguilla", ISO3DigitCountry=660, ISO2CountryCode="AI", ISO3CountryCode = "AIA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saint Lucia", ISO3DigitCountry=662, ISO2CountryCode="LC", ISO3CountryCode = "LCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saint Pierre and Miquelon", ISO3DigitCountry=666, ISO2CountryCode="PM", ISO3CountryCode = "SPM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saint Vincent and the Grenadines", ISO3DigitCountry=670, ISO2CountryCode="VC", ISO3CountryCode = "VCT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "San Marino", ISO3DigitCountry=674, ISO2CountryCode="SM", ISO3CountryCode = "SMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Sao Tome and Principe", ISO3DigitCountry=678, ISO2CountryCode="ST", ISO3CountryCode = "STP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Saudi Arabia", ISO3DigitCountry=682, ISO2CountryCode="SA", ISO3CountryCode = "SAU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Senegal", ISO3DigitCountry=686, ISO2CountryCode="SN", ISO3CountryCode = "SEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Seychelles", ISO3DigitCountry=690, ISO2CountryCode="SC", ISO3CountryCode = "SYC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Sierra Leone", ISO3DigitCountry=694, ISO2CountryCode="SL", ISO3CountryCode = "SLE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Singapore", ISO3DigitCountry=702, ISO2CountryCode="SG", ISO3CountryCode = "SGP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Slovakia", ISO3DigitCountry=703, ISO2CountryCode="SK", ISO3CountryCode = "SVK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Viet Nam", ISO3DigitCountry=704, ISO2CountryCode="VN", ISO3CountryCode = "VNM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Slovenia", ISO3DigitCountry=705, ISO2CountryCode="SI", ISO3CountryCode = "SVN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Somalia", ISO3DigitCountry=706, ISO2CountryCode="SO", ISO3CountryCode = "SOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "South Africa", ISO3DigitCountry=710, ISO2CountryCode="ZA", ISO3CountryCode = "ZAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Zimbabwe", ISO3DigitCountry=716, ISO2CountryCode="ZW", ISO3CountryCode = "ZWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Spain", ISO3DigitCountry=724, ISO2CountryCode="ES", ISO3CountryCode = "ESP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Western Sahara", ISO3DigitCountry=732, ISO2CountryCode="EH", ISO3CountryCode = "ESH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Sudan", ISO3DigitCountry=736, ISO2CountryCode="SD", ISO3CountryCode = "SDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Suriname", ISO3DigitCountry=740, ISO2CountryCode="SR", ISO3CountryCode = "SUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Svalbard and Jan Mayen", ISO3DigitCountry=744, ISO2CountryCode="SJ", ISO3CountryCode = "SJM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Swaziland", ISO3DigitCountry=748, ISO2CountryCode="SZ", ISO3CountryCode = "SWZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Sweden", ISO3DigitCountry=752, ISO2CountryCode="SE", ISO3CountryCode = "SWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Switzerland", ISO3DigitCountry=756, ISO2CountryCode="CH", ISO3CountryCode = "CHE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Syrian Arab Republic", ISO3DigitCountry=760, ISO2CountryCode="SY", ISO3CountryCode = "SYR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tajikistan", ISO3DigitCountry=762, ISO2CountryCode="TJ", ISO3CountryCode = "TJK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Thailand", ISO3DigitCountry=764, ISO2CountryCode="TH", ISO3CountryCode = "THA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Togo", ISO3DigitCountry=768, ISO2CountryCode="TG", ISO3CountryCode = "TGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tokelau", ISO3DigitCountry=772, ISO2CountryCode="TK", ISO3CountryCode = "TKL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tonga", ISO3DigitCountry=776, ISO2CountryCode="TO", ISO3CountryCode = "TON",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Trinidad and Tobago", ISO3DigitCountry=780, ISO2CountryCode="TT", ISO3CountryCode = "TTO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "United Arab Emirates", ISO3DigitCountry=784, ISO2CountryCode="AE", ISO3CountryCode = "ARE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tunisia", ISO3DigitCountry=788, ISO2CountryCode="TN", ISO3CountryCode = "TUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Turkey", ISO3DigitCountry=792, ISO2CountryCode="TR", ISO3CountryCode = "TUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Turkmenistan", ISO3DigitCountry=795, ISO2CountryCode="TM", ISO3CountryCode = "TKM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Turks and Caicos Islands", ISO3DigitCountry=796, ISO2CountryCode="TC", ISO3CountryCode = "TCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tuvalu", ISO3DigitCountry=798, ISO2CountryCode="TV", ISO3CountryCode = "TUV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Uganda", ISO3DigitCountry=800, ISO2CountryCode="UG", ISO3CountryCode = "UGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Ukraine", ISO3DigitCountry=804, ISO2CountryCode="UA", ISO3CountryCode = "UKR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Macedonia, The former Yugoslav Republic of ", ISO3DigitCountry=807, ISO2CountryCode="MK", ISO3CountryCode = "MKD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Egypt", ISO3DigitCountry=818, ISO2CountryCode="EG", ISO3CountryCode = "EGY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "United Kingdom", ISO3DigitCountry=826, ISO2CountryCode="GB", ISO3CountryCode = "GBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "United States", ISO3DigitCountry=840, ISO2CountryCode="US", ISO3CountryCode = "USA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Tanzania, United Republic of ", ISO3DigitCountry=834, ISO2CountryCode="TZ", ISO3CountryCode = "TZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "U.S. Virgin Islands", ISO3DigitCountry=850, ISO2CountryCode="VI", ISO3CountryCode = "VIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Burkina Faso", ISO3DigitCountry=854, ISO2CountryCode="BF", ISO3CountryCode = "BFA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Uruguay", ISO3DigitCountry=858, ISO2CountryCode="UY", ISO3CountryCode = "URY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Uzbekistan", ISO3DigitCountry=860, ISO2CountryCode="UZ", ISO3CountryCode = "UZB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Venezuela", ISO3DigitCountry=862, ISO2CountryCode="VE", ISO3CountryCode = "VEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Wallis and Futuna", ISO3DigitCountry=876, ISO2CountryCode="WF", ISO3CountryCode = "WLF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Samoa", ISO3DigitCountry=882, ISO2CountryCode="WS", ISO3CountryCode = "WSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Yemen", ISO3DigitCountry=887, ISO2CountryCode="YE", ISO3CountryCode = "YEM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Serbia and Montenegro (Yugoslavia)", ISO3DigitCountry=891, ISO2CountryCode="CS", ISO3CountryCode = "SCG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Countries() { Name = "Zambia", ISO3DigitCountry=894, ISO2CountryCode="ZM", ISO3CountryCode = "ZMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
            }.OrderBy(t => t.Name);
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

        static IEnumerable<Provinces> GetPreconfiguredAllProvinces(int provincetypeid, int countryid, string countryName)
        {
            if (countryName == "Argentina")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Buenos Aires Province", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Capital Federal", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Catamarca", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chaco", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chubut", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Córdoba", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Corrientes", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Entre Ríos", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Formosa", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jujuy", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Pampa", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Rioja", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mendoza", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Misiones", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Neuquén", Code = "Q", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Río Negro", Code = "R", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salta", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "San Juan", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "San Luis", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santa Cruz", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santa Fe", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santiago del Estero", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tierra del Fuego", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tucumán", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Córdoba", Code = "COR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Córdoba", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Rioja", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Australia")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Australian Capital Territory", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northern Territory", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Queensland", Code = "QL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Australia", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tasmania", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Victoria", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Western Australia", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New South Wales", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Austria")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Burgenland", Code = "Burgenland", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Carinthia", Code = "Kärnten", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lower Austria", Code = "Niederösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salzburg", Code = "Salzburg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Styria", Code = "Steiermark", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tyrol", Code = "Tirol", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Upper Austria", Code = "Oberösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vienna", Code = "Wien", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vorarlberg", Code = "Vorarlberg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Belgium")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Antwerpen", Code = "VAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brabant Wallon", Code = "WBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brussels", Code = "BRU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Flanders", Code = "VLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hainaut", Code = "WHT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Liège", Code = "WLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Limburg", Code = "VLI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Luxembourg", Code = "WLX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Namur", Code = "WNA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oost-Vlaanderen", Code = "VOV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vlaams Brabant", Code = "VBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wallonia", Code = "WAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West-Vlaanderen", Code = "VWV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Limburg", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Brazil")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Acre", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alagoas", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Amapá", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Amazonas", Code = "AM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bahia", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ceará", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Distrito Federal", Code = "DF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Espírito Santo", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Goiás", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maranhão", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mato Grosso", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mato Grosso do Sul", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Minas Gerais", Code = "MG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pará", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Paraíba", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Paraná", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pernambuco", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Piauí", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rio de Janeiro", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rio Grande do Norte", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rio Grande do Sul", Code = "RS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rondônia", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Roraima", Code = "RR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santa Catarina", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "São Paulo", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sergipe", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tocantins", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Amazonas", Code = "AMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Distrito Federal", Code = "DIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Bulgaria")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Blagoevgrad", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Burgas", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dobrich", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gabrovo", Code = "EB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haskovo", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kardzhali", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kyustendil", Code = "KH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lovech", Code = "OB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Montana", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pazardzhik", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pernik", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pleven", Code = "EH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Plovdiv", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Razgrad", Code = "PP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ruse", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shumen", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Silistra", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sliven", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Smolyan", Code = "CM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sofia", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sofia Province", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stara Zagora", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Targovishte", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Varna", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Veliko Tarnovo", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vidin", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vratsa", Code = "BP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yambol", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Canada")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Alberta", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "British Columbia", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Manitoba", Code = "MB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New Brunswick", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Newfoundland and Labrador", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northwest Territories", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Nova Scotia", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nunavut", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Ontario", Code = "ON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prince Edward Island", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Quebec", Code = "QC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saskatchewan", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Provinces() { Name = "Yukon Territory", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "China")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Anhui", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Beijing", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chongqing", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fujian", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gansu", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guangdong", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guangxi", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guizhou", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hainan", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hebei", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Heilongjiang", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Henan", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hong Kong", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hubei", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hunan", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jiangsu", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jiangxi", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jilin", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Liaoning", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Macau", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nei Mongol", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ningxia", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Qinghai", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shaanxi", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shandong", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shanghai", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shanxi", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sichuan", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taiwan †", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tianjin", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Xinjiang", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Xizang", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yunnan", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zhejiang", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Taiwan, Province of China")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Changhua", Code = "CHA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chiayi", Code = "CYI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chiayi", Code = "CYQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hsinchu", Code = "HSQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hsinchu", Code = "HSZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hualien", Code = "HUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilan", Code = "ILA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kaohsiung", Code = "KHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kaohsiung", Code = "KHQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Keelung", Code = "KEE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Miaoli", Code = "MIA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nantou", Code = "NAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Penghu", Code = "PEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pingtung", Code = "PIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taichung", Code = "TXG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taichung", Code = "TXQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tainan", Code = "TNN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tainan", Code = "TNQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taipei", Code = "TPE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taipei", Code = "TPQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taitung", Code = "TTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taoyuan", Code = "TAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yunlin", Code = "YUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Colombia")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Antioquia", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arauca", Code = "ARA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Atlántico", Code = "ATL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bogotá D.C.", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bolívar", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Boyacá", Code = "BOY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caldas", Code = "CAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caquetá", Code = "CAQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Casanare", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cauca", Code = "CAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cesar", Code = "CES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chocó", Code = "CHO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cundinamarca", Code = "CUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guainía", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guaviare", Code = "GUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Huila", Code = "HUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Guajira", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Magdalena", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Meta", Code = "MET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nariño", Code = "NAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Norte de Santander", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Putumayo", Code = "PUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Quindío", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Risaralda", Code = "RIS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "San Andrés and Providencia", Code = "SAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santander", Code = "SAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sucre", Code = "SUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tolima", Code = "TOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Valle del Cauca", Code = "VAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vaupés", Code = "VAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vichada", Code = "VID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Czech Republic")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Carlsbad Region", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Central Bohemian Region", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hradec Králové Region", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Liberec Region", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Moravian-Silesian Region", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Olomouc Region", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pardubice Region", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Plzen Region", Code = "PL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prague, the Capital", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Bohemian Region", Code = "JC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Moravian Region", Code = "JM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ústí nad Labem Region", Code = "US", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vysocina Region", Code = "VY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zlín Region", Code = "ZL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Denmark")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Århus", Code = "070", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bornholm", Code = "040", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Copenhagen", Code = "015", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Copenhagen City", Code = "101", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Frederiksberg", Code = "147", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Frederiksborg", Code = "020", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fyn", Code = "042", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Jutland", Code = "080", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ribe", Code = "055", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ringkøbing", Code = "065", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Roskilde", Code = "025", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Jutland", Code = "050", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Storstrøm", Code = "035", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vejle", Code = "060", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vestsjælland", Code = "030", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Viborg", Code = "076", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Finland")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Aland Islands", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eastern Finland", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lapland", Code = "LL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oulu", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southern Finland", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Western Finland", Code = "LS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "France")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Ain", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aisne", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Allier", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alpes-de-Haute-Provence", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alpes-Maritimes", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ardèche", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ardennes", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ariège", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aube", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aude", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aveyron", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bas-Rhin", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bouches-du-Rhône", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Calvados", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cantal", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Charente", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Charente-Maritime", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cher", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Corrèze", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Corse-du-Sud", Code = "2A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Côte-d'Or", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Côtes-d'Armor", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Creuse", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Deux-Sèvres", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dordogne", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Doubs", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Drôme", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Essonne", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eure", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eure-et-Loir", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Finistère", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "French Polynesia", Code = "PF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "French Southern Territories", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gard", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gers", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gironde", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Corse", Code = "2B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Garonne", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Loire", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Marne", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hautes-Alpes", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Saône", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Savoie", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hautes-Pyrénées", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haute-Vienne", Code = "87", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haut-Rhin", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hauts-de-Seine", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hérault", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ille-et-Vilaine", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Indre", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Indre-et-Loire", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isère", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jura", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Landes", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Loire", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Loire-Atlantique", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Loiret", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Loir-et-Cher", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lot", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lot-et-Garonne", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lozère", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maine-et-Loire", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Manche", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Marne", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mayenne", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mayotte", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Meurthe-et-Moselle", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Meuse", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Morbihan", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Moselle", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New Caledonia", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nièvre", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nord", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oise", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Orne", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Paris", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pas-de-Calais", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Puy-de-Dôme", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pyrénées-Atlantiques", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pyrénées-Orientales", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rhône", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saint-Pierre and Miquelon", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saône-et-Loire", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sarthe", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Savoie", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Seine-et-Marne", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Seine-Maritime", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Seine-Saint-Denis", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Somme", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tarn", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tarn-et-Garonne", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Territoire-de-Belfort", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Val-de-Marne", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Val-d'Oise", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Var", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vaucluse", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vendée", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vienne", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vosges", Code = "88", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wallis and Futuna", Code = "WF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yonne", Code = "89", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yvelines", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jura", Code = "JU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Germany")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Baden-Württemberg", Code = "BW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bavaria", Code = "BY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Berlin", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brandenburg", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bremen", Code = "HB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hamburg", Code = "HH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hesse", Code = "HE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lower Saxony", Code = "NI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mecklenburg-Western Pomerania", Code = "MV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Rhine-Westphalia", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rhineland-Palatinate", Code = "RP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saarland", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saxony", Code = "SN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saxony-Anhalt", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Schleswig-Holstein", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Thuringia", Code = "TH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Greece")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Achaea", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aetolia-Acarnania", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arcadia", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Argolis", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arta", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Attica", Code = "A1", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Boeotia", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chalcidice", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chania", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chios", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Corfu", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Corinthia", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cyclades", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dodecanese", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Drama", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Euboea", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Evros", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Evrytania", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Florina", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Grevena", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Heraklion", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilia", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Imathia", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ioannina", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Karditsa", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kastoria", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kavala", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kefallinia", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kilkis", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kozani", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Laconia", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Larissa", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lasithi", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lefkada", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lesbos", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Magnesia", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Messinia", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mount Athos", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pella", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phocis", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phthiotis", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pieria", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Preveza", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rethymno", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rhodope", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samos", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Serres", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Thesprotia", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Thessaloniki", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trikala", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Xanthi", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zakynthos", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "India")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Andaman and Nicobar Islands", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Andhra Pradesh", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arunachal Pradesh", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Assam", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bihar", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chandigarh", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chhattisgarh", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dadra and Nagar Haveli", Code = "DN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Daman and Diu", Code = "DD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Delhi", Code = "DL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Goa", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gujarat", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haryana", Code = "HR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Himachal Pradesh", Code = "HP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jammu and Kashmir", Code = "JK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jharkhand", Code = "JH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Karnataka", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kerala", Code = "KL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lakshadweep", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Madhya Pradesh", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maharashtra", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Manipur", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Meghalaya", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mizoram", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nagaland", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Orissa", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pondicherry", Code = "PY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Punjab", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rajasthan", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sikkim", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tamil Nadu", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tripura", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uttar Pradesh", Code = "UP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uttaranchal", Code = "UL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Bengal", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Italy")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Agrigento", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alessandria", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ancona", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aosta", Code = "AO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arezzo", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ascoli Piceno", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Asti", Code = "AT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Avellino", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bari", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Barletta-Andria-Trani", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Belluno", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Benevento", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bergamo", Code = "BG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Biella", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bologna", Code = "BO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bolzano", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brescia", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brindisi", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cagliari", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caltanissetta", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Campobasso", Code = "CB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Carbonia-Iglesias", Code = "CI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caserta", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Catania", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Catanzaro", Code = "CZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chieti", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Como", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cosenza", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cremona", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Crotone", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cuneo", Code = "CN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Enna", Code = "EN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fermo", Code = "FM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ferrara", Code = "FE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Firenze (Florence)", Code = "FI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Foggia", Code = "FG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Forlì-Cesena", Code = "FO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Frosinone", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Genova (Genoa)", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gorizia", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Grosseto", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Imperia", Code = "IM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isernia", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Spezia", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "L'Aquila", Code = "AQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Latina", Code = "LT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lecce", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lecco", Code = "LC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Livorno", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lodi", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lucca", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Macerata", Code = "MC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mantova (Mantua)", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Massa-Carrara", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Matera", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Medio Campidano", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Messina", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Milano (Milan)", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Modena", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Monza", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Napoli (Naples)", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Novara", Code = "NO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nuoro", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ogliastra", Code = "OG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Olbia-Tempio", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oristano", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Padova (Padua)", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Palermo", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Parma", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pavia", Code = "PV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Perugia", Code = "PG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pesaro e Urbino", Code = "PS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pescara", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Piacenza", Code = "PC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pisa", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pistoia", Code = "PT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pordenone", Code = "PN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Potenza", Code = "PZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prato", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ragusa", Code = "RG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ravenna", Code = "RA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Reggio Calabria", Code = "RC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Reggio Emilia", Code = "RE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rieti", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rimini", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Roma (Rome)", Code = "RM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rovigo", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salerno", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sassari", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Savona", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Siena", Code = "SI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Siracusa (Syracuse)", Code = "SR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sondrio", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Taranto", Code = "TA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Teramo", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Terni", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Torino (Turin)", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trapani", Code = "TP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trento", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Treviso", Code = "TV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trieste", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Udine", Code = "UD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Varese", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Venezia (Venice)", Code = "VE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Verbano-Cusio-Ossola", Code = "VB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vercelli", Code = "VC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Verona", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vibo Valentia", Code = "VV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vicenza", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Viterbo", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Japan")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Aiti (Aichi)", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Akita", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aomori", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ehime", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gihu (Gifu)", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gunma", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hirosima (Hiroshima)", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hokkaido", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hukui (Fukui)", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hukuoka (Fukuoka)", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hukusima (Fukushima)", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hyogo", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ibaraki", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isikawa (Ishikawa)", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Iwate", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kagawa", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kagosima (Kagoshima)", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kanagawa", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Koti (Kochi)", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kumamoto", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kyoto", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mie", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Miyagi", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Miyazaki", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nagano", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nagasaki", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nara", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Niigata", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oita", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Okayama", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Okinawa", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Osaka", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saga", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saitama", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Siga (Shiga)", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Simane (Shimane)", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sizuoka (Shizuoka)", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tiba (Chiba)", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tokusima (Tokushima)", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tokyo", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Totigi (Tochigi)", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tottori", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Toyama", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wakayama", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yamagata", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yamaguti (Yamaguchi)", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yamanasi (Yamanashi)", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Korea, Republic of")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Busan (M)", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chungcheongbuk-do", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chungcheongnam-do", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Daegu (M)", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Daejeon (M)", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gangwon-do", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gwangju (M)", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gyeonggi-do", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gyeongsangbuk-do", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gyeongsangnam-do", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Incheon (M)", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jeju-do", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jeollabuk-do", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jeollanam-do", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Seoul (S)", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ulsan (M)", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Malaysia")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Johor", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kedah", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kelantan", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kuala Lumpur", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Labuan", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Melaka", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Negeri Sembilan", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pahang", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Perak", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Perlis", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pulau Pinang", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Putrajaya", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sabah", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sarawak", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Selangor", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Terengganu", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Mexico")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Aguascalientes", Code = "AGU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Baja California", Code = "BCN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Baja California Sur", Code = "BCS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Campeche", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chiapas", Code = "CHP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chihuahua", Code = "CHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Coahuila", Code = "COA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Colima", Code = "COL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Durango", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guanajuato", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guerrero", Code = "GRO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hidalgo", Code = "HID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jalisco", Code = "JAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mexico", Code = "MEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Michoacán", Code = "MIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Morelos", Code = "MOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nayarit", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nuevo León", Code = "NLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oaxaca", Code = "OAX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Puebla", Code = "PUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Querétaro", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Quintana Roo", Code = "ROO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "San Luis Potosí", Code = "SLP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sinaloa", Code = "SIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sonora", Code = "SON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tabasco", Code = "TAB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tamaulipas", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tlaxcala", Code = "TLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Veracruz", Code = "VER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yucatán", Code = "YUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zacatecas", Code = "ZAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Netherlands")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Drenthe", Code = "DR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Flevoland", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Friesland", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gelderland", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Groningen", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Noord Brabant", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Noord Holland", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Overijssel", Code = "OV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Utrecht", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zeeland", Code = "ZE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zuid Holland", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Norway")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Akershus", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aust-Agder", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Buskerud", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Finnmark", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hedmark", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hordaland", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Møre og Romsdal", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nordland", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nord-Trøndelag", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oppland", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oslo", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Østfold", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rogaland", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sogn og Fjordane", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sør-Trøndelag", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Telemark", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Troms", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vest-Agder", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vestfold", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Philippines")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Abra", Code = "ABR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Agusan del Norte", Code = "AGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Agusan del Sur", Code = "AGS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aklan", Code = "AKL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Albay", Code = "ALB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Antique", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Apayao", Code = "APA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aurora", Code = "AUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Autonomous Region in Muslim Mindanao (ARMM)", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Basilan", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bataan", Code = "BAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Batanes", Code = "BTN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Batangas", Code = "BTG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Benguet", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bicol", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Biliran", Code = "BIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bohol", Code = "BOH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bukidnon", Code = "BUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bulacan", Code = "BUL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cagayan", Code = "CAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cagayan Valley", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Camarines Norte", Code = "CAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Camarines Sur", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Camiguin", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Capiz", Code = "CAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "CARAGA", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Catanduanes", Code = "CAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cavite", Code = "CAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cebu", Code = "CEB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Central Luzon", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Central Mindanao", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Central Visayas", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Compostela Valley", Code = "COM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cordillera Administrative Region (CAR)", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cotabato (North Cotabato)", Code = "NCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Davao del Norte", Code = "DAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Davao del Sur", Code = "DAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Davao Oriental", Code = "DAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eastern Samar", Code = "EAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eastern Visayas", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guimaras", Code = "GUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ifugao", Code = "IFU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilocos", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilocos Norte", Code = "ILN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilocos Sur", Code = "ILS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Iloilo", Code = "ILI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isabela", Code = "ISA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kalinga", Code = "KAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "La Union", Code = "LUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Laguna", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lanao del Norte", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lanao del Sur", Code = "LAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Leyte", Code = "LEY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maguindanao", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Marinduque", Code = "MAD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Masbate", Code = "MAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mindoro Occidental", Code = "MDC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mindoro Oriental", Code = "MDR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Misamis Occidental", Code = "MSC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Misamis Oriental", Code = "MSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mountain Province", Code = "MOU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "National Capital Region (Manila)", Code = "00", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Negros Occidental", Code = "NEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Negros Oriental", Code = "NER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northern Mindanao", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northern Samar", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nueva Ecija", Code = "NUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nueva Vizcaya", Code = "NUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Palawan", Code = "PLW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pampanga", Code = "PAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pangasinan", Code = "PAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Quezon", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Quirino", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rizal", Code = "RIZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Romblon", Code = "ROM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samar (Western Samar)", Code = "WSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sarangani", Code = "SAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Siquijor", Code = "SIG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sorsogon", Code = "SOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Cotabato", Code = "SCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southern Leyte", Code = "SLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southern Mindanao", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southern Tagalog", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sultan Kudarat", Code = "SUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sulu", Code = "SLU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Surigao del Norte", Code = "SUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Surigao del Sur", Code = "SUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tarlac", Code = "TAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tawi-Tawi", Code = "TAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Western Mindanao", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Western Visayas", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zambales", Code = "ZMB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zamboanga del Norte", Code = "ZAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zamboanga del Sur", Code = "ZAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zamboanga Sibugay", Code = "ZSI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Poland")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Dolnoslaskie", Code = "DS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kujawsko-pomorskie", Code = "KP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lódzkie", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lubelskie", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lubuskie", Code = "LB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Malopolskie", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mazowieckie", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Opolskie", Code = "OP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Podkarpackie", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Podlaskie", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pomorskie", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Slaskie", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Swietokrzyskie", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Warminsko-mazurskie", Code = "WN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wielkopolskie", Code = "WP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zachodniopomorskie", Code = "ZP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Romania")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Alba", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arad", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arges", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bacau", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bihor", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bistrita-Nasaud", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Botosani", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Braila", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brasov", Code = "BV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bucuresti", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Buzau", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Calarasi", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caras-Severin", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cluj", Code = "CJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Constanta", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Covasna", Code = "CV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dâmbovita", Code = "DB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dolj", Code = "DJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Galati", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Giurgiu", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gorj", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Harghita", Code = "HG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hunedoara", Code = "HD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ialomita", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Iasi", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ilfov", Code = "IF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maramures", Code = "MM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mehedinti", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mures", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Neamt", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Olt", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prahova", Code = "PH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salaj", Code = "SJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Satu Mare", Code = "SM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sibiu", Code = "SB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Suceava", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Teleorman", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Timis", Code = "TM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tulcea", Code = "TL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vâlcea", Code = "VL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vaslui", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vrancea", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Spain")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "A Coruña", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Álava", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Albacete", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alicante", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Almería", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Asturias", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ávila", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Badajoz", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Baleares", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Barcelona", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Burgos", Code = "BU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cáceres", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cádiz", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cantabria", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Castellón", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ceuta", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ciudad Real", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cuenca", Code = "CU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Girona", Code = "GI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Granada", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guadalajara", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guipúzcoa", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Huelva", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Huesca", Code = "HU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jaén", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Las Palmas", Code = "GC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "León", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lleida", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lugo", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Madrid", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Málaga", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Melilla", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Murcia", Code = "MU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Navarre", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ourense", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Palencia", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pontevedra", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salamanca", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Santa Cruz De Tenerife", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Segovia", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Seville", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Soria", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tarragona", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Teruel", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Toledo", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Valencia", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Valladolid", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vizcaya", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zamora", Code = "ZA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zaragoza", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Sweden")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Blekinge", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dalarna", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gävleborg", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gotland", Code = "I", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Halland", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jämtland", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jönköping", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kalmar", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kronoberg", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Norrbotten", Code = "BD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Örebro", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Östergötland", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Skåne", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Södermanland", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stockholm", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uppsala", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Värmland", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Västerbotten", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Västernorrland", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Västmanland", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Västra Götaland", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Switzerland")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Aargau (Argovia)", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Appenzell Ausserrhoden (Outer Rhodes)", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Appenzell Innerrhoden (Inner Rhodes)", Code = "AI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Basel-Landschaft (Basle-Country)", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Basel-Stadt (Basle-City)", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bern (Berne)", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fribourg", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Geneva", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Glarus", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Graubünden (Grisons)", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lucerne", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Neuchâtel", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nidwalden (Nidwald)", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Obwalden (Obwald)", Code = "OW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Schaffhausen", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Schwyz", Code = "SZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Solothurn", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "St. Gallen (St. Gall)", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Thurgau (Thurgovia)", Code = "TG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ticino", Code = "TI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uri", Code = "UR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Valais", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vaud", Code = "VD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zug", Code = "ZG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zürich (Zurich)", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Thailand")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Amnat Charoen", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ang Thong", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bangkok", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Buri Ram", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chachoengsao", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chai Nat", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chaiyaphum", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chanthaburi", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chiang Mai", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chiang Rai", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chon Buri", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Chumpon", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kalasin", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kamphaeng Phet", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kanchanaburi", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Khon Kaen", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Krabi", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lampang", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lamphun", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Loei", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lop Buri", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mae Hong Son", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maha Sarakham", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mukdahan", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Nayok", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Pathom", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Phanom", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Ratchasima", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Sawan", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nakhon Si Thammarat", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nan", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Narathiwat", Code = "96", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nong Bua Lam Phu", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nong Khai", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nonthaburi", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pathum Thani", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pattani", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pattaya", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phang Nga", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phattalung", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phayao", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phetchabun", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phetchaburi", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phichit", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phitsanulok", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phra Nakhon Si Ayutthaya", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phrae", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Phuket", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prachin Buri", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Prachuap Khiri Khan", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ranong", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ratchaburi", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rayong", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Roi Et", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sa Kaeo", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sakon Nakhon", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samut Prakan", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samut Sakhon", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samut Songkhram", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Saraburi", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Satun", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Si Sa Ket", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sing Buri", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Songkhla", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sukhothai", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Suphanburi", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Surat Thani", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Surin", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tak", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trang", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trat", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ubon Ratchathani", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Udon Thani", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uthai Thani", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Uttaradit", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yala", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yasothon", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "Turkey")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Adana", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Adiyaman", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Afyonkarahisar", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Agri", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aksaray", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Amasya", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ankara", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Antalya", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ardahan", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Artvin", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aydin", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Balikesir", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bartin", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Batman", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bayburt", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bilecik", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bingöl", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bitlis", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bolu", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Burdur", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bursa", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Çanakkale", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Çankiri", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Çorum", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Denizli", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Diyarbakir", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Düzce", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Edirne", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Elazig", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Erzincan", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Erzurum", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eskisehir", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gaziantep", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Giresun", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gümüshane", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hakkari", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hatay", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Igdir", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isparta", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Istanbul", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Izmir", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kahramanmaras", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Karabük", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Karaman", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kars", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kastamonu", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kayseri", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kilis", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kirikkale", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kirklareli", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kirsehir", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kocaeli", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Konya", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kütahya", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Malatya", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Manisa", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mardin", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mersin", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mugla", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mus", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nevsehir", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nigde", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ordu", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Osmaniye", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rize", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sakarya", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Samsun", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sanliurfa", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Siirt", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sinop", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sirnak", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sivas", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tekirdag", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tokat", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trabzon", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tunceli", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Usak", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Van", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yalova", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Yozgat", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Zonguldak", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "United Kingdom")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Aberdeen", Code = "ABE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Aberdeenshire", Code = "ABD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Angus", Code = "ANS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Antrim", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ards", Code = "ARD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Argyll and Bute", Code = "AGB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Armagh", Code = "ARM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ballymena", Code = "BLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ballymoney", Code = "BLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Banbridge", Code = "BNB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Barking and Dagenham (London borough)", Code = "BDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Barnet (London borough)", Code = "BNE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Barnsley (South Yorkshire district)", Code = "BNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bath and North East Somerset (unitary authority)", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bedfordshire (county)", Code = "BDF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Belfast", Code = "BFS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bexley (London borough)", Code = "BEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Birmingham (West Midlands district)", Code = "BIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Blackburn with Darwen (unitary authority)", Code = "BBD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Blackpool (unitary authority)", Code = "BPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Blaenau Gwent", Code = "BGW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bolton (Greater Manchester district)", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bournemouth (unitary authority)", Code = "BMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bracknell Forest (unitary authority)", Code = "BRC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bradford (West Yorkshire district)", Code = "BRD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brent (London borough)", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bridgend", Code = "BGE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Brighton and Hove (unitary authority)", Code = "BNH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bristol, City of (unitary authority)", Code = "BST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bromley (London borough)", Code = "BRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Buckinghamshire (county)", Code = "BKM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Bury (Greater Manchester district)", Code = "BUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Caerphilly", Code = "CAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Calderdale (West Yorkshire district)", Code = "CLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cambridgeshire (county)", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Camden (London borough)", Code = "CMD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cardiff", Code = "CRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Carmarthenshire", Code = "CMN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Carrickfergus", Code = "CKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Castelreagh", Code = "CSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ceredigion", Code = "CGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cheshire (county)", Code = "CHS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Clackmannanshire", Code = "CLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Coleraine", Code = "CLR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Conwy", Code = "CWY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cookstown", Code = "CKT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cornwall (county)", Code = "CON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Coventry (West Midlands district)", Code = "COV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Craigavon", Code = "CGV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Croydon (London borough)", Code = "CRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Cumbria (county)", Code = "CMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Darlington (unitary authority)", Code = "DAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Denbighshire", Code = "DEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Derby (unitary authority)", Code = "DER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Derbyshire (county)", Code = "DBY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Derry", Code = "DRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Devon (county)", Code = "DEV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Doncaster (South Yorkshire district)", Code = "DNC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dorset (county)", Code = "DOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Down", Code = "DOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dudley (West Midlands district)", Code = "DUD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dumfries and Galloway", Code = "DGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dundee", Code = "DND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Dungannon and South Tyrone", Code = "DGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Durham (county)", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ealing (London borough)", Code = "EAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Ayrshire", Code = "EAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Dunbartonshire", Code = "EDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Lothian", Code = "ELN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Renfrewshire", Code = "ERW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Riding of Yorkshire (unitary authority)", Code = "ERY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "East Sussex (county)", Code = "ESX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Edinburgh", Code = "EDH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Eilean Siar", Code = "ELS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Enfield (London borough)", Code = "ENF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Essex (county)", Code = "ESS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Falkirk", Code = "FAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fermanagh", Code = "FER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Fife", Code = "FIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Flintshire", Code = "FLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gateshead (Tyne & Wear district)", Code = "GAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Glasgow", Code = "GLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gloucestershire (county)", Code = "GLS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Greenwich (London borough)", Code = "GRE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guernsey", Code = "GSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Gwynedd", Code = "GWN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hackney (London borough)", Code = "HCK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Halton (unitary authority)", Code = "HAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hammersmith and Fulham (London borough)", Code = "HMF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hampshire (county)", Code = "HAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Haringey (London borough)", Code = "HRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Harrow (London borough)", Code = "HRW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hartlepool (unitary authority)", Code = "HPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Havering (London borough)", Code = "HAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Herefordshire, County of (unitary authority)", Code = "HEF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hertfordshire (county)", Code = "HRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Highland", Code = "HLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hillingdon (London borough)", Code = "HIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hounslow (London borough)", Code = "HNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Inverclyde", Code = "IVC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isle of Anglesey", Code = "AGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isle of Wight (unitary authority)", Code = "IOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Isles of Scilly (special area)", Code = "IOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Islington (London borough)", Code = "ISL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Jersey", Code = "JSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kensington and Chelsea (London borough)", Code = "KEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kent (county)", Code = "KEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kingston upon Hull, City of (unitary authority)", Code = "KHL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kingston upon Thames (London borough)", Code = "KTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kirklees (West Yorkshire district)", Code = "KIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Knowsley (Merseyside district)", Code = "KWL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lambeth (London borough)", Code = "LBH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lancashire (county)", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Larne", Code = "LRN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Leeds (West Yorkshire district)", Code = "LDS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Leicester (unitary authority)", Code = "LCE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Leicestershire (county)", Code = "LEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lewisham (London borough)", Code = "LEW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Limavady", Code = "LMV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lincolnshire (county)", Code = "LIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Lisburn", Code = "LSB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Liverpool (Merseyside district)", Code = "LIV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "London, City of (London borough)", Code = "LND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Luton (unitary authority)", Code = "LUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Magherafelt", Code = "MFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Manchester (Greater Manchester district)", Code = "MAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Medway (unitary authority)", Code = "MDW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Merthyr Tydfil", Code = "MTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Merton (London borough)", Code = "MRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Middlesbrough (unitary authority)", Code = "MDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Midlothian", Code = "MLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Milton Keynes (unitary authority)", Code = "MIK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Monmouthshire", Code = "MON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Moray", Code = "MRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Moyle", Code = "MYL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Neath Port Talbot", Code = "NTL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Newcastle upon Tyne (Tyne & Wear district)", Code = "NET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Newham (London borough)", Code = "NWM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Newport", Code = "NWP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Newry and Mourne", Code = "NYM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Newtownabbey", Code = "NTA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Norfolk (county)", Code = "NFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Ayrshire", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Down", Code = "NDN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North East Lincolnshire (unitary authority)", Code = "NEL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Lanarkshire", Code = "NLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Lincolnshire (unitary authority)", Code = "NLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Somerset (unitary authority)", Code = "NSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Tyneside (Tyne & Wear district)", Code = "NTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Yorkshire (county)", Code = "NYK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northamptonshire (county)", Code = "NTH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northumberland (county)", Code = "NBL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nottingham (unitary authority)", Code = "NGM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nottinghamshire (county)", Code = "NTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oldham (Greater Manchester district)", Code = "OLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Omagh", Code = "OMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Orkney Islands", Code = "ORK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oxfordshire (county)", Code = "OXF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pembrokeshire", Code = "PEM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Perth and Kinross", Code = "PKN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Peterborough (unitary authority)", Code = "PTE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Plymouth (unitary authority)", Code = "PLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Poole (unitary authority)", Code = "POL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Portsmouth (unitary authority)", Code = "POR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Powys", Code = "POW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Reading (unitary authority)", Code = "RDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Redbridge (London borough)", Code = "RDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Redcar and Cleveland (unitary authority)", Code = "RCC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Renfrewshire", Code = "RFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rhondda Cynon Taf", Code = "RCT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Richmond upon Thames (London borough)", Code = "RIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rochdale (Greater Manchester district)", Code = "RCH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rotherham (South Yorkshire district)", Code = "ROT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rutland (unitary authority)", Code = "RUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Salford (Greater Manchester district)", Code = "SLF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sandwell (West Midlands district)", Code = "SAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Scottish Borders, The", Code = "SCB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sefton (Merseyside district)", Code = "SFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sheffield (South Yorkshire district)", Code = "SHF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shetland Islands", Code = "ZET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Shropshire (county)", Code = "SHR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Slough (unitary authority)", Code = "SLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Solihull (West Midlands district)", Code = "SOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Somerset (county)", Code = "SOM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Ayrshire", Code = "SAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Gloucestershire (unitary authority)", Code = "SGC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Lanarkshire", Code = "SLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Tyneside (Tyne & Wear district)", Code = "STY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southampton (unitary authority)", Code = "STH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southend-on-Sea (unitary authority)", Code = "SOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Southwark (London borough)", Code = "SWK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "St Helens (Merseyside district)", Code = "SHN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Staffordshire (county)", Code = "STS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stirling", Code = "STG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stockport (Greater Manchester district)", Code = "SKP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stockton-on-Tees (unitary authority)", Code = "STT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Stoke-on-Trent (unitary authority)", Code = "STE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Strabane", Code = "STB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Suffolk (county)", Code = "SFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sunderland (Tyne & Wear district)", Code = "SND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Surrey (county)", Code = "SRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Sutton (London borough)", Code = "STN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Swansea", Code = "SWA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Swindon (unitary authority)", Code = "SWD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tameside (Greater Manchester district)", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Telford and Wrekin (unitary authority)", Code = "TFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Thurrock (unitary authority)", Code = "THR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Torbay (unitary authority)", Code = "TOB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Torfaen", Code = "TOF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tower Hamlets (London borough)", Code = "TWH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Trafford (Greater Manchester district)", Code = "TRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vale of Glamorgan", Code = "VGL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wakefield (West Yorkshire district)", Code = "WKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Walsall (West Midlands district)", Code = "WLL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Waltham Forest (London borough)", Code = "WFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wandsworth (London borough)", Code = "WND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Warrington (unitary authority)", Code = "WRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Warwickshire (county)", Code = "WAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Berkshire (unitary authority)", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Dunbartonshire", Code = "WDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Lothian", Code = "WLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Sussex (county)", Code = "WSX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Westminster (London borough)", Code = "WSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wigan (Greater Manchester district)", Code = "WGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wiltshire (county)", Code = "WIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Windsor and Maidenhead (unitary authority)", Code = "WNM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wirral (Merseyside district)", Code = "WRL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wokingham (unitary authority)", Code = "WOK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wolverhampton (West Midlands district)", Code = "WLV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Worcestershire (county)", Code = "WOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wrexham", Code = "WRX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "York (unitary authority)", Code = "YOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.Name);
            }
            else if (countryName == "United States")
            {
                return new List<Provinces>()
                {
                    new Provinces() { Name = "Alabama", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Alaska", Code = "AK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "American Samoa", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arizona", Code = "AZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Arkansas", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "California", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Colorado", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Connecticut", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Delaware", Code = "DE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "District of Columbia", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Florida", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Georgia", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Guam", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Hawaii", Code = "HI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Idaho", Code = "ID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Illinois", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Indiana", Code = "IN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Iowa", Code = "IA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kansas", Code = "KS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Kentucky", Code = "KY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Louisiana", Code = "LA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maine", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Maryland", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Massachusetts", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Michigan", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Minnesota", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Mississippi", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Missouri", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nebraska", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Nevada", Code = "NV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New Hampshire", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New Jersey", Code = "NJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New Mexico", Code = "NM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "New York", Code = "NY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Carolina", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "North Dakota", Code = "ND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Northern Mariana Islands", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Ohio", Code = "OH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oklahoma", Code = "OK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Oregon", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Pennsylvania", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Puerto Rico", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Rhode Island", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Carolina", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "South Dakota", Code = "SD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Tennessee", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Texas", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "U.S. Minor Outlying Islands", Code = "UM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Utah", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Vermont", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Virgin Islands of the U.S.", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Virginia", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Washington", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "West Virginia", Code = "WV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wisconsin", Code = "WI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Provinces() { Name = "Wyoming", Code = "WY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
                }.OrderBy(t => t.Name);
            }
            else
            {
                return new List<Provinces>()
                {
                }.OrderBy(t => t.Name);
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
