using EDI.ApplicationCore.Exceptions;
using EDI.ApplicationCore.Entities;

namespace Ardalis.GuardClauses
{
    public static class CustomerGuards
    {
        public static void NullCustomer(this IGuardClause guardClause, int customerid, Customers customers)
        {
            if (customers == null)
                throw new CustomerNotFoundException(customerid);
        }
    }
}