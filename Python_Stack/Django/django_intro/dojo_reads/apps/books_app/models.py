from django.db import models
from ..login_register_app.models import User

class Author(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)


class Book(models.Model):
    title = models.CharField(max_length=255)
    authors = models.ForeignKey(Author,related_name='books', on_delete=models.CASCADE)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)




class Review(models.Model):
     review = models.CharField(max_length=255)
     rating = models.IntegerField()
     users = models.ForeignKey(User, related_name='reviews', on_delete=models.CASCADE)
     books = models.ForeignKey(Book, related_name='reviews', on_delete=models.CASCADE)
     created_at = models.DateTimeField(auto_now_add=True)
     updated_at = models.DateTimeField(auto_now_add=True)
