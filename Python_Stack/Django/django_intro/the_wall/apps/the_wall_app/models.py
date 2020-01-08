from django.db import models
from ..login_register_app.models import User

class Message(models.Model):
    users = models.ForeignKey(User, related_name='messages', on_delete=models.CASCADE)
    message = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)




class Comment(models.Model):
    messages = models.ForeignKey(Message, related_name='comments', on_delete=models.CASCADE)
    users = models.ForeignKey(User, related_name='comments', on_delete=models.CASCADE)
    comment = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
