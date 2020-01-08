from django.shortcuts import render
from time import strftime, localtime

def timezone(request):
    context = {
        "time": strftime("%Y-%m-%d %H:%M %p", localtime())
    }
    return render(request, 'timeDisplayApp/index.html', context)

# Create your views here.
