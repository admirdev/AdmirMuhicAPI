using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmirMuhicAPI.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Image { get; set; } = null!;

        // Comma separated tags (simple seed/persistence strategy)
        public string Tags { get; set; } = null!;

        public string Link { get; set; } = null!;
    }
}
