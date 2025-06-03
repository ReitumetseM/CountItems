# Count Items API

A .NET Web API that provides functionality to count occurrences of items in a list. The API supports counting both numbers and strings.

## Features

- Generic item counting functionality
- Separate endpoints for counting numbers and strings
- RESTful API design
- Swagger documentation
- Input validation


## API Endpoints

### Count Numbers
Counts occurrences of numbers in a list.

```http
POST /api/count/count-numbers
Content-Type: application/json

[1, 2, 1, 3, 2, 1]
'''
### Count Strings
Counts occurrences of strings in a list.

```http
POST /api/count/count
Content-Type: application/json

["apple", "banana", "apple", "cherry", "banana", "apple"]

