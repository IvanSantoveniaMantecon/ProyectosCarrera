using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    [DataContract]
    public class Jugador
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }

        [DataMember]
        public string Equipo { get; set; }

        [DataMember]
        public int Dorsal { get; set; }

        [DataMember]
        public int Edad { get; set; }

        public Jugador(string nombre, string apellido, string equipo, int dorsal, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Equipo = equipo;
            Dorsal = dorsal;
            Edad = edad;
        }
    }
}
