from flask import Flask, request, jsonify

app = Flask(__name__)

@app.route('/calculate', methods=['GET'])
def calculate():
    result = "Hello, from flask"
    return jsonify({'result': result})

if __name__ == '__main__':
    app.run(debug=True)
