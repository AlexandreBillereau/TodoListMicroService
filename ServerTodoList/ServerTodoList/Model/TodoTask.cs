using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ServerTodoList.Model;

public class TodoTask
{
    [Key]
    [JsonIgnore]
    public int Id { get; set; }

    [Required]
    public string name { get; set; }
    [Required]
    public State state { get; set; }
    public string comment { get; set; }
}