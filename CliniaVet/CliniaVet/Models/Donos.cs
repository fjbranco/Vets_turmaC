﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CliniaVet.Models
{
    public class Donos
    {
        public Donos()
        {
            // inicializar a lista de animais associados a um "dono"
            ListaDeAnimais = new HashSet<Animais>();
        }
        
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }

        // Lista dos animais que o Dono tem
        public ICollection<Animais> ListaDeAnimais { get; set; }

    }
}
