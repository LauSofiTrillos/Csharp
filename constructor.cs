using System;
namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string nombre;
        
        // propiedad forma larga
        public string Nombre
        {
            get{return "Copia:" + nombre;}
            set{nombre = value.ToUpper();}
        }

        // propiedad forma corta
        public int AñoCreación{get; set;}
        public string Pais{get; set;}
        public string Ciudad {get; set;}

        // CONSTRUCTOR 
        /* 
        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñoCreación = año;
        }
        */

        // OTRA FORMA DE DECLARAR EL CONSTRUCTOR, Por DUPLAS 
        public Escuela(string nombre, int año) => (Nombre, AñoCreación) = (nombre, año);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2012);
            //escuela.nombre = "Platzi Academy"
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            Console.WriteLine(escuela.nombre);
        }
    }
}
