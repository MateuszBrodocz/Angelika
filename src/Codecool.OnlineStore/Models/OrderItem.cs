using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Order item class
    /// </summary>

    [Table("OrderItem")]
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets order's item id
        /// </summary>
        public int OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets order's id
        /// </summary>

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets order's item order
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Gets or sets order's item product
        /// </summary>

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets order's item product
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets order's item price
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets order's item quantity
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int orderId, Product product, decimal price, int quantity)
        {
            OrderId = orderId;
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
}
