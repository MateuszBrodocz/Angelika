using System;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// Inheritor featured category  class
    /// </summary>

    public class FeaturedCategory : Category
    {
        /// <summary>
        /// Gets or sets featured's category expiration date
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        public FeaturedCategory()
        {
        }

        public FeaturedCategory(string name, bool isAvailable, DateTime expirationDate)
            : base(name, isAvailable)
        {
            ExpirationDate = expirationDate;
        }
    }
}
