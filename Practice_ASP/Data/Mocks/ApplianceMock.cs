using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Mocks
{
    public class ApplianceMock : IAppliance
    {
        private List<Appliance> appliances = new List<Appliance>();

        public ApplianceMock() 
        {
            appliances.Add(new Appliance() { Id = 1, Name = "SAMSUNG RB38T676FB1", Price = 27000, Description = "Загальний об'єм холодильника\r\n400 л\r\nТип холодильника\r\nДвокамерний\r\nКлас енергоспоживання\r\nA+\r\nСистема розморожування холодильної камери\r\nNo Frost (суха)\r\nГабарити (ВхШхГ)\r\n203 x 59.5 x 65.8 см", WarrantyInMonths = 36, IdCategory = 1 });
            appliances.Add(new Appliance() { Id = 2, Name = "WHIRLPOOL WRBSB 6228", Price = 15000, Description = "Максимальне завантаження білизни\r\n6 кг\r\nТип двигуна\r\nІнверторний\r\nКлас енергоспоживання\r\nА+++\r\nКількість програм\r\n16\r\nТехнічні особливості\r\nЗ дисплеєм\r\nГабарити (ВхШхГ)\r\n85 х 59.5 х 42.5 см\r\nМаксимальна швидкість віджимання, об/хв\r\n1200", WarrantyInMonths = 120, IdCategory = 2 });
            appliances.Add(new Appliance() { Id = 3, Name = "MYSTERY MTH07CT-W3N2", Price = 10000, Description = "Тип компресора\r\nЗвичайний\r\nТип встановлення внутрішнього блока\r\nНастінний\r\nТип\r\nСпліт-система\r\nОхолодження, кВт\r\n2.2\r\nТеплопродуктивність, кВт\r\n2.30\r\nСпоживана потужність обігрів/охолодження\r\n1.0/0.9 кВт\r\nГабарити внутрішнього блока (ВхШхГ)\r\n25.5 х 69.8 х 19 см\r\nГабарити зовнішнього блока (ВхШхГ)\r\n50 х 60 х 23.2 см\r\nКолір\r\nБелый", WarrantyInMonths = 60, IdCategory = 3 });
        }

        public void AddNewAppliance(Appliance appliance)
        {
            appliance.Id = appliances.Count;
            appliances.Add(appliance);
        }

        public IEnumerable<Appliance> GetAppliances()
        {
            return appliances;
        }

        public void RemoveAppliance(int id)
        {
            var find = appliances.FindIndex(el => el.Id == id);
            if(find != -1)
            {
                appliances.RemoveAt(find);
            }
        }
    }
}
