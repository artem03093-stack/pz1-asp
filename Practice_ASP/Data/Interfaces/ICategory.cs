using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Appliance> GetApplianceByCategory(Category category);
        void AddApplianceToCategory(Appliance appliance);
    }
}
