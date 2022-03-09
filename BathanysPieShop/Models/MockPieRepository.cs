using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BathanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => 
            new List<Pie> { 
            
                new Pie { PieId =1, Name="Strawberry Pie", Price = 15.95M, ShortDescription="Strawberry pie description.", Category =_categoryRepository.AllCategories.SingleOrDefault(c=>c.CategoryName.Equals("Fruit Pies"))},
                new Pie {PieId =2, Name="Cheese Cake", Price=18.95M, ShortDescription = "CheeseCakeDescription", Category = _categoryRepository.AllCategories.SingleOrDefault(c=>c.CategoryName.Equals("Cheese Cakes"))},
                new Pie { PieId =3, Name="Rhubarb Pie", Price = 15.95M, ShortDescription="Rhubarb Pie description.", Category = _categoryRepository.AllCategories.SingleOrDefault(c=>c.CategoryName.Equals("Fruit Pies"))},
                new Pie {PieId =4, Name="Pumpkin Cake", Price=18.95M, ShortDescription = "PumpkinCakeDescription", Category = _categoryRepository.AllCategories.SingleOrDefault(c=>c.CategoryName.Equals("Seasonal Pies"))}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p=>p.PieId == pieId);
        }
    }
}
