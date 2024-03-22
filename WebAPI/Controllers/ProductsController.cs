using BusinessLayer.Abstract;
using EntitiesLater;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //  api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        private ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // Route Parameters, Quary String => Get isteklerinde popüler
        // Body => Post,Put
        // Headers => Yan bilgiler içerir.

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            _productService.Add(product);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productService.Update(product);
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }


        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return _productService.GetById(id);


        }
    }
}

