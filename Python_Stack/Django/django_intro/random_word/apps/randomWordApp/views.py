from django.shortcuts import render, redirect
from django.utils.crypto import get_random_string

def random(request):
    context = {
        "random": get_random_string(length=14)
    }
    if 'count' not in request.session:
        request.session['count'] = 0
    request.session['count'] += 1
    return render(request, 'randomWordApp/index.html', context)

def reset(request):
    del request.session['count']
    return redirect("/")

# Create your views here.
