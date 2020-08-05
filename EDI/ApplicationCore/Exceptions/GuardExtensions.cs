using EDI.ApplicationCore.Exceptions;
using EDI.ApplicationCore.Entities;
using Ardalis.GuardClauses;

namespace Ardalis.GuardClauses
{
    public static class SiteGuards
    {
        public static void NullSite(this IGuardClause guardClause, int siteid, Sites sites)
        {
            if (sites == null)
                throw new SiteNotFoundException(siteid);
        }
    }

    public static class SchoolGuards
    {
        public static void NullSchool(this IGuardClause guardClause, int schoolid, Schools schools)
        {
            if (schools == null)
                throw new SchoolNotFoundException(schoolid);
        }
    }
}
