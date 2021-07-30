# API Rest DotNet Core5
- Criar controller;
- Declarar e utilizar anotacoes;
- Como receber requisicoes GET, POST, PUT, DELETE;
- Persistir dados em um banco com DbContext;
- Modelar um objeto para o BD;
- [Key] campo primario de identificacao;
- Retornar informações nao armazenadas no banco em tempo de execução.

## Connection
- Console Gerenciador de Pacotes
    - Add-Migration NOME DA MIGRACAO "cria automaticamente o arquivo com as tabelas";
    - Update-Database "migra as tabelas para o bando de dados".

##  Workbench
- use filmedb;
- show tables;
- desc filmes; "exibe a tabela filmes";
- select * from filmes.

## Pacotes NuGet
- Microsoft.EntityFrameworkCore;
- Microsoft.EntityFrameworkCore.Tools;
- Mysql.EntityFrameworkCore;
- AutoMapper.Extensions.Microsoft.DependencyInjection 8.1.1.
