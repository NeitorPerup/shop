using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Advantshop.Models
{
    public class ShopDbInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            db.Categorys.Add(new Category { Name = "Одежда", Url = "../img/popularCategory/clothes.png" });
            db.Categorys.Add(new Category { Name = "Мебель", Url = "../img/popularCategory/furniture.png" });
            db.Categorys.Add(new Category { Name = "Бытовая техника", Url = "../img/popularCategory/tehnics.png" });
            db.Categorys.Add(new Category { Name = "Спорт", Url = "../img/popularCategory/sport.png" });
            db.Categorys.Add(new Category { Name = "Косметика", Url = "../img/popularCategory/dove.png" });
            db.Categorys.Add(new Category { Name = "Садовая техника", Url = "../img/popularCategory/gardening.png" });

            base.Seed(db);
        }
    }
}
