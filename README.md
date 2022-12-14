# CRM2-MVC

CRM2-MVC é uma API Web MVC que permite o cadastro de novas leads, cursos e a matrículas.

As leads são pessoas que possam se interessar pelos cursos ofertados;
Os cursos realmentão são cursos :neutral_face:;
E as matrículas são as relações pessoa-curso;


## Funções

- [x] Criar novas leads (candidatos); /

- [x] Criar novos cursos;/

- [x] Fazer novas matrículas. Cada aluno pode ter vários cursos./



## Configurações Iniciais e uso
- Após clonar o repositório, o primeiro passo é configurar a string de conexão com o banco de dados no arquivo appsettings -> ConnectionStrings.DataBase.
Lá há um exemplo de string de conexão que deve ser utilizado para conectar ao sqlserver.

- Em seguida basta rodar o comando
```
dotnet restore
```
ou equivalente para instalar as dependências.

- Gerar as migrations e o banco de dados que será utilizado pelo aplicativo, com os comandos:
```
para o Visual Studio:
add-migration NomeDaMigration

para o terminal:
dotnet ef migrations add NomeDaMigration
```
Seguido do comando:
```
para o Visual Studio:
Update-Database

para o terminal:
dotnet ef database update
```

- Agora basta rodar o comando
```
dotnet run
```
ou executar o programa manualmente e o ver rodando no seu localhost


## Future implementations

1. Adicionar docker para o app e para o banco de dados;
2. Finalizar crud;
3. Fazer validação online de cpf;

### Contatos!
- email: caio_swame@hotmail.com
- linkedin: [caio-s-s-paulino](https://www.linkedin.com/in/caio-s-s-paulino/)

\
\
Desejo tudo de bom!
