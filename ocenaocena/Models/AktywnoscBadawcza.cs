using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ocenaocena.Models
{
    public class AktywnoscBadawcza
    {
        [Key]
        public int AktywnoscBadawczaId { get; set; }

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
        [Column(TypeName = "Date")]
        public DateTime DataZawarciaUmowy { get; set; }

        [Required(ErrorMessage = "Pole 'Data złożenia wniosku' jest wymagane.")]
        [Column(TypeName = "Date")]
        public DateTime DataZlozeniaWniosku { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataRozpoczeciaProjektu { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataZakonczeniaProjektu { get; set; }

        [ForeignKey("AppUserId")]  // Poprawione na "AppUserId"
        public virtual AppUser? User { get; set; }
        public int UserId { get; set; }
 
    }


}
