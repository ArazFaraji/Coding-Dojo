"""dojo_reads URL Configuration

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
from apps.books_app import views as books

urlpatterns = [
    path('', views.home),
    path('register', views.register),
    path('home', views.success),
    path('login', views.login),
    path('destroy', views.destroy),
    path('books/add', books.book_form),
    path('add_book', books.add_book),
    # path('wall', books.wall),
    # path('post_message', books.post_message),
    # path('add_comment', books.add_comment),
    path('admin/', admin.site.urls),
]