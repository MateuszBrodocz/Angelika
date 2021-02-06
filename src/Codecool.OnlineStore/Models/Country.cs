using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Country class
    /// </summary>

    [Table("Country")]
    public class Country
    {
        /// <summary>
        /// Gets or sets country's id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets country's name
        /// </summary>
        [Required]
        public string CountryName { get; set; }

        public Country()
        {
        }

        public Country(string countryName)
        {
            CountryName = countryName;
        }
    }
}
