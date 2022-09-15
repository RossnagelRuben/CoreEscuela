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
            Console.ReadKey();
            Console.WriteLine(Escuela.Nombre);

        }
    }

}