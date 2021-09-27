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
        public TiposEscuela TipoEscuela{get;set;}

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

// Metodo ToString()
        public override string ToString()
        {
            return $"Nombre: (Nombre), Tipo: (TipoEscuela), \n Pais: (Pais), Ciudad: (Ciudad)";
        }
    }
}
