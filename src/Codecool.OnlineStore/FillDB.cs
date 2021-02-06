using System.Collections.Generic;
using Codecool.OnlineStore.DAL;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore
{
    public class FillDB
    {
        public static void AddRecords()
        {
            using (var db = new AllegrettoContext())
            {
                var unitOfWork = new RepositoryFactory(db);
                Category cat1 = new Category()
                {
                    Name = "Gry planszowe",
                    IsAvailable = true,
                    Products = new List<Product>()
                };
                unitOfWork.Categories.Add(cat1);
                Product prod1 = new Product()
                {
                    Name = "Catan",
                    Price = 129.99M,
                    Quantity = 8,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod1);
                Product prod2 = new Product()
                {
                    Name = "Splendor",
                    Price = 102.99M,
                    Quantity = 5,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod2);
                Product prod3 = new Product()
                {
                    Name = "Talisman Magia i Miecz",
                    Price = 171.99M,
                    Quantity = 3,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod3);
                Product prod4 = new Product()
                {
                    Name = "Dominion",
                    Price = 149.99M,
                    Quantity = 0,
                    IsAvailable = false,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod4);
                Product prod5 = new Product()
                {
                    Name = "Carcassonne",
                    Price = 89.99M,
                    Quantity = 15,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod5);
                Product prod6 = new Product()
                {
                    Name = "Dune: Imperium",
                    Price = 244.95M,
                    Quantity = 2,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod6);
                Product prod7 = new Product()
                {
                    Name = "Scrabble",
                    Price = 104.99M,
                    Quantity = 10,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod7);
                Product prod8 = new Product()
                {
                    Name = "Monopoly",
                    Price = 99.99M,
                    Quantity = 11,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod8);
                Product prod9 = new Product()
                {
                    Name = "Lisek urwisek",
                    Price = 54.17M,
                    Quantity = 4,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod9);
                Product prod10 = new Product()
                {
                    Name = "Talisman Batman",
                    Price = 248.99M,
                    Quantity = 3,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat1
                };
                unitOfWork.Products.Add(prod10);
                unitOfWork.Complete();

                Category cat2 = new Category()
                {
                    Name = "Smartfony",
                    IsAvailable = true,
                    Products = new List<Product>()
                };
                unitOfWork.Categories.Add(cat2);
                Product prod11 = new Product()
                {
                    Name = "Samsung Galaxy M11 (czarny)",
                    Price = 499M,
                    Quantity = 11,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod11);
                Product prod12 = new Product()
                {
                    Name = "Xiaomi Redmi 9C 3/64GB (szary)",
                    Price = 499M,
                    Quantity = 14,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod12);
                Product prod13 = new Product()
                {
                    Name = "Samsung Galaxy S21 5G 128GB (szary)",
                    Price = 3899M,
                    Quantity = 5,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod13);
                Product prod14 = new Product()
                {
                    Name = "Motorola moto g9 power 4/128GB (zielony)",
                    Price = 699M,
                    Quantity = 19,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod14);
                Product prod15 = new Product()
                {
                    Name = "Xiaomi Redmi Note 9 Pro 6+128 (biały)",
                    Price = 999M,
                    Quantity = 16,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod15);
                Product prod16 = new Product()
                {
                    Name = "Samsung Galaxy S20+ 5G (czarny)",
                    Price = 3999M,
                    Quantity = 2,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod16);
                Product prod17 = new Product()
                {
                    Name = "Samsung Galaxy Note10 Lite (czarny)",
                    Price = 1999M,
                    Quantity = 10,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod17);
                Product prod18 = new Product()
                {
                    Name = "Motorola Moto E6s 2/32 (niebieski)",
                    Price = 349M,
                    Quantity = 11,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod18);
                Product prod19 = new Product()
                {
                    Name = "OPPO Reno4 Lite (niebieski)",
                    Price = 1399M,
                    Quantity = 4,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod19);
                Product prod20 = new Product()
                {
                    Name = "Apple iPhone 12‌ 256GB (czarny)",
                    Price = 4949M,
                    Quantity = 3,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat2
                };
                unitOfWork.Products.Add(prod20);
                unitOfWork.Complete();

                Category cat3 = new Category()
                {
                    Name = "Ksiazki",
                    IsAvailable = true,
                    Products = new List<Product>()
                };
                unitOfWork.Categories.Add(cat3);
                Product prod21 = new Product()
                {
                    Name = "Szepty spoza nicosci",
                    Price = 26.53M,
                    Quantity = 11,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod21);
                Product prod22 = new Product()
                {
                    Name = "Moj ksiaże. Bridgertonowie. Tom 1",
                    Price = 26.34M,
                    Quantity = 14,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod22);
                Product prod23 = new Product()
                {
                    Name = "Powrot",
                    Price = 27.65M,
                    Quantity = 5,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod23);
                Product prod24 = new Product()
                {
                    Name = "Powrot z Bambuko",
                    Price = 23.94M,
                    Quantity = 19,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod24);
                Product prod25 = new Product()
                {
                    Name = "Dlaczego rodzice tak cie wkurzaja i co z tym zrobic",
                    Price = 19.99M,
                    Quantity = 16,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod25);
                Product prod26 = new Product()
                {
                    Name = "Chorzy ze stresu. Problemy psychosomatyczne",
                    Price = 24.10M,
                    Quantity = 2,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod26);
                Product prod27 = new Product()
                {
                    Name = "Piec Stawow. Dom bez adresu",
                    Price = 26.65M,
                    Quantity = 10,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod27);
                Product prod28 = new Product()
                {
                    Name = "Czuly narrator",
                    Price = 29.63M,
                    Quantity = 11,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod28);
                Product prod29 = new Product()
                {
                    Name = "Rok pelen inspiracji",
                    Price = 25.59M,
                    Quantity = 4,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod29);
                Product prod30 = new Product()
                {
                    Name = "Zagrywka",
                    Price = 28.62M,
                    Quantity = 3,
                    IsAvailable = true,
                    CategoryId = 1,
                    Category = cat3
                };
                unitOfWork.Products.Add(prod30);
                unitOfWork.Complete();
            }
        }
    }
}