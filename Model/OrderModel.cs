using Hplus.EfCore;
using System.ComponentModel.DataAnnotations;

namespace Hplus.Model
{
    public class OrderModel
    {
        public int Id { get; set; }

        [Required]
        public virtual Product Product { get; set; } = new Product();
        [Required]
        public String Name { get; set; } = String.Empty;
        [Required]

        public String Address { get; set; } = String.Empty;

        [Required]

        public string PhhoneNumber { get; set; } = string.Empty;

    }
}
