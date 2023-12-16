import redis
from typing import Optional, List

from models.order import Order

class OrderRepository:
    def __init__(self, redis_instance: redis.Redis):
        self.redis = redis_instance

    def delete_order(self, order_id: int) -> None:
        try:
            # Delete the order from Redis using the globally unique key
            key = f"order:{str(order_id)}"
            self.redis.delete(key)
        except redis.exceptions.RedisError as e:
            # Handle Redis specific exceptions here
            raise OrderRepositoryException("Failed to delete order") from e

    def get_all_orders(self) -> List[Order]:
        try:
            # Retrieve all orders from Redis - return an empty list if there are no orders
            order_keys = self.redis.keys("order:*")
            orders = []
            for key in order_keys:
                order_json = self.redis.get(key)
                if order_json:
                    order = Order.parse_raw(order_json)
                    orders.append(order)
            return orders
        except redis.exceptions.RedisError as e:
            # Handle Redis specific exceptions here
            raise OrderRepositoryException("Failed to get all orders") from e

    def create_order(self, order_data: dict) -> Order:
        try:
            # Create a new order and save it to Redis
            order = Order(**order_data)
            self.save_order(order)
            return order
        except ValueError as e:
            # Handle validation errors here
            raise OrderRepositoryException("Failed to create order") from e

    def get_order_by_id(self, order_id: int) -> Optional[Order]:
        try:
            # Retrieve the order from Redis using the globally unique key
            key = f"order:{str(order_id)}"
            order_json = self.redis.get(key)
            if order_json:
                return Order.parse_raw(order_json)
            return None
        except redis.exceptions.RedisError as e:
            # Handle Redis specific exceptions here
            raise OrderRepositoryException("Failed to get order by ID") from e

    def update_order(self, order_id: str, updated_data: dict) -> Optional[Order]:
        try:
            # Update the order in Redis using the globally unique key
            key = f"order:{order_id}"
            order_json = self.redis.get(key)
            if order_json:
                order = Order.parse_raw(order_json)
                order_data = order.dict()
                order_data.update(updated_data)
                updated_order = Order(**order_data)
                self.save_order(updated_order)
                return updated_order
            return None
        except ValueError as e:
            # Handle validation errors here
            raise OrderRepositoryException("Failed to update order") from e

    def save_order(self, order: Order) -> None:
        try:
            # Save the order to Redis using the globally unique key
            key = f"order:{order.id}"
            order_json = order.json()
            self.redis.set(key, order_json)
        except redis.exceptions.RedisError as e:
            # Handle Redis specific exceptions here
            raise OrderRepositoryException("Failed to save order") from e

class OrderRepositoryException(Exception):
    pass
