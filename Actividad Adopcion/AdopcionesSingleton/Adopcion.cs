using System;
using System.Collections.Generic;
using System.Text;

namespace AdopcionesSingleton
{
    class Adopcion
    {
        public Persona PersonaAdopta { get; set; }
        public Perro PerroAdoptado { get; set; }
        public DateTime FechaAdopcion { get { return DateTime.Now; } }

         
    }
}
