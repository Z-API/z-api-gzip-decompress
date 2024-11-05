# Python + Django

Este guia explica como configurar, instalar dependências e rodar um projeto Django com Python.

## Pré-requisitos

- Python: Certifique-se de que o Python está instalado.

- Pip: O gerenciador de pacotes Python. Ele geralmente já vem com o Python.

```bash
python3 --version
```

## Passos para a configuração

### 1. Clonar o repositório (opcional)

### 2. Criar um ambiente virtual:

Para isolar as dependências do projeto, crie um ambiente virtual:

```bash
python3 -m venv venv
```

Ative o ambiente virtual:

- No Windows

```bash
venv\Scripts\activate
```

- No macOS/Linux

```bash
source venv/bin/activate
```

### 3. Instalar dependências

Com o ambiente virtual ativado, instale as dependências listadas no arquivo `requirements.txt`:

```bash
pip install -r requirements.txt
```

4. Executar o Servidor

```bash
python manage.py runserver 3000
```

Depois de iniciar o servidor, o projeto geralmente está acessível no navegador em:

```plaintext
http://localhost:3000
```

## Recebendo webhooks

Após rodar a aplicação e verificar se o endereço acima está correto, basta configurar o seu webhook através do [painel do Z-API](https://developer.z-api.io/webhooks/introduction#via-painel) ou [via API](https://developer.z-api.io/webhooks/introduction#via-api).

O valor que deverá ser inserido no endereço do webhook é:

```plaintext
http://localhost:3000/webhook
```

Agora basta acionar um dos webhooks que você configurou anteriormente. Por exemplo: caso tenha configurado o webhook "Ao enviar", basta enviar uma mensagem através do seu número configurado que o webhook será acionado.

## Próximos passos

Agora que você entendeu como receber e como descomprimir os webhooks, você está pronto para fazer as alterações necessárias na sua aplicação.
