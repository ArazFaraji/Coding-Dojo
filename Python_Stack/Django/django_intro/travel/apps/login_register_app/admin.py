from django.contrib import admin
from apps.login_register_app.models import User

class UserAdmin(admin.ModelAdmin):
    pass
admin.site.register(User, UserAdmin)
# Register your models here.
