using System;
namespace examenPastedBud
{
    public class Entrenador : Persona, IEntrenadores
    {
        private int puntos_tactica;

        public delegate void PlayerCalledInjuredEventHandler(object source, JugadorEventArgs args);

        public event PlayerCalledInjuredEventHandler PlayerCalledInjured;

        protected virtual void OnPlayerCalledInjured(Jugador jugador)
        {
            if (PlayerCalledInjured != null)
            {

                PlayerCalledInjured(this, new JugadorEventArgs() { Jugador = jugador });

            }
        }

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
            Console.WriteLine("El Entrenador: " + equipo.Entrenadores[0].Nombre);
            Console.WriteLine("Edad: " + equipo.Entrenadores[0].Edad);
            Console.WriteLine("De Nacionalidad " + equipo.Entrenadores[0].Nación);
            Console.WriteLine("Con Sueldo: " + equipo.Entrenadores[0].Sueldo);
            Console.WriteLine("Puntos Tactica: " + equipo.Entrenadores[0].Puntos_tactica);
        }

        public void OnPlayerInjured(object source, JugadorEventArgs e)
        {
            Console.WriteLine("El Jugador " + e.Jugador.Nombre + "le ha avisado a su Entrenador que se ha Lesionado!");
            PlayerCalledInjured += Partido.OnPlayerCalledInjured;
            OnPlayerCalledInjured(e.Jugador);
            //debido a que no es necesario simular y lo importante es solo la clase Equipo
            //Por conveniencia crearé una instancia de jugador para reemplazar al jugador lesionado
            // sin embargo en caso de necesitar implementar una simulación del programa basta elegir a un jugador en especifico del equipo para cambiarlo
            Jugador jugador_banca = new Jugador();
            jugador_banca.Arquero = false;
            jugador_banca.Edad = 21;
            jugador_banca.EnCancha = false;
            jugador_banca.Lesionado = false;
            jugador_banca.Nación = e.Jugador.Nación;
            jugador_banca.Nombre = "Carlo";
            jugador_banca.Numero_camiseta = 30;
            jugador_banca.Puntos_ataque = 99;
            jugador_banca.Puntos_defensa = 99;
            jugador_banca.Sueldo = 200000;

            this.Cambiar_Jugador(e.Jugador, jugador_banca);
        }
    }
}
