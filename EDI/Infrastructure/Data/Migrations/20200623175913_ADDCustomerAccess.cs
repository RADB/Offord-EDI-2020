using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.DaEDI.Migrations
{
    public partial class ADDCustomerAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"exec('
CREATE view [dbo].[CustomerAccess]
as
SELECT cu.[Id]
      ,cu.[Name]
      ,cu.[Email]
      ,(cu.[Contact1] + '' '' + cu.[Contact2]) as Contact
      ,cu.[Contact1]
      ,cu.[Contact2]
      ,cu.[Phone]
      ,cu.[CurrencyID]
	  ,cr.Name as Currency
      ,cu.[BillingCountryID]
	  ,ct.Name as BillingCountry
      ,cu.[BillingProvinceID]
	  ,p.Name as BillingProvince
      ,cu.[BillingAddress1]
      ,cu.[BillingAddress2]
      ,cu.[BillingCity]
      ,cu.[BillingPostal]
      ,cu.[HasShippingAddress]
      ,cu.[ShippingCountryID]
	  ,ct2.Name as ShippingCountry
      ,cu.[ShippingProvinceID]
	  ,p2.Name as ShippingProvince
      ,cu.[ShippingContact]
      ,cu.[ShippingAddress1]
      ,cu.[ShippingAddress2]
      ,cu.[ShippingCity]
      ,cu.[ShippingPostal]
      ,cu.[ShippingPhone]
      ,cu.[DeliveryInstructions]
      ,cu.[AccountNumber]
      ,cu.[Fax]
      ,cu.[Mobile]
      ,cu.[TollFree]
      ,cu.[Website]
      ,cu.[InternalNotes]
      ,cu.[CreatedBy]
      ,cu.[CreatedDate]
      ,cu.[ModifiedBy]
      ,cu.[ModifiedDate]
  FROM [dbo].[Customers] cu
  left join Country ct on cu.BillingCountryID = ct.Id
  left join Country ct2 on cu.ShippingCountryID = ct.Id
  left join Currency cr on cu.CurrencyID = cr.Id
  left join Province p on cu.BillingProvinceID = p.Id
  left join Province p2 on cu.ShippingProvinceID = p.Id')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
