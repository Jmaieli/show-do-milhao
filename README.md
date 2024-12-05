# Show do Milhão - Sistema de Quiz em C#

Este é um projeto de um sistema de quiz inspirado no programa de TV *Show do Milhão*, desenvolvido com **C#**, **ASP.NET MVC**, **Entity Framework** e **SQL Server**. O jogo permite que os usuários participem de um quiz de perguntas e respostas, seguindo o formato do programa.

## Funcionalidades

- **Sistema de Login**: Permite que os jogadores se registrem e façam login para participar do jogo.
- **Sistema de Pontuação**: O jogador acumula pontos conforme avança nas rodadas e acerta as respostas.
- **Ajuda**: Implementação de ajudas como "Pular Pergunta", "50-50", "Chave de Resposta" etc.
- **Base de Dados**: Utiliza o **Entity Framework** para a persistência das informações (usuários, perguntas, respostas).

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal.
- **ASP.NET MVC**: Framework para a construção do aplicativo web.
- **Entity Framework**: ORM para interagir com o banco de dados.
- **SQL Server**: Banco de dados relacional para armazenar dados dos usuários, perguntas e respostas.
- **HTML, CSS, JavaScript**: Para a construção da interface de usuário (frontend).

## Como Rodar o Projeto

### Pré-requisitos

Antes de rodar o projeto, certifique-se de que você tem os seguintes pré-requisitos instalados:

- **.NET SDK**: Versão [x.x.x] do .NET SDK.
- **SQL Server**: Você pode usar o SQL Server local ou uma instância do SQL Server na nuvem.
- **Visual Studio**: A IDE recomendada para trabalhar com projetos ASP.NET MVC.

### Passos para rodar o projeto

1. **Clone o repositório**:

    ```bash
    git clone https://github.com/Jmaieli/show-do-milhao.git
    ```

2. **Abra o projeto no Visual Studio**.

3. **Configuração do Banco de Dados**:

    - Crie um banco de dados no SQL Server e configure a string de conexão no arquivo `appsettings.json`:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=ShowDoMilhaoDb;Trusted_Connection=True;"
      }
    }
    ```

    - Execute as migrations do Entity Framework para criar as tabelas no banco de dados:

    ```bash
    dotnet ef database update
    ```

4. **Rodando o servidor**:

    No Visual Studio, basta clicar em "Iniciar" ou usar o comando:

    ```bash
    dotnet run
    ```

5. Abra seu navegador e acesse:

    ```
    http://localhost:5000
    ```

    Agora você pode jogar o **Show do Milhão**!

## Estrutura do Projeto

- **Controllers**: Contém a lógica de controle para cada página do jogo (LoginController, QuizController, etc.).
- **Models**: Contém as classes que representam as entidades do banco de dados (User, Question, Answer, etc.).
- **Views**: Contém as páginas HTML do frontend (Login, Quiz, Resultados, etc.).
- **Data**: Configuração do Entity Framework e migrações.

## Contribuindo

1. Faça um fork deste repositório.
2. Crie uma branch para a sua funcionalidade (`git checkout -b feature/nova-funcionalidade`).
3. Commit suas mudanças (`git commit -am 'Adiciona nova funcionalidade'`).
4. Envie para a branch (`git push origin feature/nova-funcionalidade`).
5. Crie um Pull Request.

## Licença

Distribuído sob a licença MIT. Veja o arquivo `LICENSE` para mais informações.

## Agradecimentos

- Agradecimentos à [Comunidade .NET](https://dotnet.microsoft.com) e aos tutoriais de ASP.NET MVC e Entity Framework para as referências e ajuda durante o desenvolvimento deste projeto.

