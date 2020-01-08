from django.shortcuts import render, redirect
from apps.books_authors_app.models import Book, Author

def index(request):
    context = {
        "books":Book.objects.all()
    }
    return render(request, 'books_authors_app/index.html', context)

def addbook(request):
    Book.objects.create(title=request.POST['title'], desc=request.POST['description'])
    return redirect('/')

def books(request, bookID):
    context = {
        'book': Book.objects.get(id=bookID),
        'author':Book.objects.get(id=bookID).authors.all(),
        'authorlist':Author.objects.all(),
    }
    return render(request, 'books_authors_app/books.html', context)

def addAuthorToBook(request, bookID):
    authorToAdd = Author.objects.get(id=request.POST['authorID'])
    book = Book.objects.get(id=bookID)
    book.authors.add(authorToAdd)

    return redirect('/books/' + bookID)
