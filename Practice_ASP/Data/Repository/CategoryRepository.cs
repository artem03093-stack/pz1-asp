using Microsoft.EntityFrameworkCore;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //public void AddApplianceToCategory(Appliance appliance)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Appliance> GetApplianceByCategory(Category category)
        {
            return appDbContext.Appliances.Where(a => a.Category.Id == category.Id).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return appDbContext.Categories.ToList();
        }
    }
}
