using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Repository
{
    public class ApplianceRepository : IAppliance
    {
        private readonly AppDbContext appDbContext;

        public ApplianceRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void AddNewAppliance(Appliance appliance)
        {
            appDbContext.Appliances.Add(appliance);
            appDbContext.SaveChanges();
        }

        public IEnumerable<Appliance> GetAppliances()
        {
            return appDbContext.Appliances.ToList();
        }

        public void RemoveAppliance(int id)
        {
            var appliance = appDbContext.Appliances.FirstOrDefault(a => a.Id == id);
            if (appliance != null)
            {
                appDbContext.Appliances.Remove(appliance);
                appDbContext.SaveChanges();
            }
        }
    }
}
