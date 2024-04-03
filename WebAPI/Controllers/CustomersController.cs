using BusinessLayer.Abstract;
using EntitiesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public void Add([FromBody] Customer customer)
        {
            _customerService.Add(customer);
        }

        [HttpDelete]
        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }

        [HttpPut]
        public void Update([FromBody] Customer customer)
        {
            _customerService.Update(customer);
        }

        //[HttpGet]
        //public List<Customer> GetList()
        //{
        //    return _customerService.GetList();
        //}

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerService.Get(x => x.ID == id);
        }

        [HttpGet]
        public async Task<List<Customer>> GetAll()
        {
            return await _customerService.GetList();
        }
    }
}