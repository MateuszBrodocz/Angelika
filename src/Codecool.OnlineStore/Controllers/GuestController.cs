using System.Linq;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;
using Spectre.Console;

namespace Codecool.OnlineStore.Controllers
{
    public class GuestController
    {
        protected IRepositoryFactory UnitOfWOrk { get; set; }

        protected IViewFactory UnitOfView { get; set; }

        public GuestController(IRepositoryFactory repositoryFactory, IViewFactory unitOfView)
        {
            UnitOfWOrk = repositoryFactory;
            UnitOfView = unitOfView;
        }

        public void ViewProductDetails(Product product)
        {
            var table = new Table();
            table.Border = TableBorder.Square;
            table.Title(product.Name).SquareBorder();
            table.AddColumns(
                new TableColumn("characteristic").LeftAligned().Width(15),
                new TableColumn("description").LeftAligned().Width(62));

            table.AddRow("Product ID", product.ProductId.ToString());
            table.AddRow("Quantity", product.Quantity.ToString());

            float discount;
            float finalPrice;
            if (product.DiscountId != 0)
            {
                discount = UnitOfWOrk.Discounts.Get(product.DiscountId).Value;
                finalPrice = (float)product.Price * (100 - discount) / 100;
            }
            else
            {
                finalPrice = (float)product.Price;
            }

            table.AddRow("Price", finalPrice.ToString());
            table.AddRow("Available", product.IsAvailable.ToString());
            table.AddRow("Category", UnitOfWOrk.Categories.GetAll()
                                        .Where(category => category.CategoryId == product.CategoryId)
                                        .Select(category => category.Name)
                                        .FirstOrDefault());

            AnsiConsole.Render(table);
        }

        public Product ChooseProductBySearch()
        {
            var inputRequestMessage = "type what you want to search";
            string searchFrase = UnitOfView.Guest.GetText(inputRequestMessage);

            var validStringPattern = @"^[A-Za-z0-9]{3,80}$";
            bool isStringValid = UnitOfView.Guest.IsStringValid(searchFrase, validStringPattern);

            if (isStringValid == true)
            {
                string[] foundedProducts = UnitOfWOrk.Products.Find(c => c.Name.Contains(searchFrase))
                    .Select(c => c.Name)
                    .ToArray();

                if (foundedProducts.Length == 0)
                {
                    return null;
                }

                Product selectedProduct = ChooseProduct(foundedProducts);

                return selectedProduct;
            }
            else
            {
                return null;
            }
        }

        public Product ChooseProductFromChosenCategory()
        {
            string[] allCategories = UnitOfWOrk.Categories.GetAll()
                .Select(category => category.Name)
                .ToArray();

            Category selectedCategory = SelectCategory(allCategories);

            string[] allProducts = UnitOfWOrk.Products.GetAll()
                .Where(product => product.Category == selectedCategory)
                .Select(product => product.Name)
                .ToArray();

            if (allCategories.Length == 0)
            {
                return null;
            }

            Product selectedProduct = ChooseProduct(allProducts);

            return selectedProduct;
        }

        public Product ChooseFromAllProducts()
        {
            string[] allProducts = UnitOfWOrk.Products.GetAll()
                .Select(product => product.Name)
                .ToArray();

            if (allProducts.Length == 0)
            {
                return null;
            }

            Product selectedProduct = ChooseProduct(allProducts);

            return selectedProduct;
        }

        public bool Availabilityofproduct(int baseId)
        {
            Product produkt = UnitOfWOrk.Products.Get(baseId);
            bool isAvailable = produkt.IsAvailable;
            return isAvailable;
        }

        private Category SelectCategory(string[] allCategories)
        {
            var title = "select a category";
            string selectedCategoryName = UnitOfView.Guest.GetOption(title, allCategories);

            Category selectedCategory = UnitOfWOrk.Categories.GetAll()
                .Where(category => category.Name == selectedCategoryName)
                .FirstOrDefault();
            return selectedCategory;
        }

        private Product ChooseProduct(string[] allProducts)
        {
            var title = "choose one of the products";
            string selectedProductName = UnitOfView.Guest.GetOption(title, allProducts);

            Product selectedProduct = UnitOfWOrk.Products.GetAll()
                .Where(product => product.Name == selectedProductName)
                .FirstOrDefault();
            return selectedProduct;
        }
    }
}
