using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Basket item class
    /// </summary>

    [Table("BasketItem")]
    public class BasketItem
    {
        /// <summary>
        /// Gets or sets basket's item id
        /// </summary>
        public int BasketItemId { get; set; }

        /// <summary>
        /// Gets or sets customer's id
        /// </summary>

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets basket's item customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets product's id
        /// </summary>
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets basket's item product
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets basket's item quantity
        /// </summary>

        [Required]
        public int Quantity { get; set; }

        public BasketItem()
        {
        }

        public BasketItem(int customerId, int productId, int quantity)
        {
            CustomerId = customerId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
