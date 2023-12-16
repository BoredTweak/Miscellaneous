from typing import List
import unittest
from unittest.mock import MagicMock
from models.order import LineItem, Order

from repositories.order_repository import OrderRepository

class OrderRepositoryTests(unittest.TestCase):
    def setUp(self):
        self.redis_mock = MagicMock()
        self.repository = OrderRepository(self.redis_mock)

    def test_delete_order(self):
        # Arrange
        order_id = 123
        
        # Act
        self.repository.delete_order(order_id)

        # Assert
        self.redis_mock.delete.assert_called_once_with(f"order:{order_id}")

    def test_get_all_orders(self):
        # Arrange
        order_keys = [b"order:1", b"order:2"]
        self.redis_mock.keys.return_value = order_keys
        self.redis_mock.get.side_effect = [
                b'{"id": "1", "line_items": [{"product": "Product 1", "quantity": 1, "price": 1.00}]}',
                b'{"id": "2", "line_items": [{"product": "Product 2", "quantity": 2, "price": 2.00}]}'
            ]
        
        # Act
        orders = self.repository.get_all_orders()

        # Assert
        self.assertEqual(len(orders), 2)
        self.assertEqual(orders[0].id, 1)
        self.assertEqual(orders[1].id, 2)

    def test_create_order(self):
        # Arrange
        line_item: LineItem = LineItem(product="Product 1", quantity=1, price=1.00)
        order: Order = Order(id=1, line_items=[line_item])
        
        # Act
        order = self.repository.create_order(order.dict())

        # Assert
        self.redis_mock.set.assert_called_once_with("order:1", '{"id": 1, "line_items": [{"product": "Product 1", "quantity": 1, "price": 1.0}]}')
        self.assertEqual(order.id, 1)
        self.assertEqual(order.line_items[0].product, "Product 1")

    def test_get_order_by_id(self):
        # Arrange
        order_json = b'{"id": "1", "line_items": [{"product": "Product 1", "quantity": 1, "price": 1.00}]}'
        self.redis_mock.get.return_value = order_json

        # Act
        order = self.repository.get_order_by_id(1)

        # Assert
        self.assertEqual(order.id, 1)
        self.assertEqual(order.line_items[0].product, "Product 1")

if __name__ == "__main__":
    unittest.main()