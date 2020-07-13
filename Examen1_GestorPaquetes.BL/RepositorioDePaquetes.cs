using System;
using System.Collections.Generic;
using System.Text;
using Examen1_GestorPaquetes.DA;
using System.Linq;
using System.Threading.Tasks;
using Examen1_GestorPaquetes.Model;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Examen1_GestorPaquetes.BL
{
    public class RepositorioDePaquetes: IRepositorioDePaquetes
    {
        private ContextoBD ElContexto;

        public RepositorioDePaquetes(ContextoBD contexto)
        {
            ElContexto= contexto;
        }

        public List<Persona> ObtenerTodasLasPersonas()
        {
            List<Persona> Lalista;
            Lalista = ElContexto.Persona.ToList();
            return Lalista;
        }

        public void AgregarPersona(PersonaConFoto personaFoto)
        {
            Persona persona = new Persona();
            persona.Identificacion = personaFoto.Identificacion;
            persona.Nombre = personaFoto.Nombre;
            persona.PrimerApellido = personaFoto.PrimerApellido;
            persona.SegundoApellido = personaFoto.SegundoApellido;
            //persona.Foto = GetByteArrayFromImage(personaFoto.Foto);

            ElContexto.Persona.Add(persona);
            ElContexto.SaveChanges();
        }

        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }

    }
}