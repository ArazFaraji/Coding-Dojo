from django.db import models
import re
from datetime import *
from django.utils.dateparse import parse_date
import bcrypt

class UserValidation(models.Manager):
    def validator(self, postData):
        dob = postData['birthday']
        dob1 = parse_date(dob)
        today = date.today()
        errors = {}
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):    # test whether a field matches the pattern            
            errors['email'] = ("Invalid email address!")
        if len(User.objects.filter(email=postData['email'])) > 0:
            errors['email'] = "Email already registered"
        if len(postData['firstName']) < 2:
            errors['first_name'] = "First name must be at least two characters"
        if len(postData['lastName']) < 2:
            errors['last_name'] = "Last name must be at least two characters"
        if postData['birthday'] > str(date.today()):
            errors['release_date'] = "Date must be before todays date"
        if (dob1.year + 18, dob1.month, dob1.day) > (today.year, today.month, today.day):
            errors['age'] = "Must be at least 13 years old to register" 
        if len(postData['password']) < 8:
            errors['password'] = "Password must be at least 8 characters"
        if postData['password'] != postData['confirmpw']:
            errors['passwords'] = "Passwords do not match"
        return errors
    
    def login_validator(self, postData):
        errors = {}
        user = User.objects.filter(email = postData['email'])
        if len(user) < 1:
            errors['email'] = "Email does not exist"

        else:
            logged_user = user[0]
            if not bcrypt.checkpw(postData['password'].encode(), logged_user.password.encode()):
                errors['pw'] = "Incorrect password"
            # else:
            #     request.session['loggedInUserID']=logged_user.id
        return errors

        

class User(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    birthday = models.DateField()
    password = models.CharField(max_length=255)
    confirm_pw = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UserValidation()

