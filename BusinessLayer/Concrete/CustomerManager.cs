using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerRepository.Delete(customer); ;
        }

        public Customer Get(Expression<Func<Customer, bool>> predicate)
        {
            return _customerRepository.Get(predicate);
        }

        public async Task<List<Customer>> GetList(Expression<Func<Customer, bool>>? predicate = null)
        {
            return await _customerRepository.GetListAsync(predicate);
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }
    }
}