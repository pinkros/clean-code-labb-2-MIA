# Clean books API

| Path    | HTTP request | Request params | Request body    | Response codes | Response body | Notes                                      |
| ------- | ------------ | -------------- | --------------- | -------------- | ------------- | ------------------------------------------ |
| /books  | GET          | -              | -               | Ok             | BookDto[]     | Returns an array of all books              |
| /books  | POST         | -              | book: BookDto   | Ok, BadRequest | -             | Tries to add a book to the book database   |
| /orders | GET          | -              | -               | Ok             | OrderDto[]    | Returns an array of all orders             |
| /orders | POST         | -              | order: OrderDTO | Ok, BadRequest | -             | Tries to add a order to the order database |
| /users  | GET          | -              | -               | Ok             | UserDto[]     | Returns an array of all users              |
| /users  | POST         | -              | user: UserDTO   | Ok, BadRequest | -             | Tries to add a user to the user database   |
