using Entities.Data;

namespace Entities.Models.Business
{
    public class B_Category
    {
        public class B_category
        {
            public static List<CategoryEntity> CategoryList()
            {
                using (var db = new ApplicationDbContext())
                {
                    return db.Categories.ToList();
                }
            } 

            public void CreateCategory(CategoryEntity oCategory)
            {
                using (var db = new ApplicationDbContext())
                {
                    db.Categories.Add(oCategory);
                    db.SaveChanges();
                }
            }

            public void UpdateCategory(CategoryEntity oCategory)
            {
                using (var db = new ApplicationDbContext())
                {
                    db.Categories.Update(oCategory);
                    db.SaveChanges();
                }
            }
        }
    }
}
