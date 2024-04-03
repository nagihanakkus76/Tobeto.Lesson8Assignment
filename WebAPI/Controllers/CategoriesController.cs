using BusinessLayer.Abstract;
using EntitiesLayer;
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
        public void Delete(Category category)
        {
            _categoryService.Delete(category);
        }

        [HttpPut]
        public void Update([FromBody] Category category)
        {
            _categoryService.Update(category);
        }

        //[HttpGet]
        //public List<Category> GetList()
        //{
        //    return _categoryService.GetList();
        //}

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.Get(x => x.ID == id);
        }
        [HttpGet]
        public async Task<List<Category>> GetAll()
        {
            return await _categoryService.GetList();
        }
    }
}
