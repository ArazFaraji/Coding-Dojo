from django.db import models
from ..login_register_app.models import User
from datetime import *
from django.utils.dateparse import parse_date



class Validation(models.Manager):
    def trip_validator(self, postData):
        tripStart = postData['travel_date_start']
        trip_start = parse_date(tripStart)
        tripEnd = postData['travel_date_end']
        trip_end = parse_date(tripEnd)
        today = date.today()
        
        errors = {}
        if len(postData['destination']) < 1:
            errors['destination'] = "Destination required"
        if len(postData['description']) < 1:
            errors['destination'] = "Description required"
        if trip_start < today:
            errors['start'] = "Trip must be in the future"
        if trip_end < trip_start:
            errors['end'] = "Trip end date must be after trip start date"

        return errors



class Trip(models.Model):
    destination = models.CharField(max_length=255)
    description = models.TextField()
    travel_date_start = models.DateField()
    travel_date_end = models.DateField()
    creator = models.ForeignKey(User, related_name='creator', on_delete=models.CASCADE)
    users = models.ManyToManyField(User, related_name='trips')
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = Validation()


