from typing import Dict
from pydantic import BaseModel, ValidationError


class Person(BaseModel):
    name: str


PERSON_DICT: Dict[str, str] = {
    "name": "Bob Bobberson"
}

INVALID_PERSON_DICT: Dict[str, str] = {
    "favorite_color": "blue"
}


if __name__ == '__main__':
    person = Person(**PERSON_DICT)
    print(person.name)  # Accessing attribute directly
    print(person.dict())  # Converting object to dictionary

    # Pydantic provides automatic data validation
    try:
        invalid_person = Person(**INVALID_PERSON_DICT)
    except ValidationError as e:
        print(f"ValidationError: \n{e.json()}")

    # Pydantic supports field defaults and optional fields
    class Employee(BaseModel):
        name: str
        age: int = 30
        salary: float = 5000.0
        department: str = "IT"

    employee = Employee(name="John Doe")
    print(employee.dict())

    # Pydantic supports nested models
    class Address(BaseModel):
        street: str
        city: str
        zip_code: str

    class User(BaseModel):
        name: str
        age: int
        address: Address

    user_data = {
        "name": "Alice",
        "age": 25,
        "address": {
            "street": "123 Main St",
            "city": "New York",
            "zip_code": "10001"
        }
    }

    user = User(**user_data)
    print(user.dict())  
