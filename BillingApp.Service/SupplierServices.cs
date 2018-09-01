using BillingApp.Data;
using BillingApp.Model.Supplier;
using BillingApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingApp.Data.Extensions;

namespace BillingApp.Service
{
    public class SupplierServices : ISupplierServices
    {
        public SupplierListOutModel GetSupplierList(SupplierListInModel paramIn)
        {
            if(paramIn != null)
            {
                List<SupplierMaster> supp_lst = new List<SupplierMaster>();
                SupplierExt supplier_ext = new SupplierExt();
                supp_lst = supplier_ext.ext_GetSupplierList(paramIn);
            }
            return null;
        }
    }
}
