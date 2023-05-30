using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string OfferType { get; set; }
        [Required]
        public string Category { get; set; }
		
        public string Description { get; set; }

        [Range(1,100)]
        public double Discount { get; set; }

        [Range(0,100000)]
        public double Price { get; set; }

        [Range(0,100000)]
		public double OldPrice { get; set; }

        [Required]
		public string ImagePath { get; set; }
    }
}
