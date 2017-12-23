using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ekmek.UI.Entity
{
    public class DataInitializer:DropCreateDatabaseAlways<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){CategoryName="Kamera",Description="Kamera Ürünleri"},
                new Category(){CategoryName="Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){CategoryName="Ev Tekstili",Description="Ev Tekstili Ürünleri"},
                new Category(){CategoryName="Oyun",Description="Oyun Ürünleri"},
                new Category(){CategoryName="Cep Telefonları",Description="Telefon Ürünleri"},
                new Category(){CategoryName="Beyaz eşya",Description="Beyaz Eşya Ürünleri"},
            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
                context.SaveChanges();
            }

            var urunler = new List<Product>()
            {
                new Product(){ProductName="Canon 57dx",Description="Canon iyidir",Price=345.23,Stcok=12,IsApproved=true,CategoryID=1,IsHome=true,Image="Camera1.jpg"},
                new Product(){ProductName="Canon 53dx",Description="Canon iyidir",Price=245.23,Stcok=125,IsApproved=true,CategoryID=1,IsHome=true,Image="Camera2.jpg"},
                new Product(){ProductName="Canon 52dx",Description="Canon iyidir",Price=340.23,Stcok=13,IsApproved=true,CategoryID=1,IsHome=true,Image="Camera3.jpg"},
                new Product(){ProductName="Canon 51dx",Description="Canon iyidir",Price=545.23,Stcok=12,IsApproved=true,CategoryID=1,IsHome=true,Image="Camera4.jpg"},
                new Product(){ProductName="Canon 69dx",Description="Canon iyidir",Price=745.23,Stcok=2,IsApproved=true,CategoryID=1,IsHome=true,Image=null},

                new Product(){ProductName="Lenova i5",Description="i5 iyidir",Price=1250,Stcok=3,IsApproved=true,CategoryID=2,IsHome=false,Image="Bilgisayar1.jpg"},
                new Product(){ProductName="Lenova i3",Description="i3 iyidir",Price=1050,Stcok=5,IsApproved=true,CategoryID=2,IsHome=true,Image="Bilgisayar2.jpg"},
                new Product(){ProductName="Lenova i7",Description="i5 iyidir",Price=1650,Stcok=3,IsApproved=true,CategoryID=2,IsHome=true,Image="Bilgisayar3.jpg"},
                new Product(){ProductName="Macbook Pro",Description="ios iyidir",Price=4450,Stcok=3,IsApproved=true,CategoryID=2,IsHome=true,Image="Bilgisayar4.jpg"},

                new Product(){ProductName="Halı",Description="halı iyidir",Price=50,Stcok=59,IsApproved=true,CategoryID=3,IsHome=true,Image="Hali1.jpg"},
                new Product(){ProductName="Kilim",Description="kilim iyidir",Price=150,Stcok=9,IsApproved=true,CategoryID=3,IsHome=false,Image="Hali2.jpg"},
                new Product(){ProductName="Perde",Description="Perde iyidir",Price=508,Stcok=9,IsApproved=true,CategoryID=3,IsHome=true,Image="Hali3.jpg"},
                new Product(){ProductName="Masa",Description="masa iyidir",Price=150,Stcok=5,IsApproved=true,CategoryID=3,IsHome=true,Image="Hali4.jpg"},

                new Product(){ProductName="pacman",Description="pacman candır",Price=10,Stcok=10000,IsApproved=true,CategoryID=4,IsHome=false,Image="Oyun1.jpg"},
                new Product(){ProductName="hugo",Description="hugo candır",Price=14,Stcok=20000,IsApproved=true,CategoryID=4,IsHome=true,Image="Oyun2.jpg"},
                new Product(){ProductName="fifa15",Description="fifa15 candır",Price=100,Stcok=10,IsApproved=true,CategoryID=4,IsHome=true,Image="Oyun3.jpg"},
                new Product(){ProductName="fifa16",Description="fifa16 candır",Price=110,Stcok=17,IsApproved=true,CategoryID=4,IsHome=true,Image="Oyun4.jpg"},

                new Product(){ProductName="Iphone X",Description="ios iyidir",Price=6000,Stcok=43,IsApproved=true,CategoryID=5,IsHome=true,Image="Telefon1.jpg"},
                new Product(){ProductName="Iphone 5s",Description="ios iyidir",Price=1000,Stcok=33,IsApproved=true,CategoryID=5,IsHome=true,Image="Telefon2.jpg"},
                new Product(){ProductName="Iphone 6",Description="ios iyidir",Price=3000,Stcok=21,IsApproved=true,CategoryID=5,IsHome=true,Image="Telefon3.jpg"},
                new Product(){ProductName="Iphone 7s",Description="ios iyidir",Price=4000,Stcok=39,IsApproved=true,CategoryID=5,IsHome=true,Image="Telefon4.jpg"},

                new Product(){ProductName="Buzdolabı",Description="muhafaza eder",Price=900,Stcok=7,IsApproved=true,CategoryID=6,IsHome=true,Image="BeyazEsya1.jpg"},
                new Product(){ProductName="Çamaşır Mak.",Description="yıkar eder",Price=800,Stcok=8,IsApproved=true,CategoryID=6,IsHome=true,Image="BeyazEsya2.jpg"},
                new Product(){ProductName="Blender",Description="Blender eder",Price=50,Stcok=3,IsApproved=true,CategoryID=6,IsHome=false,Image="BeyazEsya3.jpg"},
                new Product(){ProductName="Fırın",Description="Fırın eder",Price=500,Stcok=2,IsApproved=true,CategoryID=6,IsHome=true,Image="BeyazEsya4.jpg"},
            };

            foreach (var item in urunler)
            {
                context.Products.Add(item);
                context.SaveChanges();
            }
        }
    }
}