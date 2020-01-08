"""travel URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/2.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path
from apps.login_register_app import views
from apps.travel_app import views as trip


urlpatterns = [
    path('', views.home),
    path('register', views.register),
    path('login', views.login),
    path('destroy', views.destroy),
    path('travels', trip.travels),
    path('travels/add', trip.add_travels),
    path('add_trip', trip.add_trip),
    path('join/<tripID>', trip.join_trip),
    path('destination/<tripID>', trip.trip_info),
    path('admin/', admin.site.urls),
]
