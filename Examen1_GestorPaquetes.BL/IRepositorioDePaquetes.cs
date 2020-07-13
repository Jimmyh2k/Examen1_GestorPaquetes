using Examen1_GestorPaquetes.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1_GestorPaquetes.BL
{
    public interface IRepositorioDePaquetes
    {
        public List<Persona> ObtenerTodasLasPersonas();
        public void AgregarPersona(PersonaConFoto persona);
    }
}
