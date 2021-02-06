using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Order class
    /// </summary>

    [Table("Order")]
    public class Order
    {
        /// <summary>
        /// Gets or sets order's id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets customer's id
        /// </summary>

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets order's customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets order's create date
        /// </summary>

        [Required]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets order's payment date
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Gets or sets order's delivered date
        /// </summary>
        public DateTime? DeliveredDate { get; set; }

        /// <summary>
        /// Gets or sets order's item associated
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
        }

        public Order(int customerId)
        {
            OrderItems = new List<OrderItem>();
            CustomerId = customerId;
        }
    }
}
