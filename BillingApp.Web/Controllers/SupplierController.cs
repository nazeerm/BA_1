using BillingApp.Model.Supplier;
using BillingApp.Service;
using BillingApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BillingApp.Web.Controllers
{
    [System.Web.Http.RoutePrefix("api/supplier")]
    public class SupplierController : ApiController
    {
        //private readonly ISupplierServices _supplierService;

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("listsupplier")]
        public HttpResponseMessage ListSupplier(HttpRequestMessage request, SupplierListInModel paramIn)
        {
            if (ModelState.IsValid)
            {
                ISupplierServices _supplierService = new SupplierServices();
                var suppliers_rslt = _supplierService.GetSupplierList(paramIn);
                if (suppliers_rslt != null)
                {
                    return request.CreateResponse(HttpStatusCode.OK, suppliers_rslt);
                }
                return Request.CreateResponse(HttpStatusCode.NotFound, "No data");
            }

            return Request.CreateResponse(HttpStatusCode.NotAcceptable,"Model Binding Error");
        }
    }
}