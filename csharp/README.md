# C# (.NET)

Este guia descreve como configurar, compilar e executar o projeto em C# com o .NET SDK.

## Pré-requisitos

.NET SDK: Certifique-se de que o .NET SDK está instalado. Recomendamos a versão mais recente compatível com o projeto.

## Passos para a configuração

### 1. Clonar o repositório (opcional)

### 2. Restaurar dependências

Entre na pasta do projeto e execute o comando:

```bash
dotnet restore
```

### 3. Compilar o projeto

Use o seguinte comando para compilar o projeto:

```bash
dotnet build
```

4. Executar o projeto

```bash
dotnet run
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
