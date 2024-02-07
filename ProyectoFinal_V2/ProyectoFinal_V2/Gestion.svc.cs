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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Gestion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Gestion.svc o Gestion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Gestion : IGestion
    {
        static GestionTOTAL gestionTotal = new GestionTOTAL();
        public void añadirJugador(Jugador jugador)
        {
            gestionTotal.anadirJugador(jugador);
        }

        public void bajaJugador(Jugador jugador)
        {
            gestionTotal.bajaJugador(jugador);
        }
        public void añadirEquipo(Equipo equipo)
        {
            gestionTotal.anadirEquipo(equipo);
        }
        public void bajaEquipo(Equipo equipo)
        {
            gestionTotal.bajaEquipo(equipo);
        }
        public async Task<string> hacerJsonJugadores()
        {
            return await gestionTotal.hacerJsonJugadores();
        }
        public async Task<string> hacerJsonEquipos()
        {
            return await gestionTotal.hacerJsonEquipos();
        }
        public void recuperarDatos()
        {
            gestionTotal.recuperarDatos();
        }

        public void recuperarDatosEquipos()
        {
            gestionTotal.recuperarDatosEquipos();
        }
    }
}
