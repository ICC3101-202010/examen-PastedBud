using System;
namespace examenPastedBud
{
    public class Medico : Persona, IMedicos
    {
        public int puntos_experiencia;

        public delegate void PlayerInjuredEventHandler(object source, JugadorEventArgs args);

        public event PlayerInjuredEventHandler PlayerInjured;

        protected virtual void OnPlayerInjured(Jugador jugador)
        {
            if (PlayerInjured != null)
            {

                PlayerInjured(this, new JugadorEventArgs() { Jugador = jugador });

            }
        }

        public Medico()
        {
        }

        public void Evaluar(Jugador jugador)
        {
            Partido partido = new Partido();

            if (jugador.Lesionado == true)
            {
                PlayerInjured += partido.OnPlayerInjured;
                OnPlayerInjured(jugador);
            }
            else
            {
                Console.WriteLine("Tu Jugador está Bien!");
            }
        }

        public void Curar(Jugador jugador)
        {
            if (jugador.Lesionado == true)
            {
                jugador.Lesionado = false;
            }
            else
            {
                Console.WriteLine("El Jugador que Quieres Curar NO tiene Ninguna Lesión!");
            }
        }

        public override void InfoPersona(Equipo equipo)
        {
            Console.WriteLine("El Medico" + equipo.Medico[0].Nombre);
            Console.WriteLine("Edad: " + equipo.Medico[0].Edad);
            Console.WriteLine("De Nacionalidad " + equipo.Medico[0].Nación);
            Console.WriteLine("Con Sueldo: " + equipo.Medico[0].Sueldo);
            Console.WriteLine("Puntos de Experiencia: " + equipo.Medico[0].puntos_experiencia);
        }

        
    }
}
