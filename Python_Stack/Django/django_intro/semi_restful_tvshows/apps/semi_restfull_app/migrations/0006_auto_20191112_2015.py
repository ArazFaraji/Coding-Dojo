# Generated by Django 2.2.7 on 2019-11-12 20:15

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('semi_restfull_app', '0005_auto_20191112_2012'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tvshow',
            name='title',
            field=models.CharField(max_length=255),
        ),
    ]
