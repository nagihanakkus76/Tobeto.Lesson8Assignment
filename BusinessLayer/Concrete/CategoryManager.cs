using BusinessLayer.Abstract;
using EntitiesLater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        List<Category> _categories;

        public CategoryManager()
        {
            _categories = new List<Category>();
        }

        public void Add(Category category)
        {
            _categories.Add(category);  
        }

        public void Delete(int id)
        {
            _categories.Remove( GetById(id) );
        }

        public List<Category> GetAll()
        {
           return _categories;
        }

        public Category GetById(int id)
        {
          return _categories.Find(x => x.Id == id)  ;
        }

        public void Update(Category category)
        {
            int id = category.Id;

            Category categoryId = GetById(id);


            if (categoryId != null)
            {
                int index = _categories.IndexOf(categoryId);
                _categories[index] = category;
            }
            else
            {
                throw new Exception("Güncellenecek veri bulunamadı.");
            }
        }
    }
}

