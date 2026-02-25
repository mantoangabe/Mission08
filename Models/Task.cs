using System.ComponentModel.DataAnnotations;

namespace Mission08.Models;

public class Task
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required]
    public string TaskName { get; set; }
    public DateTime? DueDate { get; set; }
    [Required]
    public string Quadrant { get; set; } 
    public string? Category { get; set; }
    public bool IsCompleted { get; set; }
}