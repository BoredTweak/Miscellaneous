from pydantic import BaseModel
from typing import List

class LineItem(BaseModel):
    product: str
    quantity: int
    price: float

class Order(BaseModel):
    id: int
    line_items: List[LineItem]
