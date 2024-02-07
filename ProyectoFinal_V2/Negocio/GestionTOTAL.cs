using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Negocio
{
    public class GestionTOTAL
    {
        List<Equipo> equipoList = new List<Equipo>();
        List<Jugador> jugadorList = new List<Jugador>();
        public void anadirJugador(Jugador jugador) {
            int indice = -1;
            bool añadir = false;
            for (int i = 0; i < equipoList.Count; i++)
            {
                if(jugador.Equipo.Equals(equipoList[i].Nombre))
                {
                    if (equipoList[i].JugadorList.Count == 0)
                    {
                        indice = i;
                        añadir = true;
                    }
                    else{
                        for (int j = 0; j < equipoList[i].JugadorList.Count; j++)
                        {
                            if (jugador.Dorsal == (equipoList[i].JugadorList[j].Dorsal))
                            {
                                
                            }
                            else
                            {
                                indice = i;
                                añadir = true;
                            }
                        }
                    }
                }
                else { }
            }
            if(añadir == true)
            {
                equipoList[indice].JugadorList.Add(jugador);
                jugadorList.Add(jugador);
            }
        }
        public void bajaJugador(Jugador jugador)
        {
            for (int i = 0; i < jugadorList.Count; i++)
            {
                if (jugador.Nombre == jugadorList[i].Nombre && jugador.Apellido == jugadorList[i].Apellido && jugador.Dorsal == jugadorList[i].Dorsal)
                {
                    jugadorList.RemoveAt(i);
                }
            }
        }
        public void anadirEquipo(Equipo equipo)
        {
            bool añadir = true;
            for(int i = 0; i < equipoList.Count; i++)
            {
                if (equipoList[i].Nombre == equipo.Nombre)
                {
                    añadir = false;
                }

            }
            if(añadir == true)
            {
                equipoList.Add(equipo);
            }
        }
        public void bajaEquipo(Equipo equipo)
        {
            for (int i = 0; i < equipoList.Count; i++) {
                if (equipoList[i].Nombre == equipo.Nombre && equipoList[i].Ciudad == equipo.Ciudad && equipoList[i].ColorLocal == equipo.ColorLocal && equipoList[i].ColorVisitante == equipo.ColorVisitante) { 
                    equipoList.RemoveAt(i);
                }
            }
        }
        public async Task<string> hacerJsonJugadores()
        {
            await Task.Delay(1000);
            string cadena = "";
            int indice = jugadorList.Count;
            for(int i = 0; i < jugadorList.Count; i++)
            {
                string json = JsonConvert.SerializeObject(jugadorList[i], Formatting.None);
                if (i == indice-1)
                {
                    cadena += json;
                }
                else
                {
                    cadena += json + "\n";
                }
            }
            try
            {
                //En este txt, se deberia cambiar la ruta de acceso al escritorio de cada uno
                //Se podria poner de manera mas generica como C:\ para que se quedara en todos los casos ahi
                //pero de esta manera se ve de una forma más bonita en el escritorio
                StreamWriter sw = new StreamWriter("C:\\Users\\ivans\\Desktop\\TestJsonJugador.txt");
                sw.WriteLine(cadena); 
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return cadena;
        }
        public async Task<string> hacerJsonEquipos()
        {
            await Task.Delay(1000);
            string cadena = "";
            int indice = equipoList.Count;
            for (int i = 0; i < equipoList.Count; i++)
            {
                string json = JsonConvert.SerializeObject(equipoList[i], Formatting.None);
                if (i == indice - 1)
                {
                    cadena += json;
                }
                else
                {
                    cadena += json + "\n";
                }
            }
            try
            {
                await Task.Delay(1000);
                //En este txt, se deberia cambiar la ruta de acceso al escritorio de cada uno
                //Se podria poner de manera mas generica como C:\ para que se quedara en todos los casos ahi
                //pero de esta manera se ve de una forma más bonita en el escritorio
                StreamWriter sw = new StreamWriter("C:\\Users\\ivans\\Desktop\\TestJsonEquipo.txt");
                sw.WriteLine(cadena);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return cadena;
        }
        public void recuperarDatos()
        {
            jugadorList.Clear();
            //En este txt, se deberia cambiar la ruta de acceso al escritorio de cada uno
            //Se podria poner de manera mas generica como C:\ para que se quedara en todos los casos ahi
            //pero de esta manera se ve de una forma más bonita en el escritorio
            foreach (string line in System.IO.File.ReadLines("C:\\Users\\ivans\\Desktop\\TestJsonJugador.txt"))
            {
                string json = line;
                Jugador person = JsonConvert.DeserializeObject<Jugador>(json);
                string nombre = person.Nombre;
                string apellido = person.Apellido;
                string equipo = person.Equipo;
                int dorsal = person.Dorsal;
                int edad = person.Edad;
                Jugador jugador = new Jugador(nombre,apellido,equipo,dorsal,edad);
                anadirJugador(jugador);
            }
        }
        public void recuperarDatosEquipos()
        {
            equipoList.Clear();
            //En este txt, se deberia cambiar la ruta de acceso al escritorio de cada uno
            //Se podria poner de manera mas generica como C:\ para que se quedara en todos los casos ahi
            //pero de esta manera se ve de una forma más bonita en el escritorio
            foreach (string line in System.IO.File.ReadLines("C:\\Users\\ivans\\Desktop\\TestJsonEquipo.txt"))
            {
                string json = line;
                Equipo equipoLinea = JsonConvert.DeserializeObject<Equipo>(json);
                string nombre = equipoLinea.Nombre;
                string ciudad = equipoLinea.Ciudad;
                string colorLocal = equipoLinea.ColorLocal;
                string colorVisitante = equipoLinea.ColorVisitante;
                List<Jugador> lista = equipoLinea.JugadorList;
                Equipo equipo = new Equipo(nombre, ciudad, colorLocal, colorVisitante, lista);
                anadirEquipo(equipo);
            }
        }
    }
}