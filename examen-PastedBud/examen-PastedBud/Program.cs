using System;

namespace examenPastedBud
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            string resp = "1";
            while (resp != "3")
            {
                Console.WriteLine("BIENVENIDO A NUESTRO SIMULADOR DE PARTIDOS DE FUTBOL!");
                Console.WriteLine("");
                Console.WriteLine("");
                Partido.Simular();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Deseas Ver un Equipo Creado? ");
                Console.WriteLine("1 --> Si (Equipo Creado Correctamente)");
                Console.WriteLine("2 --> Si (Equipo Creado Incorrectamente)");
                Console.WriteLine("3 --> No");

                resp = Console.ReadLine();

                if (resp == "1")
                {
                    Jugador jugador1 = new Jugador();
                    jugador1.Arquero = true;
                    jugador1.Edad = 33;
                    jugador1.EnCancha = true;
                    jugador1.Lesionado = false;
                    jugador1.Nación = "Chile";
                    jugador1.Nombre = "Claudio Bravo";
                    jugador1.Numero_camiseta = 1;
                    jugador1.Puntos_ataque = 10;
                    jugador1.Puntos_defensa = 80;
                    jugador1.Sueldo = 2000;
                    
                    Jugador jugador2 = new Jugador();
                    jugador2.Arquero = false;
                    jugador2.Edad = 33;
                    jugador2.EnCancha = true;
                    jugador2.Lesionado = false;
                    jugador2.Nación = "Chile";
                    jugador2.Nombre = "Gary Medel";
                    jugador2.Numero_camiseta = 2;
                    jugador2.Puntos_ataque = 50;
                    jugador2.Puntos_defensa = 99;
                    jugador2.Sueldo = 2000;
                    Jugador jugador3 = new Jugador();
                    jugador3.Arquero = false;
                    jugador3.Edad = 33;
                    jugador3.EnCancha = true;
                    jugador3.Lesionado = false;
                    jugador3.Nación = "Chile";
                    jugador3.Nombre = "Gato Silva";
                    jugador3.Numero_camiseta = 3;
                    jugador3.Puntos_ataque = 60;
                    jugador3.Puntos_defensa = 70;
                    jugador3.Sueldo = 2000;
                    Jugador jugador4 = new Jugador();
                    jugador4.Arquero = false;
                    jugador4.Edad = 33;
                    jugador4.EnCancha = true;
                    jugador4.Lesionado = false;
                    jugador4.Nación = "Chile";
                    jugador4.Nombre = "Charles Aránguiz ";
                    jugador4.Numero_camiseta = 4;
                    jugador4.Puntos_ataque = 40;
                    jugador4.Puntos_defensa = 80;
                    jugador4.Sueldo = 2000;
                    Jugador jugador5 = new Jugador();
                    jugador5.Arquero = false;
                    jugador5.Edad = 33;
                    jugador5.EnCancha = true;
                    jugador5.Lesionado = false;
                    jugador5.Nación = "Chile";
                    jugador5.Nombre = "Arturo Vidal";
                    jugador5.Numero_camiseta = 5;
                    jugador5.Puntos_ataque = 50;
                    jugador5.Puntos_defensa = 80;
                    jugador5.Sueldo = 2000;
                    Jugador jugador6 = new Jugador();
                    jugador6.Arquero = false;
                    jugador6.Edad = 33;
                    jugador6.EnCancha = true;
                    jugador6.Lesionado = false;
                    jugador6.Nación = "Chile";
                    jugador6.Nombre = "Guillermo Maripán ";
                    jugador6.Numero_camiseta = 6;
                    jugador6.Puntos_ataque = 60;
                    jugador6.Puntos_defensa = 80;
                    jugador6.Sueldo = 2000;
                    Jugador jugador7 = new Jugador();
                    jugador7.Arquero = false;
                    jugador7.Edad = 33;
                    jugador7.EnCancha = true;
                    jugador7.Lesionado = false;
                    jugador7.Nación = "Chile";
                    jugador7.Nombre = "Erick Pulgar";
                    jugador7.Numero_camiseta = 7;
                    jugador7.Puntos_ataque = 70;
                    jugador7.Puntos_defensa = 80;
                    jugador7.Sueldo = 2000;
                    Jugador jugador8 = new Jugador();
                    jugador8.Arquero = false;
                    jugador8.Edad = 33;
                    jugador8.EnCancha = true;
                    jugador8.Lesionado = false;
                    jugador8.Nación = "Chile";
                    jugador8.Nombre = "Mauricio Isla";
                    jugador8.Numero_camiseta = 8;
                    jugador8.Puntos_ataque = 80;
                    jugador8.Puntos_defensa = 80;
                    jugador8.Sueldo = 2000;
                    Jugador jugador9 = new Jugador();
                    jugador9.Arquero = false;
                    jugador9.Edad = 33;
                    jugador9.EnCancha = true;
                    jugador9.Lesionado = false;
                    jugador9.Nación = "Chile";
                    jugador9.Nombre = "Gabriel Arias";
                    jugador9.Numero_camiseta = 9;
                    jugador9.Puntos_ataque = 90;
                    jugador9.Puntos_defensa = 80;
                    jugador9.Sueldo = 2000;
                    Jugador jugador10 = new Jugador();
                    jugador10.Arquero = false;
                    jugador10.Edad = 33;
                    jugador10.EnCancha = true;
                    jugador10.Lesionado = false;
                    jugador10.Nación = "Chile";
                    jugador10.Nombre = "Eduardo Vargas";
                    jugador10.Numero_camiseta = 10;
                    jugador10.Puntos_ataque = 100;
                    jugador10.Puntos_defensa = 80;
                    jugador10.Sueldo = 2000;
                    Jugador jugador11 = new Jugador();
                    jugador11.Arquero = false;
                    jugador11.Edad = 33;
                    jugador11.EnCancha = true;
                    jugador11.Lesionado = false;
                    jugador11.Nación = "Chile";
                    jugador11.Nombre = "Alexis Sánchez ";
                    jugador11.Numero_camiseta = 11;
                    jugador11.Puntos_ataque = 110;
                    jugador11.Puntos_defensa = 80;
                    jugador11.Sueldo = 2000;
                    Jugador jugador12 = new Jugador();
                    jugador12.Arquero = false;
                    jugador12.Edad = 33;
                    jugador12.EnCancha = false;
                    jugador12.Lesionado = false;
                    jugador12.Nación = "Chile";
                    jugador12.Nombre = "Jean Beausejour";
                    jugador12.Numero_camiseta = 12;
                    jugador12.Puntos_ataque = 120;
                    jugador12.Puntos_defensa = 80;
                    jugador12.Sueldo = 2000;
                    Jugador jugador13 = new Jugador();
                    jugador13.Arquero = false;
                    jugador13.Edad = 33;
                    jugador13.EnCancha = false;
                    jugador13.Lesionado = false;
                    jugador13.Nación = "Chile";
                    jugador13.Nombre = "Paulo Díaz";
                    jugador13.Numero_camiseta = 13;
                    jugador13.Puntos_ataque = 130;
                    jugador13.Puntos_defensa = 80;
                    jugador13.Sueldo = 2000;
                    Jugador jugador14 = new Jugador();
                    jugador14.Arquero = false;
                    jugador14.Edad = 33;
                    jugador14.EnCancha = false;
                    jugador14.Lesionado = true;
                    jugador14.Nación = "Chile";
                    jugador14.Nombre = "Óscar Opazo ";
                    jugador14.Numero_camiseta = 14;
                    jugador14.Puntos_ataque = 140;
                    jugador14.Puntos_defensa = 80;
                    jugador14.Sueldo = 2000;
                    Jugador jugador15 = new Jugador();
                    jugador15.Arquero = false;
                    jugador15.Edad = 33;
                    jugador15.EnCancha = false;
                    jugador15.Lesionado = true;
                    jugador15.Nación = "Chile";
                    jugador15.Nombre = "José Pedro Fuenzalida";
                    jugador15.Numero_camiseta = 15;
                    jugador15.Puntos_ataque = 150;
                    jugador15.Puntos_defensa = 80;
                    jugador15.Sueldo = 2000;
                    Entrenador entrenador = new Entrenador();
                    entrenador.Edad = 45;
                    entrenador.Nación = "Chile";
                    entrenador.Nombre = "Reinaldo Rueda";
                    entrenador.Puntos_tactica = 60;
                    entrenador.Sueldo = 1000;
                    Medico medico = new Medico();
                    medico.Edad = 21;
                    medico.Nación = "Italia";
                    medico.Nombre = "Carlo Vitali";
                    medico.puntos_experiencia = 99;
                    medico.Sueldo = 999;
                    try
                    {
                        Equipo equipo = new Equipo("Selección Chilena", true, jugador1, jugador2, jugador3, jugador4, jugador5, jugador6, jugador7, jugador8, jugador9, jugador10, jugador11, jugador12, jugador13, jugador14, jugador15, entrenador, medico);
                        string resp1 = "1";
                        while (resp1 != "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Deseas Corroborar la Nacionalidad del Equipo? ");
                            Console.WriteLine("1 --> Si");
                            Console.WriteLine("2 --> No");
                            Console.WriteLine("");
                            resp1 = Console.ReadLine();
                            Console.WriteLine("");
                            if (resp1 == "1")
                            {
                                if (equipo.Nacional == true)
                                {
                                    if (equipo.Corroborar_Nacionalidad(equipo) == true)
                                    {
                                        Console.WriteLine("Todos Los Jugadores son de la Misma Nacionalidad");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Todos los Jugadores Pueden Jugar!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El Equipo es de Liga y No Requiere Corroboración de la Nacionalidad");
                                }

                            }
                            else if (resp1 == "2")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Opción Invalida!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        
                    }
                    

                    
                    
                }
                else if (resp == "2")
                {
                    Jugador jugador1 = new Jugador();
                    jugador1.Arquero = true;
                    jugador1.Edad = 33;
                    jugador1.EnCancha = true;
                    jugador1.Lesionado = false;
                    jugador1.Nación = "Francia";
                    jugador1.Nombre = "Claudio Bravo";
                    jugador1.Numero_camiseta = 1;
                    jugador1.Puntos_ataque = 10;
                    jugador1.Puntos_defensa = 80;
                    jugador1.Sueldo = 2000;

                    Jugador jugador2 = new Jugador();
                    jugador2.Arquero = false;
                    jugador2.Edad = 33;
                    jugador2.EnCancha = true;
                    jugador2.Lesionado = false;
                    jugador2.Nación = "Chile";
                    jugador2.Nombre = "Gary Medel";
                    jugador2.Numero_camiseta = 2;
                    jugador2.Puntos_ataque = 50;
                    jugador2.Puntos_defensa = 99;
                    jugador2.Sueldo = 2000;
                    Jugador jugador3 = new Jugador();
                    jugador3.Arquero = false;
                    jugador3.Edad = 33;
                    jugador3.EnCancha = true;
                    jugador3.Lesionado = false;
                    jugador3.Nación = "Chile";
                    jugador3.Nombre = "Gato Silva";
                    jugador3.Numero_camiseta = 3;
                    jugador3.Puntos_ataque = 60;
                    jugador3.Puntos_defensa = 70;
                    jugador3.Sueldo = 2000;
                    Jugador jugador4 = new Jugador();
                    jugador4.Arquero = false;
                    jugador4.Edad = 33;
                    jugador4.EnCancha = true;
                    jugador4.Lesionado = false;
                    jugador4.Nación = "Chile";
                    jugador4.Nombre = "Charles Aránguiz ";
                    jugador4.Numero_camiseta = 4;
                    jugador4.Puntos_ataque = 40;
                    jugador4.Puntos_defensa = 80;
                    jugador4.Sueldo = 2000;
                    Jugador jugador5 = new Jugador();
                    jugador5.Arquero = false;
                    jugador5.Edad = 33;
                    jugador5.EnCancha = true;
                    jugador5.Lesionado = false;
                    jugador5.Nación = "Chile";
                    jugador5.Nombre = "Arturo Vidal";
                    jugador5.Numero_camiseta = 5;
                    jugador5.Puntos_ataque = 50;
                    jugador5.Puntos_defensa = 80;
                    jugador5.Sueldo = 2000;
                    Jugador jugador6 = new Jugador();
                    jugador6.Arquero = false;
                    jugador6.Edad = 33;
                    jugador6.EnCancha = true;
                    jugador6.Lesionado = false;
                    jugador6.Nación = "Chile";
                    jugador6.Nombre = "Guillermo Maripán ";
                    jugador6.Numero_camiseta = 6;
                    jugador6.Puntos_ataque = 60;
                    jugador6.Puntos_defensa = 80;
                    jugador6.Sueldo = 2000;
                    Jugador jugador7 = new Jugador();
                    jugador7.Arquero = false;
                    jugador7.Edad = 33;
                    jugador7.EnCancha = true;
                    jugador7.Lesionado = false;
                    jugador7.Nación = "Chile";
                    jugador7.Nombre = "Erick Pulgar";
                    jugador7.Numero_camiseta = 7;
                    jugador7.Puntos_ataque = 70;
                    jugador7.Puntos_defensa = 80;
                    jugador7.Sueldo = 2000;
                    Jugador jugador8 = new Jugador();
                    jugador8.Arquero = false;
                    jugador8.Edad = 33;
                    jugador8.EnCancha = true;
                    jugador8.Lesionado = false;
                    jugador8.Nación = "Chile";
                    jugador8.Nombre = "Mauricio Isla";
                    jugador8.Numero_camiseta = 8;
                    jugador8.Puntos_ataque = 80;
                    jugador8.Puntos_defensa = 80;
                    jugador8.Sueldo = 2000;
                    Jugador jugador9 = new Jugador();
                    jugador9.Arquero = false;
                    jugador9.Edad = 33;
                    jugador9.EnCancha = true;
                    jugador9.Lesionado = false;
                    jugador9.Nación = "Chile";
                    jugador9.Nombre = "Gabriel Arias";
                    jugador9.Numero_camiseta = 9;
                    jugador9.Puntos_ataque = 90;
                    jugador9.Puntos_defensa = 80;
                    jugador9.Sueldo = 2000;
                    Jugador jugador10 = new Jugador();
                    jugador10.Arquero = false;
                    jugador10.Edad = 33;
                    jugador10.EnCancha = true;
                    jugador10.Lesionado = false;
                    jugador10.Nación = "Chile";
                    jugador10.Nombre = "Eduardo Vargas";
                    jugador10.Numero_camiseta = 10;
                    jugador10.Puntos_ataque = 100;
                    jugador10.Puntos_defensa = 80;
                    jugador10.Sueldo = 2000;
                    Jugador jugador11 = new Jugador();
                    jugador11.Arquero = false;
                    jugador11.Edad = 33;
                    jugador11.EnCancha = true;
                    jugador11.Lesionado = false;
                    jugador11.Nación = "Chile";
                    jugador11.Nombre = "Alexis Sánchez ";
                    jugador11.Numero_camiseta = 11;
                    jugador11.Puntos_ataque = 110;
                    jugador11.Puntos_defensa = 80;
                    jugador11.Sueldo = 2000;
                    Jugador jugador12 = new Jugador();
                    jugador12.Arquero = false;
                    jugador12.Edad = 33;
                    jugador12.EnCancha = false;
                    jugador12.Lesionado = false;
                    jugador12.Nación = "Chile";
                    jugador12.Nombre = "Jean Beausejour";
                    jugador12.Numero_camiseta = 12;
                    jugador12.Puntos_ataque = 120;
                    jugador12.Puntos_defensa = 80;
                    jugador12.Sueldo = 2000;
                    Jugador jugador13 = new Jugador();
                    jugador13.Arquero = false;
                    jugador13.Edad = 33;
                    jugador13.EnCancha = false;
                    jugador13.Lesionado = false;
                    jugador13.Nación = "Chile";
                    jugador13.Nombre = "Paulo Díaz";
                    jugador13.Numero_camiseta = 13;
                    jugador13.Puntos_ataque = 130;
                    jugador13.Puntos_defensa = 80;
                    jugador13.Sueldo = 2000;
                    Jugador jugador14 = new Jugador();
                    jugador14.Arquero = false;
                    jugador14.Edad = 33;
                    jugador14.EnCancha = false;
                    jugador14.Lesionado = true;
                    jugador14.Nación = "Chile";
                    jugador14.Nombre = "Óscar Opazo ";
                    jugador14.Numero_camiseta = 14;
                    jugador14.Puntos_ataque = 140;
                    jugador14.Puntos_defensa = 80;
                    jugador14.Sueldo = 2000;
                    Jugador jugador15 = new Jugador();
                    jugador15.Arquero = false;
                    jugador15.Edad = 33;
                    jugador15.EnCancha = false;
                    jugador15.Lesionado = true;
                    jugador15.Nación = "Chile";
                    jugador15.Nombre = "José Pedro Fuenzalida";
                    jugador15.Numero_camiseta = 15;
                    jugador15.Puntos_ataque = 150;
                    jugador15.Puntos_defensa = 80;
                    jugador15.Sueldo = 2000;
                    Entrenador entrenador = new Entrenador();
                    entrenador.Edad = 45;
                    entrenador.Nación = "Chile";
                    entrenador.Nombre = "Reinaldo Rueda";
                    entrenador.Puntos_tactica = 60;
                    entrenador.Sueldo = 1000;
                    Medico medico = new Medico();
                    medico.Edad = 21;
                    medico.Nación = "Italia";
                    medico.Nombre = "Carlo Vitali";
                    medico.puntos_experiencia = 99;
                    medico.Sueldo = 999;

                    Equipo equipo = new Equipo("Selección Chilena", true, jugador1, jugador2, jugador3, jugador4, jugador5, jugador6, jugador7, jugador8, jugador9, jugador10, jugador11, jugador12, jugador13, jugador14, jugador15, entrenador, medico);


                }
                else if (resp == "3")
                {

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Opcion Invalida");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
    }
}
