using System.ComponentModel.DataAnnotations;

namespace ClientApp.Model;

public class User
{
    [Required(ErrorMessage  = "the user name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage  = "the password name is required")]
    public string Pwd { get; set; }
}