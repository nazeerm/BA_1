using BillingApp.Model.Common;
using System;

namespace BillingApp.Model.Supplier
{
    public class SupplierListOutModel
    {
        public int SupplierMasterID { get; set; }
        public string SupplierName { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal TotalPurchaseAmount { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal PurchaseAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int SupplierDetailID { get; set; }
        public int TotalRecords { get; set; }
        public int total_Pages { get; set; }
        //public Pagination pagination { get; set; }
    }
}
