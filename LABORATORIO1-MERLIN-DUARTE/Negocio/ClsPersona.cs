using LABORATORIO1_MERLIN_DUARTE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1_MERLIN_DUARTE.Negocio
{
    public class ClsPersona
    {
        public String calcularIMC(Persona persona)
        {
            Double pro = persona.peso / Math.Pow(persona.altura, 2);

            if (pro > 24 && pro < 25)
            {
                return persona.nombre + " Tiene un peso ideal";

            }
            else if (pro < 24)
            {
                return persona.nombre + " Está por debajo de su peso ideal";
            }
            else if (pro >= 25)
            {
                return persona.nombre + " Tiene sobre peso";
            }
            return "";
        }

        public String esMayorDeEdad(Persona persona)
        {
            if (persona.edad >= 18)
            {
                return persona.nombre + " Es mayor de edad";

            }
            else
            {
                return persona.nombre + " Es menor de edad";
            }
        }
    }
}
