// ejemplo creacion clase y objeto en C#
using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public void timbrar()
        {
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(783, 250); //Sol
            Console.Beep(880, 250); //La
            Console.Beep(987, 1000); //Si

            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(1760, 1000); //La'
            Console.Beep(1567, 500); //Sol'
            Console.Beep(1174, 1000); //Re'

            Console.Beep(1046, 250); //Do
            Console.Beep(987, 250); //Si
            Console.Beep(880, 1000); //La

            //Console.Beep(523, 500); //Do      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // crear objeto llamado miEscuela 
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi";
            miEscuela.direccion = "Cr 9";
            miEscuela.añoFundacion = 2012;
            miEscuela.timbrar(); 
            Console.WriteLine("Hello World!");
            Console.WriteLine(miEscuela.nombre);
            Console.WriteLine(miEscuela.direccion);
            Console.WriteLine(miEscuela.añoFundacion);
        }
    }
}
