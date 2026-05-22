using FSM.Models;

namespace FSM.Data
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        Category GetCategoryById(int categoryId);
    }
}
