using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Models
{
    public class ProductsViewModel
    {
        public List<ProductList> ProductsLists{ get; set; }
    }

    public class ProductList
    {
        public string Title { get;set; }
        public IEnumerable<Product> Items { get; set; }
    }
}
