using Core.DataAccess;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerRepository : IRepository<Customer> , IAsyncRepository<Customer>
    {
    }
}