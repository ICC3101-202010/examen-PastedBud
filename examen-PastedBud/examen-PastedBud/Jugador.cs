using System;
namespace examenPastedBud
{
    public class Jugador : Persona
    {
        private int puntos_ataque;
        private int puntos_defensa;
        private int numero_camiseta;
        private bool arquero;
        private bool enCancha;
        private bool lesionado;

        public int Puntos_ataque { get => puntos_ataque; set => puntos_ataque = value; }
        public int Puntos_defensa { get => puntos_defensa; set => puntos_defensa = value; }
        public int Numero_camiseta { get => numero_camiseta; set => numero_camiseta = value; }
        public bool Arquero { get => arquero; set => arquero = value; }
        public bool EnCancha { get => enCancha; set => enCancha = value; }
        public bool Lesionado { get => lesionado; set => lesionado = value; }

        public Jugador()
        {
        }

        /*
        Finalmente, los jugadores se pueden lesionar, para esto, debe implementar la arquitectura necesaria
        para que un jugador avise a su entrenador que se lesionó, donde este notifica al partido y debe ejecutar un cambio.
        */

        public override void InfoPersona(Equipo equipo)
        {
            foreach (Jugador jugador in equipo.Jugadores)
            {
                Console.WriteLine(jugador.Nombre);
                if (jugador.Arquero == true)
                {
                    Console.WriteLine("Rol: Arquero");

                }
                else
                {
                    Console.WriteLine("Rol: Jugador");
                }
                Console.WriteLine("Edad: " + jugador.Edad);
                Console.WriteLine("De Nacionalidad " + jugador.Nación);
                Console.WriteLine("Con Sueldo: " + jugador.Sueldo);
                Console.WriteLine("Puntos de Ataque: " + jugador.Puntos_ataque);
                Console.WriteLine("Puntos de Defensa" + jugador.Puntos_defensa);
                Console.WriteLine("Numero de Camiseta: " + jugador.Numero_camiseta);
            }
        }
    }
}
