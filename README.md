# [Hotchocolate](https://hotchocolate.io) Example

## Setup:

.Net Core 3.1, ASP.NET Core. Simple TODO API.

## Query

```
query {
  todos {
  	id
    title
    description
  }
}
```

## Error

```
{
  "errors": [
    {
      "message": "Unexpected Execution Error",
      "locations": [
        {
          "line": 3,
          "column": 5
        }
      ],
      "path": [
        "todos",
        "id"
      ]
    },
    {
      "message": "Unexpected Execution Error",
      "locations": [
        {
          "line": 4,
          "column": 5
        }
      ],
      "path": [
        "todos",
        "title"
      ]
    },
    {
      "message": "Unexpected Execution Error",
      "locations": [
        {
          "line": 5,
          "column": 5
        }
      ],
      "path": [
        "todos",
        "description"
      ]
    }
  ],
  "data": {
    "todos": null
  }
}
```
