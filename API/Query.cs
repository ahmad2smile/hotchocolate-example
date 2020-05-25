using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;

namespace API
{
	public class Query
	{
		private readonly ITodoRepository _todoRepository;

		public Query(ITodoRepository todoRepository)
		{
			_todoRepository = todoRepository;
		}

		public IEnumerable<Todo> Todos() => _todoRepository.GetAllTodo();
	}
}