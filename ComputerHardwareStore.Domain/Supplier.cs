using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerHardwareStore.Domain
{
    public class Supplier
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Contacts { get; set; }
    }
}