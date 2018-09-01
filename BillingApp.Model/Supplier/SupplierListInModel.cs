using BillingApp.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp.Model.Supplier
{
    public class SupplierListInModel
    {
        public int ShopID { get; set; }
        public string SearchSupplierName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal purchaseAmount { get; set; }
        public Pagination pagination { get; set; }
    }
}
