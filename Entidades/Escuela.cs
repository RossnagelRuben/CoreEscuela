namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string NombreEscuela { get {return "eL nombre de la escuela es: " + nombre;} set {nombre = value.ToUpper();} }

        public string Nombre = "Platzi";

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }


        // => igualacion por tuplas
        //metodo constructor
        public Escuela(String Nombre, int Año) => (nombre, AñoDeCreacion) = (Nombre, Año); 

            public override string ToString()
            {
                return $"Nombre de la escuela: {Nombre}";
            }

    }
}