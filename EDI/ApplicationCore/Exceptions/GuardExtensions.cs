using EDI.ApplicationCore.Exceptions;
using EDI.ApplicationCore.Entities;
using Ardalis.GuardClauses;

namespace Ardalis.GuardClauses
{
    public static class SiteGuards
    {
        public static void NullSite(this IGuardClause guardClause, int siteid, Site sites)
        {
            if (sites == null)
                throw new SiteNotFoundException(siteid);
        }
    }

    public static class SchoolGuards
    {
        public static void NullSchool(this IGuardClause guardClause, int schoolid, School schools)
        {
            if (schools == null)
                throw new SchoolNotFoundException(schoolid);
        }
    }

    public static class YearGuards
    {
        public static void NullYear(this IGuardClause guardClause, int yearid, Year years)
        {
            if (years == null)
                throw new YearNotFoundException(yearid);
        }
    }

    public static class SpecialProblemGuards
    {
        public static void NullSpecialProblem(this IGuardClause guardClause, int spid, SpecialProblem problems)
        {
            if (problems == null)
                throw new SpecialProblemNotFoundException(spid);
        }
    }

    public static class LanguageGuards
    {
        public static void NullLanguage(this IGuardClause guardClause, int languageid, Language years)
        {
            if (years == null)
                throw new LanguageNotFoundException(languageid);
        }
    }

    public static class CountryGuards
    {
        public static void NullCountry(this IGuardClause guardClause, int countryid, Country countries)
        {
            if (countries == null)
                throw new CountryNotFoundException(countryid);
        }
    }

    public static class ProvinceGuards
    {
        public static void NullProvince(this IGuardClause guardClause, int provinceid, Province provinces)
        {
            if (provinces == null)
                throw new ProvinceNotFoundException(provinceid);
        }
    }

    public static class ConfigurationGuards
    {
        public static void NullConfiguration(this IGuardClause guardClause, int configid, SystemConfigurations configs)
        {
            if (configs == null)
                throw new ConfigurationNotFoundException(configid);
        }
    }

    public static class ChildGuards
    {
        public static void NullChild(this IGuardClause guardClause, int childid, Child children)
        {
            if (children == null)
                throw new ChildNotFoundException(childid);
        }
    }

    public static class TeacherGuards
    {
        public static void NullTeacher(this IGuardClause guardClause, int teacherid, Teacher teachers)
        {
            if (teachers == null)
                throw new TeacherNotFoundException(teacherid);
        }
    }

    public static class CoordinatorGuards
    {
        public static void NullCoordinator(this IGuardClause guardClause, int coordinatorid, Coordinator coordinators)
        {
            if (coordinators == null)
                throw new CoordinatorNotFoundException(coordinatorid);
        }
    }

    public static class LinkGuards
    {
        public static void NullLink(this IGuardClause guardClause, int linkid, Link link)
        {
            if (link == null)
                throw new LinkNotFoundException(linkid);
        }
    }

    public static class FaqGuards
    {
        public static void NullFaq(this IGuardClause guardClause, int faqid, Faq faq)
        {
            if (faq == null)
                throw new FaqNotFoundException(faqid);
        }
    }
}
