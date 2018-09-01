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
        public List<SupplierListOutModel> GetSupplierList(SupplierListInModel paramIn)
        {
            if(paramIn != null)
            {
                List<SupplierListOutModel> supp_lst = new List<SupplierListOutModel>();
                SupplierExt supplier_ext = new SupplierExt();
                supp_lst = supplier_ext.ext_GetSupplierList(paramIn);
            }
            return null;
        }
    }
}
