# Java + Spring Boot

Este guia fornece instruções sobre como configurar, compilar e executar um projeto Java com Spring Boot.

## Pré-requisitos

-   Java Development Kit (JDK): Certifique-se de que o JDK está instalado. Você pode verificar a instalação usando o comando:

```bash
java -version
```

-   Apache Maven: Instale o Maven para gerenciar as dependências do projeto.

## Passos para a configuração

### 1. Clonar o repositório (opcional)

### 2. Verificar o arquivo pom.xml

Certifique-se de que o arquivo `pom.xml` está presente. Ele contém as dependências necessárias para o projeto.

### 3. Compilar o projeto

Execute o seguinte comando para compilar o projeto

```bash
mvn clean install
```

### 4. Iniciar o servidor

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
