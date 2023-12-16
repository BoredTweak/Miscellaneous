from typing import List, Dict, Any, Optional
from flask import Flask, Response, request, jsonify, url_for
from redis import Redis
from models.order import Order
from repositories.order_repository import OrderRepository

app: Flask = Flask(__name__)
redis_instance: Redis = Redis(host='redis', port=6379, db=0)
order_repository: OrderRepository = OrderRepository(redis_instance=redis_instance)

@app.route('/orders', methods=['GET'])
def get_orders() -> Response:
    orders: List[Order] = order_repository.get_all_orders()
    orders_with_links: List[Dict[str, Any]] = []
    for order in orders:
        order_with_links: Dict[str, Any] = order.dict()
        order_with_links['links'] = {
            'self': url_for('get_order', order_id=order.id, _external=True),
            'update': url_for('update_order', order_id=order.id, _external=True),
            'delete': url_for('delete_order', order_id=order.id, _external=True)
        }
        orders_with_links.append(order_with_links)
    return jsonify(orders_with_links)

@app.route('/orders', methods=['POST'])
def create_order() -> Response:
    data: Dict[str, Any] = request.get_json()
    order: Order = Order(**data)
    created_order: Order = order_repository.create_order(order)
    created_order_with_links: Dict[str, Any] = created_order.dict()
    created_order_with_links['links'] = {
        'self': url_for('get_order', order_id=created_order.id, _external=True),
        'update': url_for('update_order', order_id=created_order.id, _external=True),
        'delete': url_for('delete_order', order_id=created_order.id, _external=True)
    }
    return jsonify(created_order_with_links), 201

@app.route('/orders/<order_id>', methods=['GET'])
def get_order(order_id: str) -> Response:
    order: Optional[Order] = order_repository.get_order_by_id(order_id)
    if order:
        order_with_links: Dict[str, Any] = order.dict()
        order_with_links['links'] = {
            'self': url_for('get_order', order_id=order.id, _external=True),
            'update': url_for('update_order', order_id=order.id, _external=True),
            'delete': url_for('delete_order', order_id=order.id, _external=True)
        }
        return jsonify(order_with_links)
    else:
        return jsonify({'message': 'Order not found'}), 404

@app.route('/orders/<order_id>', methods=['PUT'])
def update_order(order_id: str) -> Response:
    data: Dict[str, Any] = request.get_json()
    order: Optional[Order] = order_repository.get_order_by_id(order_id)
    if order:
        updated_order: Order = order_repository.update_order(order_id, data)
        updated_order_with_links: Dict[str, Any] = updated_order.dict()
        updated_order_with_links['links'] = {
            'self': url_for('get_order', order_id=updated_order.id, _external=True),
            'update': url_for('update_order', order_id=updated_order.id, _external=True),
            'delete': url_for('delete_order', order_id=updated_order.id, _external=True)
        }
        return jsonify(updated_order_with_links)
    else:
        return jsonify({'message': 'Order not found'}), 404

@app.route('/orders/<order_id>', methods=['DELETE'])
def delete_order(order_id: str) -> Response:
    order: Optional[Order] = order_repository.get_order_by_id(order_id)
    if order:
        order_repository.delete_order(order_id)
        return jsonify({'message': 'Order deleted'})
    else:
        return jsonify({'message': 'Order not found'}), 404

if __name__ == '__main__':
    app.run(host="0.0.0.0", debug=True)
