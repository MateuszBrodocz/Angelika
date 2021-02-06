using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Statistic class
    /// </summary>

    [Table("Statistic")]
    public class Statistic
    {
        /// <summary>
        /// Gets or sets statistic's id
        /// </summary>
        public int StatisticId { get; set; }

        /// <summary>
        /// Gets or sets order's id
        /// </summary>
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets statistic's order
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Gets or sets statistic's product
        /// </summary>

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets statistic's product
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets statistic's rate
        /// </summary>
        [Required]
        public short Rate { get; set; }

        /// <summary>
        /// Gets or sets statistic's date
        /// </summary>
        [Required]
        public DateTime StatisticDate { get; set; }

        public Statistic()
        {
        }

        public Statistic(int orderId, Product product, short rate)
        {
            OrderId = orderId;
            Product = product;
            Rate = rate;
        }
    }
}
