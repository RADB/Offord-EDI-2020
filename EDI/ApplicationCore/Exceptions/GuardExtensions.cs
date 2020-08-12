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
}
