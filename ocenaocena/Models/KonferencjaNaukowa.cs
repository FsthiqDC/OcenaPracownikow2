using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class KonferencjaNaukowa
    {
        [Key]
        public int KonferencjaNaukowaId { get; set; }

        [Required(ErrorMessage = "Pole 'Rola' jest wymagane.")]
        public string? Rola { get; set; }

        [Required(ErrorMessage = "Pole 'Zasięg konferencji' jest wymagane.")]
        public string? ZasiegKonferencji { get; set; }

        [Required(ErrorMessage = "Pole 'Tytuł referatu' jest wymagane.")]
        [MaxLength(255)]
        public string? TytulReferatu { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa konferencji' jest wymagane.")]
        [MaxLength(255)]
        public string? NazwaKonferencji { get; set; }

        [Required(ErrorMessage = "Pole 'Data konferencji' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime DataKonferencji { get; set; }

        [Required(ErrorMessage = "Pole 'Miejsce konferencji' jest wymagane.")]
        [MaxLength(255)]
        public string? MiejsceKonferencji { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa organizatora konferencji' jest wymagane.")]
        [MaxLength(255)]
        public string? NazwaOrganizatoraKonferencji { get; set; }
    }
}
