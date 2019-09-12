using System.ComponentModel.DataAnnotations;

namespace PetPa.models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}