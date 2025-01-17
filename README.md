# ServerVideoAPI

Este projeto é uma API para gerenciar servidores e realizar upload de vídeos para os mesmos. Ele foi desenvolvido utilizando .NET 8 e PostgreSQL, seguindo boas práticas de arquitetura e organização de código.

## 🚀 Funcionalidades
- **Servidores**
  - Adicionar servidores.
  - Listar todos os servidores.
- **Vídeos**
  - Fazer upload de vídeos para um servidor.
  - Listar os vídeos de um servidor específico.

## 🛠️ Tecnologias Utilizadas
- **.NET 8** - Framework para criação de APIs.
- **Entity Framework Core**.
- **PostgreSQL** - Banco de dados relacional.
- **Swagger** - Para documentação e testes dos endpoints.

## 📂 Estrutura do Projeto
- **Entity**: Contém as classes principais (Server e Video).
- **DTOs**: Classes para transferir dados entre camadas.
- **Infra**: Configuração do banco de dados.
- **Controllers**: Implementação dos endpoints.
