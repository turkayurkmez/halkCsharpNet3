using System.ComponentModel.DataAnnotations;

namespace introduceToDotNetCore.Models
{
    public class User
    {
        [Required(ErrorMessage = "Adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Epostanızı giriniz")]
        [EmailAddress(ErrorMessage = "Eposta adresiniz hatalı!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Soyadınızı giriniz")]
        public string LastName { get; set; }
        public string? Comment { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ResponseDate { get; set; }
    }
}
