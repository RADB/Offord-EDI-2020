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

        static IEnumerable<Country> GetPreconfiguredAllCountries()
        {
            return new List<Country>()
            {
                new Country() { English = "Afghanistan", Code=4, ISO2CountryCode="AF", ISO3CountryCode = "AFG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Albania", Code=8, ISO2CountryCode="AL", ISO3CountryCode = "ALB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Antarctica", Code=10, ISO2CountryCode="AQ", ISO3CountryCode = "ATA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Algeria", Code=12, ISO2CountryCode="DZ", ISO3CountryCode = "DZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "American Samoa", Code=16, ISO2CountryCode="AS", ISO3CountryCode = "ASM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Andorra", Code=20, ISO2CountryCode="AD", ISO3CountryCode = "AND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Angola", Code=24, ISO2CountryCode="AO", ISO3CountryCode = "AGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Antigua and Barbuda", Code=28, ISO2CountryCode="AG", ISO3CountryCode = "ATG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Azerbaijan", Code=31, ISO2CountryCode="AZ", ISO3CountryCode = "AZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Argentina", Code=32, ISO2CountryCode="AR", ISO3CountryCode = "ARG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Australia", Code=36, ISO2CountryCode="AU", ISO3CountryCode = "AUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Austria", Code=40, ISO2CountryCode="AT", ISO3CountryCode = "AUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahamas", Code=44, ISO2CountryCode="BS", ISO3CountryCode = "BHS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahrain", Code=48, ISO2CountryCode="BH", ISO3CountryCode = "BHR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bangladesh", Code=50, ISO2CountryCode="BD", ISO3CountryCode = "BGD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Armenia", Code=51, ISO2CountryCode="AM", ISO3CountryCode = "ARM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Barbados", Code=52, ISO2CountryCode="BB", ISO3CountryCode = "BRB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belgium", Code=56, ISO2CountryCode="BE", ISO3CountryCode = "BEL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bermuda", Code=60, ISO2CountryCode="BM", ISO3CountryCode = "BMU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bhutan", Code=64, ISO2CountryCode="BT", ISO3CountryCode = "BTN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bolivia", Code=68, ISO2CountryCode="BO", ISO3CountryCode = "BOL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bosnia and Herzegovina", Code=70, ISO2CountryCode="BA", ISO3CountryCode = "BIH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Botswana", Code=72, ISO2CountryCode="BW", ISO3CountryCode = "BWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bouvet Island", Code=74, ISO2CountryCode="BV", ISO3CountryCode = "BVT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Brazil", Code=76, ISO2CountryCode="BR", ISO3CountryCode = "BRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belize", Code=84, ISO2CountryCode="BZ", ISO3CountryCode = "BLZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "British Indian Ocean Territory", Code=86, ISO2CountryCode="IO", ISO3CountryCode = "IOT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Solomon Islands", Code=90, ISO2CountryCode="SB", ISO3CountryCode = "SLB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "British Virgin Islands", Code=92, ISO2CountryCode="VG", ISO3CountryCode = "VGB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Brunei Darussalam", Code=96, ISO2CountryCode="BN", ISO3CountryCode = "BRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Bulgaria", Code=100, ISO2CountryCode="BG", ISO3CountryCode = "BGR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Myanmar", Code=104, ISO2CountryCode="MM", ISO3CountryCode = "MMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Burundi", Code=108, ISO2CountryCode="BI", ISO3CountryCode = "BDI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Belarus", Code=112, ISO2CountryCode="BY", ISO3CountryCode = "BLR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cambodia", Code=116, ISO2CountryCode="KH", ISO3CountryCode = "KHM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cameroon", Code=120, ISO2CountryCode="CM", ISO3CountryCode = "CMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cape Verde", Code=132, ISO2CountryCode="CV", ISO3CountryCode = "CPV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cayman Islands", Code=136, ISO2CountryCode="KY", ISO3CountryCode = "CYM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Central African Republic", Code=140, ISO2CountryCode="CF", ISO3CountryCode = "CAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sri Lanka", Code=144, ISO2CountryCode="LK", ISO3CountryCode = "LKA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Canada", Code=124, ISO2CountryCode="CA", ISO3CountryCode = "CAN", CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                new Country() { English = "Chad", Code=148, ISO2CountryCode="TD", ISO3CountryCode = "TCD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Chile", Code=152, ISO2CountryCode="CL", ISO3CountryCode = "CHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "China", Code=156, ISO2CountryCode="CN", ISO3CountryCode = "CHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Taiwan, Province of China", Code=158, ISO2CountryCode="TW", ISO3CountryCode = "TWN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Christmas Island", Code=162, ISO2CountryCode="CX", ISO3CountryCode = "CXR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cocos (Keeling) Islands", Code=166, ISO2CountryCode="CC", ISO3CountryCode = "CCK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Colombia", Code=170, ISO2CountryCode="CO", ISO3CountryCode = "COL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Comoros", Code=174, ISO2CountryCode="KM", ISO3CountryCode = "COM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mayotte", Code=175, ISO2CountryCode="YT", ISO3CountryCode = "MYT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo", Code=178, ISO2CountryCode="CG", ISO3CountryCode = "COG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo, The Democratic Republic Of The (Zaire)", Code=180, ISO2CountryCode="CD", ISO3CountryCode = "COD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cook Islands", Code=184, ISO2CountryCode="CK", ISO3CountryCode = "COK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Costa Rica", Code=188, ISO2CountryCode="CR", ISO3CountryCode = "CRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Croatia", Code=191, ISO2CountryCode="HR", ISO3CountryCode = "HRV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cuba", Code=192, ISO2CountryCode="CU", ISO3CountryCode = "CUB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Cyprus", Code=196, ISO2CountryCode="CY", ISO3CountryCode = "CYP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Czech Republic", Code=203, ISO2CountryCode="CZ", ISO3CountryCode = "CZE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Benin", Code=204, ISO2CountryCode="BJ", ISO3CountryCode = "BEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Denmark", Code=208, ISO2CountryCode="DK", ISO3CountryCode = "DNK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominica", Code=212, ISO2CountryCode="DM", ISO3CountryCode = "DMA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominican Republic", Code=214, ISO2CountryCode="DO", ISO3CountryCode = "DOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ecuador", Code=218, ISO2CountryCode="EC", ISO3CountryCode = "ECU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "El Salvador", Code=222, ISO2CountryCode="SV", ISO3CountryCode = "SLV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Equatorial Guinea", Code=226, ISO2CountryCode="GQ", ISO3CountryCode = "GNQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ethiopia", Code=231, ISO2CountryCode="ET", ISO3CountryCode = "ETH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Eritrea", Code=232, ISO2CountryCode="ER", ISO3CountryCode = "ERI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Estonia", Code=233, ISO2CountryCode="EE", ISO3CountryCode = "EST",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Faroe Islands", Code=234, ISO2CountryCode="FO", ISO3CountryCode = "FRO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Falkland Islands (Malvinas)", Code=238, ISO2CountryCode="FK", ISO3CountryCode = "FLK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "South Georgia and the South Sandwich Islands", Code=239, ISO2CountryCode="GS", ISO3CountryCode = "SGS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Fiji", Code=242, ISO2CountryCode="FJ", ISO3CountryCode = "FJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Finland", Code=246, ISO2CountryCode="FI", ISO3CountryCode = "FIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Aland Islands", Code=248, ISO2CountryCode="AX", ISO3CountryCode = "ALA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "France", Code=250, ISO2CountryCode="FR", ISO3CountryCode = "FRA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Guiana", Code=254, ISO2CountryCode="GF", ISO3CountryCode = "GUF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Polynesia", Code=258, ISO2CountryCode="PF", ISO3CountryCode = "PYF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "French Southern Territories", Code=260, ISO2CountryCode="TF", ISO3CountryCode = "ATF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Djibouti", Code=262, ISO2CountryCode="DJ", ISO3CountryCode = "DJI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gabon", Code=266, ISO2CountryCode="GA", ISO3CountryCode = "GAB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Georgia", Code=268, ISO2CountryCode="GE", ISO3CountryCode = "GEO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gambia", Code=270, ISO2CountryCode="GM", ISO3CountryCode = "GMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Palestinian Territory, Occupied", Code=275, ISO2CountryCode="PS", ISO3CountryCode = "PSE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Germany", Code=276, ISO2CountryCode="DE", ISO3CountryCode = "DEU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ghana", Code=288, ISO2CountryCode="GH", ISO3CountryCode = "GHA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Gibraltar", Code=292, ISO2CountryCode="GI", ISO3CountryCode = "GIB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kiribati", Code=296, ISO2CountryCode="KI", ISO3CountryCode = "KIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Greece", Code=300, ISO2CountryCode="GR", ISO3CountryCode = "GRC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Greenland", Code=304, ISO2CountryCode="GL", ISO3CountryCode = "GRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Grenada", Code=308, ISO2CountryCode="GD", ISO3CountryCode = "GRD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guadeloupe", Code=312, ISO2CountryCode="GP", ISO3CountryCode = "GLP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guam", Code=316, ISO2CountryCode="GU", ISO3CountryCode = "GUM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guatemala", Code=320, ISO2CountryCode="GT", ISO3CountryCode = "GTM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea", Code=324, ISO2CountryCode="GN", ISO3CountryCode = "GIN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guyana", Code=328, ISO2CountryCode="GY", ISO3CountryCode = "GUY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Haiti", Code=332, ISO2CountryCode="HT", ISO3CountryCode = "HTI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Heard Island and McDonald Islands", Code=334, ISO2CountryCode="HM", ISO3CountryCode = "HMD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Holy See (Vatican City State)", Code=336, ISO2CountryCode="VA", ISO3CountryCode = "VAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Honduras", Code=340, ISO2CountryCode="HN", ISO3CountryCode = "HND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Hong Kong", Code=344, ISO2CountryCode="HK", ISO3CountryCode = "HKG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Hungary", Code=348, ISO2CountryCode="HU", ISO3CountryCode = "HUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iceland", Code=352, ISO2CountryCode="IS", ISO3CountryCode = "ISL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "India", Code=356, ISO2CountryCode="IN", ISO3CountryCode = "IND",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Indonesia", Code=360, ISO2CountryCode="ID", ISO3CountryCode = "IDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iran, Islamic Republic of ", Code=364, ISO2CountryCode="IR", ISO3CountryCode = "IRN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Iraq", Code=368, ISO2CountryCode="IQ", ISO3CountryCode = "IRQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ireland", Code=372, ISO2CountryCode="IE", ISO3CountryCode = "IRL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Israel", Code=376, ISO2CountryCode="IL", ISO3CountryCode = "ISR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Italy", Code=380, ISO2CountryCode="IT", ISO3CountryCode = "ITA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ivory Coast", Code=384, ISO2CountryCode="CI", ISO3CountryCode = "CIV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Jamaica", Code=388, ISO2CountryCode="JM", ISO3CountryCode = "JAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Japan", Code=392, ISO2CountryCode="JP", ISO3CountryCode = "JPN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kazakstan", Code=398, ISO2CountryCode="KZ", ISO3CountryCode = "KAZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Jordan", Code=400, ISO2CountryCode="JO", ISO3CountryCode = "JOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kenya", Code=404, ISO2CountryCode="KE", ISO3CountryCode = "KEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Democratic Peoples Republic of ", Code=408, ISO2CountryCode="KP", ISO3CountryCode = "PRK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Republic of", Code=410, ISO2CountryCode="KR", ISO3CountryCode = "KOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kuwait", Code=414, ISO2CountryCode="KW", ISO3CountryCode = "KWT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Kyrgyzstan", Code=417, ISO2CountryCode="KG", ISO3CountryCode = "KGZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lao Peoples Deomcratic Republic", Code=418, ISO2CountryCode="LA", ISO3CountryCode = "LAO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lebanon", Code=422, ISO2CountryCode="LB", ISO3CountryCode = "LBN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lesotho", Code=426, ISO2CountryCode="LS", ISO3CountryCode = "LSO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Latvia", Code=428, ISO2CountryCode="LV", ISO3CountryCode = "LVA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Liberia", Code=430, ISO2CountryCode="LR", ISO3CountryCode = "LBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Libyan Arab Jamahiriya", Code=434, ISO2CountryCode="LY", ISO3CountryCode = "LBY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Liechtenstein", Code=438, ISO2CountryCode="LI", ISO3CountryCode = "LIE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Lithuania", Code=440, ISO2CountryCode="LT", ISO3CountryCode = "LTU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Luxembourg", Code=442, ISO2CountryCode="LU", ISO3CountryCode = "LUX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Macau", Code=446, ISO2CountryCode="MO", ISO3CountryCode = "MAC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Madagascar", Code=450, ISO2CountryCode="MG", ISO3CountryCode = "MDG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malawi", Code=454, ISO2CountryCode="MW", ISO3CountryCode = "MWI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malaysia", Code=458, ISO2CountryCode="MY", ISO3CountryCode = "MYS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Maldives", Code=462, ISO2CountryCode="MV", ISO3CountryCode = "MDV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mali", Code=466, ISO2CountryCode="ML", ISO3CountryCode = "MLI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Malta", Code=470, ISO2CountryCode="MT", ISO3CountryCode = "MLT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Martinique", Code=474, ISO2CountryCode="MQ", ISO3CountryCode = "MTQ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritania", Code=478, ISO2CountryCode="MR", ISO3CountryCode = "MRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritius", Code=480, ISO2CountryCode="MU", ISO3CountryCode = "MUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mexico", Code=484, ISO2CountryCode="MX", ISO3CountryCode = "MEX",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Monaco", Code=492, ISO2CountryCode="MC", ISO3CountryCode = "MCO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mongolia", Code=496, ISO2CountryCode="MN", ISO3CountryCode = "MNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Moldova, Republic of ", Code=498, ISO2CountryCode="MD", ISO3CountryCode = "MDA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Montserrat", Code=500, ISO2CountryCode="MS", ISO3CountryCode = "MSR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Morocco", Code=504, ISO2CountryCode="MA", ISO3CountryCode = "MAR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Mozambique", Code=508, ISO2CountryCode="MZ", ISO3CountryCode = "MOZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Oman", Code=512, ISO2CountryCode="OM", ISO3CountryCode = "OMN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Namibia", Code=516, ISO2CountryCode="NA", ISO3CountryCode = "NAM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nauru", Code=520, ISO2CountryCode="NR", ISO3CountryCode = "NRU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nepal", Code=524, ISO2CountryCode="NP", ISO3CountryCode = "NPL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands", Code=528, ISO2CountryCode="NL", ISO3CountryCode = "NLD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands Antilles", Code=530, ISO2CountryCode="AN", ISO3CountryCode = "ANT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Aruba", Code=533, ISO2CountryCode="AW", ISO3CountryCode = "ABW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "New Caledonia", Code=540, ISO2CountryCode="NC", ISO3CountryCode = "NCL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Vanuatu", Code=548, ISO2CountryCode="VU", ISO3CountryCode = "VUT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "New Zealand", Code=554, ISO2CountryCode="NZ", ISO3CountryCode = "NZL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nicaragua", Code=558, ISO2CountryCode="NI", ISO3CountryCode = "NIC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Niger", Code=562, ISO2CountryCode="NE", ISO3CountryCode = "NER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Nigeria", Code=566, ISO2CountryCode="NG", ISO3CountryCode = "NGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Niue", Code=570, ISO2CountryCode="NU", ISO3CountryCode = "NIU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Norfolk Island", Code=574, ISO2CountryCode="NF", ISO3CountryCode = "NFK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Norway", Code=578, ISO2CountryCode="NO", ISO3CountryCode = "NOR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Northern Mariana Islands", Code=580, ISO2CountryCode="MP", ISO3CountryCode = "MNP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United States Minor Outlying Islands", Code=581, ISO2CountryCode="UM", ISO3CountryCode = "UMI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Micronesia, Federated States of ", Code=583, ISO2CountryCode="FM", ISO3CountryCode = "FSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Marshall Islands", Code=584, ISO2CountryCode="MH", ISO3CountryCode = "MHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Palau", Code=585, ISO2CountryCode="PW", ISO3CountryCode = "PLW",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Pakistan", Code=586, ISO2CountryCode="PK", ISO3CountryCode = "PAK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Panama", Code=591, ISO2CountryCode="PA", ISO3CountryCode = "PAN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Papua New Guinea", Code=598, ISO2CountryCode="PG", ISO3CountryCode = "PNG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Paraguay", Code=600, ISO2CountryCode="PY", ISO3CountryCode = "PRY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Peru", Code=604, ISO2CountryCode="PE", ISO3CountryCode = "PER",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Philippines", Code=608, ISO2CountryCode="PH", ISO3CountryCode = "PHL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Pitcairn", Code=612, ISO2CountryCode="PN", ISO3CountryCode = "PCN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Poland", Code=616, ISO2CountryCode="PL", ISO3CountryCode = "POL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Portugal", Code=620, ISO2CountryCode="PT", ISO3CountryCode = "PRT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea-Bissau", Code=624, ISO2CountryCode="GW", ISO3CountryCode = "GNB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Timor-Leste", Code=626, ISO2CountryCode="TL", ISO3CountryCode = "TLS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Puerto Rico", Code=630, ISO2CountryCode="PR", ISO3CountryCode = "PRI",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Qatar", Code=634, ISO2CountryCode="QA", ISO3CountryCode = "QAT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Reunion", Code=638, ISO2CountryCode="RE", ISO3CountryCode = "REU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Romania", Code=642, ISO2CountryCode="RO", ISO3CountryCode = "ROM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Russian Federation", Code=643, ISO2CountryCode="RU", ISO3CountryCode = "RUS",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Rwanda", Code=646, ISO2CountryCode="RW", ISO3CountryCode = "RWA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Helena", Code=654, ISO2CountryCode="SH", ISO3CountryCode = "SHN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Kitts and Nevis", Code=659, ISO2CountryCode="KN", ISO3CountryCode = "KNA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Anguilla", Code=660, ISO2CountryCode="AI", ISO3CountryCode = "AIA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Lucia", Code=662, ISO2CountryCode="LC", ISO3CountryCode = "LCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Pierre and Miquelon", Code=666, ISO2CountryCode="PM", ISO3CountryCode = "SPM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Vincent and the Grenadines", Code=670, ISO2CountryCode="VC", ISO3CountryCode = "VCT",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "San Marino", Code=674, ISO2CountryCode="SM", ISO3CountryCode = "SMR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sao Tome and Principe", Code=678, ISO2CountryCode="ST", ISO3CountryCode = "STP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Saudi Arabia", Code=682, ISO2CountryCode="SA", ISO3CountryCode = "SAU",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Senegal", Code=686, ISO2CountryCode="SN", ISO3CountryCode = "SEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Seychelles", Code=690, ISO2CountryCode="SC", ISO3CountryCode = "SYC",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sierra Leone", Code=694, ISO2CountryCode="SL", ISO3CountryCode = "SLE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Singapore", Code=702, ISO2CountryCode="SG", ISO3CountryCode = "SGP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovakia", Code=703, ISO2CountryCode="SK", ISO3CountryCode = "SVK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Viet Nam", Code=704, ISO2CountryCode="VN", ISO3CountryCode = "VNM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovenia", Code=705, ISO2CountryCode="SI", ISO3CountryCode = "SVN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Somalia", Code=706, ISO2CountryCode="SO", ISO3CountryCode = "SOM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "South Africa", Code=710, ISO2CountryCode="ZA", ISO3CountryCode = "ZAF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Zimbabwe", Code=716, ISO2CountryCode="ZW", ISO3CountryCode = "ZWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Spain", Code=724, ISO2CountryCode="ES", ISO3CountryCode = "ESP",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Western Sahara", Code=732, ISO2CountryCode="EH", ISO3CountryCode = "ESH",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sudan", Code=736, ISO2CountryCode="SD", ISO3CountryCode = "SDN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Suriname", Code=740, ISO2CountryCode="SR", ISO3CountryCode = "SUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Svalbard and Jan Mayen", Code=744, ISO2CountryCode="SJ", ISO3CountryCode = "SJM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Swaziland", Code=748, ISO2CountryCode="SZ", ISO3CountryCode = "SWZ",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Sweden", Code=752, ISO2CountryCode="SE", ISO3CountryCode = "SWE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Switzerland", Code=756, ISO2CountryCode="CH", ISO3CountryCode = "CHE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Syrian Arab Republic", Code=760, ISO2CountryCode="SY", ISO3CountryCode = "SYR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tajikistan", Code=762, ISO2CountryCode="TJ", ISO3CountryCode = "TJK",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Thailand", Code=764, ISO2CountryCode="TH", ISO3CountryCode = "THA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Togo", Code=768, ISO2CountryCode="TG", ISO3CountryCode = "TGO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tokelau", Code=772, ISO2CountryCode="TK", ISO3CountryCode = "TKL",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tonga", Code=776, ISO2CountryCode="TO", ISO3CountryCode = "TON",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Trinidad and Tobago", Code=780, ISO2CountryCode="TT", ISO3CountryCode = "TTO",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United Arab Emirates", Code=784, ISO2CountryCode="AE", ISO3CountryCode = "ARE",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tunisia", Code=788, ISO2CountryCode="TN", ISO3CountryCode = "TUN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkey", Code=792, ISO2CountryCode="TR", ISO3CountryCode = "TUR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkmenistan", Code=795, ISO2CountryCode="TM", ISO3CountryCode = "TKM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Turks and Caicos Islands", Code=796, ISO2CountryCode="TC", ISO3CountryCode = "TCA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tuvalu", Code=798, ISO2CountryCode="TV", ISO3CountryCode = "TUV",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uganda", Code=800, ISO2CountryCode="UG", ISO3CountryCode = "UGA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Ukraine", Code=804, ISO2CountryCode="UA", ISO3CountryCode = "UKR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Macedonia, The former Yugoslav Republic of ", Code=807, ISO2CountryCode="MK", ISO3CountryCode = "MKD",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Egypt", Code=818, ISO2CountryCode="EG", ISO3CountryCode = "EGY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United Kingdom", Code=826, ISO2CountryCode="GB", ISO3CountryCode = "GBR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "United States", Code=840, ISO2CountryCode="US", ISO3CountryCode = "USA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Tanzania, United Republic of ", Code=834, ISO2CountryCode="TZ", ISO3CountryCode = "TZA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "U.S. Virgin Islands", Code=850, ISO2CountryCode="VI", ISO3CountryCode = "VIR",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Burkina Faso", Code=854, ISO2CountryCode="BF", ISO3CountryCode = "BFA",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uruguay", Code=858, ISO2CountryCode="UY", ISO3CountryCode = "URY",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Uzbekistan", Code=860, ISO2CountryCode="UZ", ISO3CountryCode = "UZB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Venezuela", Code=862, ISO2CountryCode="VE", ISO3CountryCode = "VEN",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Wallis and Futuna", Code=876, ISO2CountryCode="WF", ISO3CountryCode = "WLF",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Samoa", Code=882, ISO2CountryCode="WS", ISO3CountryCode = "WSM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Yemen", Code=887, ISO2CountryCode="YE", ISO3CountryCode = "YEM",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Serbia and Montenegro (Yugoslavia)", Code=891, ISO2CountryCode="CS", ISO3CountryCode = "SCG",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                new Country() { English = "Zambia", Code=894, ISO2CountryCode="ZM", ISO3CountryCode = "ZMB",  CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
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
                    new Province() { English = "Buenos Aires Province", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capital Federal", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catamarca", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaco", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chubut", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrientes", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Entre Ríos", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Formosa", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jujuy", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Pampa", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mendoza", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misiones", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuquén", Code = "Q", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Río Negro", Code = "R", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salta", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Juan", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Fe", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santiago del Estero", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tierra del Fuego", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tucumán", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", Code = "COR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Australia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Australian Capital Territory", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Territory", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Queensland", Code = "QL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Australia", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tasmania", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Victoria", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Australia", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New South Wales", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Austria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Burgenland", Code = "Burgenland", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carinthia", Code = "Kärnten", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Austria", Code = "Niederösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salzburg", Code = "Salzburg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Styria", Code = "Steiermark", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tyrol", Code = "Tirol", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Upper Austria", Code = "Oberösterreich", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienna", Code = "Wien", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vorarlberg", Code = "Vorarlberg", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Belgium")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antwerpen", Code = "VAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brabant Wallon", Code = "WBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brussels", Code = "BRU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flanders", Code = "VLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainaut", Code = "WHT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liège", Code = "WLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", Code = "VLI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luxembourg", Code = "WLX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Namur", Code = "WNA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oost-Vlaanderen", Code = "VOV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vlaams Brabant", Code = "VBR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallonia", Code = "WAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West-Vlaanderen", Code = "VWV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Brazil")
            {
                return new List<Province>()
                {
                    new Province() { English = "Acre", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alagoas", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amapá", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", Code = "AM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bahia", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceará", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", Code = "DF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Espírito Santo", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goiás", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maranhão", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso do Sul", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minas Gerais", Code = "MG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pará", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraíba", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraná", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernambuco", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piauí", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio de Janeiro", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Norte", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Sul", Code = "RS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rondônia", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roraima", Code = "RR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Catarina", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "São Paulo", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sergipe", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tocantins", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", Code = "AMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", Code = "DIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Bulgaria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blagoevgrad", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgas", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dobrich", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gabrovo", Code = "EB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haskovo", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kardzhali", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyustendil", Code = "KH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lovech", Code = "OB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Montana", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pazardzhik", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernik", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pleven", Code = "EH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plovdiv", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Razgrad", Code = "PP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ruse", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shumen", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Silistra", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sliven", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Smolyan", Code = "CM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia Province", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stara Zagora", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Targovishte", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varna", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veliko Tarnovo", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vidin", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vratsa", Code = "BP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yambol", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Canada")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alberta", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "British Columbia", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Manitoba", Code = "MB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Brunswick", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Newfoundland and Labrador", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northwest Territories", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Nova Scotia", Code = "NS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nunavut", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Ontario", Code = "ON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prince Edward Island", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Quebec", Code = "QC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saskatchewan", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now },
                    new Province() { English = "Yukon Territory", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Anhui", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Beijing", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chongqing", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fujian", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gansu", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangdong", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangxi", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guizhou", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainan", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hebei", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heilongjiang", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Henan", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hong Kong", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hubei", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunan", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangsu", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangxi", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jilin", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liaoning", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macau", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nei Mongol", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ningxia", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Qinghai", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shaanxi", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shandong", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanghai", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanxi", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sichuan", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taiwan †", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tianjin", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xinjiang", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xizang", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunnan", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zhejiang", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Taiwan, Province of China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Changhua", Code = "CHA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", Code = "CYI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", Code = "CYQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", Code = "HSQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", Code = "HSZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hualien", Code = "HUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilan", Code = "ILA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", Code = "KHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", Code = "KHQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Keelung", Code = "KEE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miaoli", Code = "MIA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nantou", Code = "NAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Penghu", Code = "PEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pingtung", Code = "PIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", Code = "TXG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", Code = "TXQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", Code = "TNN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", Code = "TNQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taipei", Code = "TPE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taipei", Code = "TPQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taitung", Code = "TTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taoyuan", Code = "TAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunlin", Code = "YUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Colombia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antioquia", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arauca", Code = "ARA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Atlántico", Code = "ATL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bogotá D.C.", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolívar", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boyacá", Code = "BOY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caldas", Code = "CAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caquetá", Code = "CAQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Casanare", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cauca", Code = "CAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cesar", Code = "CES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chocó", Code = "CHO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cundinamarca", Code = "CUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guainía", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guaviare", Code = "GUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huila", Code = "HUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Guajira", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magdalena", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meta", Code = "MET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nariño", Code = "NAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norte de Santander", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putumayo", Code = "PUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quindío", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Risaralda", Code = "RIS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Andrés and Providencia", Code = "SAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santander", Code = "SAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sucre", Code = "SUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tolima", Code = "TOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valle del Cauca", Code = "VAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaupés", Code = "VAU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vichada", Code = "VID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Czech Republic")
            {
                return new List<Province>()
                {
                    new Province() { English = "Carlsbad Region", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Bohemian Region", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hradec Králové Region", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liberec Region", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moravian-Silesian Region", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olomouc Region", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pardubice Region", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plzen Region", Code = "PL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prague, the Capital", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Bohemian Region", Code = "JC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Moravian Region", Code = "JM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ústí nad Labem Region", Code = "US", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vysocina Region", Code = "VY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zlín Region", Code = "ZL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Denmark")
            {
                return new List<Province>()
                {
                    new Province() { English = "Århus", Code = "070", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bornholm", Code = "040", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen", Code = "015", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen City", Code = "101", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksberg", Code = "147", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksborg", Code = "020", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fyn", Code = "042", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Jutland", Code = "080", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ribe", Code = "055", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ringkøbing", Code = "065", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roskilde", Code = "025", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Jutland", Code = "050", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Storstrøm", Code = "035", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vejle", Code = "060", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestsjælland", Code = "030", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viborg", Code = "076", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Finland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aland Islands", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Finland", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lapland", Code = "LL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oulu", Code = "OL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Finland", Code = "ES", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Finland", Code = "LS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "France")
            {
                return new List<Province>()
                {
                    new Province() { English = "Ain", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aisne", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Allier", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-de-Haute-Provence", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-Maritimes", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardèche", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardennes", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ariège", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aube", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aude", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aveyron", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bas-Rhin", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bouches-du-Rhône", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calvados", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantal", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente-Maritime", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cher", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrèze", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corse-du-Sud", Code = "2A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côte-d'Or", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côtes-d'Armor", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Creuse", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Deux-Sèvres", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dordogne", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doubs", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drôme", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essonne", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure-et-Loir", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finistère", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Polynesia", Code = "PF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Southern Territories", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gard", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gers", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gironde", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Corse", Code = "2B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Garonne", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Loire", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Marne", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Alpes", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Saône", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Savoie", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Pyrénées", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Vienne", Code = "87", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haut-Rhin", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hauts-de-Seine", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hérault", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ille-et-Vilaine", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre-et-Loire", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isère", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Landes", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire-Atlantique", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loiret", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loir-et-Cher", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot-et-Garonne", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lozère", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine-et-Loire", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manche", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marne", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayenne", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayotte", Code = "YT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meurthe-et-Moselle", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meuse", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morbihan", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moselle", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Caledonia", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nièvre", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oise", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orne", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paris", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pas-de-Calais", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puy-de-Dôme", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Atlantiques", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Orientales", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhône", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saint-Pierre and Miquelon", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saône-et-Loire", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarthe", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savoie", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-et-Marne", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Maritime", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Saint-Denis", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somme", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn-et-Garonne", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Territoire-de-Belfort", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-de-Marne", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-d'Oise", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Var", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaucluse", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vendée", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienne", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vosges", Code = "88", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallis and Futuna", Code = "WF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yonne", Code = "89", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yvelines", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", Code = "JU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Germany")
            {
                return new List<Province>()
                {
                    new Province() { English = "Baden-Württemberg", Code = "BW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bavaria", Code = "BY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Berlin", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brandenburg", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bremen", Code = "HB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hamburg", Code = "HH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hesse", Code = "HE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Saxony", Code = "NI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mecklenburg-Western Pomerania", Code = "MV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Rhine-Westphalia", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhineland-Palatinate", Code = "RP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saarland", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony", Code = "SN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony-Anhalt", Code = "ST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schleswig-Holstein", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thuringia", Code = "TH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Greece")
            {
                return new List<Province>()
                {
                    new Province() { English = "Achaea", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aetolia-Acarnania", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arcadia", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argolis", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arta", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Attica", Code = "A1", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boeotia", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chalcidice", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chania", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chios", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corfu", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corinthia", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cyclades", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dodecanese", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drama", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Euboea", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evros", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evrytania", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florina", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grevena", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heraklion", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilia", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imathia", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ioannina", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karditsa", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastoria", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kavala", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kefallinia", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilkis", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kozani", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laconia", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larissa", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lasithi", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lefkada", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lesbos", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magnesia", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messinia", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mount Athos", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pella", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phocis", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phthiotis", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pieria", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Preveza", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rethymno", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhodope", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samos", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Serres", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thesprotia", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thessaloniki", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trikala", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xanthi", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zakynthos", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "India")
            {
                return new List<Province>()
                {
                    new Province() { English = "Andaman and Nicobar Islands", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Andhra Pradesh", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arunachal Pradesh", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Assam", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihar", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chandigarh", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chhattisgarh", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dadra and Nagar Haveli", Code = "DN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daman and Diu", Code = "DD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delhi", Code = "DL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goa", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gujarat", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haryana", Code = "HR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Himachal Pradesh", Code = "HP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jammu and Kashmir", Code = "JK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jharkhand", Code = "JH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karnataka", Code = "KA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kerala", Code = "KL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lakshadweep", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madhya Pradesh", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maharashtra", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manipur", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meghalaya", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mizoram", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagaland", Code = "NL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orissa", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pondicherry", Code = "PY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Punjab", Code = "PB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rajasthan", Code = "RJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sikkim", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamil Nadu", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tripura", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttar Pradesh", Code = "UP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaranchal", Code = "UL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Bengal", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Italy")
            {
                return new List<Province>()
                {
                    new Province() { English = "Agrigento", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alessandria", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ancona", Code = "AN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aosta", Code = "AO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arezzo", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ascoli Piceno", Code = "AP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asti", Code = "AT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Avellino", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bari", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barletta-Andria-Trani", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belluno", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benevento", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bergamo", Code = "BG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biella", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bologna", Code = "BO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolzano", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brescia", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brindisi", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagliari", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caltanissetta", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campobasso", Code = "CB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carbonia-Iglesias", Code = "CI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caserta", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catania", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanzaro", Code = "CZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chieti", Code = "CH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Como", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cosenza", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cremona", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Crotone", Code = "KR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuneo", Code = "CN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enna", Code = "EN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermo", Code = "FM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ferrara", Code = "FE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Firenze (Florence)", Code = "FI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Foggia", Code = "FG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Forlì-Cesena", Code = "FO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frosinone", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Genova (Genoa)", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorizia", Code = "GO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grosseto", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imperia", Code = "IM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isernia", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Spezia", Code = "SP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "L'Aquila", Code = "AQ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Latina", Code = "LT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecce", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecco", Code = "LC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Livorno", Code = "LI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lodi", Code = "LO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucca", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macerata", Code = "MC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mantova (Mantua)", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massa-Carrara", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Matera", Code = "MT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medio Campidano", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messina", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milano (Milan)", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Modena", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monza", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Napoli (Naples)", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Novara", Code = "NO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuoro", Code = "NU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ogliastra", Code = "OG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olbia-Tempio", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oristano", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Padova (Padua)", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palermo", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Parma", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pavia", Code = "PV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perugia", Code = "PG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pesaro e Urbino", Code = "PS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pescara", Code = "PE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piacenza", Code = "PC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pisa", Code = "PI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pistoia", Code = "PT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pordenone", Code = "PN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Potenza", Code = "PZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prato", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ragusa", Code = "RG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ravenna", Code = "RA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Calabria", Code = "RC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Emilia", Code = "RE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rieti", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rimini", Code = "RN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roma (Rome)", Code = "RM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rovigo", Code = "RO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salerno", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sassari", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savona", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siena", Code = "SI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siracusa (Syracuse)", Code = "SR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sondrio", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taranto", Code = "TA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teramo", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terni", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torino (Turin)", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trapani", Code = "TP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trento", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Treviso", Code = "TV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trieste", Code = "TS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udine", Code = "UD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varese", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Venezia (Venice)", Code = "VE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verbano-Cusio-Ossola", Code = "VB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vercelli", Code = "VC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verona", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vibo Valentia", Code = "VV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vicenza", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viterbo", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Japan")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aiti (Aichi)", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Akita", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aomori", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ehime", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gihu (Gifu)", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gunma", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hirosima (Hiroshima)", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hokkaido", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukui (Fukui)", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukuoka (Fukuoka)", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukusima (Fukushima)", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hyogo", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ibaraki", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isikawa (Ishikawa)", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iwate", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagawa", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagosima (Kagoshima)", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanagawa", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Koti (Kochi)", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kumamoto", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyoto", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mie", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyagi", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyazaki", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagano", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagasaki", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nara", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Niigata", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oita", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okayama", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okinawa", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osaka", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saga", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saitama", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siga (Shiga)", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Simane (Shimane)", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sizuoka (Shizuoka)", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tiba (Chiba)", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokusima (Tokushima)", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokyo", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Totigi (Tochigi)", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tottori", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toyama", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakayama", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamagata", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamaguti (Yamaguchi)", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamanasi (Yamanashi)", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Korea, Republic of")
            {
                return new List<Province>()
                {
                    new Province() { English = "Busan (M)", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongbuk-do", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongnam-do", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daegu (M)", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daejeon (M)", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gangwon-do", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwangju (M)", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeonggi-do", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangbuk-do", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangnam-do", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Incheon (M)", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeju-do", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollabuk-do", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollanam-do", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seoul (S)", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ulsan (M)", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Malaysia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Johor", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kedah", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kelantan", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kuala Lumpur", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Labuan", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melaka", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negeri Sembilan", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pahang", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perak", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perlis", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pulau Pinang", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putrajaya", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sabah", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarawak", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Selangor", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terengganu", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Mexico")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aguascalientes", Code = "AGU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California", Code = "BCN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California Sur", Code = "BCS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campeche", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiapas", Code = "CHP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chihuahua", Code = "CHH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coahuila", Code = "COA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colima", Code = "COL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durango", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guanajuato", Code = "GUA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guerrero", Code = "GRO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hidalgo", Code = "HID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jalisco", Code = "JAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mexico", Code = "MEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michoacán", Code = "MIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morelos", Code = "MOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nayarit", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuevo León", Code = "NLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oaxaca", Code = "OAX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puebla", Code = "PUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Querétaro", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quintana Roo", Code = "ROO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis Potosí", Code = "SLP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinaloa", Code = "SIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sonora", Code = "SON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tabasco", Code = "TAB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamaulipas", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tlaxcala", Code = "TLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veracruz", Code = "VER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yucatán", Code = "YUC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zacatecas", Code = "ZAC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Netherlands")
            {
                return new List<Province>()
                {
                    new Province() { English = "Drenthe", Code = "DR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flevoland", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Friesland", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gelderland", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Groningen", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Brabant", Code = "NB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Holland", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Overijssel", Code = "OV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utrecht", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zeeland", Code = "ZE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zuid Holland", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Norway")
            {
                return new List<Province>()
                {
                    new Province() { English = "Akershus", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aust-Agder", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buskerud", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finnmark", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hedmark", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hordaland", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Møre og Romsdal", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nordland", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord-Trøndelag", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oppland", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oslo", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Østfold", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rogaland", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sogn og Fjordane", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sør-Trøndelag", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telemark", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Troms", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vest-Agder", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestfold", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Philippines")
            {
                return new List<Province>()
                {
                    new Province() { English = "Abra", Code = "ABR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Norte", Code = "AGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Sur", Code = "AGS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aklan", Code = "AKL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albay", Code = "ALB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antique", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Apayao", Code = "APA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aurora", Code = "AUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Autonomous Region in Muslim Mindanao (ARMM)", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basilan", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bataan", Code = "BAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batanes", Code = "BTN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batangas", Code = "BTG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benguet", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bicol", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biliran", Code = "BIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bohol", Code = "BOH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bukidnon", Code = "BUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bulacan", Code = "BUL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan", Code = "CAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan Valley", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Norte", Code = "CAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Sur", Code = "CAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camiguin", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capiz", Code = "CAP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "CARAGA", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanduanes", Code = "CAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cavite", Code = "CAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cebu", Code = "CEB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Luzon", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Mindanao", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Visayas", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Compostela Valley", Code = "COM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cordillera Administrative Region (CAR)", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cotabato (North Cotabato)", Code = "NCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Norte", Code = "DAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Sur", Code = "DAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao Oriental", Code = "DAO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Samar", Code = "EAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Visayas", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guimaras", Code = "GUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ifugao", Code = "IFU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Norte", Code = "ILN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Sur", Code = "ILS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iloilo", Code = "ILI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isabela", Code = "ISA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalinga", Code = "KAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Union", Code = "LUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laguna", Code = "LAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Norte", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Sur", Code = "LAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leyte", Code = "LEY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maguindanao", Code = "MAG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marinduque", Code = "MAD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Masbate", Code = "MAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Occidental", Code = "MDC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Oriental", Code = "MDR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Occidental", Code = "MSC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Oriental", Code = "MSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mountain Province", Code = "MOU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "National Capital Region (Manila)", Code = "00", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Occidental", Code = "NEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Oriental", Code = "NER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mindanao", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Samar", Code = "NSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Ecija", Code = "NUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Vizcaya", Code = "NUV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palawan", Code = "PLW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pampanga", Code = "PAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pangasinan", Code = "PAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quezon", Code = "QUE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quirino", Code = "QUI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rizal", Code = "RIZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Romblon", Code = "ROM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samar (Western Samar)", Code = "WSA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarangani", Code = "SAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siquijor", Code = "SIG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sorsogon", Code = "SOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Cotabato", Code = "SCO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Leyte", Code = "SLE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Mindanao", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Tagalog", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sultan Kudarat", Code = "SUK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sulu", Code = "SLU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Norte", Code = "SUN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Sur", Code = "SUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarlac", Code = "TAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tawi-Tawi", Code = "TAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Mindanao", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Visayas", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zambales", Code = "ZMB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Norte", Code = "ZAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Sur", Code = "ZAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga Sibugay", Code = "ZSI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Poland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Dolnoslaskie", Code = "DS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kujawsko-pomorskie", Code = "KP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lódzkie", Code = "LD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubelskie", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubuskie", Code = "LB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malopolskie", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mazowieckie", Code = "MZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Opolskie", Code = "OP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podkarpackie", Code = "PK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podlaskie", Code = "PD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pomorskie", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slaskie", Code = "SL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swietokrzyskie", Code = "SK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warminsko-mazurskie", Code = "WN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wielkopolskie", Code = "WP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zachodniopomorskie", Code = "ZP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Romania")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alba", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arad", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arges", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bacau", Code = "BC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihor", Code = "BH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bistrita-Nasaud", Code = "BN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Botosani", Code = "BT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Braila", Code = "BR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brasov", Code = "BV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bucuresti", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buzau", Code = "BZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calarasi", Code = "CL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caras-Severin", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cluj", Code = "CJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Constanta", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Covasna", Code = "CV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dâmbovita", Code = "DB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dolj", Code = "DJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Galati", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giurgiu", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorj", Code = "GJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harghita", Code = "HG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunedoara", Code = "HD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ialomita", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iasi", Code = "IS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilfov", Code = "IF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maramures", Code = "MM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mehedinti", Code = "MH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mures", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neamt", Code = "NT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olt", Code = "OT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prahova", Code = "PH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salaj", Code = "SJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satu Mare", Code = "SM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sibiu", Code = "SB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suceava", Code = "SV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teleorman", Code = "TR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Timis", Code = "TM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tulcea", Code = "TL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vâlcea", Code = "VL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaslui", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vrancea", Code = "VR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Spain")
            {
                return new List<Province>()
                {
                    new Province() { English = "A Coruña", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Álava", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albacete", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alicante", Code = "A", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Almería", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asturias", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ávila", Code = "AV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Badajoz", Code = "BA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baleares", Code = "PM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barcelona", Code = "B", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgos", Code = "BU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cáceres", Code = "CC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cádiz", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantabria", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castellón", Code = "CS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceuta", Code = "CE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ciudad Real", Code = "CR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuenca", Code = "CU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Girona", Code = "GI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Granada", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guadalajara", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guipúzcoa", Code = "SS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huelva", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huesca", Code = "HU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jaén", Code = "J", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Las Palmas", Code = "GC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "León", Code = "LE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lleida", Code = "L", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lugo", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madrid", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Málaga", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melilla", Code = "ML", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Murcia", Code = "MU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Navarre", Code = "NA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ourense", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palencia", Code = "P", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pontevedra", Code = "PO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salamanca", Code = "SA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz De Tenerife", Code = "TF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Segovia", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seville", Code = "SE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Soria", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarragona", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teruel", Code = "TE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toledo", Code = "TO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valencia", Code = "V", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valladolid", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vizcaya", Code = "BI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamora", Code = "ZA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zaragoza", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Sweden")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blekinge", Code = "K", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dalarna", Code = "W", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gävleborg", Code = "X", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gotland", Code = "I", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halland", Code = "N", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jämtland", Code = "Z", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jönköping", Code = "F", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalmar", Code = "H", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kronoberg", Code = "G", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norrbotten", Code = "BD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Örebro", Code = "T", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Östergötland", Code = "E", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Skåne", Code = "M", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Södermanland", Code = "D", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockholm", Code = "AB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uppsala", Code = "C", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Värmland", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västerbotten", Code = "AC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västernorrland", Code = "Y", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västmanland", Code = "U", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västra Götaland", Code = "O", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Switzerland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aargau (Argovia)", Code = "AG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Ausserrhoden (Outer Rhodes)", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Innerrhoden (Inner Rhodes)", Code = "AI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Landschaft (Basle-Country)", Code = "BL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Stadt (Basle-City)", Code = "BS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bern (Berne)", Code = "BE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fribourg", Code = "FR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Geneva", Code = "GE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glarus", Code = "GL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Graubünden (Grisons)", Code = "GR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucerne", Code = "LU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuchâtel", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nidwalden (Nidwald)", Code = "NW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Obwalden (Obwald)", Code = "OW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schaffhausen", Code = "SH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schwyz", Code = "SZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solothurn", Code = "SO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "St. Gallen (St. Gall)", Code = "SG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurgau (Thurgovia)", Code = "TG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ticino", Code = "TI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uri", Code = "UR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valais", Code = "VS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaud", Code = "VD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zug", Code = "ZG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zürich (Zurich)", Code = "ZH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Thailand")
            {
                return new List<Province>()
                {
                    new Province() { English = "Amnat Charoen", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ang Thong", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bangkok", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buri Ram", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chachoengsao", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chai Nat", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaiyaphum", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chanthaburi", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Mai", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Rai", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chon Buri", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chumpon", Code = "86", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalasin", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kamphaeng Phet", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanchanaburi", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Khon Kaen", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Krabi", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lampang", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lamphun", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loei", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lop Buri", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mae Hong Son", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maha Sarakham", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mukdahan", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Nayok", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Pathom", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Phanom", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Ratchasima", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Sawan", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Si Thammarat", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nan", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Narathiwat", Code = "96", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Bua Lam Phu", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Khai", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nonthaburi", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pathum Thani", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattani", Code = "94", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattaya", Code = "S", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phang Nga", Code = "82", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phattalung", Code = "93", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phayao", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchabun", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchaburi", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phichit", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phitsanulok", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phra Nakhon Si Ayutthaya", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phrae", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phuket", Code = "83", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachin Buri", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachuap Khiri Khan", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ranong", Code = "85", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ratchaburi", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rayong", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roi Et", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sa Kaeo", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakon Nakhon", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Prakan", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Sakhon", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Songkhram", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saraburi", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satun", Code = "91", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Si Sa Ket", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sing Buri", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Songkhla", Code = "90", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sukhothai", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suphanburi", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surat Thani", Code = "84", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surin", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tak", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trang", Code = "92", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trat", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ubon Ratchathani", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udon Thani", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uthai Thani", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaradit", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yala", Code = "95", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yasothon", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Turkey")
            {
                return new List<Province>()
                {
                    new Province() { English = "Adana", Code = "01", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Adiyaman", Code = "02", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Afyonkarahisar", Code = "03", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agri", Code = "04", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aksaray", Code = "68", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amasya", Code = "05", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ankara", Code = "06", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antalya", Code = "07", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardahan", Code = "75", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Artvin", Code = "08", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aydin", Code = "09", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Balikesir", Code = "10", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bartin", Code = "74", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batman", Code = "72", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bayburt", Code = "69", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bilecik", Code = "11", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bingöl", Code = "12", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bitlis", Code = "13", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolu", Code = "14", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burdur", Code = "15", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bursa", Code = "16", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çanakkale", Code = "17", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çankiri", Code = "18", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çorum", Code = "19", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denizli", Code = "20", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Diyarbakir", Code = "21", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Düzce", Code = "81", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edirne", Code = "22", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Elazig", Code = "23", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzincan", Code = "24", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzurum", Code = "25", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eskisehir", Code = "26", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gaziantep", Code = "27", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giresun", Code = "28", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gümüshane", Code = "29", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hakkari", Code = "30", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hatay", Code = "31", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Igdir", Code = "76", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isparta", Code = "32", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Istanbul", Code = "34", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Izmir", Code = "35", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kahramanmaras", Code = "46", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karabük", Code = "78", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karaman", Code = "70", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kars", Code = "36", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastamonu", Code = "37", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kayseri", Code = "38", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilis", Code = "79", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirikkale", Code = "71", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklareli", Code = "39", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirsehir", Code = "40", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kocaeli", Code = "41", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Konya", Code = "42", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kütahya", Code = "43", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malatya", Code = "44", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manisa", Code = "45", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mardin", Code = "47", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mersin", Code = "33", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mugla", Code = "48", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mus", Code = "49", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevsehir", Code = "50", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nigde", Code = "51", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ordu", Code = "52", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osmaniye", Code = "80", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rize", Code = "53", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakarya", Code = "54", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samsun", Code = "55", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sanliurfa", Code = "63", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siirt", Code = "56", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinop", Code = "57", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sirnak", Code = "73", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sivas", Code = "58", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tekirdag", Code = "59", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokat", Code = "60", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trabzon", Code = "61", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tunceli", Code = "62", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Usak", Code = "64", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Van", Code = "65", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yalova", Code = "77", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yozgat", Code = "66", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zonguldak", Code = "67", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United Kingdom")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aberdeen", Code = "ABE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aberdeenshire", Code = "ABD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Angus", Code = "ANS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antrim", Code = "ANT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ards", Code = "ARD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argyll and Bute", Code = "AGB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Armagh", Code = "ARM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymena", Code = "BLA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymoney", Code = "BLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Banbridge", Code = "BNB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barking and Dagenham (London borough)", Code = "BDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnet (London borough)", Code = "BNE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnsley (South Yorkshire district)", Code = "BNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bath and North East Somerset (unitary authority)", Code = "BAS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bedfordshire (county)", Code = "BDF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belfast", Code = "BFS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bexley (London borough)", Code = "BEX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Birmingham (West Midlands district)", Code = "BIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackburn with Darwen (unitary authority)", Code = "BBD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackpool (unitary authority)", Code = "BPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blaenau Gwent", Code = "BGW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolton (Greater Manchester district)", Code = "BOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bournemouth (unitary authority)", Code = "BMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bracknell Forest (unitary authority)", Code = "BRC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bradford (West Yorkshire district)", Code = "BRD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brent (London borough)", Code = "BEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bridgend", Code = "BGE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brighton and Hove (unitary authority)", Code = "BNH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bristol, City of (unitary authority)", Code = "BST", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bromley (London borough)", Code = "BRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buckinghamshire (county)", Code = "BKM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bury (Greater Manchester district)", Code = "BUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caerphilly", Code = "CAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calderdale (West Yorkshire district)", Code = "CLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cambridgeshire (county)", Code = "CAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camden (London borough)", Code = "CMD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cardiff", Code = "CRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carmarthenshire", Code = "CMN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carrickfergus", Code = "CKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castelreagh", Code = "CSR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceredigion", Code = "CGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cheshire (county)", Code = "CHS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Clackmannanshire", Code = "CLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coleraine", Code = "CLR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Conwy", Code = "CWY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cookstown", Code = "CKT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cornwall (county)", Code = "CON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coventry (West Midlands district)", Code = "COV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Craigavon", Code = "CGV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Croydon (London borough)", Code = "CRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cumbria (county)", Code = "CMA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Darlington (unitary authority)", Code = "DAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denbighshire", Code = "DEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derby (unitary authority)", Code = "DER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derbyshire (county)", Code = "DBY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derry", Code = "DRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Devon (county)", Code = "DEV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doncaster (South Yorkshire district)", Code = "DNC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dorset (county)", Code = "DOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Down", Code = "DOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dudley (West Midlands district)", Code = "DUD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dumfries and Galloway", Code = "DGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dundee", Code = "DND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dungannon and South Tyrone", Code = "DGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durham (county)", Code = "DUR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ealing (London borough)", Code = "EAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Ayrshire", Code = "EAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Dunbartonshire", Code = "EDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Lothian", Code = "ELN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Renfrewshire", Code = "ERW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Riding of Yorkshire (unitary authority)", Code = "ERY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Sussex (county)", Code = "ESX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edinburgh", Code = "EDH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eilean Siar", Code = "ELS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enfield (London borough)", Code = "ENF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essex (county)", Code = "ESS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Falkirk", Code = "FAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermanagh", Code = "FER", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fife", Code = "FIF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flintshire", Code = "FLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gateshead (Tyne & Wear district)", Code = "GAT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glasgow", Code = "GLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gloucestershire (county)", Code = "GLS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Greenwich (London borough)", Code = "GRE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guernsey", Code = "GSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwynedd", Code = "GWN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hackney (London borough)", Code = "HCK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halton (unitary authority)", Code = "HAL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hammersmith and Fulham (London borough)", Code = "HMF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hampshire (county)", Code = "HAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haringey (London borough)", Code = "HRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harrow (London borough)", Code = "HRW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hartlepool (unitary authority)", Code = "HPL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Havering (London borough)", Code = "HAV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Herefordshire, County of (unitary authority)", Code = "HEF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hertfordshire (county)", Code = "HRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Highland", Code = "HLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hillingdon (London borough)", Code = "HIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hounslow (London borough)", Code = "HNS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Inverclyde", Code = "IVC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Anglesey", Code = "AGY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Wight (unitary authority)", Code = "IOW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isles of Scilly (special area)", Code = "IOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Islington (London borough)", Code = "ISL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jersey", Code = "JSY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kensington and Chelsea (London borough)", Code = "KEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kent (county)", Code = "KEN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Hull, City of (unitary authority)", Code = "KHL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Thames (London borough)", Code = "KTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklees (West Yorkshire district)", Code = "KIR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Knowsley (Merseyside district)", Code = "KWL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lambeth (London borough)", Code = "LBH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lancashire (county)", Code = "LAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larne", Code = "LRN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leeds (West Yorkshire district)", Code = "LDS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicester (unitary authority)", Code = "LCE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicestershire (county)", Code = "LEC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lewisham (London borough)", Code = "LEW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limavady", Code = "LMV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lincolnshire (county)", Code = "LIN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lisburn", Code = "LSB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liverpool (Merseyside district)", Code = "LIV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "London, City of (London borough)", Code = "LND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luton (unitary authority)", Code = "LUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magherafelt", Code = "MFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manchester (Greater Manchester district)", Code = "MAN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medway (unitary authority)", Code = "MDW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merthyr Tydfil", Code = "MTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merton (London borough)", Code = "MRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Middlesbrough (unitary authority)", Code = "MDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Midlothian", Code = "MLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milton Keynes (unitary authority)", Code = "MIK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monmouthshire", Code = "MON", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moray", Code = "MRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moyle", Code = "MYL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neath Port Talbot", Code = "NTL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newcastle upon Tyne (Tyne & Wear district)", Code = "NET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newham (London borough)", Code = "NWM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newport", Code = "NWP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newry and Mourne", Code = "NYM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newtownabbey", Code = "NTA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norfolk (county)", Code = "NFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Ayrshire", Code = "NAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Down", Code = "NDN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North East Lincolnshire (unitary authority)", Code = "NEL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lanarkshire", Code = "NLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lincolnshire (unitary authority)", Code = "NLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Somerset (unitary authority)", Code = "NSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Tyneside (Tyne & Wear district)", Code = "NTY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Yorkshire (county)", Code = "NYK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northamptonshire (county)", Code = "NTH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northumberland (county)", Code = "NBL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottingham (unitary authority)", Code = "NGM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottinghamshire (county)", Code = "NTT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oldham (Greater Manchester district)", Code = "OLD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Omagh", Code = "OMH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orkney Islands", Code = "ORK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oxfordshire (county)", Code = "OXF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pembrokeshire", Code = "PEM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perth and Kinross", Code = "PKN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Peterborough (unitary authority)", Code = "PTE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plymouth (unitary authority)", Code = "PLY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Poole (unitary authority)", Code = "POL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Portsmouth (unitary authority)", Code = "POR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Powys", Code = "POW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reading (unitary authority)", Code = "RDG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redbridge (London borough)", Code = "RDB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redcar and Cleveland (unitary authority)", Code = "RCC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Renfrewshire", Code = "RFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhondda Cynon Taf", Code = "RCT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Richmond upon Thames (London borough)", Code = "RIC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rochdale (Greater Manchester district)", Code = "RCH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rotherham (South Yorkshire district)", Code = "ROT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rutland (unitary authority)", Code = "RUT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salford (Greater Manchester district)", Code = "SLF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sandwell (West Midlands district)", Code = "SAW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Scottish Borders, The", Code = "SCB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sefton (Merseyside district)", Code = "SFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sheffield (South Yorkshire district)", Code = "SHF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shetland Islands", Code = "ZET", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shropshire (county)", Code = "SHR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slough (unitary authority)", Code = "SLG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solihull (West Midlands district)", Code = "SOL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somerset (county)", Code = "SOM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Ayrshire", Code = "SAY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Gloucestershire (unitary authority)", Code = "SGC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Lanarkshire", Code = "SLK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Tyneside (Tyne & Wear district)", Code = "STY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southampton (unitary authority)", Code = "STH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southend-on-Sea (unitary authority)", Code = "SOS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southwark (London borough)", Code = "SWK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "St Helens (Merseyside district)", Code = "SHN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Staffordshire (county)", Code = "STS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stirling", Code = "STG", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockport (Greater Manchester district)", Code = "SKP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockton-on-Tees (unitary authority)", Code = "STT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stoke-on-Trent (unitary authority)", Code = "STE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Strabane", Code = "STB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suffolk (county)", Code = "SFK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sunderland (Tyne & Wear district)", Code = "SND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surrey (county)", Code = "SRY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sutton (London borough)", Code = "STN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swansea", Code = "SWA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swindon (unitary authority)", Code = "SWD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tameside (Greater Manchester district)", Code = "TAM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telford and Wrekin (unitary authority)", Code = "TFW", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurrock (unitary authority)", Code = "THR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torbay (unitary authority)", Code = "TOB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torfaen", Code = "TOF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tower Hamlets (London borough)", Code = "TWH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trafford (Greater Manchester district)", Code = "TRF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vale of Glamorgan", Code = "VGL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakefield (West Yorkshire district)", Code = "WKF", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Walsall (West Midlands district)", Code = "WLL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Waltham Forest (London borough)", Code = "WFT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wandsworth (London borough)", Code = "WND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warrington (unitary authority)", Code = "WRT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warwickshire (county)", Code = "WAR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Berkshire (unitary authority)", Code = "WB", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Dunbartonshire", Code = "WDU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Lothian", Code = "WLN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Sussex (county)", Code = "WSX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Westminster (London borough)", Code = "WSM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wigan (Greater Manchester district)", Code = "WGN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wiltshire (county)", Code = "WIL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Windsor and Maidenhead (unitary authority)", Code = "WNM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wirral (Merseyside district)", Code = "WRL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wokingham (unitary authority)", Code = "WOK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wolverhampton (West Midlands district)", Code = "WLV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Worcestershire (county)", Code = "WOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wrexham", Code = "WRX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "York (unitary authority)", Code = "YOR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United States")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alabama", Code = "AL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alaska", Code = "AK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "American Samoa", Code = "AS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arizona", Code = "AZ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arkansas", Code = "AR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "California", Code = "CA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colorado", Code = "CO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Connecticut", Code = "CT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delaware", Code = "DE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "District of Columbia", Code = "DC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florida", Code = "FL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Georgia", Code = "GA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guam", Code = "GU", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hawaii", Code = "HI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Idaho", Code = "ID", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Illinois", Code = "IL", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indiana", Code = "IN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iowa", Code = "IA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kansas", Code = "KS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kentucky", Code = "KY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Louisiana", Code = "LA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine", Code = "ME", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maryland", Code = "MD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massachusetts", Code = "MA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michigan", Code = "MI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minnesota", Code = "MN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mississippi", Code = "MS", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Missouri", Code = "MO", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nebraska", Code = "NE", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevada", Code = "NV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Hampshire", Code = "NH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Jersey", Code = "NJ", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Mexico", Code = "NM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "New York", Code = "NY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Carolina", Code = "NC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Dakota", Code = "ND", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mariana Islands", Code = "MP", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ohio", Code = "OH", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oklahoma", Code = "OK", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oregon", Code = "OR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pennsylvania", Code = "PA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puerto Rico", Code = "PR", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhode Island", Code = "RI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Carolina", Code = "SC", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Dakota", Code = "SD", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tennessee", Code = "TN", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Texas", Code = "TX", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "U.S. Minor Outlying Islands", Code = "UM", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utah", Code = "UT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vermont", Code = "VT", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virgin Islands of the U.S.", Code = "VI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virginia", Code = "VA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Washington", Code = "WA", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Virginia", Code = "WV", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wisconsin", Code = "WI", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wyoming", Code = "WY", CountryID = countryid, ProvinceTypeId = provincetypeid, CreatedBy ="dengb", CreatedDate= DateTime.Now, ModifiedBy = "dengb", ModifiedDate = DateTime.Now }
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
