using FSM.Models;

namespace FSM.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
        [
            new Category { CategoryID = 1, CategoryName = "Web Development" },
            new Category { CategoryID = 2, CategoryName = "Mobile Development" },
            new Category { CategoryID = 3, CategoryName = "Data Science" },
            new Category { CategoryID = 4, CategoryName = "Cybersecurity" },
            new Category { CategoryID = 5, CategoryName = "Cloud Computing" }
        ];

        public Category GetCategoryById(int categoryId) => AllCategories.FirstOrDefault(c => c.CategoryID == categoryId);
    }
}
