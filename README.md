
# Sistema de Gerenciamento de Clientes e Produtos com Vendas

## Visão Geral

Este é um sistema de gerenciamento de clientes e produtos com funcionalidade de vendas, desenvolvido em Windows Forms utilizando C# na versão .NET 7.0. O sistema permite realizar operações CRUD (Criar, Ler, Atualizar, Deletar) em clientes e produtos, além de registrar vendas. O PostgreSQL (16.3) é utilizado como banco de dados configurado em um contâiner Docker e a biblioteca Npgsql é usada para a conexão com o banco.

## Funcionalidades

- **Gerenciamento de Clientes:** Adicionar, visualizar, editar e excluir clientes.

- **Gerenciamento de Produtos:** Adicionar, visualizar, editar e excluir produtos.

- **Registro de Vendas:** Realizar vendas utilizando os clientes e produtos cadastrados

## Tecnologias Utilizadas

- **Linguagem de Programação:** C#
- **Framework:** .NET 7.0
- **Interface de Usuário:** Windows Forms
- **Banco de Dados:** PostgreSQL
- **Gerenciamento de Banco de Dados:** Docker Desktop
- **Biblioteca de Conexão:** Npgsql

## Pré-requisitos

Antes de executar o projeto, certifique-se de ter o seguinte instalado:

- Docker Desktop
- PostgreSQL 16.3
- .NET 7.0 SDK
- Visual Studio 2022 (ou superior, posteriormente)

## Configuração do Ambiente de Desenvolvimento

### Configuração do Docker

  - Instale o [Docker Desktop](https://www.docker.com/products/docker-desktop/).
  - Crie um contâiner	Docker para o PostgreSQL:
  ```bash
  docker run --name my_postgres -e POSTGRES_PASSWORD=mysecretpassword -d -p 5432:5432 postgres:16.3
  ``` 
  - Verifique se o contâiner está em execução:
  ``` bash
  docker ps
  ```

### Configuração do Banco de Dados

  - Conecte-se ao banco de dados PostgreSQL utilizando de um cliente como pgAdmin ou DBeaver.
  - Crie um banco de dados com o nome desejado.
  - Não é necessário rodar mais nenhum script, pois o sistema já possui uma configuração de `migração` que já cria automaticamente as tabelas utilizadas.

### Configuração do projeto

  - Clone o repositório do projeto:
  ``` bash
  git clone https://github.com/enzolozano/teste-demaria-software.git
  ```
  - Abra o projeto no Visual Studio 2022.
  - Configure a string de conexão no arquivo `App.config`:
  ``` bash
  <add key="ConnectionString" value="Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=senha"/>
  ```
  - Recompile o projeto (Em caso de erro, restaure os pacotes NuGet e recompile novamente).

## Estrutura do Projeto
  - **Data:** Contém o arquivo principal de comunicação com o banco de dados.
  - **Entities:** Contém os objetos representante das tabelas presentes no banco de dados.
  - **Exceptions:** Contém os objetos de `Exceptions` customizadas.
  - **Helpers:** Contém classes que possuem métodos úteis para formatação de tipos de variáveis e classes.
  - **Mappers:** Contém as classes usadas para transformar os dados de um formato para outro, mapeando atributos de um objeto para outro objeto.
  - **Migrations:** Classes geradas automaticamente com o objetivo de automatizar a inserção das tabelas no banco de dados.
  - **Models:** Contém as classes que representar requisições e respostas das entidades do sistema.
  - **Repositories:** Contém as classes responsáveis pela interação com o banco de dados.
  - **Resources:** Contém os arquivos externos (imagens) usados no sistema.
  - **Services:** Contém a lógica de negócios do sistema.
  - **Views:** Contém os formulários do Windows Forms.

## Contato
Em caso de dúvida sobre o funcionamento do sistema, entrar em contato pelo e-mail: `enzo.malozano@gmail.com`.


