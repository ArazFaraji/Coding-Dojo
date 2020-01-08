from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages
import bcrypt

def home(request):
    return render(request, 'login_register_app/index.html')

def register(request):
    validate_error = User.objects.validator(request.POST)
    if len(validate_error) > 0:
        for key,value in validate_error.items():
            messages.error(request, value)
        return redirect('/')
    else:
        password = request.POST['password']
        pw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt())

        loggedInUser = User.objects.create(first_name = request.POST['firstName'], last_name = request.POST['lastName'], email = request.POST['email'], password = pw_hash.decode())
        request.session['loggedInUserID'] = loggedInUser.id
        return redirect('/wishes')

def login(request):
    validate_error = User.objects.login_validator(request.POST)
    if len(validate_error) > 0:
        for key,value in validate_error.items():
            messages.error(request, value)
        return redirect('/')
    else:
        loggedInUser = User.objects.filter(email = request.POST['email'])
        loggedInUser = loggedInUser[0]
        request.session['loggedInUserID'] = loggedInUser.id
        return redirect('/wishes')


def success(request):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")
    loggedInUser = User.objects.get(id = request.session['loggedInUserID'] )
    context = {
        "user": loggedInUser
    }
    return render(request, "login_register_app/success.html", context)

def destroy(request):
     del request.session['loggedInUserID']
     return redirect("/")
