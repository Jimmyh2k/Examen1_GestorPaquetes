using Examen1_GestorPaquetes.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1_GestorPaquetes.DA
{
    public class ContextoBD: DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        public ContextoBD(DbContextOptions<ContextoBD> opcion) : base(opcion)
        {

        }
    }
}
