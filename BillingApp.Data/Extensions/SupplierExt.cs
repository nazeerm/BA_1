using System.Collections.Generic;
using System.Data.SqlClient;
using BillingApp.Model.Supplier;
using System.Linq;

namespace BillingApp.Data.Extensions
{
    public class SupplierExt
    {
        public List<SupplierMaster> ext_GetSupplierList(SupplierListInModel paramIn)
        {
            List<SupplierMaster> suppliersLst = new List<SupplierMaster>();
            suppliersLst = null;
            var datacontext = new BillingAppEntities();
            SqlParameter[] procedureParameters = new SqlParameter[] 
            {
                new SqlParameter {ParameterName = "@shopID", Value = 1 },
                //new SqlParameter {ParameterName = "@searchSupplierName", Value = string.IsNullOrEmpty(paramIn.) },
                new SqlParameter {ParameterName = "@pageNo", Value = 1 },
                new SqlParameter {ParameterName = "@recordsPerPage", Value = 1 },
                new SqlParameter {ParameterName = "@purchaseDate", Value = 1 },
                new SqlParameter {ParameterName = "@purchaseAmount", Value = 1 }               
            };
            suppliersLst = datacontext.Database.SqlQuery<SupplierMaster>("exec usp_list_suppliers @param1",
                procedureParameters).ToList();
            if (suppliersLst != null)
            { return suppliersLst; }
            return null;
        }
    }
}
