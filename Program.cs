using System;
using CoreEscuela.Entidades;

namespace Etapa01
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escuela = new Escuela("Platzi",2012);
            Escuela.Pais="Argentina";
            Escuela.Ciudad="EldoCity";

            Console.WriteLine("Welcome!");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine(Escuela.NombreEscuela);
            Console.WriteLine("");
            Console.ReadKey();

            //Console.WriteLine(Escuela);
            //de fondo, c# usar el ToString al momento de ejecutar esta linea...
            //lo que podemos hacer es sobreescribir el metodo construcor de ToString...

            Console.WriteLine(Escuela);
        }
    }

}