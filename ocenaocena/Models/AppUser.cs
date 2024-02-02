using Microsoft.AspNetCore.Identity;
using ocenaocena.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ocenaocena.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<AktywnoscBadawcza>? AktywnosciBadawcze { get; set; }

        

        [Display(Name = "Imię użytkownika:")]
        [MaxLength(20)]
        public string? FirstName { get; set; }

        [Display(Name = "Nazwisko użytkownika:")]
        [MaxLength(50)]
        public string? LastName { get; set; }

        #region dodatkowe pole nieodwzorowywane w bazie
        [NotMapped]
        [Display(Name = "Pan/Pani:")]
        public string? FullName
        {
            get { return FirstName + " " + LastName; }
        }
        #endregion

        [Display(Name = "Informacja o użytkowniku:")]
        [MaxLength(255, ErrorMessage = "Zbyt długi opis - skróć do 255 znaków")]
        public string? Information { get; set; }

        [Display(Name = "Zdjęcie użytkownika:")]
        [FileExtensions(Extensions = ". jpg,. png,. gif", ErrorMessage = "Niepoprawne rozszerzenie pliku.")]
        [MaxLength(128)]
        public string? Photo { get; set; }

    }

}
