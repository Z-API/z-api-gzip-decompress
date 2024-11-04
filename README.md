## Como usar

Criamos esse repositório para auxiliá-los a descomprimir os dados dos webhooks do Z-API, que agora chegam no formato GZIP.

Antes de ir para o tutorial, é importante saber se seu webhook está chegando no formato GZIP. Para isso, verifique os headers da request da rota que lida com o webhook.

Caso possua o seguinte header: `'Content-Encoding': 'gzip'`, você precisará descomprimir os dados antes de conseguir trabalhar com eles.

Para facilitar, criamos aplicações em diversas linguagens para aproximar ao máximo da estrutura da sua aplicação, facilitando a sua implementação e economizando o seu tempo.

## Esse tutorial auxilia as seguintes aplicações

- Javascript
    - Express
- Java
    - Spring Boot
- Golang
    - Gin
- Python
    - Flask
    - Django
- C# + .NET
