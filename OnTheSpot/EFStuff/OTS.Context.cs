﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTheSpot.EFStuff
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Store1Entities2 : DbContext
    {
        public Store1Entities2()
            : base("name=Store1Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<AppliedCrs> AppliedCrs { get; set; }
        public virtual DbSet<AutoNumber> AutoNumber { get; set; }
        public virtual DbSet<BillCyclePeriods> BillCyclePeriods { get; set; }
        public virtual DbSet<BillingCenters> BillingCenters { get; set; }
        public virtual DbSet<BillingCycles> BillingCycles { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CardBillAutoCredits> CardBillAutoCredits { get; set; }
        public virtual DbSet<CardBilling> CardBilling { get; set; }
        public virtual DbSet<CCAudits> CCAudits { get; set; }
        public virtual DbSet<CCKeys> CCKeys { get; set; }
        public virtual DbSet<CCPaymentContracts> CCPaymentContracts { get; set; }
        public virtual DbSet<CCSettings> CCSettings { get; set; }
        public virtual DbSet<CCStationSettings> CCStationSettings { get; set; }
        public virtual DbSet<ClerkDrawers> ClerkDrawers { get; set; }
        public virtual DbSet<ClockInAccounts> ClockInAccounts { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Credits> Credits { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DeletedCusts> DeletedCusts { get; set; }
        public virtual DbSet<DeliveryCenters> DeliveryCenters { get; set; }
        public virtual DbSet<DeliveryGroups> DeliveryGroups { get; set; }
        public virtual DbSet<DeliveryLog> DeliveryLog { get; set; }
        public virtual DbSet<EditedCusts> EditedCusts { get; set; }
        public virtual DbSet<EmailLogs> EmailLogs { get; set; }
        public virtual DbSet<EmployeeDefaults> EmployeeDefaults { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<GiftCardTypes> GiftCardTypes { get; set; }
        public virtual DbSet<GiftTransactions> GiftTransactions { get; set; }
        public virtual DbSet<GLAccounts> GLAccounts { get; set; }
        public virtual DbSet<GLJournal> GLJournal { get; set; }
        public virtual DbSet<Heatseals> Heatseals { get; set; }
        public virtual DbSet<ImageLibrary> ImageLibrary { get; set; }
        public virtual DbSet<Inventories> Inventories { get; set; }
        public virtual DbSet<InvoiceAdjusts> InvoiceAdjusts { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<InvPaids> InvPaids { get; set; }
        public virtual DbSet<KioskSettings> KioskSettings { get; set; }
        public virtual DbSet<Lots> Lots { get; set; }
        public virtual DbSet<MerchantQTY> MerchantQTY { get; set; }
        public virtual DbSet<MergedCusts> MergedCusts { get; set; }
        public virtual DbSet<NoSales> NoSales { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderProcess> OrderProcess { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Originals> Originals { get; set; }
        public virtual DbSet<OverdueStats> OverdueStats { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistory { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Physical> Physical { get; set; }
        public virtual DbSet<PostalCodes> PostalCodes { get; set; }
        public virtual DbSet<Preferences> Preferences { get; set; }
        public virtual DbSet<PurgedCusts> PurgedCusts { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<RecurringGroups> RecurringGroups { get; set; }
        public virtual DbSet<Recurrings> Recurrings { get; set; }
        public virtual DbSet<RouteItems> RouteItems { get; set; }
        public virtual DbSet<RouteStops> RouteStops { get; set; }
        public virtual DbSet<SalesTax> SalesTax { get; set; }
        public virtual DbSet<ScanLogs> ScanLogs { get; set; }
        public virtual DbSet<SOFBatches> SOFBatches { get; set; }
        public virtual DbSet<StatementBalances> StatementBalances { get; set; }
        public virtual DbSet<StatementHistory> StatementHistory { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<TaxAuthorities> TaxAuthorities { get; set; }
        public virtual DbSet<TimeCards> TimeCards { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }
        public virtual DbSet<WirelessCarriers> WirelessCarriers { get; set; }
    }
}
