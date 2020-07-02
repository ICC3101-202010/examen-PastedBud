using System;
using System.Collections.Generic;

namespace examenPastedBud
{
    public abstract class Persona
    {
        private string nombre;
        private string nación;
        private int edad;
        private int sueldo;


        public Persona()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nación { get => nación; set => nación = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        public abstract void InfoPersona(Equipo equipo);

    }
}
