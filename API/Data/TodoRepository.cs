using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;

namespace API.Data
{
    public class TodoRepository : ITodoRepository
    {
	    private readonly Dictionary<string, Todo> _todos;

	    public TodoRepository()
	    {
		    _todos = CreateTodos().ToDictionary(t => t.Id.ToString());
	    }

	    public Todo GetTodo(string id)
	    {
		    return _todos[id];
	    }

	    public IEnumerable<Todo> GetAllTodo()
	    {
		    return _todos.Values;
	    }

	    private static IEnumerable<Todo> CreateTodos()
	    {
		    yield return new Todo
		    {
				Id = Guid.NewGuid(),
				Title = "New Todo Title 1",
				Description = "New Description 1"
		    };
		    yield return new Todo
		    {
			    Id = Guid.NewGuid(),
			    Title = "New Todo Title 2",
			    Description = "New Description 2"
		    };
		    yield return new Todo
		    {
			    Id = Guid.NewGuid(),
			    Title = "New Todo Title 3",
			    Description = "New Description 3"
		    };
		    yield return new Todo
		    {
			    Id = Guid.NewGuid(),
			    Title = "New Todo Title 4",
			    Description = "New Description 4"
		    };
		    yield return new Todo
		    {
			    Id = Guid.NewGuid(),
			    Title = "New Todo Title 5",
			    Description = "New Description 5"
		    };

	    }
    }
}
