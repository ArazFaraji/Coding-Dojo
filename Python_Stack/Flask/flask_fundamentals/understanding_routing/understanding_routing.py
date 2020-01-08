from flask import Flask
app = Flask(__name__)

@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route('/dojo')
def dojo():
    return 'Dojo!'

@app.route('/say/<name>')
def hello(name):
    return "Hello " + name

@app.route('/repeat/<number>/<word>')
def repeat(number, word):
    return word * int(number)

@app.errorhandler(404)
def not_found(e):
    return "Sorry! No response. Try again."


if __name__=="__main__":
    app.run(debug=True)