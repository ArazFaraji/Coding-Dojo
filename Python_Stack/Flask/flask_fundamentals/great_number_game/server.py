from flask import Flask, render_template, request, redirect, session
import random
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'


@app.route('/')
def index():
    if 'randomNum' not in session:
        session['randomNum'] = random.randint(1,101)
    if 'result' not in session:
        session['result'] = ""
    if 'count' not in session:
        session['count'] = 0

    print(session['randomNum'])
    return render_template('index.html', result = session['result'], attempts = session['count'])

@app.route('/guess', methods=['POST'])
def guess():

    if int(request.form['user_guess']) > session['randomNum']:
        session['result'] = "Too High."
        print('guess is too high')
    if int(request.form['user_guess']) < session['randomNum']:
        session['result'] = "Too Low."
        print('guess is too low')
    if int(request.form['user_guess']) == session['randomNum']:
        session['result'] = "Correct!"
        print('Great guess')

    return redirect('/')

@app.route('/playAgain')
def playAgain():
    session.clear()
    return redirect('/')



if __name__ == "__main__":
    app.run(debug=True)