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
                if (ServiceContext.Years.Where(y => y.Ediyear == DateTime.Now.Year).FirstOrDefault() == null)
                {
                    ServiceContext.Years.AddRange(
                        GetPreconfiguredYear());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.SpecialProblems.Any())
                {
                    ServiceContext.SpecialProblems.AddRange(
                        GetPreconfiguredSpecialProblem());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.Languages.Any())
                {
                    ServiceContext.Languages.AddRange(
                        GetPreconfiguredLanguage());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.Genders.Any())
                {
                    ServiceContext.Genders.AddRange(
                        GetPreconfiguredGender());

                    await ServiceContext.SaveChangesAsync();
                }
                
                if (!ServiceContext.Orientations.Any())
                {
                    ServiceContext.Orientations.AddRange(
                        GetPreconfiguredOrientation());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.LookupSets.Any())
                {
                    ServiceContext.LookupSets.AddRange(
                        GetPreconfiguredLookupSet());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.LookupSetOptions.Any())
                {
                    ServiceContext.LookupSetOptions.AddRange(
                        GetPreconfiguredLookupSetOption());

                    await ServiceContext.SaveChangesAsync();
                }

                if (!ServiceContext.InputTypes.Any())
                {
                    ServiceContext.InputTypes.AddRange(
                        GetPreconfiguredInputType());

                    await ServiceContext.SaveChangesAsync();
                }
                if (!ServiceContext.Questionnaires.Any())
                {
                    ServiceContext.Questionnaires.AddRange(
                        GetPreconfiguredQuestionnaires());

                    await ServiceContext.SaveChangesAsync();
                }
                if (!ServiceContext.FileImportStatuses.Any())
                {
                    ServiceContext.FileImportStatuses.AddRange(
                        GetPreconfiguredFileImportStatus());

                    await ServiceContext.SaveChangesAsync();
                }

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
                    var ProvinceTypeId = ServiceContext.ProvinceType.Where(t => t.Name == "Province").Select(t => t.Id).FirstOrDefault();
                    var statetyPrinceEdwardIslandd = ServiceContext.ProvinceType.Where(t => t.Name == "State").Select(t => t.Id).FirstOrDefault();

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
                        GetPreconfiguredAllProvinces(ProvinceTypeId, countryid, "Canada"));

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
                        GetPreconfiguredAllProvinces(statetyPrinceEdwardIslandd, countryid, "United States"));

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

        static IEnumerable<Year> GetPreconfiguredYear()
        {           
            return new List<Year>()
            {
                new Year() { Ediyear = Convert.ToInt16(DateTime.Now.Year), CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Year() { Ediyear = Convert.ToInt16(DateTime.Now.AddYears(1).Year), CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Year() { Ediyear = Convert.ToInt16(DateTime.Now.AddYears(2).Year), CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<Country> GetPreconfiguredAllCountries()
        {
            return new List<Country>()
            {
                new Country() { English = "Afghanistan", French = "Afghanistan", Code=4, ISO2CountryCode="AF", ISO3CountryCode = "AFG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Albania", French = "Albania", Code=8, ISO2CountryCode="AL", ISO3CountryCode = "ALB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Antarctica", French = "Antarctica", Code=10, ISO2CountryCode="AQ", ISO3CountryCode = "ATA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Algeria", French = "Algeria", Code=12, ISO2CountryCode="DZ", ISO3CountryCode = "DZA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "American Samoa", French = "American Samoa", Code=16, ISO2CountryCode="AS", ISO3CountryCode = "ASM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Andorra", French = "Andorra", Code=20, ISO2CountryCode="AD", ISO3CountryCode = "AND",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Angola", French = "Angola", Code=24, ISO2CountryCode="AO", ISO3CountryCode = "AGO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Antigua and Barbuda", French = "Antigua and Barbuda", Code=28, ISO2CountryCode="AG", ISO3CountryCode = "ATG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Azerbaijan", French = "Azerbaijan", Code=31, ISO2CountryCode="AZ", ISO3CountryCode = "AZE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Argentina", French = "Argentina", Code=32, ISO2CountryCode="AR", ISO3CountryCode = "ARG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Australia", French = "Australia", Code=36, ISO2CountryCode="AU", ISO3CountryCode = "AUS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Austria", French = "Austria", Code=40, ISO2CountryCode="AT", ISO3CountryCode = "AUT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahamas", French = "Bahamas", Code=44, ISO2CountryCode="BS", ISO3CountryCode = "BHS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bahrain", French = "Bahrain", Code=48, ISO2CountryCode="BH", ISO3CountryCode = "BHR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bangladesh", French = "Bangladesh", Code=50, ISO2CountryCode="BD", ISO3CountryCode = "BGD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Armenia", French = "Armenia", Code=51, ISO2CountryCode="AM", ISO3CountryCode = "ARM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Barbados", French = "Barbados", Code=52, ISO2CountryCode="BB", ISO3CountryCode = "BRB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Belgium", French = "Belgium", Code=56, ISO2CountryCode="BE", ISO3CountryCode = "BEL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bermuda", French = "Bermuda", Code=60, ISO2CountryCode="BM", ISO3CountryCode = "BMU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bhutan", French = "Bhutan", Code=64, ISO2CountryCode="BT", ISO3CountryCode = "BTN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bolivia", French = "Bolivia", Code=68, ISO2CountryCode="BO", ISO3CountryCode = "BOL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bosnia and Herzegovina", French = "Bosnia and Herzegovina", Code=70, ISO2CountryCode="BA", ISO3CountryCode = "BIH",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Botswana", French = "Botswana", Code=72, ISO2CountryCode="BW", ISO3CountryCode = "BWA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bouvet Island", French = "Bouvet Island", Code=74, ISO2CountryCode="BV", ISO3CountryCode = "BVT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Brazil", French = "Brazil", Code=76, ISO2CountryCode="BR", ISO3CountryCode = "BRA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Belize", French = "Belize", Code=84, ISO2CountryCode="BZ", ISO3CountryCode = "BLZ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "British Indian Ocean Territory", French = "British Indian Ocean Territory", Code=86, ISO2CountryCode="IO", ISO3CountryCode = "IOT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Solomon Islands", French = "Solomon Islands", Code=90, ISO2CountryCode="SB", ISO3CountryCode = "SLB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "British Virgin Islands", French = "British Virgin Islands", Code=92, ISO2CountryCode="VG", ISO3CountryCode = "VGB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Brunei Darussalam", French = "Brunei Darussalam", Code=96, ISO2CountryCode="BN", ISO3CountryCode = "BRN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Bulgaria", French = "Bulgaria", Code=100, ISO2CountryCode="BG", ISO3CountryCode = "BGR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Myanmar", French = "Myanmar", Code=104, ISO2CountryCode="MM", ISO3CountryCode = "MMR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Burundi", French = "Burundi", Code=108, ISO2CountryCode="BI", ISO3CountryCode = "BDI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Belarus", French = "Belarus", Code=112, ISO2CountryCode="BY", ISO3CountryCode = "BLR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cambodia", French = "Cambodia", Code=116, ISO2CountryCode="KH", ISO3CountryCode = "KHM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cameroon", French = "Cameroon", Code=120, ISO2CountryCode="CM", ISO3CountryCode = "CMR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cape Verde", French = "Canada", Code=132, ISO2CountryCode="CV", ISO3CountryCode = "CPV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cayman Islands", French = "Cape Verde", Code=136, ISO2CountryCode="KY", ISO3CountryCode = "CYM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Central African Republic", French = "Cayman Islands", Code=140, ISO2CountryCode="CF", ISO3CountryCode = "CAF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Sri Lanka", French = "Central African Republic", Code=144, ISO2CountryCode="LK", ISO3CountryCode = "LKA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Canada", French = "Sri Lanka", Code=124, ISO2CountryCode="CA", ISO3CountryCode = "CAN", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Country() { English = "Chad", French = "Chad", Code=148, ISO2CountryCode="TD", ISO3CountryCode = "TCD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Chile", French = "Chile", Code=152, ISO2CountryCode="CL", ISO3CountryCode = "CHL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "China", French = "China", Code=156, ISO2CountryCode="CN", ISO3CountryCode = "CHN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Taiwan, Province of China", French = "Taiwan, Province of China", Code=158, ISO2CountryCode="TW", ISO3CountryCode = "TWN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Christmas Island", French = "Christmas Island", Code=162, ISO2CountryCode="CX", ISO3CountryCode = "CXR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cocos (Keeling) Islands", French = "Cocos (Keeling) Islands", Code=166, ISO2CountryCode="CC", ISO3CountryCode = "CCK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Colombia", French = "Colombia", Code=170, ISO2CountryCode="CO", ISO3CountryCode = "COL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Comoros", French = "Comoros", Code=174, ISO2CountryCode="KM", ISO3CountryCode = "COM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mayotte", French = "Mayotte", Code=175, ISO2CountryCode="YT", ISO3CountryCode = "MYT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo", French = "Congo", Code=178, ISO2CountryCode="CG", ISO3CountryCode = "COG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Congo, The Democratic Republic Of The (Zaire)", French = "Congo, The Democratic Republic Of The (Zaire)", Code=180, ISO2CountryCode="CD", ISO3CountryCode = "COD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cook Islands", French = "Cook Islands", Code=184, ISO2CountryCode="CK", ISO3CountryCode = "COK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Costa Rica", French = "Costa Rica", Code=188, ISO2CountryCode="CR", ISO3CountryCode = "CRI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Croatia", French = "Croatia", Code=191, ISO2CountryCode="HR", ISO3CountryCode = "HRV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cuba", French = "Cuba", Code=192, ISO2CountryCode="CU", ISO3CountryCode = "CUB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Cyprus", French = "Cyprus", Code=196, ISO2CountryCode="CY", ISO3CountryCode = "CYP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Czech Republic", French = "Czech Republic", Code=203, ISO2CountryCode="CZ", ISO3CountryCode = "CZE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Benin", French = "Benin", Code=204, ISO2CountryCode="BJ", ISO3CountryCode = "BEN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Denmark", French = "Denmark", Code=208, ISO2CountryCode="DK", ISO3CountryCode = "DNK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominica", French = "Dominica", Code=212, ISO2CountryCode="DM", ISO3CountryCode = "DMA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Dominican Republic", French = "Dominican Republic", Code=214, ISO2CountryCode="DO", ISO3CountryCode = "DOM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ecuador", French = "Ecuador", Code=218, ISO2CountryCode="EC", ISO3CountryCode = "ECU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "El Salvador", French = "El Salvador", Code=222, ISO2CountryCode="SV", ISO3CountryCode = "SLV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Equatorial Guinea", French = "Equatorial Guinea", Code=226, ISO2CountryCode="GQ", ISO3CountryCode = "GNQ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ethiopia", French = "Ethiopia", Code=231, ISO2CountryCode="ET", ISO3CountryCode = "ETH",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Eritrea", French = "Eritrea", Code=232, ISO2CountryCode="ER", ISO3CountryCode = "ERI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Estonia", French = "Estonia", Code=233, ISO2CountryCode="EE", ISO3CountryCode = "EST",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Faroe Islands", French = "Faroe Islands", Code=234, ISO2CountryCode="FO", ISO3CountryCode = "FRO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Falkland Islands (Malvinas)", French = "Falkland Islands (Malvinas)", Code=238, ISO2CountryCode="FK", ISO3CountryCode = "FLK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "South Georgia and the South Sandwich Islands", French = "South Georgia and the South Sandwich Islands", Code=239, ISO2CountryCode="GS", ISO3CountryCode = "SGS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Fiji", French = "Fiji", Code=242, ISO2CountryCode="FJ", ISO3CountryCode = "FJI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Finland", French = "Finland", Code=246, ISO2CountryCode="FI", ISO3CountryCode = "FIN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Aland Islands", French = "Aland Islands", Code=248, ISO2CountryCode="AX", ISO3CountryCode = "ALA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "France", French = "France", Code=250, ISO2CountryCode="FR", ISO3CountryCode = "FRA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "French Guiana", French = "French Guiana", Code=254, ISO2CountryCode="GF", ISO3CountryCode = "GUF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "French Polynesia", French = "French Polynesia", Code=258, ISO2CountryCode="PF", ISO3CountryCode = "PYF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "French Southern Territories", French = "French Southern Territories", Code=260, ISO2CountryCode="TF", ISO3CountryCode = "ATF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Djibouti", French = "Djibouti", Code=262, ISO2CountryCode="DJ", ISO3CountryCode = "DJI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Gabon", French = "Gabon", Code=266, ISO2CountryCode="GA", ISO3CountryCode = "GAB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Georgia", French = "Georgia", Code=268, ISO2CountryCode="GE", ISO3CountryCode = "GEO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Gambia", French = "Gambia", Code=270, ISO2CountryCode="GM", ISO3CountryCode = "GMB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Palestinian Territory, Occupied", French = "Palestinian Territory, Occupied", Code=275, ISO2CountryCode="PS", ISO3CountryCode = "PSE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Germany", French = "Germany", Code=276, ISO2CountryCode="DE", ISO3CountryCode = "DEU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ghana", French = "Ghana", Code=288, ISO2CountryCode="GH", ISO3CountryCode = "GHA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Gibraltar", French = "Gibraltar", Code=292, ISO2CountryCode="GI", ISO3CountryCode = "GIB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Kiribati", French = "Kiribati", Code=296, ISO2CountryCode="KI", ISO3CountryCode = "KIR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Greece", French = "Greece", Code=300, ISO2CountryCode="GR", ISO3CountryCode = "GRC",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Greenland", French = "Greenland", Code=304, ISO2CountryCode="GL", ISO3CountryCode = "GRL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Grenada", French = "Grenada", Code=308, ISO2CountryCode="GD", ISO3CountryCode = "GRD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guadeloupe", French = "Guadeloupe", Code=312, ISO2CountryCode="GP", ISO3CountryCode = "GLP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guam", French = "Guam", Code=316, ISO2CountryCode="GU", ISO3CountryCode = "GUM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guatemala", French = "Guatemala", Code=320, ISO2CountryCode="GT", ISO3CountryCode = "GTM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea", French = "Guinea", Code=324, ISO2CountryCode="GN", ISO3CountryCode = "GIN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guyana", French = "Guyana", Code=328, ISO2CountryCode="GY", ISO3CountryCode = "GUY",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Haiti", French = "Haiti", Code=332, ISO2CountryCode="HT", ISO3CountryCode = "HTI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Heard Island and McDonald Islands", French = "Heard Island and McDonald Islands", Code=334, ISO2CountryCode="HM", ISO3CountryCode = "HMD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Holy See (Vatican City State)", French = "Holy See (Vatican City State)", Code=336, ISO2CountryCode="VA", ISO3CountryCode = "VAT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Honduras", French = "Honduras", Code=340, ISO2CountryCode="HN", ISO3CountryCode = "HND",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Hong Kong", French = "Hong Kong", Code=344, ISO2CountryCode="HK", ISO3CountryCode = "HKG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Hungary", French = "Hungary", Code=348, ISO2CountryCode="HU", ISO3CountryCode = "HUN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Iceland", French = "Iceland", Code=352, ISO2CountryCode="IS", ISO3CountryCode = "ISL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "India", French = "India", Code=356, ISO2CountryCode="IN", ISO3CountryCode = "IND",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Indonesia", French = "Indonesia", Code=360, ISO2CountryCode="ID", ISO3CountryCode = "IDN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Iran, Islamic Republic of ", French = "Iran, Islamic Republic of ", Code=364, ISO2CountryCode="IR", ISO3CountryCode = "IRN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Iraq", French = "Iraq", Code=368, ISO2CountryCode="IQ", ISO3CountryCode = "IRQ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ireland", French = "Ireland", Code=372, ISO2CountryCode="IE", ISO3CountryCode = "IRL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Israel", French = "Israel", Code=376, ISO2CountryCode="IL", ISO3CountryCode = "ISR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Italy", French = "Italy", Code=380, ISO2CountryCode="IT", ISO3CountryCode = "ITA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ivory Coast", French = "Ivory Coast", Code=384, ISO2CountryCode="CI", ISO3CountryCode = "CIV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Jamaica", French = "Jamaica", Code=388, ISO2CountryCode="JM", ISO3CountryCode = "JAM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Japan", French = "Japan", Code=392, ISO2CountryCode="JP", ISO3CountryCode = "JPN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Kazakstan", French = "Kazakstan", Code=398, ISO2CountryCode="KZ", ISO3CountryCode = "KAZ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Jordan", French = "Jordan", Code=400, ISO2CountryCode="JO", ISO3CountryCode = "JOR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Kenya", French = "Kenya", Code=404, ISO2CountryCode="KE", ISO3CountryCode = "KEN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Democratic Peoples Republic of ", French = "Korea, Democratic Peoples Republic of ", Code=408, ISO2CountryCode="KP", ISO3CountryCode = "PRK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Korea, Republic of", French = "Korea, Republic of", Code=410, ISO2CountryCode="KR", ISO3CountryCode = "KOR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Kuwait", French = "Kuwait", Code=414, ISO2CountryCode="KW", ISO3CountryCode = "KWT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Kyrgyzstan", French = "Kyrgyzstan", Code=417, ISO2CountryCode="KG", ISO3CountryCode = "KGZ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Lao Peoples Deomcratic Republic", French = "Lao Peoples Deomcratic Republic", Code=418, ISO2CountryCode="LA", ISO3CountryCode = "LAO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Lebanon", French = "Lebanon", Code=422, ISO2CountryCode="LB", ISO3CountryCode = "LBN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Lesotho", French = "Lesotho", Code=426, ISO2CountryCode="LS", ISO3CountryCode = "LSO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Latvia", French = "Latvia", Code=428, ISO2CountryCode="LV", ISO3CountryCode = "LVA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Liberia", French = "Liberia", Code=430, ISO2CountryCode="LR", ISO3CountryCode = "LBR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Libyan Arab Jamahiriya", French = "Libyan Arab Jamahiriya", Code=434, ISO2CountryCode="LY", ISO3CountryCode = "LBY",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Liechtenstein", French = "Liechtenstein", Code=438, ISO2CountryCode="LI", ISO3CountryCode = "LIE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Lithuania", French = "Lithuania", Code=440, ISO2CountryCode="LT", ISO3CountryCode = "LTU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Luxembourg", French = "Luxembourg", Code=442, ISO2CountryCode="LU", ISO3CountryCode = "LUX",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Macau", French = "Macau", Code=446, ISO2CountryCode="MO", ISO3CountryCode = "MAC",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Madagascar", French = "Madagascar", Code=450, ISO2CountryCode="MG", ISO3CountryCode = "MDG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Malawi", French = "Malawi", Code=454, ISO2CountryCode="MW", ISO3CountryCode = "MWI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Malaysia", French = "Malaysia", Code=458, ISO2CountryCode="MY", ISO3CountryCode = "MYS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Maldives", French = "Maldives", Code=462, ISO2CountryCode="MV", ISO3CountryCode = "MDV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mali", French = "Mali", Code=466, ISO2CountryCode="ML", ISO3CountryCode = "MLI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Malta", French = "Malta", Code=470, ISO2CountryCode="MT", ISO3CountryCode = "MLT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Martinique", French = "Martinique", Code=474, ISO2CountryCode="MQ", ISO3CountryCode = "MTQ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritania", French = "Mauritania", Code=478, ISO2CountryCode="MR", ISO3CountryCode = "MRT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mauritius", French = "Mauritius", Code=480, ISO2CountryCode="MU", ISO3CountryCode = "MUS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mexico", French = "Mexico", Code=484, ISO2CountryCode="MX", ISO3CountryCode = "MEX",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Monaco", French = "Monaco", Code=492, ISO2CountryCode="MC", ISO3CountryCode = "MCO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mongolia", French = "Mongolia", Code=496, ISO2CountryCode="MN", ISO3CountryCode = "MNG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Moldova, Republic of ", French = "Moldova, Republic of ", Code=498, ISO2CountryCode="MD", ISO3CountryCode = "MDA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Montserrat", French = "Montserrat", Code=500, ISO2CountryCode="MS", ISO3CountryCode = "MSR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Morocco", French = "Morocco", Code=504, ISO2CountryCode="MA", ISO3CountryCode = "MAR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Mozambique", French = "Mozambique", Code=508, ISO2CountryCode="MZ", ISO3CountryCode = "MOZ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Oman", French = "Oman", Code=512, ISO2CountryCode="OM", ISO3CountryCode = "OMN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Namibia", French = "Namibia", Code=516, ISO2CountryCode="NA", ISO3CountryCode = "NAM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Nauru", French = "Nauru", Code=520, ISO2CountryCode="NR", ISO3CountryCode = "NRU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Nepal", French = "Nepal", Code=524, ISO2CountryCode="NP", ISO3CountryCode = "NPL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands", French = "Netherlands", Code=528, ISO2CountryCode="NL", ISO3CountryCode = "NLD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Netherlands Antilles", French = "Netherlands Antilles", Code=530, ISO2CountryCode="AN", ISO3CountryCode = "ANT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Aruba", French = "Aruba", Code=533, ISO2CountryCode="AW", ISO3CountryCode = "ABW",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "New Caledonia", French = "New Caledonia", Code=540, ISO2CountryCode="NC", ISO3CountryCode = "NCL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Vanuatu", French = "Vanuatu", Code=548, ISO2CountryCode="VU", ISO3CountryCode = "VUT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "New Zealand", French = "New Zealand", Code=554, ISO2CountryCode="NZ", ISO3CountryCode = "NZL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Nicaragua", French = "Nicaragua", Code=558, ISO2CountryCode="NI", ISO3CountryCode = "NIC",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Niger", French = "Niger", Code=562, ISO2CountryCode="NE", ISO3CountryCode = "NER",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Nigeria", French = "Nigeria", Code=566, ISO2CountryCode="NG", ISO3CountryCode = "NGA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Niue", French = "Niue", Code=570, ISO2CountryCode="NU", ISO3CountryCode = "NIU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Norfolk Island", French = "Norfolk Island", Code=574, ISO2CountryCode="NF", ISO3CountryCode = "NFK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Norway", French = "Norway", Code=578, ISO2CountryCode="NO", ISO3CountryCode = "NOR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Northern Mariana Islands", French = "Northern Mariana Islands", Code=580, ISO2CountryCode="MP", ISO3CountryCode = "MNP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "United States Minor Outlying Islands", French = "United States Minor Outlying Islands", Code=581, ISO2CountryCode="UM", ISO3CountryCode = "UMI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Micronesia, Federated States of ", French = "Micronesia, Federated States of ", Code=583, ISO2CountryCode="FM", ISO3CountryCode = "FSM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Marshall Islands", French = "Marshall Islands", Code=584, ISO2CountryCode="MH", ISO3CountryCode = "MHL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Palau", French = "Palau", Code=585, ISO2CountryCode="PW", ISO3CountryCode = "PLW",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Pakistan", French = "Pakistan", Code=586, ISO2CountryCode="PK", ISO3CountryCode = "PAK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Panama", French = "Panama", Code=591, ISO2CountryCode="PA", ISO3CountryCode = "PAN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Papua New Guinea", French = "Papua New Guinea", Code=598, ISO2CountryCode="PG", ISO3CountryCode = "PNG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Paraguay", French = "Paraguay", Code=600, ISO2CountryCode="PY", ISO3CountryCode = "PRY",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Peru", French = "Peru", Code=604, ISO2CountryCode="PE", ISO3CountryCode = "PER",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Philippines", French = "Philippines", Code=608, ISO2CountryCode="PH", ISO3CountryCode = "PHL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Pitcairn", French = "Pitcairn", Code=612, ISO2CountryCode="PN", ISO3CountryCode = "PCN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Poland", French = "Poland", Code=616, ISO2CountryCode="PL", ISO3CountryCode = "POL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Portugal", French = "Portugal", Code=620, ISO2CountryCode="PT", ISO3CountryCode = "PRT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Guinea-Bissau", French = "Guinea-Bissau", Code=624, ISO2CountryCode="GW", ISO3CountryCode = "GNB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Timor-Leste", French = "Timor-Leste", Code=626, ISO2CountryCode="TL", ISO3CountryCode = "TLS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Puerto Rico", French = "Puerto Rico", Code=630, ISO2CountryCode="PR", ISO3CountryCode = "PRI",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Qatar", French = "Qatar", Code=634, ISO2CountryCode="QA", ISO3CountryCode = "QAT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Reunion", French = "Reunion", Code=638, ISO2CountryCode="RE", ISO3CountryCode = "REU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Romania", French = "Romania", Code=642, ISO2CountryCode="RO", ISO3CountryCode = "ROM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Russian Federation", French = "Russian Federation", Code=643, ISO2CountryCode="RU", ISO3CountryCode = "RUS",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Rwanda", French = "Rwanda", Code=646, ISO2CountryCode="RW", ISO3CountryCode = "RWA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Helena", French = "Saint Helena", Code=654, ISO2CountryCode="SH", ISO3CountryCode = "SHN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Kitts and Nevis", French = "Saint Kitts and Nevis", Code=659, ISO2CountryCode="KN", ISO3CountryCode = "KNA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Anguilla", French = "Anguilla", Code=660, ISO2CountryCode="AI", ISO3CountryCode = "AIA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Lucia", French = "Saint Lucia", Code=662, ISO2CountryCode="LC", ISO3CountryCode = "LCA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Pierre and Miquelon", French = "Saint Pierre and Miquelon", Code=666, ISO2CountryCode="PM", ISO3CountryCode = "SPM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saint Vincent and the Grenadines", French = "Saint Vincent and the Grenadines", Code=670, ISO2CountryCode="VC", ISO3CountryCode = "VCT",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "San Marino", French = "San Marino", Code=674, ISO2CountryCode="SM", ISO3CountryCode = "SMR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Sao Tome and Principe", French = "Sao Tome and Principe", Code=678, ISO2CountryCode="ST", ISO3CountryCode = "STP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Saudi Arabia", French = "Saudi Arabia", Code=682, ISO2CountryCode="SA", ISO3CountryCode = "SAU",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Senegal", French = "Senegal", Code=686, ISO2CountryCode="SN", ISO3CountryCode = "SEN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Seychelles", French = "Seychelles", Code=690, ISO2CountryCode="SC", ISO3CountryCode = "SYC",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Sierra Leone", French = "Sierra Leone", Code=694, ISO2CountryCode="SL", ISO3CountryCode = "SLE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Singapore", French = "Singapore", Code=702, ISO2CountryCode="SG", ISO3CountryCode = "SGP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovakia", French = "Slovakia", Code=703, ISO2CountryCode="SK", ISO3CountryCode = "SVK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Viet Nam", French = "Viet Nam", Code=704, ISO2CountryCode="VN", ISO3CountryCode = "VNM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Slovenia", French = "Slovenia", Code=705, ISO2CountryCode="SI", ISO3CountryCode = "SVN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Somalia", French = "Somalia", Code=706, ISO2CountryCode="SO", ISO3CountryCode = "SOM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "South Africa", French = "South Africa", Code=710, ISO2CountryCode="ZA", ISO3CountryCode = "ZAF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Zimbabwe", French = "Zimbabwe", Code=716, ISO2CountryCode="ZW", ISO3CountryCode = "ZWE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Spain", French = "Spain", Code=724, ISO2CountryCode="ES", ISO3CountryCode = "ESP",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Western Sahara", French = "Western Sahara", Code=732, ISO2CountryCode="EH", ISO3CountryCode = "ESH",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Sudan", French = "Sudan", Code=736, ISO2CountryCode="SD", ISO3CountryCode = "SDN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Suriname", French = "Suriname", Code=740, ISO2CountryCode="SR", ISO3CountryCode = "SUR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Svalbard and Jan Mayen", French = "Svalbard and Jan Mayen", Code=744, ISO2CountryCode="SJ", ISO3CountryCode = "SJM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Swaziland", French = "Swaziland", Code=748, ISO2CountryCode="SZ", ISO3CountryCode = "SWZ",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Sweden", French = "Sweden", Code=752, ISO2CountryCode="SE", ISO3CountryCode = "SWE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Switzerland", French = "Switzerland", Code=756, ISO2CountryCode="CH", ISO3CountryCode = "CHE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Syrian Arab Republic", French = "Syrian Arab Republic", Code=760, ISO2CountryCode="SY", ISO3CountryCode = "SYR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tajikistan", French = "Tajikistan", Code=762, ISO2CountryCode="TJ", ISO3CountryCode = "TJK",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Thailand", French = "Thailand", Code=764, ISO2CountryCode="TH", ISO3CountryCode = "THA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Togo", French = "Togo", Code=768, ISO2CountryCode="TG", ISO3CountryCode = "TGO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tokelau", French = "Tokelau", Code=772, ISO2CountryCode="TK", ISO3CountryCode = "TKL",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tonga", French = "Tonga", Code=776, ISO2CountryCode="TO", ISO3CountryCode = "TON",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Trinidad and Tobago", French = "Trinidad and Tobago", Code=780, ISO2CountryCode="TT", ISO3CountryCode = "TTO",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "United Arab Emirates", French = "United Arab Emirates", Code=784, ISO2CountryCode="AE", ISO3CountryCode = "ARE",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tunisia", French = "Tunisia", Code=788, ISO2CountryCode="TN", ISO3CountryCode = "TUN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkey", French = "Turkey", Code=792, ISO2CountryCode="TR", ISO3CountryCode = "TUR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Turkmenistan", French = "Turkmenistan", Code=795, ISO2CountryCode="TM", ISO3CountryCode = "TKM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Turks and Caicos Islands", French = "Turks and Caicos Islands", Code=796, ISO2CountryCode="TC", ISO3CountryCode = "TCA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tuvalu", French = "Tuvalu", Code=798, ISO2CountryCode="TV", ISO3CountryCode = "TUV",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Uganda", French = "Uganda", Code=800, ISO2CountryCode="UG", ISO3CountryCode = "UGA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Ukraine", French = "Ukraine", Code=804, ISO2CountryCode="UA", ISO3CountryCode = "UKR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Macedonia, The former Yugoslav Republic of ", French = "Macedonia, The former Yugoslav Republic of ", Code=807, ISO2CountryCode="MK", ISO3CountryCode = "MKD",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Egypt", French = "Egypt", Code=818, ISO2CountryCode="EG", ISO3CountryCode = "EGY",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "United Kingdom", French = "United Kingdom", Code=826, ISO2CountryCode="GB", ISO3CountryCode = "GBR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "United States", French = "Tanzania, United Republic of ", Code=840, ISO2CountryCode="US", ISO3CountryCode = "USA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Tanzania, United Republic of ", French = "United States", Code=834, ISO2CountryCode="TZ", ISO3CountryCode = "TZA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "U.S. Virgin Islands", French = "U.S. Virgin Islands", Code=850, ISO2CountryCode="VI", ISO3CountryCode = "VIR",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Burkina Faso", French = "Burkina Faso", Code=854, ISO2CountryCode="BF", ISO3CountryCode = "BFA",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Uruguay", French = "Uruguay", Code=858, ISO2CountryCode="UY", ISO3CountryCode = "URY",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Uzbekistan", French = "Uzbekistan", Code=860, ISO2CountryCode="UZ", ISO3CountryCode = "UZB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Venezuela", French = "Venezuela", Code=862, ISO2CountryCode="VE", ISO3CountryCode = "VEN",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Wallis and Futuna", French = "Wallis and Futuna", Code=876, ISO2CountryCode="WF", ISO3CountryCode = "WLF",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Samoa", French = "Samoa", Code=882, ISO2CountryCode="WS", ISO3CountryCode = "WSM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Yemen", French = "Yemen", Code=887, ISO2CountryCode="YE", ISO3CountryCode = "YEM",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Serbia and Montenegro (Yugoslavia)", French = "Serbia and Montenegro (Yugoslavia)", Code=891, ISO2CountryCode="CS", ISO3CountryCode = "SCG",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new Country() { English = "Zambia", French = "Zambia", Code=894, ISO2CountryCode="ZM", ISO3CountryCode = "ZMB",  CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
            }.OrderBy(t => t.English);
        }

        static IEnumerable<ProvinceType> GetPreconfiguredAllProvinceTypes()
        {
            return new List<ProvinceType>()
            {
                new ProvinceType() { Name = "Province", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new ProvinceType() { Name = "State", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new ProvinceType() { Name = "District", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new ProvinceType() { Name = "Outlying Areas of the United States ", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                new ProvinceType() { Name = "Countries", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            }.OrderBy(t => t.Name);
        }

        static IEnumerable<Province> GetPreconfiguredAllProvinces(int ProvinceTypeId, int countryid, string countryName)
        {
            if (countryName == "Argentina")
            {
                return new List<Province>()
                {
                    new Province() { English = "Buenos Aires Province", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capital Federal", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catamarca", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaco", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chubut", French = "", Code = "U", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrientes", French = "", Code = "W", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Entre Ríos", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Formosa", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jujuy", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Pampa", French = "", Code = "L", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", French = "", Code = "F", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mendoza", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misiones", French = "", Code = "N", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuquén", French = "", Code = "Q", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Río Negro", French = "", Code = "R", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salta", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Juan", French = "", Code = "J", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis", French = "", Code = "D", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Fe", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santiago del Estero", French = "", Code = "G", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tierra del Fuego", French = "", Code = "V", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tucumán", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "COR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Córdoba", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Rioja", French = "", Code = "LO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Australia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Australian Capital Territory", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Territory", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Queensland", French = "", Code = "QL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Australia", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tasmania", French = "", Code = "TS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Victoria", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Australia", French = "", Code = "WA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New South Wales", French = "", Code = "NS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Austria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Burgenland", French = "", Code = "Burgenland", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carinthia", French = "", Code = "Kärnten", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Austria", French = "", Code = "Niederösterreich", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salzburg", French = "", Code = "Salzburg", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Styria", French = "", Code = "Steiermark", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tyrol", French = "", Code = "Tirol", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Upper Austria", French = "", Code = "Oberösterreich", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienna", French = "", Code = "Wien", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vorarlberg", French = "", Code = "Vorarlberg", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Belgium")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antwerpen", French = "", Code = "VAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brabant Wallon", French = "", Code = "WBR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brussels", French = "", Code = "BRU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flanders", French = "", Code = "VLG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainaut", French = "", Code = "WHT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liège", French = "", Code = "WLG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", French = "", Code = "VLI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luxembourg", French = "", Code = "WLX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Namur", French = "", Code = "WNA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oost-Vlaanderen", French = "", Code = "VOV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vlaams Brabant", French = "", Code = "VBR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallonia", French = "", Code = "WAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West-Vlaanderen", French = "", Code = "VWV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limburg", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Brazil")
            {
                return new List<Province>()
                {
                    new Province() { English = "Acre", French = "", Code = "AC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alagoas", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amapá", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", French = "", Code = "AM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bahia", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceará", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", French = "", Code = "DF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Espírito Santo", French = "", Code = "ES", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goiás", French = "", Code = "GO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maranhão", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso", French = "", Code = "MT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mato Grosso do Sul", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minas Gerais", French = "", Code = "MG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pará", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraíba", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paraná", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernambuco", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piauí", French = "", Code = "PI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio de Janeiro", French = "", Code = "RJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Norte", French = "", Code = "RN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rio Grande do Sul", French = "", Code = "RS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rondônia", French = "", Code = "RO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roraima", French = "", Code = "RR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Catarina", French = "", Code = "SC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "São Paulo", French = "", Code = "SP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sergipe", French = "", Code = "SE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tocantins", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amazonas", French = "", Code = "AMA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Distrito Federal", French = "", Code = "DIF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Bulgaria")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blagoevgrad", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgas", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dobrich", French = "", Code = "TX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gabrovo", French = "", Code = "EB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haskovo", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kardzhali", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyustendil", French = "", Code = "KH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lovech", French = "", Code = "OB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Montana", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pazardzhik", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pernik", French = "", Code = "PK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pleven", French = "", Code = "EH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plovdiv", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Razgrad", French = "", Code = "PP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ruse", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shumen", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Silistra", French = "", Code = "CC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sliven", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Smolyan", French = "", Code = "CM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sofia Province", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stara Zagora", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Targovishte", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varna", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veliko Tarnovo", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vidin", French = "", Code = "BH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vratsa", French = "", Code = "BP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yambol", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Canada")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alberta", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "British Columbia", French = "", EDICode= 99, Code = "BC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Manitoba", French = "", Code = "MB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Brunswick", French = "", Code = "NB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Newfoundland and Labrador", French = "", Code = "NL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northwest Territories", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Nova Scotia", French = "", Code = "NS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nunavut", French = "", Code = "NU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Ontario", French = "", EDICode = 1, Code = "ON", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prince Edward Island", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Quebec", French = "", Code = "QC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saskatchewan", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now },
                    new Province() { English = "Yukon Territory", French = "", Code = "YT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Anhui", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Beijing", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chongqing", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fujian", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gansu", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangdong", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guangxi", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guizhou", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hainan", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hebei", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heilongjiang", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Henan", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hong Kong", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hubei", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunan", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangsu", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jiangxi", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jilin", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liaoning", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macau", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nei Mongol", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ningxia", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Qinghai", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shaanxi", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shandong", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanghai", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shanxi", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sichuan", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taiwan †", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tianjin", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xinjiang", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xizang", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunnan", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zhejiang", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Taiwan, Province of China")
            {
                return new List<Province>()
                {
                    new Province() { English = "Changhua", French = "", Code = "CHA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", French = "", Code = "CYI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiayi", French = "", Code = "CYQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", French = "", Code = "HSQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hsinchu", French = "", Code = "HSZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hualien", French = "", Code = "HUA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilan", French = "", Code = "ILA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", French = "", Code = "KHH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kaohsiung", French = "", Code = "KHQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Keelung", French = "", Code = "KEE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miaoli", French = "", Code = "MIA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nantou", French = "", Code = "NAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Penghu", French = "", Code = "PEN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pingtung", French = "", Code = "PIF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", French = "", Code = "TXG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taichung", French = "", Code = "TXQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", French = "", Code = "TNN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tainan", French = "", Code = "TNQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "TaiPrinceEdwardIsland", French = "", Code = "TPE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "TaiPrinceEdwardIsland", French = "", Code = "TPQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taitung", French = "", Code = "TTT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taoyuan", French = "", Code = "TAO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yunlin", French = "", Code = "YUN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Colombia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Antioquia", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arauca", French = "", Code = "ARA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Atlántico", French = "", Code = "ATL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bogotá D.C.", French = "", Code = "DC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolívar", French = "", Code = "BOL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boyacá", French = "", Code = "BOY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caldas", French = "", Code = "CAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caquetá", French = "", Code = "CAQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Casanare", French = "", Code = "CAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cauca", French = "", Code = "CAU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cesar", French = "", Code = "CES", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chocó", French = "", Code = "CHO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cundinamarca", French = "", Code = "CUN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guainía", French = "", Code = "GUA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guaviare", French = "", Code = "GUV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huila", French = "", Code = "HUI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Guajira", French = "", Code = "LAG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magdalena", French = "", Code = "MAG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meta", French = "", Code = "MET", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nariño", French = "", Code = "NAR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norte de Santander", French = "", Code = "NSA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putumayo", French = "", Code = "PUT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quindío", French = "", Code = "QUI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Risaralda", French = "", Code = "RIS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Andrés and Providencia", French = "", Code = "SAP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santander", French = "", Code = "SAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sucre", French = "", Code = "SUC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tolima", French = "", Code = "TOL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valle del Cauca", French = "", Code = "VAC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaupés", French = "", Code = "VAU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vichada", French = "", Code = "VID", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Czech Republic")
            {
                return new List<Province>()
                {
                    new Province() { English = "Carlsbad Region", French = "", Code = "KA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Bohemian Region", French = "", Code = "ST", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hradec Králové Region", French = "", Code = "KR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liberec Region", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moravian-Silesian Region", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olomouc Region", French = "", Code = "OL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pardubice Region", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plzen Region", French = "", Code = "PL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prague, the Capital", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Bohemian Region", French = "", Code = "JC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Moravian Region", French = "", Code = "JM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ústí nad Labem Region", French = "", Code = "US", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vysocina Region", French = "", Code = "VY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zlín Region", French = "", Code = "ZL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Denmark")
            {
                return new List<Province>()
                {
                    new Province() { English = "Århus", French = "", Code = "070", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bornholm", French = "", Code = "040", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen", French = "", Code = "015", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Copenhagen City", French = "", Code = "101", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksberg", French = "", Code = "147", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frederiksborg", French = "", Code = "020", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fyn", French = "", Code = "042", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Jutland", French = "", Code = "080", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ribe", French = "", Code = "055", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ringkøbing", French = "", Code = "065", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roskilde", French = "", Code = "025", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Jutland", French = "", Code = "050", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Storstrøm", French = "", Code = "035", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vejle", French = "", Code = "060", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestsjælland", French = "", Code = "030", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viborg", French = "", Code = "076", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Finland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aland Islands", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Finland", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lapland", French = "", Code = "LL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oulu", French = "", Code = "OL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Finland", French = "", Code = "ES", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Finland", French = "", Code = "LS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "France")
            {
                return new List<Province>()
                {
                    new Province() { English = "Ain", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aisne", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Allier", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-de-Haute-Provence", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alpes-Maritimes", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardèche", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardennes", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ariège", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aube", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aude", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aveyron", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bas-Rhin", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bouches-du-Rhône", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calvados", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantal", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Charente-Maritime", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cher", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corrèze", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corse-du-Sud", French = "", Code = "2A", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côte-d'Or", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Côtes-d'Armor", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Creuse", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Deux-Sèvres", French = "", Code = "79", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dordogne", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doubs", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drôme", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essonne", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eure-et-Loir", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finistère", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Polynesia", French = "", Code = "PF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "French Southern Territories", French = "", Code = "TF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gard", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gers", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gironde", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Corse", French = "", Code = "2B", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Garonne", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Loire", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Marne", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Alpes", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Saône", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Savoie", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hautes-Pyrénées", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haute-Vienne", French = "", Code = "87", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haut-Rhin", French = "", Code = "68", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hauts-de-Seine", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hérault", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ille-et-Vilaine", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indre-et-Loire", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isère", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Landes", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loire-Atlantique", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loiret", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loir-et-Cher", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lot-et-Garonne", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lozère", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine-et-Loire", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manche", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marne", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayenne", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mayotte", French = "", Code = "YT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meurthe-et-Moselle", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meuse", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morbihan", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moselle", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Caledonia", French = "", Code = "NC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nièvre", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oise", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orne", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Paris", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pas-de-Calais", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puy-de-Dôme", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Atlantiques", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pyrénées-Orientales", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhône", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saint-Pierre and Miquelon", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saône-et-Loire", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarthe", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savoie", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-et-Marne", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Maritime", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seine-Saint-Denis", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somme", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarn-et-Garonne", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Territoire-de-Belfort", French = "", Code = "90", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-de-Marne", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Val-d'Oise", French = "", Code = "95", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Var", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaucluse", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vendée", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vienne", French = "", Code = "86", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vosges", French = "", Code = "88", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wallis and Futuna", French = "", Code = "WF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yonne", French = "", Code = "89", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yvelines", French = "", Code = "78", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jura", French = "", Code = "JU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Germany")
            {
                return new List<Province>()
                {
                    new Province() { English = "Baden-Württemberg", French = "", Code = "BW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bavaria", French = "", Code = "BY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Berlin", French = "", Code = "BE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brandenburg", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bremen", French = "", Code = "HB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hamburg", French = "", Code = "HH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hesse", French = "", Code = "HE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lower Saxony", French = "", Code = "NI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mecklenburg-Western Pomerania", French = "", Code = "MV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Rhine-Westphalia", French = "", Code = "NW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhineland-Palatinate", French = "", Code = "RP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saarland", French = "", Code = "SL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony", French = "", Code = "SN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saxony-Anhalt", French = "", Code = "ST", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schleswig-Holstein", French = "", Code = "SH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thuringia", French = "", Code = "TH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Greece")
            {
                return new List<Province>()
                {
                    new Province() { English = "Achaea", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aetolia-Acarnania", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arcadia", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argolis", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arta", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Attica", French = "", Code = "A1", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Boeotia", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chalcidice", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chania", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chios", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corfu", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Corinthia", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cyclades", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dodecanese", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Drama", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Euboea", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evros", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Evrytania", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florina", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grevena", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Heraklion", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilia", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imathia", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ioannina", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karditsa", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastoria", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kavala", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kefallinia", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilkis", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kozani", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laconia", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larissa", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lasithi", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lefkada", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lesbos", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magnesia", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messinia", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mount Athos", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pella", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phocis", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phthiotis", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pieria", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Preveza", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rethymno", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhodope", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samos", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Serres", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thesprotia", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thessaloniki", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trikala", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Xanthi", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zakynthos", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "India")
            {
                return new List<Province>()
                {
                    new Province() { English = "Andaman and Nicobar Islands", French = "", Code = "AN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Andhra Pradesh", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arunachal Pradesh", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Assam", French = "", Code = "AS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihar", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chandigarh", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chhattisgarh", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dadra and Nagar Haveli", French = "", Code = "DN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daman and Diu", French = "", Code = "DD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delhi", French = "", Code = "DL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Goa", French = "", Code = "GA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gujarat", French = "", Code = "GJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haryana", French = "", Code = "HR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Himachal Pradesh", French = "", Code = "HP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jammu and Kashmir", French = "", Code = "JK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jharkhand", French = "", Code = "JH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karnataka", French = "", Code = "KA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kerala", French = "", Code = "KL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lakshadweep", French = "", Code = "LD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madhya Pradesh", French = "", Code = "MP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maharashtra", French = "", Code = "MH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manipur", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Meghalaya", French = "", Code = "ML", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mizoram", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagaland", French = "", Code = "NL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orissa", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pondicherry", French = "", Code = "PY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Punjab", French = "", Code = "PB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rajasthan", French = "", Code = "RJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sikkim", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamil Nadu", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tripura", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttar Pradesh", French = "", Code = "UP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaranchal", French = "", Code = "UL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Bengal", French = "", Code = "WB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Italy")
            {
                return new List<Province>()
                {
                    new Province() { English = "Agrigento", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alessandria", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ancona", French = "", Code = "AN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aosta", French = "", Code = "AO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arezzo", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ascoli Piceno", French = "", Code = "AP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asti", French = "", Code = "AT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Avellino", French = "", Code = "AV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bari", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barletta-Andria-Trani", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belluno", French = "", Code = "BL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benevento", French = "", Code = "BN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bergamo", French = "", Code = "BG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biella", French = "", Code = "BI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bologna", French = "", Code = "BO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolzano", French = "", Code = "BZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brescia", French = "", Code = "BS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brindisi", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagliari", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caltanissetta", French = "", Code = "CL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campobasso", French = "", Code = "CB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carbonia-Iglesias", French = "", Code = "CI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caserta", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catania", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanzaro", French = "", Code = "CZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chieti", French = "", Code = "CH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Como", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cosenza", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cremona", French = "", Code = "CR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Crotone", French = "", Code = "KR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuneo", French = "", Code = "CN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enna", French = "", Code = "EN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermo", French = "", Code = "FM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ferrara", French = "", Code = "FE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Firenze (Florence)", French = "", Code = "FI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Foggia", French = "", Code = "FG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Forlì-Cesena", French = "", Code = "FO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Frosinone", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Genova (Genoa)", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorizia", French = "", Code = "GO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Grosseto", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Imperia", French = "", Code = "IM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isernia", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Spezia", French = "", Code = "SP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "L'Aquila", French = "", Code = "AQ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Latina", French = "", Code = "LT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecce", French = "", Code = "LE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lecco", French = "", Code = "LC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Livorno", French = "", Code = "LI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lodi", French = "", Code = "LO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucca", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Macerata", French = "", Code = "MC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mantova (Mantua)", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massa-Carrara", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Matera", French = "", Code = "MT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medio Campidano", French = "", Code = "MD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Messina", French = "", Code = "ME", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milano (Milan)", French = "", Code = "MI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Modena", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monza", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Napoli (Naples)", French = "", Code = "NA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Novara", French = "", Code = "NO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuoro", French = "", Code = "NU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ogliastra", French = "", Code = "OG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olbia-Tempio", French = "", Code = "OT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oristano", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Padova (Padua)", French = "", Code = "PD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palermo", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Parma", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pavia", French = "", Code = "PV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perugia", French = "", Code = "PG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pesaro e Urbino", French = "", Code = "PS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pescara", French = "", Code = "PE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Piacenza", French = "", Code = "PC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pisa", French = "", Code = "PI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pistoia", French = "", Code = "PT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pordenone", French = "", Code = "PN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Potenza", French = "", Code = "PZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prato", French = "", Code = "PO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ragusa", French = "", Code = "RG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ravenna", French = "", Code = "RA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Calabria", French = "", Code = "RC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reggio Emilia", French = "", Code = "RE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rieti", French = "", Code = "RI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rimini", French = "", Code = "RN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roma (Rome)", French = "", Code = "RM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rovigo", French = "", Code = "RO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salerno", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sassari", French = "", Code = "SS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Savona", French = "", Code = "SV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siena", French = "", Code = "SI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siracusa (Syracuse)", French = "", Code = "SR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sondrio", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Taranto", French = "", Code = "TA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teramo", French = "", Code = "TE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terni", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torino (Turin)", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trapani", French = "", Code = "TP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trento", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Treviso", French = "", Code = "TV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trieste", French = "", Code = "TS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udine", French = "", Code = "UD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Varese", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Venezia (Venice)", French = "", Code = "VE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verbano-Cusio-Ossola", French = "", Code = "VB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vercelli", French = "", Code = "VC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Verona", French = "", Code = "VR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vibo Valentia", French = "", Code = "VV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vicenza", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Viterbo", French = "", Code = "VT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Japan")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aiti (Aichi)", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Akita", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aomori", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ehime", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gihu (Gifu)", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gunma", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hirosima (Hiroshima)", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hokkaido", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukui (Fukui)", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukuoka (Fukuoka)", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hukusima (Fukushima)", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hyogo", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ibaraki", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isikawa (Ishikawa)", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iwate", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagawa", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kagosima (Kagoshima)", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanagawa", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Koti (Kochi)", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kumamoto", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kyoto", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mie", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyagi", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Miyazaki", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagano", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nagasaki", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nara", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Niigata", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oita", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okayama", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Okinawa", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osaka", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saga", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saitama", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siga (Shiga)", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Simane (Shimane)", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sizuoka (Shizuoka)", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tiba (Chiba)", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokusima (Tokushima)", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokyo", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Totigi (Tochigi)", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tottori", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toyama", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakayama", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamagata", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamaguti (Yamaguchi)", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yamanasi (Yamanashi)", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Korea, Republic of")
            {
                return new List<Province>()
                {
                    new Province() { English = "Busan (M)", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongbuk-do", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chungcheongnam-do", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daegu (M)", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Daejeon (M)", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gangwon-do", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwangju (M)", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeonggi-do", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangbuk-do", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gyeongsangnam-do", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Incheon (M)", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeju-do", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollabuk-do", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jeollanam-do", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seoul (S)", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ulsan (M)", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Malaysia")
            {
                return new List<Province>()
                {
                    new Province() { English = "Johor", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kedah", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kelantan", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kuala Lumpur", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Labuan", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melaka", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negeri Sembilan", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pahang", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perak", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perlis", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pulau Pinang", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Putrajaya", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sabah", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarawak", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Selangor", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Terengganu", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Mexico")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aguascalientes", French = "", Code = "AGU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California", French = "", Code = "BCN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baja California Sur", French = "", Code = "BCS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Campeche", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiapas", French = "", Code = "CHP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chihuahua", French = "", Code = "CHH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coahuila", French = "", Code = "COA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colima", French = "", Code = "COL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durango", French = "", Code = "DUR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guanajuato", French = "", Code = "GUA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guerrero", French = "", Code = "GRO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hidalgo", French = "", Code = "HID", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jalisco", French = "", Code = "JAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mexico", French = "", Code = "MEX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michoacán", French = "", Code = "MIC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Morelos", French = "", Code = "MOR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nayarit", French = "", Code = "NAY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nuevo León", French = "", Code = "NLE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oaxaca", French = "", Code = "OAX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puebla", French = "", Code = "PUE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Querétaro", French = "", Code = "QUE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quintana Roo", French = "", Code = "ROO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "San Luis Potosí", French = "", Code = "SLP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinaloa", French = "", Code = "SIN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sonora", French = "", Code = "SON", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tabasco", French = "", Code = "TAB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tamaulipas", French = "", Code = "TAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tlaxcala", French = "", Code = "TLA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Veracruz", French = "", Code = "VER", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yucatán", French = "", Code = "YUC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zacatecas", French = "", Code = "ZAC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Netherlands")
            {
                return new List<Province>()
                {
                    new Province() { English = "Drenthe", French = "", Code = "DR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flevoland", French = "", Code = "FL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Friesland", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gelderland", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Groningen", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Brabant", French = "", Code = "NB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Noord Holland", French = "", Code = "NH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Overijssel", French = "", Code = "OV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utrecht", French = "", Code = "UT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zeeland", French = "", Code = "ZE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zuid Holland", French = "", Code = "ZH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Norway")
            {
                return new List<Province>()
                {
                    new Province() { English = "Akershus", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aust-Agder", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buskerud", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Finnmark", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hedmark", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hordaland", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Møre og Romsdal", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nordland", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nord-Trøndelag", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oppland", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oslo", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Østfold", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rogaland", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sogn og Fjordane", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sør-Trøndelag", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telemark", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Troms", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vest-Agder", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vestfold", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Philippines")
            {
                return new List<Province>()
                {
                    new Province() { English = "Abra", French = "", Code = "ABR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Norte", French = "", Code = "AGN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agusan del Sur", French = "", Code = "AGS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aklan", French = "", Code = "AKL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albay", French = "", Code = "ALB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antique", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Apayao", French = "", Code = "APA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aurora", French = "", Code = "AUR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Autonomous Region in Muslim Mindanao (ARMM)", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basilan", French = "", Code = "BAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bataan", French = "", Code = "BAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batanes", French = "", Code = "BTN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batangas", French = "", Code = "BTG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Benguet", French = "", Code = "BEN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bicol", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Biliran", French = "", Code = "BIL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bohol", French = "", Code = "BOH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bukidnon", French = "", Code = "BUK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bulacan", French = "", Code = "BUL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan", French = "", Code = "CAG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cagayan Valley", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Norte", French = "", Code = "CAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camarines Sur", French = "", Code = "CAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camiguin", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Capiz", French = "", Code = "CAP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "CARAGA", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Catanduanes", French = "", Code = "CAT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cavite", French = "", Code = "CAV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cebu", French = "", Code = "CEB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Luzon", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Mindanao", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Central Visayas", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Compostela Valley", French = "", Code = "COM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cordillera Administrative Region (CAR)", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cotabato (North Cotabato)", French = "", Code = "NCO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Norte", French = "", Code = "DAV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao del Sur", French = "", Code = "DAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Davao Oriental", French = "", Code = "DAO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Samar", French = "", Code = "EAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eastern Visayas", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guimaras", French = "", Code = "GUI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ifugao", French = "", Code = "IFU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Norte", French = "", Code = "ILN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilocos Sur", French = "", Code = "ILS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iloilo", French = "", Code = "ILI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isabela", French = "", Code = "ISA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalinga", French = "", Code = "KAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "La Union", French = "", Code = "LUN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Laguna", French = "", Code = "LAG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Norte", French = "", Code = "LAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lanao del Sur", French = "", Code = "LAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leyte", French = "", Code = "LEY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maguindanao", French = "", Code = "MAG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Marinduque", French = "", Code = "MAD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Masbate", French = "", Code = "MAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Occidental", French = "", Code = "MDC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mindoro Oriental", French = "", Code = "MDR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Occidental", French = "", Code = "MSC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Misamis Oriental", French = "", Code = "MSR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mountain Province", French = "", Code = "MOU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "National Capital Region (Manila)", French = "", Code = "00", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Occidental", French = "", Code = "NEC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Negros Oriental", French = "", Code = "NER", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mindanao", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Samar", French = "", Code = "NSA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Ecija", French = "", Code = "NUE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nueva Vizcaya", French = "", Code = "NUV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palawan", French = "", Code = "PLW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pampanga", French = "", Code = "PAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pangasinan", French = "", Code = "PAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quezon", French = "", Code = "QUE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Quirino", French = "", Code = "QUI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rizal", French = "", Code = "RIZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Romblon", French = "", Code = "ROM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samar (Western Samar)", French = "", Code = "WSA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sarangani", French = "", Code = "SAR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siquijor", French = "", Code = "SIG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sorsogon", French = "", Code = "SOR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Cotabato", French = "", Code = "SCO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Leyte", French = "", Code = "SLE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Mindanao", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southern Tagalog", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sultan Kudarat", French = "", Code = "SUK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sulu", French = "", Code = "SLU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Norte", French = "", Code = "SUN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surigao del Sur", French = "", Code = "SUR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarlac", French = "", Code = "TAR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tawi-Tawi", French = "", Code = "TAW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Mindanao", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Western Visayas", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zambales", French = "", Code = "ZMB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Norte", French = "", Code = "ZAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga del Sur", French = "", Code = "ZAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamboanga Sibugay", French = "", Code = "ZSI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Poland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Dolnoslaskie", French = "", Code = "DS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kujawsko-pomorskie", French = "", Code = "KP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lódzkie", French = "", Code = "LD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubelskie", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lubuskie", French = "", Code = "LB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malopolskie", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mazowieckie", French = "", Code = "MZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Opolskie", French = "", Code = "OP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podkarpackie", French = "", Code = "PK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Podlaskie", French = "", Code = "PD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pomorskie", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slaskie", French = "", Code = "SL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swietokrzyskie", French = "", Code = "SK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warminsko-mazurskie", French = "", Code = "WN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wielkopolskie", French = "", Code = "WP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zachodniopomorskie", French = "", Code = "ZP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Romania")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alba", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arad", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arges", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bacau", French = "", Code = "BC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bihor", French = "", Code = "BH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bistrita-Nasaud", French = "", Code = "BN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Botosani", French = "", Code = "BT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Braila", French = "", Code = "BR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brasov", French = "", Code = "BV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bucuresti", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buzau", French = "", Code = "BZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calarasi", French = "", Code = "CL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caras-Severin", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cluj", French = "", Code = "CJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Constanta", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Covasna", French = "", Code = "CV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dâmbovita", French = "", Code = "DB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dolj", French = "", Code = "DJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Galati", French = "", Code = "GL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giurgiu", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gorj", French = "", Code = "GJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harghita", French = "", Code = "HG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hunedoara", French = "", Code = "HD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ialomita", French = "", Code = "IL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iasi", French = "", Code = "IS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ilfov", French = "", Code = "IF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maramures", French = "", Code = "MM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mehedinti", French = "", Code = "MH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mures", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neamt", French = "", Code = "NT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Olt", French = "", Code = "OT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prahova", French = "", Code = "PH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salaj", French = "", Code = "SJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satu Mare", French = "", Code = "SM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sibiu", French = "", Code = "SB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suceava", French = "", Code = "SV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teleorman", French = "", Code = "TR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Timis", French = "", Code = "TM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tulcea", French = "", Code = "TL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vâlcea", French = "", Code = "VL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaslui", French = "", Code = "VS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vrancea", French = "", Code = "VR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Spain")
            {
                return new List<Province>()
                {
                    new Province() { English = "A Coruña", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Álava", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Albacete", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alicante", French = "", Code = "A", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Almería", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Asturias", French = "", Code = "O", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ávila", French = "", Code = "AV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Badajoz", French = "", Code = "BA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Baleares", French = "", Code = "PM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barcelona", French = "", Code = "B", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burgos", French = "", Code = "BU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cáceres", French = "", Code = "CC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cádiz", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cantabria", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castellón", French = "", Code = "CS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceuta", French = "", Code = "CE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ciudad Real", French = "", Code = "CR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cuenca", French = "", Code = "CU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Girona", French = "", Code = "GI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Granada", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guadalajara", French = "", Code = "GU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guipúzcoa", French = "", Code = "SS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huelva", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Huesca", French = "", Code = "HU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jaén", French = "", Code = "J", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Las Palmas", French = "", Code = "GC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "León", French = "", Code = "LE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lleida", French = "", Code = "L", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lugo", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Madrid", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Málaga", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Melilla", French = "", Code = "ML", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Murcia", French = "", Code = "MU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Navarre", French = "", Code = "NA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ourense", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Palencia", French = "", Code = "P", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pontevedra", French = "", Code = "PO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salamanca", French = "", Code = "SA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Santa Cruz De Tenerife", French = "", Code = "TF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Segovia", French = "", Code = "SG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Seville", French = "", Code = "SE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Soria", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tarragona", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Teruel", French = "", Code = "TE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Toledo", French = "", Code = "TO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valencia", French = "", Code = "V", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valladolid", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vizcaya", French = "", Code = "BI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zamora", French = "", Code = "ZA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zaragoza", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Sweden")
            {
                return new List<Province>()
                {
                    new Province() { English = "Blekinge", French = "", Code = "K", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dalarna", French = "", Code = "W", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gävleborg", French = "", Code = "X", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gotland", French = "", Code = "I", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halland", French = "", Code = "N", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jämtland", French = "", Code = "Z", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jönköping", French = "", Code = "F", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalmar", French = "", Code = "H", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kronoberg", French = "", Code = "G", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norrbotten", French = "", Code = "BD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Örebro", French = "", Code = "T", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Östergötland", French = "", Code = "E", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Skåne", French = "", Code = "M", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Södermanland", French = "", Code = "D", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockholm", French = "", Code = "AB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uppsala", French = "", Code = "C", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Värmland", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västerbotten", French = "", Code = "AC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västernorrland", French = "", Code = "Y", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västmanland", French = "", Code = "U", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Västra Götaland", French = "", Code = "O", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Switzerland")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aargau (Argovia)", French = "", Code = "AG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Ausserrhoden (Outer Rhodes)", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Appenzell Innerrhoden (Inner Rhodes)", French = "", Code = "AI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Landschaft (Basle-Country)", French = "", Code = "BL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Basel-Stadt (Basle-City)", French = "", Code = "BS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bern (Berne)", French = "", Code = "BE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fribourg", French = "", Code = "FR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Geneva", French = "", Code = "GE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glarus", French = "", Code = "GL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Graubünden (Grisons)", French = "", Code = "GR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lucerne", French = "", Code = "LU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neuchâtel", French = "", Code = "NE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nidwalden (Nidwald)", French = "", Code = "NW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Obwalden (Obwald)", French = "", Code = "OW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schaffhausen", French = "", Code = "SH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Schwyz", French = "", Code = "SZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solothurn", French = "", Code = "SO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "St. Gallen (St. Gall)", French = "", Code = "SG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurgau (Thurgovia)", French = "", Code = "TG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ticino", French = "", Code = "TI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uri", French = "", Code = "UR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Valais", French = "", Code = "VS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vaud", French = "", Code = "VD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zug", French = "", Code = "ZG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zürich (Zurich)", French = "", Code = "ZH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Thailand")
            {
                return new List<Province>()
                {
                    new Province() { English = "Amnat Charoen", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ang Thong", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bangkok", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buri Ram", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chachoengsao", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chai Nat", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chaiyaphum", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chanthaburi", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Mai", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chiang Rai", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chon Buri", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Chumpon", French = "", Code = "86", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kalasin", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kamphaeng Phet", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kanchanaburi", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Khon Kaen", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Krabi", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lampang", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lamphun", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Loei", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lop Buri", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mae Hong Son", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maha Sarakham", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mukdahan", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Nayok", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Pathom", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Phanom", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Ratchasima", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Sawan", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nakhon Si Thammarat", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nan", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Narathiwat", French = "", Code = "96", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Bua Lam Phu", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nong Khai", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nonthaburi", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pathum Thani", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattani", French = "", Code = "94", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pattaya", French = "", Code = "S", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phang Nga", French = "", Code = "82", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phattalung", French = "", Code = "93", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phayao", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchabun", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phetchaburi", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phichit", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phitsanulok", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phra Nakhon Si Ayutthaya", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phrae", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Phuket", French = "", Code = "83", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachin Buri", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Prachuap Khiri Khan", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ranong", French = "", Code = "85", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ratchaburi", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rayong", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Roi Et", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sa Kaeo", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakon Nakhon", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Prakan", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Sakhon", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samut Songkhram", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Saraburi", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Satun", French = "", Code = "91", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Si Sa Ket", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sing Buri", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Songkhla", French = "", Code = "90", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sukhothai", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suphanburi", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surat Thani", French = "", Code = "84", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surin", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tak", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trang", French = "", Code = "92", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trat", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ubon Ratchathani", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Udon Thani", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uthai Thani", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Uttaradit", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yala", French = "", Code = "95", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yasothon", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "Turkey")
            {
                return new List<Province>()
                {
                    new Province() { English = "Adana", French = "", Code = "01", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Adiyaman", French = "", Code = "02", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Afyonkarahisar", French = "", Code = "03", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Agri", French = "", Code = "04", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aksaray", French = "", Code = "68", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Amasya", French = "", Code = "05", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ankara", French = "", Code = "06", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antalya", French = "", Code = "07", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ardahan", French = "", Code = "75", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Artvin", French = "", Code = "08", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aydin", French = "", Code = "09", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Balikesir", French = "", Code = "10", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bartin", French = "", Code = "74", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Batman", French = "", Code = "72", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bayburt", French = "", Code = "69", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bilecik", French = "", Code = "11", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bingöl", French = "", Code = "12", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bitlis", French = "", Code = "13", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolu", French = "", Code = "14", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Burdur", French = "", Code = "15", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bursa", French = "", Code = "16", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çanakkale", French = "", Code = "17", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çankiri", French = "", Code = "18", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Çorum", French = "", Code = "19", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denizli", French = "", Code = "20", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Diyarbakir", French = "", Code = "21", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Düzce", French = "", Code = "81", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edirne", French = "", Code = "22", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Elazig", French = "", Code = "23", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzincan", French = "", Code = "24", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Erzurum", French = "", Code = "25", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eskisehir", French = "", Code = "26", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gaziantep", French = "", Code = "27", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Giresun", French = "", Code = "28", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gümüshane", French = "", Code = "29", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hakkari", French = "", Code = "30", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hatay", French = "", Code = "31", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Igdir", French = "", Code = "76", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isparta", French = "", Code = "32", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Istanbul", French = "", Code = "34", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Izmir", French = "", Code = "35", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kahramanmaras", French = "", Code = "46", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karabük", French = "", Code = "78", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Karaman", French = "", Code = "70", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kars", French = "", Code = "36", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kastamonu", French = "", Code = "37", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kayseri", French = "", Code = "38", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kilis", French = "", Code = "79", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirikkale", French = "", Code = "71", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklareli", French = "", Code = "39", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirsehir", French = "", Code = "40", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kocaeli", French = "", Code = "41", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Konya", French = "", Code = "42", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kütahya", French = "", Code = "43", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Malatya", French = "", Code = "44", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manisa", French = "", Code = "45", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mardin", French = "", Code = "47", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mersin", French = "", Code = "33", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mugla", French = "", Code = "48", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mus", French = "", Code = "49", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevsehir", French = "", Code = "50", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nigde", French = "", Code = "51", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ordu", French = "", Code = "52", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Osmaniye", French = "", Code = "80", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rize", French = "", Code = "53", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sakarya", French = "", Code = "54", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Samsun", French = "", Code = "55", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sanliurfa", French = "", Code = "63", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Siirt", French = "", Code = "56", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sinop", French = "", Code = "57", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sirnak", French = "", Code = "73", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sivas", French = "", Code = "58", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tekirdag", French = "", Code = "59", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tokat", French = "", Code = "60", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trabzon", French = "", Code = "61", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tunceli", French = "", Code = "62", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Usak", French = "", Code = "64", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Van", French = "", Code = "65", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yalova", French = "", Code = "77", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Yozgat", French = "", Code = "66", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Zonguldak", French = "", Code = "67", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United Kingdom")
            {
                return new List<Province>()
                {
                    new Province() { English = "Aberdeen", French = "", Code = "ABE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Aberdeenshire", French = "", Code = "ABD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Angus", French = "", Code = "ANS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Antrim", French = "", Code = "ANT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ards", French = "", Code = "ARD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Argyll and Bute", French = "", Code = "AGB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Armagh", French = "", Code = "ARM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymena", French = "", Code = "BLA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ballymoney", French = "", Code = "BLY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Banbridge", French = "", Code = "BNB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barking and Dagenham (London borough)", French = "", Code = "BDG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnet (London borough)", French = "", Code = "BNE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Barnsley (South Yorkshire district)", French = "", Code = "BNS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bath and North East Somerset (unitary authority)", French = "", Code = "BAS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bedfordshire (county)", French = "", Code = "BDF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Belfast", French = "", Code = "BFS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bexley (London borough)", French = "", Code = "BEX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Birmingham (West Midlands district)", French = "", Code = "BIR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackburn with Darwen (unitary authority)", French = "", Code = "BBD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blackpool (unitary authority)", French = "", Code = "BPL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Blaenau Gwent", French = "", Code = "BGW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bolton (Greater Manchester district)", French = "", Code = "BOL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bournemouth (unitary authority)", French = "", Code = "BMH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bracknell Forest (unitary authority)", French = "", Code = "BRC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bradford (West Yorkshire district)", French = "", Code = "BRD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brent (London borough)", French = "", Code = "BEN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bridgend", French = "", Code = "BGE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Brighton and Hove (unitary authority)", French = "", Code = "BNH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bristol, City of (unitary authority)", French = "", Code = "BST", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bromley (London borough)", French = "", Code = "BRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Buckinghamshire (county)", French = "", Code = "BKM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Bury (Greater Manchester district)", French = "", Code = "BUR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Caerphilly", French = "", Code = "CAY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Calderdale (West Yorkshire district)", French = "", Code = "CLD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cambridgeshire (county)", French = "", Code = "CAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Camden (London borough)", French = "", Code = "CMD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cardiff", French = "", Code = "CRF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carmarthenshire", French = "", Code = "CMN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Carrickfergus", French = "", Code = "CKF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Castelreagh", French = "", Code = "CSR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ceredigion", French = "", Code = "CGN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cheshire (county)", French = "", Code = "CHS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Clackmannanshire", French = "", Code = "CLK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coleraine", French = "", Code = "CLR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Conwy", French = "", Code = "CWY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cookstown", French = "", Code = "CKT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cornwall (county)", French = "", Code = "CON", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Coventry (West Midlands district)", French = "", Code = "COV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Craigavon", French = "", Code = "CGV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Croydon (London borough)", French = "", Code = "CRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Cumbria (county)", French = "", Code = "CMA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Darlington (unitary authority)", French = "", Code = "DAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Denbighshire", French = "", Code = "DEN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derby (unitary authority)", French = "", Code = "DER", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derbyshire (county)", French = "", Code = "DBY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Derry", French = "", Code = "DRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Devon (county)", French = "", Code = "DEV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Doncaster (South Yorkshire district)", French = "", Code = "DNC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dorset (county)", French = "", Code = "DOR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Down", French = "", Code = "DOW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dudley (West Midlands district)", French = "", Code = "DUD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dumfries and Galloway", French = "", Code = "DGY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dundee", French = "", Code = "DND", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Dungannon and South Tyrone", French = "", Code = "DGN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Durham (county)", French = "", Code = "DUR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ealing (London borough)", French = "", Code = "EAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Ayrshire", French = "", Code = "EAY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Dunbartonshire", French = "", Code = "EDU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Lothian", French = "", Code = "ELN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Renfrewshire", French = "", Code = "ERW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Riding of Yorkshire (unitary authority)", French = "", Code = "ERY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "East Sussex (county)", French = "", Code = "ESX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Edinburgh", French = "", Code = "EDH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Eilean Siar", French = "", Code = "ELS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Enfield (London borough)", French = "", Code = "ENF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Essex (county)", French = "", Code = "ESS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Falkirk", French = "", Code = "FAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fermanagh", French = "", Code = "FER", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Fife", French = "", Code = "FIF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Flintshire", French = "", Code = "FLN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gateshead (Tyne & Wear district)", French = "", Code = "GAT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Glasgow", French = "", Code = "GLG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gloucestershire (county)", French = "", Code = "GLS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Greenwich (London borough)", French = "", Code = "GRE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guernsey", French = "", Code = "GSY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Gwynedd", French = "", Code = "GWN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hackney (London borough)", French = "", Code = "HCK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Halton (unitary authority)", French = "", Code = "HAL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hammersmith and Fulham (London borough)", French = "", Code = "HMF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hampshire (county)", French = "", Code = "HAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Haringey (London borough)", French = "", Code = "HRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Harrow (London borough)", French = "", Code = "HRW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hartlepool (unitary authority)", French = "", Code = "HPL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Havering (London borough)", French = "", Code = "HAV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Herefordshire, County of (unitary authority)", French = "", Code = "HEF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hertfordshire (county)", French = "", Code = "HRT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Highland", French = "", Code = "HLD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hillingdon (London borough)", French = "", Code = "HIL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hounslow (London borough)", French = "", Code = "HNS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Inverclyde", French = "", Code = "IVC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Anglesey", French = "", Code = "AGY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isle of Wight (unitary authority)", French = "", Code = "IOW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Isles of Scilly (special area)", French = "", Code = "IOS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Islington (London borough)", French = "", Code = "ISL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Jersey", French = "", Code = "JSY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kensington and Chelsea (London borough)", French = "", Code = "KEC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kent (county)", French = "", Code = "KEN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Hull, City of (unitary authority)", French = "", Code = "KHL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kingston upon Thames (London borough)", French = "", Code = "KTT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kirklees (West Yorkshire district)", French = "", Code = "KIR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Knowsley (Merseyside district)", French = "", Code = "KWL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lambeth (London borough)", French = "", Code = "LBH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lancashire (county)", French = "", Code = "LAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Larne", French = "", Code = "LRN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leeds (West Yorkshire district)", French = "", Code = "LDS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicester (unitary authority)", French = "", Code = "LCE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Leicestershire (county)", French = "", Code = "LEC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lewisham (London borough)", French = "", Code = "LEW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Limavady", French = "", Code = "LMV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lincolnshire (county)", French = "", Code = "LIN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Lisburn", French = "", Code = "LSB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Liverpool (Merseyside district)", French = "", Code = "LIV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "London, City of (London borough)", French = "", Code = "LND", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Luton (unitary authority)", French = "", Code = "LUT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Magherafelt", French = "", Code = "MFT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Manchester (Greater Manchester district)", French = "", Code = "MAN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Medway (unitary authority)", French = "", Code = "MDW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merthyr Tydfil", French = "", Code = "MTY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Merton (London borough)", French = "", Code = "MRT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Middlesbrough (unitary authority)", French = "", Code = "MDB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Midlothian", French = "", Code = "MLN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Milton Keynes (unitary authority)", French = "", Code = "MIK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Monmouthshire", French = "", Code = "MON", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moray", French = "", Code = "MRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Moyle", French = "", Code = "MYL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Neath Port Talbot", French = "", Code = "NTL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newcastle upon Tyne (Tyne & Wear district)", French = "", Code = "NET", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newham (London borough)", French = "", Code = "NWM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newport", French = "", Code = "NWP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newry and Mourne", French = "", Code = "NYM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Newtownabbey", French = "", Code = "NTA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Norfolk (county)", French = "", Code = "NFK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Ayrshire", French = "", Code = "NAY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Down", French = "", Code = "NDN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North East Lincolnshire (unitary authority)", French = "", Code = "NEL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lanarkshire", French = "", Code = "NLK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Lincolnshire (unitary authority)", French = "", Code = "NLN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Somerset (unitary authority)", French = "", Code = "NSM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Tyneside (Tyne & Wear district)", French = "", Code = "NTY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Yorkshire (county)", French = "", Code = "NYK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northamptonshire (county)", French = "", Code = "NTH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northumberland (county)", French = "", Code = "NBL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottingham (unitary authority)", French = "", Code = "NGM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nottinghamshire (county)", French = "", Code = "NTT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oldham (Greater Manchester district)", French = "", Code = "OLD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Omagh", French = "", Code = "OMH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Orkney Islands", French = "", Code = "ORK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oxfordshire (county)", French = "", Code = "OXF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pembrokeshire", French = "", Code = "PEM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Perth and Kinross", French = "", Code = "PKN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Peterborough (unitary authority)", French = "", Code = "PTE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Plymouth (unitary authority)", French = "", Code = "PLY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Poole (unitary authority)", French = "", Code = "POL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Portsmouth (unitary authority)", French = "", Code = "POR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Powys", French = "", Code = "POW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Reading (unitary authority)", French = "", Code = "RDG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redbridge (London borough)", French = "", Code = "RDB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Redcar and Cleveland (unitary authority)", French = "", Code = "RCC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Renfrewshire", French = "", Code = "RFW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhondda Cynon Taf", French = "", Code = "RCT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Richmond upon Thames (London borough)", French = "", Code = "RIC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rochdale (Greater Manchester district)", French = "", Code = "RCH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rotherham (South Yorkshire district)", French = "", Code = "ROT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rutland (unitary authority)", French = "", Code = "RUT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Salford (Greater Manchester district)", French = "", Code = "SLF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sandwell (West Midlands district)", French = "", Code = "SAW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Scottish Borders, The", French = "", Code = "SCB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sefton (Merseyside district)", French = "", Code = "SFT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sheffield (South Yorkshire district)", French = "", Code = "SHF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shetland Islands", French = "", Code = "ZET", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Shropshire (county)", French = "", Code = "SHR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Slough (unitary authority)", French = "", Code = "SLG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Solihull (West Midlands district)", French = "", Code = "SOL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Somerset (county)", French = "", Code = "SOM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Ayrshire", French = "", Code = "SAY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Gloucestershire (unitary authority)", French = "", Code = "SGC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Lanarkshire", French = "", Code = "SLK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Tyneside (Tyne & Wear district)", French = "", Code = "STY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southampton (unitary authority)", French = "", Code = "STH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southend-on-Sea (unitary authority)", French = "", Code = "SOS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Southwark (London borough)", French = "", Code = "SWK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "St Helens (Merseyside district)", French = "", Code = "SHN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Staffordshire (county)", French = "", Code = "STS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stirling", French = "", Code = "STG", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockport (Greater Manchester district)", French = "", Code = "SKP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stockton-on-Tees (unitary authority)", French = "", Code = "STT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Stoke-on-Trent (unitary authority)", French = "", Code = "STE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Strabane", French = "", Code = "STB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Suffolk (county)", French = "", Code = "SFK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sunderland (Tyne & Wear district)", French = "", Code = "SND", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Surrey (county)", French = "", Code = "SRY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Sutton (London borough)", French = "", Code = "STN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swansea", French = "", Code = "SWA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Swindon (unitary authority)", French = "", Code = "SWD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tameside (Greater Manchester district)", French = "", Code = "TAM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Telford and Wrekin (unitary authority)", French = "", Code = "TFW", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Thurrock (unitary authority)", French = "", Code = "THR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torbay (unitary authority)", French = "", Code = "TOB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Torfaen", French = "", Code = "TOF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tower Hamlets (London borough)", French = "", Code = "TWH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Trafford (Greater Manchester district)", French = "", Code = "TRF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vale of Glamorgan", French = "", Code = "VGL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wakefield (West Yorkshire district)", French = "", Code = "WKF", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Walsall (West Midlands district)", French = "", Code = "WLL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Waltham Forest (London borough)", French = "", Code = "WFT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wandsworth (London borough)", French = "", Code = "WND", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warrington (unitary authority)", French = "", Code = "WRT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Warwickshire (county)", French = "", Code = "WAR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Berkshire (unitary authority)", French = "", Code = "WB", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Dunbartonshire", French = "", Code = "WDU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Lothian", French = "", Code = "WLN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Sussex (county)", French = "", Code = "WSX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Westminster (London borough)", French = "", Code = "WSM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wigan (Greater Manchester district)", French = "", Code = "WGN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wiltshire (county)", French = "", Code = "WIL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Windsor and Maidenhead (unitary authority)", French = "", Code = "WNM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wirral (Merseyside district)", French = "", Code = "WRL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wokingham (unitary authority)", French = "", Code = "WOK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wolverhampton (West Midlands district)", French = "", Code = "WLV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Worcestershire (county)", French = "", Code = "WOR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wrexham", French = "", Code = "WRX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "York (unitary authority)", French = "", Code = "YOR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
                }.OrderBy(t => t.English);
            }
            else if (countryName == "United States")
            {
                return new List<Province>()
                {
                    new Province() { English = "Alabama", French = "", Code = "AL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Alaska", French = "", Code = "AK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "American Samoa", French = "", Code = "AS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arizona", French = "", Code = "AZ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Arkansas", French = "", Code = "AR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "California", French = "", Code = "CA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Colorado", French = "", Code = "CO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Connecticut", French = "", Code = "CT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Delaware", French = "", Code = "DE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "District of Columbia", French = "", Code = "DC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Florida", French = "", Code = "FL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Georgia", French = "", Code = "GA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Guam", French = "", Code = "GU", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Hawaii", French = "", Code = "HI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Idaho", French = "", Code = "ID", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Illinois", French = "", Code = "IL", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Indiana", French = "", Code = "IN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Iowa", French = "", Code = "IA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kansas", French = "", Code = "KS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Kentucky", French = "", Code = "KY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Louisiana", French = "", Code = "LA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maine", French = "", Code = "ME", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Maryland", French = "", Code = "MD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Massachusetts", French = "", Code = "MA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Michigan", French = "", Code = "MI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Minnesota", French = "", Code = "MN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Mississippi", French = "", Code = "MS", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Missouri", French = "", Code = "MO", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nebraska", French = "", Code = "NE", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Nevada", French = "", Code = "NV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Hampshire", French = "", Code = "NH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Jersey", French = "", Code = "NJ", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New Mexico", French = "", Code = "NM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "New York", French = "", Code = "NY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Carolina", French = "", Code = "NC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "North Dakota", French = "", Code = "ND", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Northern Mariana Islands", French = "", Code = "MP", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Ohio", French = "", Code = "OH", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oklahoma", French = "", Code = "OK", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Oregon", French = "", Code = "OR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Pennsylvania", French = "", Code = "PA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Puerto Rico", French = "", Code = "PR", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Rhode Island", French = "", Code = "RI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Carolina", French = "", Code = "SC", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "South Dakota", French = "", Code = "SD", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Tennessee", French = "", Code = "TN", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Texas", French = "", Code = "TX", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "U.S. Minor Outlying Islands", French = "", Code = "UM", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Utah", French = "", Code = "UT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Vermont", French = "", Code = "VT", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virgin Islands of the U.S.", French = "", Code = "VI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Virginia", French = "", Code = "VA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Washington", French = "", Code = "WA", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "West Virginia", French = "", Code = "WV", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wisconsin", French = "", Code = "WI", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                    new Province() { English = "Wyoming", French = "", Code = "WY", CountryID = countryid, ProvinceTypeId = ProvinceTypeId, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now }
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
                new SystemConfigurations() { FieldName = "ClassTime", FieldValue = @"9", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now},
                new SystemConfigurations() { FieldName = "Owner", FieldValue = @"© <a href=""http://www.offordcentre.com/readiness/index.html"">Offord Centre for Child Studies</a>", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Footer", FieldValue = @"McMaster University & Hamilton Health Sciences, Hamilton ON, Canada | Tel. (905)525-9140 27051", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Bootstrap Icons", FieldValue = @"https://icons.getbootstrap.com/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "UseIconic Icons", FieldValue = @"https://useiconic.com/icons/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "SimpleLine Icons - In Use", FieldValue = @"https://simplelineicons.github.io/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Fontawesome Icons", FieldValue = @"https://fontawesome.com/icons?d=gallery&m=free", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "IconMonster Icons", FieldValue = @"https://iconmonstr.com/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Material Icons", FieldValue = @"https://material.io/resources/icons/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Unicons Icons", FieldValue = @"https://iconscout.com/unicons", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Fabric Icons", FieldValue = @"https://uifabricicons.azurewebsites.net/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Feather Icons", FieldValue = @"https://feathericons.com/", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "Year", FieldValue = @"2020", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now },
                new SystemConfigurations() { FieldName = "DateFormat", FieldValue = @"yyyy-MM-dd", CreatedBy ="rennera", CreatedDate= DateTime.Now, ModifiedBy = "rennera", ModifiedDate = DateTime.Now }




            }.OrderBy(t => t.FieldName);
        }

        static IEnumerable<SpecialProblem> GetPreconfiguredSpecialProblem()
        {
            return new List<SpecialProblem>()
            {
                new SpecialProblem() { Code = "1", English = "Acquired Brain Injury", French= "Lésion cérébrale acquise", Sequence = 1, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "2", English = "ADHD", French= "Trouble déficitaire de l'attention ", Sequence = 2, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "5", English = "Autism Spectrum Disorder (ASD includes Autism, Asperger Syndrome, Pervasive Developmental Disorder not specified)", French= "Trouble du spectre de l'autisme (TSA) – comprend l'autisme, le syndrome d'Asperger, le trouble envahissant du développement non spécifié (TEDNS)", Sequence = 5, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "6", English = "Asthma", French= "Asthme", Sequence = 6, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "9", English = "Down Syndrome/other genetic", French= "Syndrome de Down/autre trouble génétique", Sequence = 22, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "10", English = "Developmentally Delayed/Global delay", French= "Retard du développement/retard global de développement", Sequence = 24, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "11", English = "Diabetes", French= "Diabète", Sequence = 21, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "12", English = "Epilepsy/Seizures", French= "Épilepsie", Sequence = 30, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "13", English = "Fetal Alcohol Spectrum Disorder (FASD) or Alcohol-Related Neurodevelopmental Disorder (ARND)", French= "Ensemble des troubles causés par l'alcoolisation fœtale (ETCAF) ou trouble neurologique du développement lié à l'alcool (TNDLA)", Sequence = 31, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "14", English = "Heart problems/stroke", French= "Troubles cardiaques/accident cérébrovasculaire ", Sequence = 32, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "15", English = "Intellectual delay (mild or moderate)", French= "Retard mental (léger ou moyen)", Sequence = 33, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "18", English = "Anxiety", French= "Anxiété", Sequence = 3, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "19", English = "Depression", French= "Dépression", Sequence = 20, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "20", English = "Oppositional defiant disorder/Conduct Disorder", French= "Trouble oppositionnel avec provocation/trouble des conduites ", Sequence = 42, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "22", English = "Cerebral palsy", French= "Paralysie cérébrale", Sequence = 11, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "23", English = "Juvenile Rheumatoid  Arthritis", French= "Arthrite chronique juvénile", Sequence = 34, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "24", English = "Muscular dystrophies", French= "Dystrophie musculaire", Sequence = 40, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "25", English = "Spina Bifida", French= "Spina-bifida", Sequence = 48, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "26", English = "Obesity", French= "Obésité", Sequence = 41, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "28", English = "Apraxia", French= "Apraxie", Sequence = 4, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "29", English = "Cleft palette/lip", French= "Fente palatine ou labiale", Sequence = 12, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "30", English = "Receptive or Expressive language", French= "Langage dans son versant réceptif/expression orale du langage ", Sequence = 45, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "31", English = "Selective Mutism", French= "Mutisme sélectif", Sequence = 47, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "33", English = "Other, not listed", French= "Autre, ne figurant pas sur la liste ", Sequence = 94, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "34", English = "Other Mental Health Disorders", French= "Autres troubles de santé mentale ", Sequence = 90, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "35", English = "Rett’s Disorder, Childhood Disintegrative Disorder [CDD]", French= "Syndrome de Rett, trouble désintégratif de l'enfance (TDE) ", Sequence = 46, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "36", English = "Other Speech & Language Disorders", French= "Autre trouble de la parole et du langage ", Sequence = 93, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "37", English = "Blind/Visually Impaired", French= "Cécité/déficience visuelle ", Sequence = 7, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "38", English = "Deaf/Hard of Hearing ", French= "Surdité/déficience auditive  ", Sequence = 23, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "39", English = "Other Sensory", French= "Autre trouble sensoriel ", Sequence = 92, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "40", English = "Mitochondrial disease", French= "Maladie mitochondriale", Sequence = 39, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "41", English = "Other Motor Impairment", French= "Autre déficience motrice", Sequence = 91, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "42", English = "Cystic Fibrosis (CF)", French= "Fibrose kystique", Sequence = 13, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "43", English = "Phenylketonuria (PKU) /other metabolic", French= "Phénylcétonurie/autre trouble métabolique", Sequence = 43, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "50", English = "Tourette Syndrome", French= "Syndrome de Tourette", Sequence = 50, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "51", English = "Learning disorders (reading, writing, math)", French= "Troubles d’apprentissage (lecture, écriture, mathématiques)", Sequence = 38, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new SpecialProblem() { Code = "52", English = "Cancer/Leukemia/Brain Tumour", French= "Cancer/leucémie/tumeur cérébrale", Sequence = 10, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<Language> GetPreconfiguredLanguage()
        {
            return new List<Language>()
            {
                new Language() { Code = "0", English = "Unknown", French = "Inconnu",  Sequence = 15, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "10", English = "Afrikaans", French = "Afrikaans",  Sequence = 20, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "20", English = "Albanian", French = "Albanais",  Sequence = 25, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "25", English = "Amharic", French = "Amharique",  Sequence = 30, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "30", English = "Arabic", French = "Arabe",  Sequence = 35, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "40", English = "Armenian", French = "Arménien",  Sequence = 40, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "42", English = "Ashanti", French = "Asante",  Sequence = 45, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "45", English = "Assyrian", French = "Assyrien",  Sequence = 50, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "50", English = "Azeri", French = "Azéri",  Sequence = 55, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "60", English = "Bengali", French = "Bengalais",  Sequence = 60, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "70", English = "Bihari", French = "Bihari",  Sequence = 65, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "80", English = "Bulgarian", French = "Bulgare",  Sequence = 70, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "90", English = "Burmese", French = "Birman",  Sequence = 75, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "100", English = "Cantonese", French = "Cantonais",  Sequence = 80, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "105", English = "Chiu Chow", French = "Chiu Chow",  Sequence = 85, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "108", English = "Cree", French = "Crie",  Sequence = 90, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "110", English = "Czech", French = "Tchèque",  Sequence = 95, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "120", English = "Danish", French = "Danois",  Sequence = 100, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "125", English = "Dari", French = "Dari",  Sequence = 105, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "130", English = "Dutch/Flemish", French = "Hollandais/flamand",  Sequence = 110, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "135", English = "Egyptian", French = "Égyptien",  Sequence = 115, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "140", English = "English", French = "Anglais",  Sequence = 120, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "150", English = "Estonian", French = "Estonien",  Sequence = 125, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "155", English = "Ethiopian", French = "Éthiopien",  Sequence = 130, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "160", English = "Finnish", French = "Finlandais",  Sequence = 145, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "170", English = "French", French = "Français",  Sequence = 150, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "175", English = "Fukienese", French = "Fou-kien",  Sequence = 155, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "180", English = "Gaelic", French = "Gaélique",  Sequence = 160, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "190", English = "German", French = "Allemand",  Sequence = 165, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "200", English = "Greek", French = "Grec",  Sequence = 175, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "210", English = "Gujarati", French = "Gujarati",  Sequence = 180, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "215", English = "Hakka", French = "Hakka",  Sequence = 185, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "220", English = "Hebrew", French = "Hébreu",  Sequence = 190, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "230", English = "Hindi", French = "Hindi",  Sequence = 195, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "240", English = "Hindustani", French = "Hindustani",  Sequence = 200, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "245", English = "Hok Chiu", French = "Hok Chiu",  Sequence = 205, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "250", English = "Hungarian", French = "Hongrois",  Sequence = 210, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "260", English = "Icelandic", French = "Islandais",  Sequence = 215, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "270", English = "Ilocano", French = "Ilocano",  Sequence = 220, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "275", English = "Indigenous (North American)", French = "Autochtones (Amérique du Nord)",  Sequence = 225, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "280", English = "Indigenous (South American)", French = "Autochtones (Amérique du Sud)",  Sequence = 230, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "285", English = "Inuktitut", French = "Inuktitut",  Sequence = 240, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "290", English = "Italian", French = "Italien",  Sequence = 245, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "295", English = "Jaffna", French = "Jaffna",  Sequence = 250, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "300", English = "Japanese", French = "Japonais",  Sequence = 255, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "310", English = "Katchi", French = "Katchi",  Sequence = 270, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "320", English = "Kannada", French = "Canara",  Sequence = 260, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "330", English = "Kashmiri", French = "Kashméré",  Sequence = 265, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "335", English = "Khmer", French = "Kampuchéen",  Sequence = 275, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "340", English = "Korean", French = "Coréen",  Sequence = 290, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "345", English = "Lao", French = "Lao",  Sequence = 300, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "350", English = "Latvian", French = "Lettonien",  Sequence = 305, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "355", English = "Lebanese", French = "Libanais",  Sequence = 310, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "360", English = "Lithuanian", French = "Lithuanien",  Sequence = 320, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "370", English = "Macedonian", French = "Macédonien",  Sequence = 325, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "375", English = "Malayalam", French = "Malayalam",  Sequence = 330, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "380", English = "Indonesian/Malay", French = "Indonésien/malais",  Sequence = 235, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "400", English = "Mandarin", French = "Mandarin",  Sequence = 335, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "410", English = "Marathi", French = "Marathi",  Sequence = 345, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "415", English = "Mohawk", French = "Mohawk",  Sequence = 355, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "420", English = "Norwegian", French = "Norvégien",  Sequence = 360, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "422", English = "Ojibway", French = "Ojibway",  Sequence = 365, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "425", English = "Pashto/Pushtu", French = "Afhgan/Pachtou",  Sequence = 370, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "430", English = "Farsi/Persian", French = "Parsi/Persan",  Sequence = 135, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "440", English = "Polish", French = "Polonais",  Sequence = 380, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "450", English = "Portuguese", French = "Portugais",  Sequence = 385, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "460", English = "Punjabi", French = "Punjabi",  Sequence = 390, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "480", English = "Romanian", French = "Roumain",  Sequence = 395, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "490", English = "Russian", French = "Russe",  Sequence = 400, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "495", English = "Serbian", French = "Serbe",  Sequence = 405, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "500", English = "Serbo-Croatian", French = "Serbo-croate",  Sequence = 410, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "505", English = "Sindhi", French = "Sindhi",  Sequence = 415, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "510", English = "Singhalese", French = "Cinghalais",  Sequence = 420, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "520", English = "Slovak", French = "Slovaque",  Sequence = 425, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "530", English = "Slovenian", French = "Slovène",  Sequence = 430, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "535", English = "Somali", French = "Somalien",  Sequence = 435, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "540", English = "Spanish", French = "Espagnol",  Sequence = 440, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "550", English = "Swahili", French = "Swahili",  Sequence = 445, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "560", English = "SwLudatash", French = "Suédois",  Sequence = 450, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "570", English = "Filipino/Tagalog", French = "Philippin/tagalog",  Sequence = 140, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "580", English = "Tamil", French = "Tamoul",  Sequence = 455, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "600", English = "Thai", French = "Thai",  Sequence = 460, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "610", English = "Tigrinia", French = "Tigrigna",  Sequence = 465, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "620", English = "Turkish", French = "Turque",  Sequence = 470, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "630", English = "Twi", French = "Twi",  Sequence = 475, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "640", English = "Ukrainian", French = "Ukrainien",  Sequence = 480, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "650", English = "Urdu", French = "Urdu",  Sequence = 485, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "660", English = "Vietnamese", French = "Vietnamien",  Sequence = 490, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "670", English = "Welsh", French = "Gallois",  Sequence = 495, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "680", English = "Patois/Creole", French = "Patois/créole",  Sequence = 375, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "685", English = "Xhosa", French = "Xhosa",  Sequence = 505, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "690", English = "Yiddish", French = "Yiddish",  Sequence = 510, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "700", English = "Yoruba", French = "Yoruba",  Sequence = 515, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "710", English = "Other", French = "Autre",  Sequence = 520, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "720", English = "Other Chinese", French = "Autre langue chinoise",  Sequence = 525, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "730", English = "Other African", French = "Autre langue africaine",  Sequence = 530, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "740", English = "Other Indian (Asia)", French = "Autre langue indienne (Asie)",  Sequence = 535, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "750", English = "Other Asian", French = "Autre langue asiatique",  Sequence = 540, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "760", English = "Other European", French = "Autre langue européenne",  Sequence = 545, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "365", English = "Lingala", French = "Lingala",  Sequence = 315, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "195", English = "Grebo", French = "Grebo",  Sequence = 170, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "342", English = "Kurdish", French = "Kurde",  Sequence = 295, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "315", English = "Kirundi", French = "Kirundi",  Sequence = 285, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "325", English = "Kinyarwanda", French = "Kinyarwanda",  Sequence = 280, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "378", English = "Manding", French = "Mandingues",  Sequence = 340, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "675", English = "Wolastoqiyik (Maliseet) ", French = "Wolastoqiyik (Maliseet) ",  Sequence = 500, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "412", English = "mi'kmaq", French = "mi'kmaq",  Sequence = 350, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "170", English = "French", French = "Français",  Sequence = 10, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Language() { Code = "140", English = "English", French = "Anglais",  Sequence = 5, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<Gender> GetPreconfiguredGender()
        {
            return new List<Gender>()
            {
                new Gender() { Code = "1", English = "Male", French = "Mâle",  Sequence = 1, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Gender() { Code = "2", English = "Female", French = "Femelle",  Sequence = 2, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}

            };
        }

        static IEnumerable<FileImportStatus> GetPreconfiguredFileImportStatus()
        {
            return new List<FileImportStatus>()
            {
                new FileImportStatus() { Code = "1", English = "Imported", French = "Importé",  Sequence = 1, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new FileImportStatus() { Code = "2", English = "Processed", French = "Traité",  Sequence = 2, CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<Orientation> GetPreconfiguredOrientation()
        {
            return new List<Orientation>()
            {
                new Orientation() { YearId= 1, English = "Horizontal", French = "Horizontal", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new Orientation() { YearId= 1, English = "Vertical", French = "Vertical", CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<LookupSet> GetPreconfiguredLookupSet()
        {
            return new List<LookupSet>()
            {
                new LookupSet() {LookupName="Languages",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="LandAgreements",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="NWTLanguages",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="EthnicStatus",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="ConsideredESL",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="Gender",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="ClassType",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="ClassAssignment",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="Status",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="YesNo",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="YesNoDontKnow",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="GoodAvgPoorDontKnow",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="OftenSometimesNeverDontKnow",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="ObservedDiagnosisBoth",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new LookupSet() {LookupName="FullPartDontknowNO",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<LookupSetOption> GetPreconfiguredLookupSetOption()
        {
            return new List<LookupSetOption>()
            {
                new LookupSetOption() {English="Yes",LookupSetId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Oui",Value=1,Sequence=10},
                new LookupSetOption() {English="No",LookupSetId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="non",Value=0,Sequence=20},
                new LookupSetOption() {English="Yes",LookupSetId=2,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="oui",Value=1,Sequence=10},
                new LookupSetOption() {English="No",LookupSetId=2,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="non",Value=2,Sequence=20},
                new LookupSetOption() {English="Don't Know",LookupSetId=2,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="ne sais pas",Value=3,Sequence=30},
                new LookupSetOption() {English="Very Good/Good",LookupSetId=3,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="très bon/bon",Value=1,Sequence=10},
                new LookupSetOption() {English="Average",LookupSetId=3,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="moyen",Value=2,Sequence=20},
                new LookupSetOption() {English="Poor/Very Poor",LookupSetId=3,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="mauvais/très mauvais",Value=3,Sequence=30},
                new LookupSetOption() {English="Don't Know",LookupSetId=3,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="ne sais pas",Value=4,Sequence=40},
                new LookupSetOption() {English="Often or Very True",LookupSetId=4,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="souvent ou très vrai",Value=1,Sequence=10},
                new LookupSetOption() {English="Sometimes or Somewhat True",LookupSetId=4,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="quelquefois ou assez vrai",Value=2,Sequence=20},
                new LookupSetOption() {English="Never or Not True",LookupSetId=4,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="jamais ou pas vrai",Value=3,Sequence=30},
                new LookupSetOption() {English="Don't Know",LookupSetId=4,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="ne sais pas",Value=4,Sequence=40},
                new LookupSetOption() {English="Yes Observed",LookupSetId=5,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="OUI Observations de l'enseignant(e)",Value=1,Sequence=10},
                new LookupSetOption() {English="Yes Parent Info/Medical Diagnosis",LookupSetId=5,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="OUI Renseignements des parents et/ou diagnostic médical",Value=2,Sequence=20},
                new LookupSetOption() {English="Both",LookupSetId=5,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="tous les deux",Value=3,Sequence=30},
                new LookupSetOption() {English="Full-Time",LookupSetId=6,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="à plein temps",Value=1,Sequence=10},
                new LookupSetOption() {English="Part-Time",LookupSetId=6,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="à temps partiel",Value=2,Sequence=20},
                new LookupSetOption() {English="Don't Know",LookupSetId=6,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="ne sais pas",Value=3,Sequence=30},
                new LookupSetOption() {English="No",LookupSetId=6,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="non",Value=4,Sequence=40},
                new LookupSetOption() {English="Child in class more than 1 month",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="dans la classe plus d'un mois",Value=1,Sequence=10},
                new LookupSetOption() {English="Child in class less than 1 month",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="dans la classe moins d'un mois",Value=2,Sequence=20},
                new LookupSetOption() {English="Moved out of this class",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="a quitté la classe",Value=3,Sequence=30},
                new LookupSetOption() {English="Moved out of school",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="a quitté l’école",Value=4,Sequence=40},
                new LookupSetOption() {English="Other",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="autre",Value=9,Sequence=50},
                new LookupSetOption() {English="registered non-attender",LookupSetId=7,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="inscrit mais non fréquentant",Value=6,Sequence=60},
                new LookupSetOption() {English="Kindergarten",LookupSetId=8,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Maternelle",Value=1,Sequence=10},
                new LookupSetOption() {English="K",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M",Value=1,Sequence=10},
                new LookupSetOption() {English="K-1",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-1",Value=2,Sequence=20},
                new LookupSetOption() {English="K-2",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-2",Value=3,Sequence=30},
                new LookupSetOption() {English="K-3",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-3",Value=4,Sequence=40},
                new LookupSetOption() {English="K-4",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-4",Value=5,Sequence=50},
                new LookupSetOption() {English="K-5",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-5",Value=6,Sequence=60},
                new LookupSetOption() {English="K-6",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="M-6",Value=7,Sequence=70},
                new LookupSetOption() {English="Other",LookupSetId=9,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre",Value=8,Sequence=80},
                new LookupSetOption() {English="Male",LookupSetId=10,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Masculin",Value=1,Sequence=10},
                new LookupSetOption() {English="Female",LookupSetId=10,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Feminin",Value=2,Sequence=20},
                new LookupSetOption() {English="No",LookupSetId=11,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Non",Value=0,Sequence=10},
                new LookupSetOption() {English="ESL",LookupSetId=11,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="ALS",Value=1,Sequence=20},
                new LookupSetOption() {English="FSL",LookupSetId=11,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="FLS",Value=2,Sequence=30},
                new LookupSetOption() {English="Dene(D)",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Déné",Value=1,Sequence=10},
                new LookupSetOption() {English="Inuit/Inuvialuit (I)",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inuit/Inuvialuit",Value=2,Sequence=20},
                new LookupSetOption() {English="Metis (M)",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Métis",Value=3,Sequence=30},
                new LookupSetOption() {English="Southern Aboriginal (S)",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autochtone du sud",Value=4,Sequence=40},
                new LookupSetOption() {English="Non-Aboriginal (N)",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Non autochtone",Value=5,Sequence=50},
                new LookupSetOption() {English="Don't Know",LookupSetId=12,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Ne sais pas",Value=6,Sequence=60},
                new LookupSetOption() {English="Chipewyan",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Chippewyan",Value=31,Sequence=10},
                new LookupSetOption() {English="Cree",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Cri",Value=32,Sequence=20},
                new LookupSetOption() {English="English",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Anglais",Value=33,Sequence=30},
                new LookupSetOption() {English="French",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Fran&ccedil;ais",Value=34,Sequence=40},
                new LookupSetOption() {English="Gwich'in",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Gwich'in",Value=35,Sequence=50},
                new LookupSetOption() {English="Inuinnaqtun",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inuinnaqtun",Value=36,Sequence=60},
                new LookupSetOption() {English="Inuktitut",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Cri",Value=37,Sequence=70},
                new LookupSetOption() {English="Inuvialuktun",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inuvialuktun",Value=38,Sequence=80},
                new LookupSetOption() {English="North Slavey",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Langue des Esclaves du nord",Value=39,Sequence=90},
                new LookupSetOption() {English="South Slavey",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Langue des Esclaves du sud",Value=40,Sequence=100},
                new LookupSetOption() {English="Tlicho (Dogrib)",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Tlicho (Dogrib)",Value=41,Sequence=110},
                new LookupSetOption() {English="Other",LookupSetId=13,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre",Value=42,Sequence=120},
                new LookupSetOption() {English="Inuvialuit",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inuvialuit",Value=1,Sequence=10},
                new LookupSetOption() {English="Gwich'in",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Gwich'in",Value=2,Sequence=20},
                new LookupSetOption() {English="Sahtu",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Sahtu",Value=3,Sequence=30},
                new LookupSetOption() {English="Tlicho",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Tlicho",Value=4,Sequence=40},
                new LookupSetOption() {English="Don't Know",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Ne sais pas",Value=5,Sequence=50},
                new LookupSetOption() {English="No",LookupSetId=14,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Non",Value=6,Sequence=60},
                new LookupSetOption() {English="English",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Anglais",Value=140,Sequence=10},
                new LookupSetOption() {English="French",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Français",Value=170,Sequence=20},
                new LookupSetOption() {English="Unknown",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inconnu",Value=0,Sequence=30},
                new LookupSetOption() {English="Afrikaans",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Afrikaans",Value=10,Sequence=40},
                new LookupSetOption() {English="Albanian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Albanais",Value=20,Sequence=50},
                new LookupSetOption() {English="Amharic",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Amharique",Value=25,Sequence=60},
                new LookupSetOption() {English="Arabic",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Arabe",Value=30,Sequence=70},
                new LookupSetOption() {English="Armenian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Arménien",Value=40,Sequence=80},
                new LookupSetOption() {English="Ashanti",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Asante",Value=42,Sequence=90},
                new LookupSetOption() {English="Assyrian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Assyrien",Value=45,Sequence=100},
                new LookupSetOption() {English="Azeri",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Azéri",Value=50,Sequence=110},
                new LookupSetOption() {English="Bengali",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Bengalais",Value=60,Sequence=120},
                new LookupSetOption() {English="Bihari",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Bihari",Value=70,Sequence=130},
                new LookupSetOption() {English="Bulgarian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Bulgare",Value=80,Sequence=140},
                new LookupSetOption() {English="Burmese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Birman",Value=90,Sequence=150},
                new LookupSetOption() {English="Cantonese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Cantonais",Value=100,Sequence=160},
                new LookupSetOption() {English="Chiu Chow",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Chiu Chow",Value=105,Sequence=170},
                new LookupSetOption() {English="Cree",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Crie",Value=108,Sequence=180},
                new LookupSetOption() {English="Czech",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Tchèque",Value=110,Sequence=190},
                new LookupSetOption() {English="Danish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Danois",Value=120,Sequence=200},
                new LookupSetOption() {English="Dari",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Dari",Value=125,Sequence=210},
                new LookupSetOption() {English="Dutch/Flemish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hollandais/flamand",Value=130,Sequence=220},
                new LookupSetOption() {English="Egyptian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Égyptien",Value=135,Sequence=230},
                new LookupSetOption() {English="English",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Anglais",Value=140,Sequence=240},
                new LookupSetOption() {English="Estonian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Estonien",Value=150,Sequence=250},
                new LookupSetOption() {English="Ethiopian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Éthiopien",Value=155,Sequence=260},
                new LookupSetOption() {English="Farsi/Persian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Parsi/Persan",Value=430,Sequence=270},
                new LookupSetOption() {English="Filipino/Tagalog",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Philippin/tagalog",Value=570,Sequence=280},
                new LookupSetOption() {English="Finnish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Finlandais",Value=160,Sequence=290},
                new LookupSetOption() {English="French",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Français",Value=170,Sequence=300},
                new LookupSetOption() {English="Fukienese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Fou-kien",Value=175,Sequence=310},
                new LookupSetOption() {English="Gaelic",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Gaélique",Value=180,Sequence=320},
                new LookupSetOption() {English="German",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Allemand",Value=190,Sequence=330},
                new LookupSetOption() {English="Grebo",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Grebo",Value=195,Sequence=340},
                new LookupSetOption() {English="Greek",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Grec",Value=200,Sequence=350},
                new LookupSetOption() {English="Gujarati",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Gujarati",Value=210,Sequence=360},
                new LookupSetOption() {English="Hakka",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hakka",Value=215,Sequence=370},
                new LookupSetOption() {English="Hebrew",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hébreu",Value=220,Sequence=380},
                new LookupSetOption() {English="Hindi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hindi",Value=230,Sequence=390},
                new LookupSetOption() {English="Hindustani",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hindustani",Value=240,Sequence=400},
                new LookupSetOption() {English="Hok Chiu",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hok Chiu",Value=245,Sequence=410},
                new LookupSetOption() {English="Hungarian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Hongrois",Value=250,Sequence=420},
                new LookupSetOption() {English="Icelandic",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Islandais",Value=260,Sequence=430},
                new LookupSetOption() {English="Ilocano",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Ilocano",Value=270,Sequence=440},
                new LookupSetOption() {English="Indigenous (North American)",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autochtones (Amérique du Nord)",Value=275,Sequence=450},
                new LookupSetOption() {English="Indigenous (South American)",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autochtones (Amérique du Sud)",Value=280,Sequence=460},
                new LookupSetOption() {English="Indonesian/Malay",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Indonésien/malais",Value=380,Sequence=470},
                new LookupSetOption() {English="Inuktitut",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Inuktitut",Value=285,Sequence=480},
                new LookupSetOption() {English="Italian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Italien",Value=290,Sequence=490},
                new LookupSetOption() {English="Jaffna",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Jaffna",Value=295,Sequence=500},
                new LookupSetOption() {English="Japanese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Japonais",Value=300,Sequence=510},
                new LookupSetOption() {English="Kannada",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Canara",Value=320,Sequence=520},
                new LookupSetOption() {English="Kashmiri",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Kashméré",Value=330,Sequence=530},
                new LookupSetOption() {English="Katchi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Katchi",Value=310,Sequence=540},
                new LookupSetOption() {English="Khmer",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Kampuchéen",Value=335,Sequence=550},
                new LookupSetOption() {English="Kinyarwanda",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Kinyarwanda",Value=325,Sequence=560},
                new LookupSetOption() {English="Kirundi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Kirundi",Value=315,Sequence=570},
                new LookupSetOption() {English="Korean",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Coréen",Value=340,Sequence=580},
                new LookupSetOption() {English="Kurdish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Kurde",Value=342,Sequence=590},
                new LookupSetOption() {English="Lao",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Lao",Value=345,Sequence=600},
                new LookupSetOption() {English="Latvian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Lettonien",Value=350,Sequence=610},
                new LookupSetOption() {English="Lebanese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Libanais",Value=355,Sequence=620},
                new LookupSetOption() {English="Lingala",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Lingala",Value=365,Sequence=630},
                new LookupSetOption() {English="Lithuanian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Lithuanien",Value=360,Sequence=640},
                new LookupSetOption() {English="Macedonian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Macédonien",Value=370,Sequence=650},
                new LookupSetOption() {English="Malayalam",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Malayalam",Value=375,Sequence=660},
                new LookupSetOption() {English="Mandarin",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Mandarin",Value=400,Sequence=670},
                new LookupSetOption() {English="Manding",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Mandingues",Value=378,Sequence=680},
                new LookupSetOption() {English="Marathi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Marathi",Value=410,Sequence=690},
                new LookupSetOption() {English="mi'kmaq",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="mi'kmaq",Value=412,Sequence=700},
                new LookupSetOption() {English="Mohawk",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Mohawk",Value=415,Sequence=710},
                new LookupSetOption() {English="Norwegian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Norvégien",Value=420,Sequence=720},
                new LookupSetOption() {English="Ojibway",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Ojibway",Value=422,Sequence=730},
                new LookupSetOption() {English="Pashto/Pushtu",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Afhgan/Pachtou",Value=425,Sequence=740},
                new LookupSetOption() {English="Patois/Creole",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Patois/créole",Value=680,Sequence=750},
                new LookupSetOption() {English="Polish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Polonais",Value=440,Sequence=760},
                new LookupSetOption() {English="Portuguese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Portugais",Value=450,Sequence=770},
                new LookupSetOption() {English="Punjabi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Punjabi",Value=460,Sequence=780},
                new LookupSetOption() {English="Romanian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Roumain",Value=480,Sequence=790},
                new LookupSetOption() {English="Russian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Russe",Value=490,Sequence=800},
                new LookupSetOption() {English="Serbian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Serbe",Value=495,Sequence=810},
                new LookupSetOption() {English="Serbo-Croatian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Serbo-croate",Value=500,Sequence=820},
                new LookupSetOption() {English="Sindhi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Sindhi",Value=505,Sequence=830},
                new LookupSetOption() {English="Singhalese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Cinghalais",Value=510,Sequence=840},
                new LookupSetOption() {English="Slovak",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Slovaque",Value=520,Sequence=850},
                new LookupSetOption() {English="Slovenian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Slovène",Value=530,Sequence=860},
                new LookupSetOption() {English="Somali",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Somalien",Value=535,Sequence=870},
                new LookupSetOption() {English="Spanish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Espagnol",Value=540,Sequence=880},
                new LookupSetOption() {English="Swahili",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Swahili",Value=550,Sequence=890},
                new LookupSetOption() {English="SwLudatash",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Suédois",Value=560,Sequence=900},
                new LookupSetOption() {English="Tamil",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Tamoul",Value=580,Sequence=910},
                new LookupSetOption() {English="Thai",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Thai",Value=600,Sequence=920},
                new LookupSetOption() {English="Tigrinia",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Tigrigna",Value=610,Sequence=930},
                new LookupSetOption() {English="Turkish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Turque",Value=620,Sequence=940},
                new LookupSetOption() {English="Twi",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Twi",Value=630,Sequence=950},
                new LookupSetOption() {English="Ukrainian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Ukrainien",Value=640,Sequence=960},
                new LookupSetOption() {English="Urdu",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Urdu",Value=650,Sequence=970},
                new LookupSetOption() {English="Vietnamese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Vietnamien",Value=660,Sequence=980},
                new LookupSetOption() {English="Welsh",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Gallois",Value=670,Sequence=990},
                new LookupSetOption() {English="Wolastoqiyik (Maliseet) ",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Wolastoqiyik (Maliseet) ",Value=675,Sequence=1000},
                new LookupSetOption() {English="Xhosa",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Xhosa",Value=685,Sequence=1010},
                new LookupSetOption() {English="Yiddish",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Yiddish",Value=690,Sequence=1020},
                new LookupSetOption() {English="Yoruba",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Yoruba",Value=700,Sequence=1030},
                new LookupSetOption() {English="Other",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre",Value=710,Sequence=1040},
                new LookupSetOption() {English="Other Chinese",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre langue chinoise",Value=720,Sequence=1050},
                new LookupSetOption() {English="Other African",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre langue africaine",Value=730,Sequence=1060},
                new LookupSetOption() {English="Other Indian (Asia)",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre langue indienne (Asie)",Value=740,Sequence=1070},
                new LookupSetOption() {English="Other Asian",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre langue asiatique",Value=750,Sequence=1080},
                new LookupSetOption() {English="Other European",LookupSetId=15,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Autre langue européenne",Value=760,Sequence=1090}
            };
        }
        static IEnumerable<InputType> GetPreconfiguredInputType()
        {
            return new List<InputType>()
            {                
                new InputType() {French="TextBox",English="TextBox",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="SelectBox",English="SelectBox",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="CheckBox",English="CheckBox",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="DatePicker",English="DatePicker",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="NumberBox",English="NumberBox",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="RadioButtons",English="RadioButtons",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="RadioMatrix",English="RadioMatrix",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now},
                new InputType() {French="TextArea",English="TextArea",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now}
            };
        }

        static IEnumerable<Questionnaire> GetPreconfiguredQuestionnaires()
        {
            return new List<Questionnaire>()
            {
                new Questionnaire() {English="Demographics",QuestionnaireName="Demographics",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Demographics",DescriptionEnglish="Demographics",DescriptionFrench="Demographics",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Section A",QuestionnaireName="Section A",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Section A",DescriptionEnglish="Section A",DescriptionFrench="Section A",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Section B",QuestionnaireName="Section B",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Section B",DescriptionEnglish="Section B",DescriptionFrench="Section B",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Section C",QuestionnaireName="Section C",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Section C",DescriptionEnglish="Section C",DescriptionFrench="Section C",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Section D",QuestionnaireName="Section D",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Section D",DescriptionEnglish="Section D",DescriptionFrench="Section D",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Section E",QuestionnaireName="Section E",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Section E",DescriptionEnglish="Section E",DescriptionFrench="Section E",ShowProgressBar=true,ShowQuestionNumbers=true},
                new Questionnaire() {English="Teacher Feedback",QuestionnaireName="Teacher Feedback",YearId=1,CreatedBy ="admin", CreatedDate= DateTime.Now, ModifiedBy = "admin", ModifiedDate = DateTime.Now,French="Teacher Feedback",DescriptionEnglish="Teacher Feedback",DescriptionFrench="Teacher Feedback",ShowProgressBar=true,ShowQuestionNumbers=true},

            };
        }
    }
}
