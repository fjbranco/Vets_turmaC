using CliniaVet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliniaVet.Data
{
    /// <summary>
    /// Vai representar a DB do nosso sistema (Clinica Veterinária)
    /// à custa de um ORM - Entity Framework Core
    /// </summary>
    public class VetsDB : DbContext
    {
        /// <summary>
        /// construtor que define e configuta a Base de Dados
        /// </summary>
        /// <param name="options">parâmetros de configuração</param>
        public VetsDB(DbContextOptions<VetsDB> options) : base(options) { }

        // adicionar as "tabelas" à Base de Dados
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Donos> Donos { get; set; }
        public DbSet<Veterinarios> Veterinarios { get; set; }
        public DbSet<Consultas> Consultas { get; set; }
    }
}
