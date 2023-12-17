from dataclasses import dataclass

@dataclass
class Apple:
    name: str
    color: str
    quantity: int

@dataclass(frozen=True)
class FrozenApple:
    name: str
    color: str
    quantity: int
