from flask import Flask, render_template
app = Flask(__name__) 

@app.route('/')
def home():
    return "Hello user"

@app.route('/play')
def play():
    return render_template('index.html', times = 3, backgroundcolor="aqua")

@app.route('/play/<timess>')
def play_times(timess):
    return render_template('index.html', times = int(timess), backgroundcolor='aqua')

@app.route('/play/<timess>/<backgroundcolor>')
def play_times_color(timess, backgroundcolor):
    return render_template('index.html', times = int(timess), backgroundcolor=backgroundcolor)




if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.
