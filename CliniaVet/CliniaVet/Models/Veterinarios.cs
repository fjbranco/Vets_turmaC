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
        public string Nome { get; set; }
        public string NumCedulaProf { get; set; }
        public string Foto { get; set; }
        
        //lista de "consultas" a que p veterinário está associado
        public ICollection<Consultas> Consultas { get; set; }
    }
}
