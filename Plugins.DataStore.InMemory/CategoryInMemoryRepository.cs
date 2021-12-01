using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //Some random categories

            categories = new List<Category>()
            {

                //Category Alcohol
                new Category { CategoryId = 1, Name = "Alcohol", Description = "+18 stuff", IsLegalForEveryone = "No",
                    IsForChildren = "No", RecommendedAge = "5"},

                //Category Sweets
                new Category { CategoryId = 2, Name = "Sweets", Description = "Sweets", IsLegalForEveryone = "Yes",
                    IsForChildren = "Yes", RecommendedAge = "6"},

                  //Category Bakery
                new Category { CategoryId = 3, Name = "Bakery", Description = "Bread", IsLegalForEveryone = "Yes",
                    IsForChildren = "Yes", RecommendedAge = "5"},
            };
        }

        public void AddCategory(Category category)
        {
           if (categories.Any(x => x.Name.Equals(category.Name,StringComparison.OrdinalIgnoreCase))) return;

           if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);

                category.CategoryId = maxId + 1;
            }
           else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
                categoryToUpdate.IsLegalForEveryone = category.IsLegalForEveryone;
                categoryToUpdate.IsForChildren = category.IsForChildren;
                categoryToUpdate.RecommendedAge = category.RecommendedAge;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}