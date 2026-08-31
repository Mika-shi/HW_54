namespace HW_54.Models;

public class ToDoIndexViewModel
{
    public List<ToDoTask> Tasks { get; set; } = new List<ToDoTask>();
    public PageViewModel PageViewModel { get; set; } = null!;
}