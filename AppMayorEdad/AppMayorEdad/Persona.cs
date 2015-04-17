using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMayorEdad
{
    class Persona
    {
        // Declarar Los Atributos
        string nombre;
        int edad;

        // Metodo Constructor Vacio
        public Persona()
        {
 
        }

        // Metodo Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Metodo Get y Set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value ; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
