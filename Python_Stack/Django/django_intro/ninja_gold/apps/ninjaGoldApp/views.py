from django.shortcuts import render, redirect
import random
import datetime

def home(request):
    if 'gold' not in request.session:
        request.session['gold'] = 0
    return render(request, 'ninjaGoldApp/index.html')

def clear(request):
    del request.session['gold']
    if 'activity_list' in request.session:
        del request.session['activity_list']
    return redirect("/")
# Create your views here.
def process(request):
    if 'activity_list' not in request.session:
        request.session['activity_list'] = []
    farmGold = random.randint(10,20)
    caveGold = random.randint(5,10)
    houseGold = random.randint(2,5)
    casinoGold = random.randint(-50,50)
    if request.method == "POST":
        if request.POST['which_form'] == 'farm':
            request.session['gold'] += farmGold
            request.session['activity_list'].append(f"Earned {farmGold} gold from the farm! {datetime.datetime.now()}")
            print(request.session['activity_list'])
        if request.POST['which_form'] == 'cave':
            request.session['gold'] += caveGold
            request.session['activity_list'].append(f"Earned {caveGold} gold from the cave! {datetime.datetime.now()}")
        if request.POST['which_form'] == 'house':
            request.session['gold'] += houseGold
            request.session['activity_list'].append(f"Earned {houseGold} gold from the house! {datetime.datetime.now()}")
        if request.POST['which_form'] == 'casino':
            request.session['gold'] += casinoGold
            if casinoGold > 0:   
                request.session['activity_list'].append(f"Earned {casinoGold} gold from the casino! {datetime.datetime.now()}")
            if casinoGold < 0: 
                request.session['activity_list'].append(f"Lost {casinoGold} gold from the casino! {datetime.datetime.now()}")
        return redirect('/')
