using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key] // identificacao para BD 
        [Required]// identificacao para BD
        public int Id { get; set; }
        [Required (ErrorMessage = "O campo Titulo e obrigatorio")] // torna campo obrigatorio e retorna 400 bad request caso esteja vazio
        public string Titulo { get; set; }
        [Required (ErrorMessage = "O campo Diretor e obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo Genero deve ter no maximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duracao deve ter no minimo 1 e no maximo 600 min")]
        public int Duracao { get; set; }
    }
}
