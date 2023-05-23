using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Interfaces
{
    public interface IAppliance
    {
        void AddNewAppliance(Appliance appliance);
        void RemoveAppliance(int id);
        IEnumerable<Appliance> GetAppliances();
    }
}
