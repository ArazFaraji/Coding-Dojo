from django.db import models
from datetime import *


class TVshowManager(models.Manager):
    def basic_validator(self, postData):
        # releaseDate = postData['release_date']
        # currentDate = date.today()
        # print(releaseDate)
        # print(currentDate)

        # newReleaseDate = datetime.strptime(releaseDate, "%Y/%m/%d")
        # newCurrentDate = datetime.strptime(currentDate, "%Y/%m/%d")
        errors = {}
        if len(postData['title']) < 2:
            errors['title'] = "TV show name should be at least 2 characters"
        if len(postData['network']) < 3:
            errors['network'] = "Network should have at least 3 characters"
        if len(postData['description']) > 0 and len(postData['description']) < 10:
            errors['description'] = "Description must have at least 10 characters"
        if postData['release_date'] > str(date.today()):
            print("we are here")
            errors['release_date'] = "Date must be before todays date"
        if len(TVshow.objects.filter(title=postData['title'])) > 0:
            errors['title_not_unique'] = "Title already exists"
        return errors

class TVshow(models.Model):
    title = models.CharField(max_length=255)
    network = models.CharField(max_length=255)
    release_date = models.DateField()
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = TVshowManager()


# Create your models here.

