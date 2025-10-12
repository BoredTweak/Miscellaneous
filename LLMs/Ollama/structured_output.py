from ollama import chat
from pydantic import BaseModel
from pydantic import Field


class Country(BaseModel):
    name: str = Field(..., description="The name of the country")
    capital: str = Field(..., description="The capital city of the country")
    languages: list[str] = Field(
        ...,
        description="A list of official languages spoken in the country. Each item must be the specific name of a language.",
    )


response = chat(
    messages=[
        {
            "role": "user",
            "content": "Tell me about Canada.",
        }
    ],
    model="llama3.1",
    format=Country.model_json_schema(),
)

country = Country.model_validate_json(response.message.content)
print(country)
print(country.model_dump())
