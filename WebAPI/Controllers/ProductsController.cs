using BusinessLayer.Abstract;
using BusinessLayer.Dtos.Product.Requests;
using BusinessLayer.Dtos.Product.Responses;
using EntitiesLayer;
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

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // Route Parameters, Quary String => Get isteklerinde popüler
        // Body => Post,Put
        // Headers => Yan bilgiler içerir.

        [HttpPost]
        public async Task Add([FromBody] AddProductRequest product)
        {
            await _productService.Add(product);
        }

        [HttpDelete]
        public void Delete(Product product)
        {
            _productService.Delete(product);
        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productService.Update(product);
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.Get(x => x.ID == id);
        }

        [HttpGet]
        public async Task<List<ListProductResponse>> GetAll()
        {
            return await _productService.GetList();
        }
    }
}