using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerHardwareStore.Domain
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Vendor { get; set; }
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShortDescription { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}