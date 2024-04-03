using Core.DataAccess;
using DataAccessLayer.Abstract;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductRepository : EfRepositoryBase<Product, BaseDbContext>, IProductRepository
    {
        public EfProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}