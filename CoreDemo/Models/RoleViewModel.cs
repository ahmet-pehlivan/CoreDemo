using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lutfen Rol Adi Giriniz")]
        public string name { get; set; }
    }
}
