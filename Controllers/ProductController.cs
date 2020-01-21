using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationWebApi.Models;

namespace WebApplicationWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private ProductDBEntities objProductDBEntities;
        public IHttpActionResult GetProduct()
        {
            objProductDBEntities = new ProductDBEntities();
            List<ProductModel> listOfProductModel = (from objProduct in objProductDBEntities.Products
                                                     select new ProductModel
                                                     {
                                                         Category = objProduct.Category,
                                                         Code = objProduct.Code,
                                                         Name = objProduct.Name,
                                                         ProductID = objProduct.ProductID,
                                                         StockQty = objProduct.StockQty,
                                                         UnitPrice = objProduct.UnitPrice
                                                     }).ToList();
            return Ok(listOfProductModel);
        }

        [HttpPost]
        public IHttpActionResult AddProduct(ProductModel objProductModel)
        {
            objProductDBEntities = new ProductDBEntities();
            Product objProduct = new Product();
            objProduct.Category = objProductModel.Category;
            objProduct.Code = objProductModel.Code;
            objProduct.Name = objProductModel.Name;
            objProduct.StockQty = objProductModel.StockQty;
            objProduct.UnitPrice = objProductModel.UnitPrice;
            objProductDBEntities.Products.Add(objProduct);
            objProductDBEntities.SaveChanges();
            return Ok("Product is Added");
        }
    }
}


