using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    [DataContract]
    public class Equipo
    {
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Ciudad { get; set; }

        [DataMember]
        public string ColorLocal { get; set; }

        [DataMember]
        public string ColorVisitante { get; set; }

        [DataMember]
        public List<Jugador> JugadorList { get; set; }
        public Equipo(string nombre, string ciudad, string colorLocal, string colorVisitante, List<Jugador> jugadorList)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            ColorLocal = colorLocal;
            ColorVisitante = colorVisitante;
            JugadorList = jugadorList;
        }
    }
}
