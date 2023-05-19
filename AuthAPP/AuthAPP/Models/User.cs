using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthAPP.Data;

public class User
{
    public User() {}

    public User(string name, string pwd)
    {
        Name = name;
        Pwd = pwd;
    }


    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Pwd { get; set; }

}