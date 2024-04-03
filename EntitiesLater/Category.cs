using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Category : Entity
    {
        // Description alanının nesne oluşturulurken gerekli olmadığı kanısına vardığımız için
        // ctor'ın parametrelerine eklemedik.
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}