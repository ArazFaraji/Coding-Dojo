from django.shortcuts import render
from .models import *

def travels(request):
    user = User.objects.get(id=request.session['loggedInUserID'])
    context = {
        "user": User.objects.get(id=request.session['loggedInUserID']),
        "trips": Trip.objects.filter(creator=user),
        "travels" : Trip.objects.all()
    }
    return render(request, 'travel_app/travel.html', context)

def add_travels(request):
    return render(request, 'travel_app/add_travel.html')

def add_trip(request):
    user = User.objects.get(id=request.session['loggedInUserID'])
    pass




# Create your views here.
