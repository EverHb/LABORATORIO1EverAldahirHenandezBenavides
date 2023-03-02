using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABORATORIO1EverAldahirHernandezBenavides.Entidades;

namespace LABORATORIO1EverAldahirHernandezBenavides.Negocio
{
    public class ClsPersona
    {
        public string CalcularIMC  (Persona persona){

            double promedio = persona.Peso/Math.Pow(persona.Altura, 2);
            if (promedio <= 24){
                return ($"Su IMC es: {promedio} \nTiene un peso ideal");
            }else{
                return ($"Su IMC es: {promedio} \nTiene sobrepeso");
            }
        }

        public string EsMayordeEdad (Persona edad){
            
            if (edad.Edad < 18){
                return ("usted es menor de edad");
            }else{
                return ("usted es mayor de edad");
            }
        }
    }
}