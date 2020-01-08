from flask import Flask, render_template, redirect, request, session
import random
app = Flask(__name__)
app.secret_key = "gold"

@app.route('/')
def index():
    if 'gold' not in session:
        session['gold'] = 0

    return render_template('index.html')

@app.route('/process_money', methods=['POST'])
def processMoney():
    if request.form['which_form'] == 'cave':
        session['gold'] += random.randint(5,11)
    if request.form['which_form'] == 'farm':
        session['gold'] += random.randint(10,21)
    if request.form['which_form'] == 'house':
        session['gold'] += random.randint(2,6)
    if request.form['which_form'] == 'casino':
        session['gold'] += random.randint(-50,51)
    return redirect('/')





if __name__ == "__main__":
    app.run(debug=True)