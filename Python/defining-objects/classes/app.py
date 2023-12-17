from dataclasses import FrozenInstanceError
from fruit import Apple, FrozenApple
from airplane import Aircraft
from flask import Flask
from flasgger import Swagger

app = Flask(__name__)
Swagger(app)

@app.route('/health')
def hello():
    """
    This is a health checking endpoint. Call this to verify that the API is working.
    ---
    tags:
      - Health
    responses:
      200:
        description: The endpoint returned healthy
        schema:
          id: health
          properties:
            status:
              type: string
              description: indication of healthy vs unhealthy
    """
    return {'status': 'Healthy'}


@app.route('/class')
def airplane():
    """
    This is a class demonstration.
    ---
    tags:
      - Class
    responses:
      200:
        description: The endpoint successfully returned an aircraft
        schema:
          id: airplane
          properties:
            _model:
              type: string
              description: Model of the aircraft
            _num_rows:
              type: number
              description: Number of rows on the aircraft
            _num_seats_per_row:
              type: number
              description: Number of seats per row on the aircraft
            _registration:
              type: string
              description: Serial number of the aircraft
    """
    airplane = Aircraft('6969', 'C-150L', 1, 2)
    return airplane.__dict__


@app.route('/dataclass')
def fruit():
    """
    This is a dataclass demonstration.
    ---
    tags:
      - Dataclass
    responses:
      200:
        description: The endpoint successfully returned an apple
        schema:
          id: fruit
          properties:
            name:
              type: string
              description: name of the fruit
            color:
              type: string
              description: Color of the fruit
            quantity:
              type: number
              description: quantity of the fruit on hand
    """
    fruit1 = Apple('Apple', 'Green', 3)
    fruit2 = Apple('Apple', 'Green', 3)
    fruit3 = Apple('Apple', 'Red', 2)
    print("Fruit 1: " + repr(fruit1))
    print("Fruit 2: " + repr(fruit2))
    print("Fruit 3: " + repr(fruit3))
    print("Fruit 1 == Fruit 2: " + str(fruit1 == fruit2))
    print("Fruit 1 == Fruit 3: " + str(fruit1 == fruit3))
    return fruit1.__dict__

@app.route('/dataclass/frozen')
def frozenfruit():
    """
    This is a frozen dataclass demonstration.
    ---
    tags:
      - Dataclass
    responses:
      200:
        description: The endpoint was succeed
        schema:
          id: fruit
          properties:
            name:
              type: string
              description: name of the fruit
            color:
              type: string
              description: Color of the fruit
            quantity:
              type: number
              description: quantity of the fruit on hand
    """
    try:
        fruit1 = FrozenApple('Apple', 'Green', 3)
        fruit1.color = 'Red'
    except FrozenInstanceError as error:
        return repr(error)
    return fruit1.__dict__


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
