using BillingApp.Model;
using BillingApp.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp.Service.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductModel> GetAllProducts();
        int AddProducts(List<ProductModel> prodctsLst);
    }
}

