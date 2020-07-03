using System;
using System.Collections.Generic;
using System.Threading;

namespace examenPastedBud
{
    public class Equipo
    {
        private string nombre;
        private bool nacional;
        private List<Jugador> jugadores = new List<Jugador>();
        private List<Entrenador> entrenadores = new List<Entrenador>();
        private List<Medico> medicos = new List<Medico>();



        public Equipo(string nombre, bool nacional, Jugador jugador1, Jugador jugador2, Jugador jugador3, Jugador jugador4, Jugador jugador5, Jugador jugador6, Jugador jugador7, Jugador jugador8, Jugador jugador9, Jugador jugador10, Jugador jugador11, Jugador jugador12, Jugador jugador13, Jugador jugador14, Jugador jugador15, Entrenador entrenador1, Medico medico1)
        {
            this.Nombre = nombre;
            this.Nacional = nacional;

            jugadores.Add(jugador1);
            jugadores.Add(jugador2);
            jugadores.Add(jugador3);
            jugadores.Add(jugador4);
            jugadores.Add(jugador5);
            jugadores.Add(jugador6);
            jugadores.Add(jugador7);
            jugadores.Add(jugador8);
            jugadores.Add(jugador9);
            jugadores.Add(jugador10);
            jugadores.Add(jugador11);
            jugadores.Add(jugador12);
            jugadores.Add(jugador13);
            jugadores.Add(jugador14);
            jugadores.Add(jugador15);

            Entrenadores.Add(entrenador1);

            Medicos.Add(medico1);

            if (this.Nacional == true)
            {
                if (Corroborar_Nacionalidad(this) == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Equipo Conformado Correctamente");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    this.Info_Equipo(this);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("El Equipo No pudo Conformarse por No tener a Todos los Jugadores de la misma Nacionalidad");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    
                    throw new System.InvalidOperationException("El Equipo No pudo Conformarse por No tener a Todos los Jugadores de la misma Nacionalidad");
                }
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Equipo Conformado Correctamente");
                Console.WriteLine("");
                Thread.Sleep(2000);
                this.Info_Equipo(this);
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Nacional { get => nacional; set => nacional = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public List<Entrenador> Entrenadores { get => entrenadores; set => entrenadores = value; }
        public List<Medico> Medicos { get => medicos; set => medicos = value; }

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
                Console.WriteLine("El Equipo " + equipo.Nombre + " es Nacional");
            }
            else
            {
                Console.WriteLine("El Equipo " + equipo.Nombre + " es de Liga");
            }
            Console.WriteLine("");
            Console.WriteLine("Se Conforma por: ");
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
