from django.shortcuts import render
from .models import *

def book_form(request):
    return render(request, 'books_app/add_book.html')

def add_book(request):
    if request.POST['add_author'] > 0:
        author = request.POST['add_author']
    else:
        author = request.POST['']
    Book.objects.create(title = request.POST['title'])
# Create your views here.
