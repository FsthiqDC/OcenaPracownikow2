using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class PozostalaDzialalnoscNaukowa
    {
        [Key]
        public int PozostalaDzialalnoscNaukowaId { get; set; }

        [Required(ErrorMessage = "Pole 'Rola' jest wymagane.")]
        [MaxLength(255)]
        public string? Rola { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa organizacji' jest wymagane.")]
        [MaxLength(255)]
        public string? NazwaOrganizacji { get; set; }

        [Required(ErrorMessage = "Pole 'Termin działalności' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime TerminDzialalnosciOd { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TerminDzialalnosciDo { get; set; }

        [ForeignKey("AppUserId")]  // Poprawione na "AppUserId"
        public virtual AppUser? User { get; set; }
        public int UserId { get; set; }

    }
}
