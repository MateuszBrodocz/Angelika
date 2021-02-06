using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Category class
    /// </summary>

    [Table("Category")]
    public class Category
    {
        /// <summary>
        /// Gets or sets category's id
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets category's name
        /// </summary>

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether category's available
        /// </summary>

        [DefaultValue(true)]
        [Required]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets category's products associated
        /// </summary>
        public List<Product> Products { get; set; }

        public Category()
        {
        }

        public Category(string name, bool isAvailable = true)
        {
            Products = new List<Product>();
            Name = name;
            IsAvailable = isAvailable;
        }
    }
}
