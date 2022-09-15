using System;
using CoreEscuela.Entidades;

namespace Etapa01
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos el objeto
            var escuela = new Escuela("Platzi",2012);
            escuela.Pais="Argentina";
            escuela.Ciudad="EldoCity";
            escuela.tiposEscuelas = TiposEscuelas.Primaria;

            Console.WriteLine("Welcome!");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine(escuela.NombreEscuela);
            Console.WriteLine("");
            Console.ReadKey();

            //Console.WriteLine(Escuela);
            //de fondo, c# usar el ToString al momento de ejecutar esta linea...
            //lo que podemos hacer es sobreescribir el metodo construcor de ToString...

            Console.WriteLine(escuela);
        }
    }

}