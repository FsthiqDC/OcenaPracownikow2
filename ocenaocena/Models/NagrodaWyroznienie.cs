using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class NagrodaWyroznienie
    {
        [Key]
        public int NagrodaWyroznienieId { get; set; }

        // Nagroda Ministra
        [MaxLength(255)]
        public string? NagrodaMinistraNazwa { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NagrodaMinistraTerminOtrzymania { get; set; }

        // Nagroda Rektora
        [MaxLength(255)]
        public string? NagrodaRektoraNazwa { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NagrodaRektoraTerminOtrzymania { get; set; }

        // Nagrody i wyróżnienia organizacji naukowych
        [MaxLength(255)]
        public string? NagrodaOrganizacjiNazwa { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NagrodaOrganizacjiTerminOtrzymania { get; set; }
    }
}
