using System.ComponentModel.DataAnnotations;

namespace PetPa.models
{
    public class Post
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Caption { get; set; }
    }
}