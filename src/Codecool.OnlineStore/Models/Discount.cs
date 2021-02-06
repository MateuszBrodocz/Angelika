using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Discount class
    /// </summary>

    [Table("Discount")]
    public class Discount
    {
        /// <summary>
        /// Gets or sets discount's id
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets product's id
        /// </summary>

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets discount's product
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets discount's value
        /// </summary>

        [Required]
        public float Value { get; set; }

        /// <summary>
        /// Gets or sets discount's expiration date
        /// </summary>

        [Required]
        public DateTime ExpirationDate { get; set; }

        public Discount()
        {
        }

        public Discount(int productId, float value)
        {
            ProductId = productId;
            Value = value;
        }
    }
}
