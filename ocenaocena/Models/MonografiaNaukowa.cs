using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ocenaocena.Models
{
    public class MonografiaNaukowa
    {
        [Key]
        public int MonografiaNaukowaId { get; set; }

        // Atrybuty ogólne

        [Required(ErrorMessage = "Pole 'Tytuł projektu' jest wymagane.")]
        [MaxLength(255)]
        public string? TytulProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'Projekt realizowany jest' jest wymagane.")]
        public string? ProjektRealizowanyJest { get; set; }

        [Required(ErrorMessage = "Pole 'Zasięg projektu' jest wymagane.")]
        public string? ZasiegProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa lidera projektu' jest wymagane.")]
        [MaxLength(255)]
        public string? NazwaLideraProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'Funkcja w projekcie' jest wymagane.")]
        public string? FunkcjaWProjekcie { get; set; }

        [Required(ErrorMessage = "Pole 'Instytucja finansująca projekt' jest wymagane.")]
        [MaxLength(255)]
        public string? InstytucjaFinansujacaProjekt { get; set; }

        [MaxLength(255)]
        public string? NazwaKonkursuProgramu { get; set; }

        [Required(ErrorMessage = "Pole 'Data zawarcia i numer umowy' jest wymagane.")]
        [Column(TypeName = "Date")]
        public DateTime DataZawarciaINumerUmowy { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataZlozeniaWniosku { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataRozpoczeciaPracy { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataZakonczeniaPracy { get; set; }

        [Required(ErrorMessage = "Pole 'Dyscypliny naukowe' jest wymagane.")]
        public string? DyscyplinyNaukowe { get; set; }

        // Atrybuty dotyczące monografii naukowej

        public string? RolaMonografii { get; set; }

        public string? DOI { get; set; }

        public string? TytulMonografii { get; set; }

        public string? TytulRozdzialuMonografii { get; set; }

        public string? ISBN { get; set; }

        public int LiczbaWszystkichAutorowMonografii { get; set; }

        public string? PozostaliWspolautorzyIRedaktorzyMonografii { get; set; }

        public string? PozostaliWspolautorzyRozdzialu { get; set; }

        public string? NumeryORCIDWspolautorowIRedaktorowMonografii { get; set; }

        public string? NumeryORCIDWspolautorowRozdzialu { get; set; }

        public string? WydawcaMonografii { get; set; }

        [Required(ErrorMessage = "Pole 'Rok wydania monografii' jest wymagane.")]
        public int RokWydaniaMonografii { get; set; }

        public string? DyscyplinaNaukowaMonografii { get; set; }

        public string? DyscyplinaNaukowaRozdzialuMonografii { get; set; }

        public string? NazwaPodmiotuUpowaznionegoMonografia { get; set; }

        public string? NazwaPodmiotuUpowaznionegoRozdzial { get; set; }

        public string? SposobUdostepnieniaMonografii { get; set; }

        public string? WersjaTekstuOtwarta { get; set; }

        public string? LicencjaOtwarta { get; set; }

        [Required(ErrorMessage = "Pole 'Data udostępnienia monografii' jest wymagane.")]
        [Column(TypeName = "Date")]
        public DateTime DataUdostepnieniaMonografii { get; set; }

        public string? UdostepnienieNastapilo { get; set; }
    }
}
