using BusinessLayer.Abstract;
using EntitiesLater;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public void Add([FromBody] Category category)
        {
            _categoryService.Add(category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }

        [HttpPut]
        public void Update([FromBody] Category category)
        {
            _categoryService.Update(category);
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

    }
}
