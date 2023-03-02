using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1EverAldahirHernandezBenavides.Entidades
{
    public class Persona
    {
        public Persona(string nombre, string sexo, double altura) 
        {
            this.Nombre = nombre;
    this.Sexo = sexo;
    this.Altura = altura;
   
        }
            public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Sexo { get; set;}
    public int Peso { get; set;}
    public double Altura { get; set;}
    }
}
