using System;
using System.Collections.Generic;

namespace examenPastedBud
{
    public class Equipo
    {
        private string nombre;
        private bool nacional;
        private List<Jugador> jugadores = new List<Jugador>();
        private List<Entrenador> entrenador = new List<Entrenador>();
        private List<Medico> medico = new List<Medico>();



        public Equipo()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Nacional { get => nacional; set => nacional = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public List<Entrenador> Entrenador { get => entrenador; set => entrenador = value; }
        public List<Medico> Medico { get => medico; set => medico = value; }

        public bool Corroborar_Nacionalidad(Equipo equipo)
        {
            bool result = true;
            if (equipo.nacional == true)
            {
                
                foreach (Jugador jugador in equipo.jugadores)
                {
                    foreach (Jugador jugador1 in equipo.jugadores)
                    {
                        if (jugador.Nación == jugador1.Nación)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    
                }
                
            }
            return result;

        }


        public void Info_Equipo(Equipo equipo)
        {
            if (equipo.Nacional == true)
            {
                Console.WriteLine("El Equipo " + equipo.Nombre + "es Nacional");
            }
            else
            {
                Console.WriteLine("El Equipo " + equipo.Nombre + "es de Liga");
            }
            Console.WriteLine("");
            Console.WriteLine(" Se Conforma por:");
            Console.WriteLine("");

            //Entrenador
            Entrenador entrenador = new Entrenador();
            entrenador.InfoPersona(equipo);

            Console.WriteLine("");
            Console.WriteLine("");

            //Medico
            Medico medico = new Medico();
            medico.InfoPersona(equipo);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Los Jugadores");
            Console.WriteLine("");

            //Jugador
            Jugador jugador = new Jugador();
            jugador.InfoPersona(equipo);
        }
    }
}
