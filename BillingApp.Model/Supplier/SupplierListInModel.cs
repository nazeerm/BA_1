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
        int ShopID { get; set; }
        string SearchSupplierName { get; set; }
        DateTime PurchaseDate { get; set; }
        decimal purchaseAmount { get; set; }
        Pagination pagination { get; set; }
    }
}
