using Microsoft.EntityFrameworkCore;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Appliance> Appliances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Холодильники", Description = "Пристрій, що підтримує низьку температуру теплоізольованої камери. Застосовується зазвичай для зберігання їжі або предметів, що вимагають зберігання у прохолодному місці (ліки, косметика)." },
                new Category() { Id = 2, Name = "Пральні машини", Description = "Автономне встановлення для прання текстильних виробів (одягу, нижньої та постільної білизни, сумок та інших речей), а також іноді взуття." },
                new Category() { Id = 3, Name = "Кондиціонери", Description = "Пристрій для підтримки оптимальних кліматичних умов у квартирах, будинках, офісах, а також для очищення повітря у приміщенні від небажаних частинок. Призначений для зниження температури повітря в приміщенні під час спеки, або (що рідше) – підвищення температури повітря в холодну пору року в приміщенні." },
                new Category() { Id = 4, Name = "Кавомашини", Description = "Пристрій для автоматичного приготування кави із пропонованого продукту. Варіння кави в кавомашині передбачає мінімальну участь людини." },
                new Category() { Id = 5, Name = "Роботи-пилососи", Description = "Пилосос, призначений для автоматичного прибирання приміщень з мінімальною участю людини або без неї." },
                new Category() { Id = 6, Name = "Мікрохвильові печі", Description = "Побутовий електроприлад для швидкого приготування або швидкого підігріву харчових продуктів, а також для їх розморожування." },
                new Category() { Id = 7, Name = "Посудомийні машини", Description = "Електромеханічне встановлення для автоматичного миття посуду." }
            );

            modelBuilder.Entity<Appliance>().HasData(
                new Appliance() { Id = 1, Name = "SAMSUNG RB38T676FB1", Price = 27000, Description = "Загальний об'єм холодильника\r\n400 л\r\nТип холодильника\r\nДвокамерний\r\nКлас енергоспоживання\r\nA+\r\nСистема розморожування холодильної камери\r\nNo Frost (суха)\r\nГабарити (ВхШхГ)\r\n203 x 59.5 x 65.8 см", WarrantyInMonths = 36, IdCategory = 1, ImgUrl = "/img/153034785.webp" },
                new Appliance() { Id = 2, Name = "WHIRLPOOL WRBSB 6228", Price = 15000, Description = "Максимальне завантаження білизни\r\n6 кг\r\nТип двигуна\r\nІнверторний\r\nКлас енергоспоживання\r\nА+++\r\nКількість програм\r\n16\r\nТехнічні особливості\r\nЗ дисплеєм\r\nГабарити (ВхШхГ)\r\n85 х 59.5 х 42.5 см\r\nМаксимальна швидкість віджимання, об/хв\r\n1200", WarrantyInMonths = 120, IdCategory = 2, ImgUrl = "/img/286602036.webp" },
                new Appliance() { Id = 3, Name = "MYSTERY MTH07CT-W3N2", Price = 10000, Description = "Тип компресора\r\nЗвичайний\r\nТип встановлення внутрішнього блока\r\nНастінний\r\nТип\r\nСпліт-система\r\nОхолодження, кВт\r\n2.2\r\nТеплопродуктивність, кВт\r\n2.30\r\nСпоживана потужність обігрів/охолодження\r\n1.0/0.9 кВт\r\nГабарити внутрішнього блока (ВхШхГ)\r\n25.5 х 69.8 х 19 см\r\nГабарити зовнішнього блока (ВхШхГ)\r\n50 х 60 х 23.2 см\r\nКолір\r\nБелый", WarrantyInMonths = 60, IdCategory = 3, ImgUrl = "/img/190102404.webp" },
                new Appliance() { Id = 4, Name = "Whirlpool W7X 81O OX 0", Price = 19700, Description = "Загальний об'єм холодильника\r\n335 л\r\nТип холодильника\r\nДвокамерний\r\nКлас енергоспоживання\r\nA+\r\nСистема розморожування холодильної камери\r\nNo Frost (суха)\r\nГабарити (ВхШхГ)\r\n191.2 х 59.6 х 67.8 см", WarrantyInMonths = 24, IdCategory = 1, ImgUrl = "/img/276046293.webp" },
                new Appliance() { Id = 5, Name = "LG GW-B509SEKM", Price = 44600, Description = "Загальний об'єм холодильника\r\n384 л\r\nТип холодильника\r\nДвокамерний\r\nКлас енергоспоживання\r\nA++\r\nСистема розморожування холодильної камери\r\nNo Frost (суха)\r\nГабарити (ВхШхГ)\r\n203 х 59.5 х 68 см", WarrantyInMonths = 240, IdCategory = 1, ImgUrl = "/img/322707864.webp" },
                new Appliance() { Id = 6, Name = "SAMSUNG WW62J42E0HX/UA", Price = 19299, Description = "Максимальне завантаження білизни\r\n6 кг\r\nТип двигуна\r\nІнверторний\r\nКлас енергоспоживання\r\nА+++\r\nТехнічні особливості\r\nЗ дисплеєм\r\nЗ парою\r\nГабарити (ВхШхГ)\r\n85 x 60.2 x 45 см\r\nМаксимальна швидкість віджимання, об/хв\r\n1200", WarrantyInMonths = 36, IdCategory = 2, ImgUrl = "/img/275807205.webp" },
                new Appliance() { Id = 7, Name = "Gorenje Primary WHP60SF", Price = 9999, Description = "Максимальне завантаження білизни\r\n6 кг\r\nТип двигуна\r\nКолекторний\r\nКлас енергоспоживання\r\nА++\r\nКількість програм\r\n15\r\nТехнічні особливості\r\nLED-індикація\r\nГабарити (ВхШхГ)\r\n85 х 59.5 х 46 см\r\nМаксимальна швидкість віджимання, об/хв\r\n1000", WarrantyInMonths = 12, IdCategory = 2, ImgUrl = "/img/284552025.webp" },
                new Appliance() { Id = 8, Name = "COOPER&HUNTER PRIMA PLUS CH-S07XN8", Price = 14119, Description = "Тип компресора\r\nЗвичайний\r\nТип встановлення внутрішнього блока\r\nНастінний\r\nТип\r\nСпліт-система\r\nОхолодження, кВт\r\n2.25\r\nТеплопродуктивність, кВт\r\n2.35\r\nСпоживана потужність обігрів/охолодження\r\n0.63/0.67 кВт\r\nГабарити внутрішнього блока (ВхШхГ)\r\n25 х 69.8 х 18.5 см\r\nГабарити зовнішнього блока (ВхШхГ)\r\n42.8 х 72 х 31 см", WarrantyInMonths = 36, IdCategory = 3, ImgUrl = "/img/265167204.webp" },
                new Appliance() { Id = 9, Name = "HYUNDAI ARN09HSSUAWF1/ARU09HSSUAWF1", Price = 16999, Description = "Тип компресора\r\nІнверторний\r\nТип встановлення внутрішнього блока\r\nНастінний\r\nТип\r\nСпліт-система\r\nОхолодження, кВт\r\n2.64\r\nТеплопродуктивність, кВт\r\n2.93\r\nСпоживана потужність обігрів/охолодження\r\n0.81/0.82 кВт\r\nГабарити внутрішнього блока (ВхШхГ)\r\n28.5 х 71.5 x 19.4 см\r\nГабарити зовнішнього блока (ВхШхГ)\r\n49.5 х 72 x 27 см", WarrantyInMonths = 36, IdCategory = 3, ImgUrl = "/img/267467639.webp" },
                new Appliance() { Id = 10, Name = "PHILIPS Series 3200 EP3246/70", Price = 19999, Description = "Тип\r\nКавомашина\r\nТип кави\r\nЗернова\r\nМелена\r\nКерування\r\nСенсорне\r\nПриготування капучино\r\nАвтоматичне", WarrantyInMonths = 24, IdCategory = 4, ImgUrl = "/img/266956279.webp" },
                new Appliance() { Id = 11, Name = "SIEMENS TI351209RW", Price = 25600, Description = "Тип\r\nКавомашина\r\nТип кави\r\nЗернова\r\nКерування\r\nСенсорне\r\nПриготування капучино\r\nАвтоматичне", WarrantyInMonths = 60, IdCategory = 4, ImgUrl = "/img/25796393.webp" },
                new Appliance() { Id = 12, Name = "DELONGHI Dinamica Plus ECAM 370.95 T", Price = 28999, Description = "Тип кави\r\nЗернова\r\nМелена\r\nКерування\r\nСенсорне\r\nПриготування капучино\r\nАвтоматичне", WarrantyInMonths = 48, IdCategory = 4, ImgUrl = "/img/245635601.webp" },
                new Appliance() { Id = 13, Name = "Rowenta X-PLORER Serie 75 S RR8567WH\r\n", Price = 12999, Description = "Тип прибирання\r\nСухе + вологе", WarrantyInMonths = 24, IdCategory = 5, ImgUrl = "/img/334009479.webp" },
                new Appliance() { Id = 14, Name = "Samsung Bespoke Jet Bot AI", Price = 39999, Description = "Тип прибирання\r\nТільки суха", WarrantyInMonths = 60, IdCategory = 5, ImgUrl = "/img/187892403.webp" },
                new Appliance() { Id = 15, Name = "SAMSUNG GE83KRS-2/UA", Price = 4500, Description = "Тип\r\nЗ грилем\r\nСпосіб встановлення\r\nОкрема\r\nКолір\r\nСріблястий (сірий)\r\nТип керування\r\nЕлектронне\r\nПотужність НВЧ\r\n800 Вт", WarrantyInMonths = 24, IdCategory = 6, ImgUrl = "/img/306074404.webp" },
                new Appliance() { Id = 16, Name = "Candy CPMW 2070S", Price = 2200, Description = "Тип\r\nЗвичайна (соло)\r\nСпосіб встановлення\r\nОкрема\r\nКолір\r\nСріблястий (сірий)\r\nТип керування\r\nМеханічне\r\nПотужність НВЧ\r\n700 Вт", WarrantyInMonths = 12, IdCategory = 6, ImgUrl = "/img/152293458.webp" },
                new Appliance() { Id = 17, Name = "BOSCH FFL020MW0", Price = 3499, Description = "Тип\r\nЗвичайна (соло)\r\nСпосіб встановлення\r\nОкрема\r\nКолір\r\nБілий\r\nТип керування\r\nМеханічне\r\nПотужність НВЧ\r\n800 Вт", WarrantyInMonths = 24, IdCategory = 6, ImgUrl = "/img/199383704.webp" },
                new Appliance() { Id = 18, Name = "GORENJE MO17E1W", Price = 2599, Description = "Тип\r\nЗвичайна (соло)\r\nСпосіб встановлення\r\nОкрема\r\nКолір\r\nБілий\r\nТип керування\r\nМеханічне\r\nПотужність НВЧ\r\n700 Вт", WarrantyInMonths = 24, IdCategory = 6, ImgUrl = "/img/285898029.webp" },
                new Appliance() { Id = 19, Name = "HOTPOINT ARISTON HI 5020 WEF", Price = 14999, Description = "Місткість комплектів\r\n14\r\nСпосіб встановлення\r\nВбудована\r\nВитрата води за цикл/рік\r\n9.5/2660 л\r\nСпоживання електроенергії за цикл/рік\r\n0.934/266 кВт*год\r\nКлас енергоспоживання\r\nA++\r\nГабарити (ВхШхГ)\r\n82 х 59.8 х 55.5 см\r\nРозміри ніші для вбудовування (ВxШxГ)\r\n82 х 60 х 56 см\r\nКлас мийки\r\nA\r\nКлас сушіння\r\nA", WarrantyInMonths = 12, IdCategory = 7, ImgUrl = "/img/169012202.webp" },
                new Appliance() { Id = 20, Name = "BOSCH SMV2IVX00K", Price = 19999, Description = "Місткість комплектів\r\n13\r\nСпосіб встановлення\r\nВбудована\r\nВитрата води за цикл/рік\r\n9.5/ 2090 л\r\nСпоживання електроенергії за цикл/рік\r\n1.03/227 кВт*год\r\nКлас енергоспоживання\r\nA+\r\nГабарити (ВхШхГ)\r\n81.5 x 59.8 x 55 см\r\nРозміри ніші для вбудовування (ВxШxГ)\r\n81.5-87.5 x 60 x 55 см\r\nКлас мийки\r\nA\r\nКлас сушіння\r\nA", WarrantyInMonths = 24, IdCategory = 7, ImgUrl = "/img/293144325.webp" }
            );
        }
    }
}
