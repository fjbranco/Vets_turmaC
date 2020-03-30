using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CliniaVet.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            //iniciarliar a lista de consultas...
            Consultas = new HashSet<Consultas>();
        }
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="O Nome é de Preenchimento obrigatório!")]
        [StringLength(40,ErrorMessage ="O {0} só pode ter, no máximo, {1} caracteres!")]
        public string Nome { get; set; }
        [Required]
        public string NumCedulaProf { get; set; }
        [Required]
        public string Foto { get; set; }
        
        //lista de "consultas" a que o veterinário está associado
        public ICollection<Consultas> Consultas { get; set; }
    }
}
