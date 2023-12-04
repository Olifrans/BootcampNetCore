Vamos criar um projeto via linha de comando e abrir no VS Code
Abra o console e rode o comando abaixo:

dotnet new mvc -n WebAppTeste




Bootcamp Udemy:
Primeiro vamos criar uma nova “solution” via linha de comando.

dotnet new sln
mkdir Data
dotnet new console

dotnet sln add Data/Data.csproj

dotnet new gitignore




https://www.nuget.org/packages?q=entity

dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0

dotnet add package Microsoft.Data.SqlClient --version 5.2.0-preview3.23201.1






Chave estrangeira da tabela Curso
ALTER TABLE Preco
ADD CONSTRAINT FK_Preco_Curso
FOREIGN KEY (CursoId)
REFERENCES Curso(CursoId);

















dotnet new sln -o ProdutosApi
Depois criaremos o projeto

dotnet new web -o ProdutosApi
Agora vamos inserir o projeto na nossa “solution”

dotnet sln ProdutosApi/ProdutosApi.sln add ProdutosApi/ProdutosApi.csproj
Pronto, agora é só usar o VSCode para fazermos a programação, só para
Abra um terminal como demonstrado na figura, e execute o comando

dotnet run


Mas vamos fazer algo mais pela API, inserindo o Swagger !

Para isto vamos adicionar o pacote nuget

dotnet add ProdutosApi.csproj package Swashbuckle.AspNetCore -v 6.2.3















dotnet new console --framework net8.0 --use-program-main


Criando o projeto
Com o comando dotnet new sln vamos criar uma nova solução, utilizamos o parâmetro -o "nome-do-diretório" para informar o diretório que será criado, caso não informe o parâmetro -o a solução será criada com o nome do diretório atual. Podemos utilizar também o parâmetro -n caso queira que a solução tenha um nome diferente do diretório atual.

dotnet new sln -o exemplo-dotnet-cli -n DotnetCli


Projeto classlib
Usamos o comando dotnet new classlib para cria uma biblioteca de classes, também vamos utilizar o parâmetro -o.

dotnet new classlib -o src/DotnetCli.Application



Projeto webapi
Com o comando dotnet new webapi vamos criar uma API Web.

dotnet new webapi -o src/DotnetCli.WebApi
Agora vamos utilizar o comando dotnet sln add para adicionar projetos a solution, podemos repetir o comando para todos os projetos ou utilizar o um comando para adicionar vários projetos a uma solução:

Adicionar um projeto por vez
dotnet sln add .\src\DotnetCli.Application\
Adicionar todos os projetos
Windows

dotnet sln add (ls -r **/*csproj)