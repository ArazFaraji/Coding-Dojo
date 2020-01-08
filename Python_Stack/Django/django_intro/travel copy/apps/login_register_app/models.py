from django.db import models
import re
from datetime import *
from django.utils.dateparse import parse_date
import bcrypt

class UserValidation(models.Manager):
    def validator(self, postData):

        errors = {}

        if len(postData['name']) < 3:
            errors['name'] = "Name must be at least 3 characters"
        if len(postData['username']) < 3:
            errors['username'] = "Username must be at least 3 characters"
        if len(User.objects.filter(username=postData['username'])) > 0:
            errors['username'] = "Username already exists"

        if len(postData['password']) < 8:
            errors['password'] = "Password must be at least 8 characters"
        if postData['password'] != postData['confirmpw']:
            errors['passwords'] = "Passwords do not match"
        return errors
    
    def login_validator(self, postData):
        errors = {}
        user = User.objects.filter(username = postData['username'])
        if len(user) < 1:
            errors['username'] = "Username does not exist"

        else:
            logged_user = user[0]
            if not bcrypt.checkpw(postData['password'].encode(), logged_user.password.encode()):
                errors['pw'] = "Incorrect password"
        return errors

        

class User(models.Model):
    name = models.CharField(max_length=255)
    username = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UserValidation()

