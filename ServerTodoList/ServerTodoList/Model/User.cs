using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ServerTodoList.Model;

public class User
{
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    
    [Required]
    public int name { get; set; }
    public ICollection<TodoTask> tasks { get; set; }
}