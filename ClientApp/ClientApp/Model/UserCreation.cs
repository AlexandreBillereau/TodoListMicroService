using System.ComponentModel.DataAnnotations;

namespace ClientApp.Model;

public class UserCreation : User
{
    [Required(ErrorMessage = "confirm password is required")]
    [Compare("Pwd", ErrorMessage = "The passwords not match")]
    public string confirmPwd { get; set; }
}