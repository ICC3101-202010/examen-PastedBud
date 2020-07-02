using System;
using System.Collections.Generic;

namespace examenPastedBud
{
    public class Partido
    {
        private DateTime minutos;
        private List<int> resultado = new List<int>();
        private bool nacional;
        public List<Equipo> equipos = new List<Equipo>();
        public Equipo equipo_local;
        public Equipo equipo_visita;
        public Partido()
        {
        }

        public DateTime Minutos { get => minutos; set => minutos = value; }
        public List<int> Resultado { get => resultado; set => resultado = value; }
        public bool Nacional { get => nacional; set => nacional = value; }


        public void OnPlayerInjured(object source, JugadorEventArgs e)
        {
            Console.WriteLine("El Jugador " +e.Jugador.Nombre + "se ha Lesionado!");

        }
    }
}
