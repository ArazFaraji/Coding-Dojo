# Generated by Django 2.2.7 on 2019-11-18 15:54

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('login_register_app', '0005_auto_20191118_1446'),
        ('travel_app', '0003_remove_trip_creator'),
    ]

    operations = [
        migrations.AddField(
            model_name='trip',
            name='creator',
            field=models.ForeignKey(default=0, on_delete=django.db.models.deletion.CASCADE, related_name='creator', to='login_register_app.User'),
            preserve_default=False,
        ),
    ]