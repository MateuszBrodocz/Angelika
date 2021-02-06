using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Customer class
    /// </summary>

    [Table("Customer")]
    public class Customer
    {
        /// <summary>
        /// Gets or sets customer's id
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets user's id
        /// </summary>

        [ForeignKey("User")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets customer's user
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets customer's first name
        /// </summary>

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets customer's last name
        /// </summary>

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets customer's phone number
        /// </summary>

        [StringLength(12)]
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets customer's street name
        /// </summary>

        [StringLength(50)]
        [Required]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets customer's postal code
        /// </summary>

        [StringLength(10)]
        [Required]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets customer's city
        /// </summary>

        [StringLength(100)]
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets country's id
        /// </summary>

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets customer's country
        /// </summary>
        [Required]
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets customer's individual discount
        /// </summary>
        [DefaultValue(0)]
        [Required]
        public float IndividualDiscount { get; set; }

        /// <summary>
        /// Gets or sets customer's orders associated
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets customer's basket associated
        /// </summary>
        public List<BasketItem> Basket { get; set; }

        public Customer()
        {
        }

        public Customer(User user, string firstname, string lastname, string phonenumber, string streetname, string postalcode, string city, Country country)
        {
            Basket = new List<BasketItem>();
            Orders = new List<Order>();
            User = user;
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;
            PostalCode = postalcode;
            StreetName = streetname;
            City = city;
            Country = country;
        }
    }
}
