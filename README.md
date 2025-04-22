
# CRUD Simples em C# com ASP.NET

Este é um projeto simples de CRUD (Create, Read, Update, Delete) desenvolvido com **.NET 6**, **ASP.NET Core** e **C#**. O objetivo do projeto é explorar o funcionamento do ASP.NET e do Entity Framework, criando uma aplicação web que permita realizar operações básicas de CRUD para gerenciar dados de um modelo `Student` e `Subscription`, onde os alunos estão relacionados às suas inscrições.

## Tecnologias Utilizadas

- **C#**
- **.NET 6 (ou superior)**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Razor Pages**

## Funcionalidades

- **Student** (Aluno):
  - **Create**: Adicionar novos estudantes ao banco de dados.
  - **Read**: Visualizar uma lista de estudantes cadastrados.
  - **Update**: Editar as informações de um estudante.
  - **Delete**: Remover um estudante do banco de dados.

- **Subscription** (Inscrição):
  - **Create**: Associar uma inscrição a um estudante.
  - **Read**: Visualizar as inscrições de um estudante.
  - **Update**: Editar os dados de uma inscrição.
  - **Delete**: Remover uma inscrição de um estudante.

## Relacionamento

Este projeto implementa um relacionamento entre as entidades `Student` e `Subscription`, onde cada aluno pode ter várias inscrições.

## Pré-requisitos

- .NET SDK (versão 6 ou superior)
- SQL Server ou qualquer banco de dados compatível com Entity Framework Core
- Visual Studio ou outra IDE de sua preferência

## Instruções para Execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. Restaure os pacotes NuGet:

   ```bash
   dotnet restore
   ```

3. Crie o banco de dados (se necessário):

   ```bash
   dotnet ef database update
   ```

4. Execute a aplicação:

   ```bash
   dotnet run
   ```

5. Acesse o aplicativo em seu navegador: `https://localhost:5001`.

## Estrutura do Projeto

- **Pages/Students**: Contém as páginas Razor para visualização e edição dos estudantes.
- **Pages/Subscriptions**: Contém as páginas Razor para visualização e edição das inscrições dos estudantes.
- **Models/Student.cs**: Modelo que representa a entidade `Student`.
- **Models/Subscription.cs**: Modelo que representa a entidade `Subscription`.
- **Data/ApplicationDbContext.cs**: Contexto do Entity Framework que gerencia a conexão com o banco de dados e o relacionamento entre `Student` e `Subscription`.

## Contribuições

Se você deseja contribuir para o projeto, siga as etapas abaixo:

1. Faça um fork deste repositório.
2. Crie uma nova branch (`git checkout -b feature/nome-da-feature`).
3. Faça as alterações desejadas.
4. Envie um pull request.
