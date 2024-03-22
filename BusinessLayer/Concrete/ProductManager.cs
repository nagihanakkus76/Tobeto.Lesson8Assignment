using BusinessLayer.Abstract;
using EntitiesLater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        List<Product> _products;

        public ProductManager()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            _products.Remove(GetById(id));
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.Find(x => x.Id == id);
        }

        public void Update(Product product)
        {
            int id = product.Id;

            Product productId = GetById(id);


            if (productId != null)
            {
                int index = _products.IndexOf(productId);
                _products[index] = product;
            }
            else
            {
                throw new Exception("Güncellenecek veri bulunamadı.");
            }
        }
    }
}
