from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages

# Create your views here.
def travels(request):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")
    user = User.objects.get(id=request.session['loggedInUserID'])
    context = {
        "user": User.objects.get(id=request.session['loggedInUserID']),
        "trips": Trip.objects.filter(users=user),
        "travels" : Trip.objects.exclude(users=user)
    }
    return render(request, 'travel_app/travel.html', context)

def add_travels(request):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")
    return render(request, 'travel_app/add_travel.html')

def add_trip(request):

    validate_error = Trip.objects.trip_validator(request.POST)
    if len(validate_error) > 0:
        for key,value in validate_error.items():
            messages.error(request, value)
        return redirect('/travels/add')


    user = User.objects.get(id=request.session['loggedInUserID'])
    trip = Trip.objects.create(destination = request.POST['destination'], description = request.POST['description'], creator = user, travel_date_start = request.POST['travel_date_start'], travel_date_end = request.POST['travel_date_end'])
    user.trips.add(trip)
    return redirect('/travels')

def join_trip(request, tripID):
    user = User.objects.get(id=request.session['loggedInUserID'])
    trip = Trip.objects.get(id=tripID)
    user.trips.add(trip)
    return redirect('/travels')

def trip_info(request, tripID):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")
    user = User.objects.get(id=request.session['loggedInUserID'])
    trip = Trip.objects.get(id=tripID)
    context = {
        "trip": trip,
        "joiners": trip.users.all(),
        "user": user
    }
    return render(request, "travel_app/trip_info.html", context)
