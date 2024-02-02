using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace ocenaocena.ViewModels
{
    public class AktywnoscBadawczaViewModel
    {
        [Required(ErrorMessage = "Pole 'Tytuł projektu' jest wymagane.")]
        [MaxLength(255, ErrorMessage = "Tytuł projektu nie może przekroczyć 255 znaków.")]
        public string? TytulProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'Projekt realizowany jest' jest wymagane.")]
        public bool ProjektWspolrealizowany { get; set; }

        public string? ZasiegProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa lidera projektu' jest wymagane.")]
        [MaxLength(100, ErrorMessage = "Nazwa lidera projektu nie może przekroczyć 100 znaków.")]
        public string? NazwaLideraProjektu { get; set; }

        public string? FunkcjaWProjekcie { get; set; }

        [Required(ErrorMessage = "Pole 'Instytucja finansująca projekt' jest wymagane.")]
        [MaxLength(150, ErrorMessage = "Instytucja finansująca projekt nie może przekroczyć 150 znaków.")]
        public string? InstytucjaFinansujacaProjekt { get; set; }

        public string? NazwaKonkursu { get; set; }

        [Required(ErrorMessage = "Pole 'Data zawarcia umowy' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime DataZawarciaUmowy { get; set; }

        [Required(ErrorMessage = "Pole 'Data złożenia wniosku' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime DataZlozeniaWniosku { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataRozpoczeciaProjektu { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataZakonczeniaProjektu { get; set; }

        [Required(ErrorMessage = "Pole 'UserId' jest wymagane.")]
        public int UserId { get; set; }
    }
}
