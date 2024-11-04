from django.urls import path

from api import views

urlpatterns = [
    path('webhook', views.decompress_gzip_webhook, name='webhook'),
]
