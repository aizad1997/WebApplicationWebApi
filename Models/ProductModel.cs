using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWebApi.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQty { get; set; }
    }
}