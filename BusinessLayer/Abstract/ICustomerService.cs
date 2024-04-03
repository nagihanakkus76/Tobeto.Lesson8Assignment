using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        Customer Get(Expression<Func<Customer, bool>> predicate);
        Task<List<Customer>> GetList(Expression<Func<Customer, bool>>? predicate = null);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}