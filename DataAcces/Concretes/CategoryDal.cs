using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal() 
        { 
            _categories = new List<Category>();
            _categories.Add(new Category { CategoryId=1,CategoryName="Yazılım Kursları"});
        }

        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void UpdateCategory(Category category)
        {
            Console.WriteLine(category.CategoryName + " Güncellendi!");
        }
    }
}
