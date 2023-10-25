using System.ComponentModel.DataAnnotations;

namespace MVCPROJECT.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string AlbumName { get; set; }

        public string Shows { get; set; }

        public string Places { get; set; }

        public string Songs{ get; set; }

        public string Music { get; set; }
    }
}