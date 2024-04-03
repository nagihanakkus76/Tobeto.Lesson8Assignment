using Core.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Product : Entity
    {
        public Product()
        {
        }

        public Product(int id, string name, decimal unitPrice, int stock, int categoryId)
        {
            ID = id;
            Name = name;
            UnitPrice = unitPrice;
            Stock = stock;
            CategoryID = categoryId;
        }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public virtual Category? Category { get; set; }
        public int CategoryID { get; set; }
    }
}