import gzip
from io import BytesIO
from django.http import JsonResponse
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def decompress_gzip_webhook(request):
    if request.method == 'POST':
        try:
            compressed_data = BytesIO(request.body)
            
            with gzip.GzipFile(fileobj=compressed_data, mode='rb') as f:
                decompressed_data = f.read().decode('utf-8')

            print("Decompressed data: ", decompressed_data)
            return JsonResponse({'message': 'Handled webhook successfully'})
        
        except Exception as e:
            return JsonResponse({
                'error': 'Failed on decompress webhook data', 
                'details': str(e)
            }, status=500)
        
    return JsonResponse({'error': 'Method not allowed'}, status=405)