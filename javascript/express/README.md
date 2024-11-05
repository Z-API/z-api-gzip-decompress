# Express.js

Este guia descreve como configurar, instalar dependências e rodar um projeto Node.js que utiliza o framework Express.

## Pré-requisitos

Node.js: Certifique-se de que o Node.js está instalado. Recomendamos a versão LTS mais recente.

## Passos para a configuração

### 1. Clonar o repositório (opcional)

### 2. Instalar Dependências

Navegue até a pasta do projeto e instale as dependências:

```bash
npm install
```

### 3. Rodar o servidor

Use o seguinte comando para iniciar o servidor Express:

```bash
npm start
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
