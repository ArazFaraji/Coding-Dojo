from django.contrib import admin
from apps.travel_app.models import Trip

class TripAdmin(admin.ModelAdmin):
    pass
admin.site.register(Trip, TripAdmin)
# Register your models here.
