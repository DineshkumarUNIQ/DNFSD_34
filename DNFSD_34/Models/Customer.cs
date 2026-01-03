using System.ComponentModel.DataAnnotations;

namespace DNFSD_34.Models
{
    public class Customer
    {
         public int Id { get; set; }
        [Required ] 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        [Required] public int Age { get; set; }
    }
}
