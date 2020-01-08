from django.shortcuts import render, redirect
from .models import *

def wall(request):
    if 'loggedInUserID' not in request.session:
        return redirect ("/")

    context = {
        "all_messages" : Message.objects.all(),
        "user": User.objects.get(id=request.session['loggedInUserID'])
    }
    return render(request, "the_wall_app/wall.html", context)

def post_message(request):
    user = User.objects.get(id=request.session['loggedInUserID'])
    Message.objects.create(message = request.POST['message'], users = user)
    
    return redirect("/wall")


def add_comment(request):
    user = User.objects.get(id=request.session['loggedInUserID'])
    message_id = request.POST['message_id']
    Comment.objects.create(comment = request.POST['comment_add'], messages = Message.objects.get(id=message_id), users = user)
    
    return redirect('/wall')


# Create your views here.
