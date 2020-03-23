using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CliniaVet.Models
{
    public class Consultas
    {
        [Key] // anotação que vai forçar este atributo a ser PK, mas não é obrigatório porque o atributo se chama ID
        public int ID { get; set; }
        
        public DateTime Data { get; set; }
        
        public string Observacoes { get; set; }

        // criar as FK
        [ForeignKey("Veterinario")]
        public int VeterinarioFK { get; set; }
        public Veterinarios Veterinario { get; set; }
        
        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }
    }
}
