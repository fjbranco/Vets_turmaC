﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CliniaVet.Models
{
    /// <summary>
    /// Esta classe apresenta a tabela animais
    /// </summary>
    public class Animais
    {
        public Animais()
        {
            ListaConsultas = new HashSet<Consultas>();
        }
        
        /// <summary>
        /// PK da tabela
        /// </summary>
        [Key]
        public int ID { set; get; }
        /// <summary>
        /// Nome do animal
        /// </summary>
        public string Nome { get; set; }
        
        /// <summary>
        /// Espécie do animal
        /// </summary>
        public string Especie { get; set; }
        /// <summary>
        /// Peso do animal
        /// </summary>
        public float Peso { get; set; }
        /// <summary>
        /// Raça do animal
        /// </summary>
        public string Raca { get; set; }
        /// <summary>
        /// Nome do ficheiro com a Foto do animal
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// FK para a tabela dos Donos
        /// </summary>
        [ForeignKey(nameof(Dono))]
        public int DonoFK { get; set; }
        public Donos Dono { get; set; }

        /// <summary>
        /// lista de consultas a que o animal foi levado pelo dono
        /// </summary>
        public ICollection<Consultas> ListaConsultas { get; set; }
    }
}
