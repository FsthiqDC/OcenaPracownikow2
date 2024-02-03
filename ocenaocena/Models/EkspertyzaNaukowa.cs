using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class EkspertyzaNaukowa
    {
        [Key]
        public int EkspertyzaNaukowaId { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa instytucji zlecającej' jest wymagane.")]
        public string? NazwaInstytucjiZlecajacej { get; set; }

        [Required(ErrorMessage = "Pole 'Tytuł ekspertyzy/opracowania naukowego' jest wymagane.")]
        [MaxLength(255)]
        public string? TytulEkspertyzyOpracowaniaNaukowego { get; set; }

        [Required(ErrorMessage = "Pole 'Termin przekazania ekspertyzy/opracowania naukowego instytucji zlecającej' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime TerminPrzekazania { get; set; }

        [ForeignKey("AppUserId")]  // Poprawione na "AppUserId"
        public virtual AppUser? User { get; set; }
        public int UserId { get; set; }

    }
}
