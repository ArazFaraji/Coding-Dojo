from django.shortcuts import render, redirect
from .models import *

def wishes(request):
    context = {
        "user": User.objects.get(id=request.session['loggedInUserID']),
        "wishes": Wish.objects.all()
    }
    return render(request, 'wish_app/wish.html', context)

# Create your views here.
def new_wish(request):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")
    context = {
        "user": User.objects.get(id=request.session['loggedInUserID'])
    }
    return render(request, 'wish_app/new_wish.html', context)

def add_wish(request):
    user = User.objects.get(id=request.session['loggedInUserID'])
    Wish.objects.create(item = request.POST['wish'], description = request.POST['description'], users = user)
    return redirect('/wishes')

def remove_wish(request, wishID):
    # user = User.objects.get(id=request.session['loggedInUserID'])
    wish = Wish.objects.get(id=wishID)
    wish.delete()
    return redirect('/wishes')

def edit_wish(request, wishID):
    user = User.objects.get(id=request.session['loggedInUserID'])
    wish = Wish.objects.get(id=wishID)
    context = {
        "user": user,
        "wish": wish
    }
    return render(request, 'wish_app/edit_wish.html', context)

def change_wish(request, wishID):
    wish = Wish.objects.get(id=wishID)
    wish.item = request.POST['wish']
    wish.description = request.POST['description']
    return redirect('/wishes')

def granted(request, wishID):
     wish = Wish.objects.get(id=wishID)
     wish.granted = True
     return redirect('/wishes')
