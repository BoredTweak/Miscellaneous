from flask_cors import CORS
from flask import send_file, Flask, request
import redis
from io import BytesIO

ALLOWED_EXTENSIONS = {'txt', 'pdf', 'png', 'jpg', 'jpeg', 'gif'}
app = Flask(__name__)
CORS(app)
cache = redis.Redis(host='redis', port=6379)


def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in ALLOWED_EXTENSIONS


'''
Test endpoint to prove this service is running
'''
@app.route('/api/chicken')
def return_files():
    try:
        return send_file('./chicken.jpg', download_name='python.jpg')
    except Exception as e:
        return str(e)


@app.route('/api/file', methods=['POST'])
def file_upload():
    print("posting!")
    if 'file' not in request.files:
        print('No file part')
        return 'No attachment found in payload'
    file = request.files['file']
    if file and allowed_file(file.filename):
        for property, value in vars(file).items():
            print(property, ":", value)
        cache.set('file', file.stream.read())
        return 'Successfully stored file'


@app.route('/api/file', methods=['GET'])
def file_retrieve():
    print("getting!")
    bytes = cache.get('file')
    return send_file(BytesIO(bytes), mimetype='image/png')


@app.errorhandler(500)
def server_error(e):
    print('An error occurred during a request. %s', e)
    return "An internal error occured", 500


if __name__ == "__main__":
    app.run(host="0.0.0.0", debug=True)
