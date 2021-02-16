using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvadoDPI_Console
{
    public class SqlProductService
    {
        private SqlCartService _cartService;

        public SqlProductService(SqlCartService cartService)
        {
            _cartService = cartService;
        }

        public void AddProduct()
        {
            _cartService.ListProduct();
            Console.WriteLine("Product Added:");
        }
    }
}
