from django.shortcuts import render

def home(request):
    return render(request, 'pokemon_app/index.html')

# Create your views here.
