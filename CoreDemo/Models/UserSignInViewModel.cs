using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lutfen Kullanici Adini Girin")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lutfen Sifrenizi Girin")]
        public string password { get; set; }
    }
}
