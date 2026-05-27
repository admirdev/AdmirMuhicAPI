using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmirMuhicAPI.Models
{
    [Table("Home")]
    public class Home
    {
        [Key]
        public int Id { get; set; }

        public string GeneralInfo { get; set; } = null!;
    }
}