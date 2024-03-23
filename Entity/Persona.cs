using System;

namespace Entity
{
    public class Persona
    {
        public Persona()
        {
        }

        public Persona(string sexo, int edad)
        {
            Edad = edad;
            Sexo = sexo;
        }

        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }

        public decimal CalcularPulsacion(Persona persona)
        {
            decimal pulsacion;
            string sexo = persona.Sexo.ToUpper(); 

            if (sexo == "F")
            {
                pulsacion = (220 - Convert.ToDecimal(persona.Edad)) / 10; 
            }
            else if (sexo == "M")
            {
                pulsacion = (210 - Convert.ToDecimal(persona.Edad)) / 10; 
            }
            else
            {
                throw new ArgumentException("El sexo ingresado no es válido.");
            }

            return pulsacion;
        }

        
    }
}

