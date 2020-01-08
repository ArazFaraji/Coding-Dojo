from django.shortcuts import render, redirect
from apps.semi_restfull_app.models import TVshow, TVshowManager
from django.contrib import messages
from datetime import date

def home(request):
    return redirect('/shows')

def newShow(request):
    return render(request, 'semi_restfull_app/index.html')

def create(request):
    errors123 = TVshow.objects.basic_validator(request.POST)
    if len(errors123) > 0:
        for key,value in errors123.items():
            messages.error(request, value)
        return redirect('/shows/new')
    else:

        show = TVshow.objects.create(title = request.POST['title'], network = request.POST['network'], release_date = request.POST['release_date'], description = request.POST['description'])

        return redirect('/shows/' + str(show.id))

def allShows(request):
    context = {
        'shows': TVshow.objects.all()
    }
    return render(request, 'semi_restfull_app/allshows.html', context)

def show(request, showID):
    context = {
        "tvshow": TVshow.objects.get(id=showID),
    }
    # print(TVshow.objects.get(id=showID).release_date)
    # print(date.today())
    return render(request, 'semi_restfull_app/show.html', context)

def edit(request, showID):
    context = {
        "show": TVshow.objects.get(id=showID),
    }
    return render(request, 'semi_restfull_app/edit.html', context)

def update(request, showID):
    errors123 = TVshow.objects.basic_validator(request.POST)
    if len(errors123) > 0:
        for key,value in errors123.items():
            messages.error(request, value)
        return redirect('/shows/' + showID + "/edit")
    else:
        show = TVshow.objects.get(id=showID)
        show.title = request.POST['title']
        show.network = request.POST['network']
        show.release_date = request.POST['release_date']
        show.description = request.POST['description']
        show.save()
        return redirect('/shows/' + showID)

def destroy(request, showID):
    show = TVshow.objects.get(id=showID)
    show.delete()
    return redirect('/shows')