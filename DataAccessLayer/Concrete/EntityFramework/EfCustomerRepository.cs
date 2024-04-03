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
    public class EfCustomerRepository : EfRepositoryBase<Customer, BaseDbContext>, ICustomerRepository
    {
        public EfCustomerRepository(BaseDbContext context) : base(context)
        {
        }
    }
}