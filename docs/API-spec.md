# Clean books API

| Path    | HTTP request | Request params | Request body       | Response codes | Response body | Notes                                      |
| ------- | ------------ | -------------- | ------------------ | -------------- | ------------- | ------------------------------------------ |
| /books  | GET          | -              | -                  | Ok             | BookDto[]     | Returns an array of all books              |
| /books  | POST         | -              | newbook: BookDto   | Ok             | -             | Tries to add a book to the book database   |
| /orders | GET          | -              | -                  | Ok             | OrderDto[]    | Returns an array of all orders             |
| /orders | POST         | -              | neworder: OrderDTO | Ok             | -             | Tries to add a order to the order database |
| /users  | GET          | -              | -                  | Ok             | UserDto[]     | Returns an array of all users              |
| /users  | POST         | -              | newuser: UserDTO   | Ok             | -             | Tries to add a user to the user database   |
