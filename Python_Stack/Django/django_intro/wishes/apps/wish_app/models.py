from django.db import models
from ..login_register_app.models import User

class Wish(models.Model):
    item = models.CharField(max_length=255)
    description = models.TextField()
    users = models.ForeignKey(User,related_name='wishes', on_delete=models.CASCADE)
    granted = models.BooleanField(default=False)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)


# Create your models here.
class Like(models.Model):
    like = models.IntegerField(default = 0)
    users = models.ForeignKey(User, related_name='likes', on_delete=models.CASCADE)
    wishes = models.ForeignKey(Wish, related_name='likes', on_delete=models.CASCADE)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

