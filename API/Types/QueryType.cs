using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace API.Types
{
    public class QueryType: ObjectType<Query>
    {
	    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
	    {
		    descriptor.Field(t => t.Todos())
			    .Type<TodoType>();
	    }
    }
}
