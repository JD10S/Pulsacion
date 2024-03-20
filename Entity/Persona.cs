using System;

namespace Entity
{
    public class persona
    {
        public persona()
        {
        }

        public persona(string sexo, int edad)
        {

            Edad = edad;
            Sexo = sexo;

        }

        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        
            public decimal CalcularPulsacion(persona persona)
            {
                 decimal pulsacion;
               

                if (persona.Sexo.ToUpper() == "F")
                {
                    pulsacion = (220 - Convert.ToDecimal(persona.Edad)) / 10;
                    
                
                    
                }
                else if (persona.Sexo.ToUpper() == "M")
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
    
