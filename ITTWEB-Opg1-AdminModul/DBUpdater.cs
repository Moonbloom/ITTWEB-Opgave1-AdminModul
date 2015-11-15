using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul
{
    public class DbUpdater
    {
        public void Update(EsDbContext context)
        {
            var category1 = new Category
            {
                CategoryName = "Cat Category"
            };
            context.Categories.Add(category1);

            var comType1 = new ComponentType
            {
                ComponentName = "namey namey",
                CategoryId = category1.Id
            };
            context.ComponentTypes.Add(comType1);

            var com1 = new Component
            {
                ComponentNumber = 1337,
                ComponentTypeId = comType1.Id,
                SerieNr = "1337",
                UserComment = "this product sux",
                AdminComment = "admin comment"
            };
            context.Components.Add(com1);

            context.SaveChanges();
        }
    }
}