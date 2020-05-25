using System.Collections.Generic;
using API.Models;

namespace API.Data
{
	public interface ITodoRepository
	{
		Todo GetTodo(string id);
		IEnumerable<Todo> GetAllTodo();
	}
}