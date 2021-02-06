using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Product class
    /// </summary>

    [Table("Product")]
    public class Product
    {
        /// <summary>
        /// Gets or sets product's id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product's name
        /// </summary>

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product's price
        /// </summary>

        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets product's quantity
        /// </summary>

        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether product's available
        /// </summary>

        [DefaultValue(true)]
        [Required]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets a categoryId
        /// </summary>

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets product's category
        /// </summary>

        [Required]
        public Category Category { get; set; }

        /// <summary>
        /// Gets or sets a discountId
        /// </summary>

        [ForeignKey("Discount")]
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets product's active discount
        /// </summary>

        public Discount? ActiveDiscount { get; set; }

        public Product()
        {
        }

        public Product(string name)
        {
            Name = name;
        }

        public Product(int categoryId, string name, decimal price, int quantity, bool isAvailable = true)
        {
            CategoryId = categoryId;
            Name = name;
            Price = price;
            Quantity = quantity;
            IsAvailable = isAvailable;
        }
    }
}