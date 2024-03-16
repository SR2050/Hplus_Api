using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Hplus.EfCore
{
    [Table("Orders")]
    public class Order
    {
        [Key,Required]
        public int Id { get; set; }

        [Required]
        public virtual Product Product { get; set; } = new Product();
        [Required]
        public String Name { get; set; } = String.Empty;
        [Required]

        public String Address {  get; set; } = String.Empty;

        [Required]

        public string PhhoneNumber { get; set; } = string.Empty;
    }
}
