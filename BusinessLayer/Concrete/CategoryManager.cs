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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            return _categoryRepository.Get(predicate);
        }

        public async Task<List<Category>> GetList(Expression<Func<Category, bool>>? predicate = null)
        {
            return await _categoryRepository.GetListAsync(predicate);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}