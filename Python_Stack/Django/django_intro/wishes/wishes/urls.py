"""wishes URL Configuration

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
from apps.wish_app import views as wish

urlpatterns = [
    path('', views.home),
    path('register', views.register),
    path('success', views.success),
    path('login', views.login),
    path('destroy', views.destroy),
    path('wishes', wish.wishes),
    path('wishes/new',wish.new_wish),
    path('add_wish', wish.add_wish),
    path('remove_wish/<wishID>', wish.remove_wish),
    path('edit/<wishID>', wish.edit_wish),
    path('change_wish/<wishID>', wish.change_wish),
    path('granted/<wishID>', wish.granted),
    # path('wall', wall_views.wall),
    # path('post_message', wall_views.post_message),
    # path('add_comment', wall_views.add_comment),
    path('admin/', admin.site.urls),
]
