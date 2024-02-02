using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class DzialalnoscOrganizacyjna
    {
        [Key]
        public int DzialalnoscOrganizacyjnaId { get; set; }

        [Required(ErrorMessage = "Pole 'Rola' jest wymagane.")]
        [MaxLength(255)]
        public string? Rola { get; set; }

        [Required(ErrorMessage = "Pole 'Zasięg organizacji' jest wymagane.")]
        [MaxLength(255)]
        public string? ZasiegOrganizacji { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa organizacji' jest wymagane.")]
        [MaxLength(255)]
        public string? NazwaOrganizacji { get; set; }

        [Required(ErrorMessage = "Pole 'Termin przynależności' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime TerminPrzynaleznosci { get; set; }

    }
}
