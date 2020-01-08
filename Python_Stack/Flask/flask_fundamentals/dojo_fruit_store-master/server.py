from flask import Flask, render_template, request, redirect
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    count = int(request.form['strawberry']) + int(request.form['raspberry']) + int(request.form['apple'])
    print('Charging', request.form['first_name'], request.form['last_name'], count)
    strawberries=request.form['strawberry']
    raspberries=request.form['raspberry']
    apples=request.form['apple']
    first=request.form['first_name']
    last=request.form['last_name']
    studentid=request.form['student_id']
    return render_template("checkout.html", strawberry=strawberries, raspberry=raspberries, apple=apples, first=first, last=last, studentid=studentid, count=count)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")


if __name__=="__main__":   
    app.run(debug=True)    