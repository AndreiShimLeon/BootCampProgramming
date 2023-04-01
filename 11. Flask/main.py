from flask import Flask
app = Flask(__name__)
@app.route('/')
def main():
    return 'Hello world!'


@app.route('/index')
def index():
    return 'It is my first project'

@app.route('/index/<x>/<y>')
def indexf(x,y):
    return f'Сумма {int(x) + int(y)}'

if __name__ == '__main__':
    app.run()