using System.Collections.Generic;
using System.Data.SqlClient;
using BillingApp.Model.Supplier;
using System.Linq;
using System;

namespace BillingApp.Data.Extensions
{
    public class SupplierExt
    {
        public List<SupplierListOutModel> ext_GetSupplierList(SupplierListInModel paramIn)
        {
            List<SupplierListOutModel> suppliersLst = new List<SupplierListOutModel>();
            suppliersLst = null;
            var datacontext = new BillingAppEntities();
            SqlParameter[] procedureParameters = new SqlParameter[] 
            {
                new SqlParameter {ParameterName = "@shopID", Value = paramIn.ShopID == null? (object)DBNull.Value: paramIn.ShopID },
                new SqlParameter {ParameterName = "@searchSupplierName", Value = string.IsNullOrEmpty(paramIn.SearchSupplierName) ? (Object)DBNull.Value : paramIn.SearchSupplierName },
                new SqlParameter {ParameterName = "@pageNo", Value = paramIn.pagination.CurrentPage == null? (Object)DBNull.Value: paramIn.pagination.CurrentPage },
                new SqlParameter {ParameterName = "@recordsPerPage", Value = paramIn.pagination.RecordsPerPage == null? (object)DBNull.Value: paramIn.pagination.RecordsPerPage },
                new SqlParameter {ParameterName = "@purchaseDate", Value = paramIn.PurchaseDate == DateTime.MinValue || paramIn.PurchaseDate == null ? (object)DBNull.Value : paramIn.PurchaseDate },
                new SqlParameter {ParameterName = "@purchaseAmount", Value = paramIn.purchaseAmount == null ? (Object)DBNull.Value : paramIn.purchaseAmount }               
            };
            suppliersLst = datacontext.Database.SqlQuery<SupplierListOutModel>("exec usp_list_suppliers @shopID, @searchSupplierName, @pageNo, @recordsPerPage, @purchaseDate, @purchaseAmount",
                procedureParameters).ToList();
            if (suppliersLst != null)
            { return suppliersLst; }
            return null;
        }
    }
}
