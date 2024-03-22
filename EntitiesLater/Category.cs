using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLater
{
    public class Category
    {
        public Category(int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;

            // Description alanının nesne oluşturulurken gerekli olmadığı kanısına vardığımız için
            // ctor'ın parametrelerine eklemedik.
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}


