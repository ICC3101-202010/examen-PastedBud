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
        public Partido(Equipo equipo1, Equipo equipo2, DateTime time)
        {
            
            if (equipo1.Nacional == equipo2.Nacional)
            {
                this.equipo_local = equipo1;
                this.equipos.Add(equipo1);
                this.equipo_visita = equipo2;
                this.equipos.Add(equipo2);
                this.Minutos = time;
                this.Resultado.Add(0);
                this.Resultado.Add(0);
                if (equipo1.Nacional == true)
                {
                    this.Nacional = true;
                }
                else
                {
                    this.Nacional = false;
                }
            }
            else
            {
                Console.WriteLine("Este Partido No se puede Jugar debido a que Mezcla Equipos de Liga y Nacionales");
            }
        }

        public DateTime Minutos { get => minutos; set => minutos = value; }
        public List<int> Resultado { get => resultado; set => resultado = value; }
        public bool Nacional { get => nacional; set => nacional = value; }

        public void Simular()
        {
            Console.WriteLine("Simulación No Implementada");
        }


        public static void OnPlayerCalledInjured(object source, JugadorEventArgs e)
        {
            Console.WriteLine("El Jugador " + e.Jugador.Nombre + "se ha Lesionado!");
            Console.WriteLine("Su Entrenador llama a un Cambio");
        }
    }
}
