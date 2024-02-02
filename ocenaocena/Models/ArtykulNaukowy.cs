using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ocenaocena.Models;

namespace ocenaocena.Models
{
    public class ArtykulNaukowy
    {
        [Key]
        public int ArtykulNaukowyId { get; set; }

        // Atrybuty ogólne

        [Required(ErrorMessage = "Pole 'Rola' jest wymagane.")]
        public string? Rola { get; set; }

        public string? DOI { get; set; }

        [Required(ErrorMessage = "Pole 'Tytuł artykułu naukowego' jest wymagane.")]
        [MaxLength(255)]
        public string? TytulArtykuluNaukowego { get; set; }

        [Required(ErrorMessage = "Pole 'Tytuł czasopisma naukowego' jest wymagane.")]
        [MaxLength(255)]
        public string? TytulCzasopismaNaukowego { get; set; }

        public string? ISSN { get; set; }

        [Required(ErrorMessage = "Pole 'Rok opublikowania artykułu naukowego' jest wymagane.")]
        public int RokOpublikowania { get; set; }

        public int TomZeszytCzasopisma { get; set; }

        public int? NumeryStron { get; set; }

        [Required(ErrorMessage = "Pole 'Liczba wszystkich autorów artykułu naukowego' jest wymagane.")]
        public int LiczbaWszystkichAutorow { get; set; }

        public string? PozostaliWspolautorzy { get; set; }

        [Required(ErrorMessage = "Pole 'Dyscyplina naukowa' jest wymagane.")]
        public string? DyscyplinaNaukowa { get; set; }

        public string? NazwaPodmiotuUpowaznionego { get; set; }

        // Atrybuty dotyczące konferencji naukowej

        public string? NazwaKonferencji { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataKonferencji { get; set; }

        public string? MiejsceKonferencji { get; set; }

        // Atrybuty dotyczące otwartego dostępu

        public string? SposobUdostepnienia { get; set; }

        public string? WersjaTekstuOtwarta { get; set; }

        public string? LicencjaOtwarta { get; set; }

        [Required(ErrorMessage = "Pole 'Data udostępnienia artykułu naukowego' jest wymagane.")]
        [Column(TypeName = "Date")]
        public DateTime DataUdostepnienia { get; set; }

        public string? UdostepnienieNastapilo { get; set; }
    }
}
