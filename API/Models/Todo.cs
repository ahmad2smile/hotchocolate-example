using System;

namespace API.Models
{
    /// <summary>
    /// Todos for any User, could be defined by Higher level users or self defined
    /// </summary>
    public class Todo
    {
	    public Guid Id { get; set; }
	    public string Title { get; set; }
	    public string Description { get; set; }
    }
}
