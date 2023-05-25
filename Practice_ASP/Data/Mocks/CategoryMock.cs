using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Mocks
{
    public class CategoryMock : ICategory
    {
        private List<Category> categories = new List<Category>();

        public CategoryMock() 
        {
            categories.Add(new Category() { Id = 1, Name = "Холодильники", Description = "Пристрій, що підтримує низьку температуру теплоізольованої камери. Застосовується зазвичай для зберігання їжі або предметів, що вимагають зберігання у прохолодному місці (ліки, косметика).\r\n" });
            categories.Add(new Category() { Id = 2, Name = "Пральні машини", Description = "Автономне встановлення для прання текстильних виробів (одягу, нижньої та постільної білизни, сумок та інших речей), а також іноді взуття.\r\n" });
            categories.Add(new Category() { Id = 3, Name = "Кондиціонери", Description = "Пристрій для підтримки оптимальних кліматичних умов у квартирах, будинках, офісах, а також для очищення повітря у приміщенні від небажаних частинок. Призначений для зниження температури повітря в приміщенні під час спеки, або (що рідше) – підвищення температури повітря в холодну пору року в приміщенні.\r\n" });
        }

        public IEnumerable<Appliance> GetApplianceByCategory(Category category)
        {
            return category.Appliances;
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        //public void AddApplianceToCategory(Appliance appliance)
        //{
        //    var category = categories.FirstOrDefault(c => c.Id == appliance.IdCategory);
        //    if(category != null)
        //    {
        //        category.Appliances.Add(appliance);
        //    }
        //}
    }
}
