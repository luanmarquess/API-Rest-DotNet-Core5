using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext // contato api e banco de dados
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt ) : base (opt) // Construtor do DbContext trata o parametro; 
        {

        }

        public DbSet<Filme> Filmes { get; set; } //Conjunto de dados do banco para acesso dos dados no banco

    }
}
