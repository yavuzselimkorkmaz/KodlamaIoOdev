using Business.Abstracts;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public void AddCategory(Category category)
        {
            _categoryDal.AddCategory(category);
        }

        public List<Category> GetCategories()
        {
           return _categoryDal.GetAll();
        }

        public void RemoveCategory(Category category)
        {
            _categoryDal.DeleteCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.UpdateCategory(category);  
        }
    }
}
