using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_V2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGestion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGestion
    {
        [OperationContract]
        void añadirJugador(Jugador jugador);

        [OperationContract]
        void bajaJugador(Jugador jugador);


        [OperationContract]
        void añadirEquipo(Equipo equipo);

        [OperationContract]
        void bajaEquipo(Equipo equipo);

        [OperationContract]
        Task<string> hacerJsonJugadores();

        [OperationContract]
        Task<string> hacerJsonEquipos();

        [OperationContract]
        void recuperarDatos();

        [OperationContract]
        void recuperarDatosEquipos();
    }
}
