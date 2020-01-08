from django.db import models
from ..login_register_app.models import User


class Trip(models.Model):
    destination = models.CharField(max_length=255)
    description = models.TextField()
    travel_date_start = models.DateField()
    travel_date_end = models.DateField()
    creator = models.ForeignKey(User, related_name='creator', on_delete=models.CASCADE)
    users = models.ManyToManyField(User, related_name='trips')
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    

