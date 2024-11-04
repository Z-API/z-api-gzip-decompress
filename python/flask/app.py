from flask import Flask, request, jsonify
import gzip
from io import BytesIO

app = Flask(__name__)

@app.route('/webhook', methods=['POST'])
def receive_webhook():
    try:
        compressed_data = BytesIO(request.data)
        with gzip.GzipFile(fileobj=compressed_data, mode='rb') as f:
            decompressed_data = f.read().decode('utf-8')
            
        print("Decompressed data:", decompressed_data)
        return jsonify({'message': 'Handled webhook successfully'})
    
    except Exception as e:
        return jsonify({ 
            'error': 'Failed on decompress webhook data', 
            'details': str(e)
        }), 500

if __name__ == '__main__':
    app.run(port=3000)
