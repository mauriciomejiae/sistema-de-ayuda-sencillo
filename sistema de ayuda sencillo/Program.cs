/* Nombre del Autor: Gustavo Adolfo Miranda Pinzon
Fecha: 21/09/2017
Doy fe que este ejercicio es de mi autoría, 
en caso de encontrar plagio la nota de todo mi trabajo debe ser de CERO 
además de las respectivas sanciones a que haya lugar */

//Un sistema de ayuda sencillo.

using System;

namespace sistema_de_ayuda_sencillo
{
    class ayuda
    {
        static void Continuar()
        {
            Console.WriteLine("");
            Console.WriteLine("Pulse una tecla para continuar.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            char menu_opciones;  //Menu de opciones
            do
            {
                Console.Clear();
                Console.WriteLine("------------------- Fase 1 - Sistema de ayuda -------------------");
                Console.Write("\n");
                Console.WriteLine("1) If");
                Console.Write("\n");
                Console.WriteLine("2) Switch");
                Console.Write("\n");
                Console.WriteLine("3) Salir\n");
                Console.Write("Seleccione una opción: ");
                do
                {
                    menu_opciones = Console.ReadKey(true).KeyChar;
                } while (menu_opciones < '1' || menu_opciones > '3');
                Console.WriteLine(menu_opciones + "\n");
                switch (menu_opciones)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("-----------Estructura If---------");  //Descripción de la esctructura If
                        Console.Write("\n");
                        Console.WriteLine("Permite ejecutar una serie de instrucciones cuando se cumple una condición determinada, y además, esta va acompañada de operadores lógicos.");
                        Console.Write("\n");
                        Console.WriteLine("-------------Sintaxis------------");
                        Console.Write("\n");
                        Console.WriteLine("if (condición) declaración;");
                        Console.WriteLine("declaración else;");
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("-----------Estructura Switch---------");  //Descripción de la esctructura Switch
                        Console.Write("\n");
                        Console.WriteLine("Permine determinar multiples casos en los cuales se encuentra una serie de instrucciones.");
                        Console.Write("\n");
                        Console.WriteLine("---------------Sintaxis--------------");
                        Console.Write("\n");
                        Console.WriteLine("switch (expresión) {");
                        Console.WriteLine("  constante case:");
                        Console.WriteLine("    secuencia de declaraciones");
                        Console.WriteLine("    break;");
                        Console.WriteLine("  // ...");
                        Console.WriteLine("}");
                        break;
                }
                if (menu_opciones != '3')
                {
                    Console.Write("\nPresione una tecla para continuar . . . ");  //Detiene hasta que pulse una tecla
                    Console.ReadKey(true);
                }
            } while (menu_opciones != '3');
        }
    }
}
