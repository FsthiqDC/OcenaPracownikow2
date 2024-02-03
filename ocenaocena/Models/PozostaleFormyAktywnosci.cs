using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class PozostaleFormyAktywnosci
    {
        [Key]
        public int PozostaleFormyAktywnosciId { get; set; }

        // Pole tekstowe ograniczone do 255 znaków
        [MaxLength(255)]
        public string? Opis { get; set; }

        [ForeignKey("AppUserId")]  // Poprawione na "AppUserId"
        public virtual AppUser? User { get; set; }
        public int UserId { get; set; }


    }
}
