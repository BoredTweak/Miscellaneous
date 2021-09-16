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
      - Airplane
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

if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
