using System;
namespace examenPastedBud
{
    public class Entrenador : Persona, Entrenadores
    {
        private int puntos_tactica;

        public Entrenador()
        {
        }

        public int Puntos_tactica { get => puntos_tactica; set => puntos_tactica = value; }

        public void Cambiar_Jugador(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1.EnCancha == true && jugador2.EnCancha == false)
            {
                jugador1.EnCancha = false;
                jugador2.EnCancha = true;
            }
            else if (jugador2.EnCancha == true && jugador1.EnCancha == false)
            {
                jugador2.EnCancha = false;
                jugador1.EnCancha = true;
            }
            else
            {
                Console.WriteLine("No Puedes Hacer Este Cambio!");
            }
            
        }

        public override void InfoPersona(Equipo equipo)
        {
            Console.WriteLine("El Entrenador: " + equipo.Entrenador[0].Nombre);
            Console.WriteLine("Edad: " + equipo.Entrenador[0].Edad);
            Console.WriteLine("De Nacionalidad " + equipo.Entrenador[0].Nación);
            Console.WriteLine("Con Sueldo: " + equipo.Entrenador[0].Sueldo);
            Console.WriteLine("Puntos Tactica: " + equipo.Entrenador[0].Puntos_tactica);
        }
    }
}
