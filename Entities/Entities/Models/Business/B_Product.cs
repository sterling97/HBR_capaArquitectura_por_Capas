using Entities.Data;

namespace Entities.Models.Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Products.LastOrDefault(p=>p.ProductId==id).ToList();
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
