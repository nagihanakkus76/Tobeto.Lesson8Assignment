using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Category Get(Expression<Func<Category, bool>> predicate);
        Task<List<Category>> GetList(Expression<Func<Category, bool>>? predicate = null);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}