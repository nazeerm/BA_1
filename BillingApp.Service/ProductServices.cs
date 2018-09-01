using BillingApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingApp.Model;
using BillingApp.Data.UnitOfWork;
using AutoMapper;
using BillingApp.Data;
using BillingApp.Model.Product;

namespace BillingApp.Service
{
    public class ProductServices : IProductServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor
        /// </summary>
        public ProductServices( UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AddProducts(List<ProductModel> prodctsLst)
        {
            int n_products_added = 0;
            try
            {
                return n_products_added;

            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            return n_products_added;
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll().ToList();
            if(products.Any())
            {
                List<ProductModel> productList = Mapper.Map<List<Product>,List<ProductModel>>(products);
                return productList;
            }
            return null;
        }
    }
}
