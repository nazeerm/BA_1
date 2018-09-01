using BillingApp.Data;
using BillingApp.Model.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp.Service.Interfaces
{
    public interface ISupplierServices
    {
        List<SupplierListOutModel> GetSupplierList(SupplierListInModel paramIn);
    }
}
