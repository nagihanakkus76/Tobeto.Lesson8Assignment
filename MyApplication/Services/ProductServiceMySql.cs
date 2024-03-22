using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public class ProductServiceMySql : BaseProductService
    {
        public override void AddProduct(Product product) { Console.WriteLine("Ürün MYSQL veri tabanına eklendi."); }

        public override void DeleteProduct(Product product)
        {
            Console.WriteLine("Ürün MYSQL veri tabanından silindi.");

        }

        public override void UpdateProduct(Product product) { Console.WriteLine("Ürün MYSQL'de güncellendi."); }
    }
}
