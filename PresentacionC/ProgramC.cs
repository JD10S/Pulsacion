using System;
using Entity;

namespace Cpresentacion
{
    class ConsoleP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Pulsaciones");

            Console.Write("Ingrese el sexo F/M: ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Ingrese la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            try
            {
                
                Persona persona = new Persona(sexo, edad);

             
                decimal pulsacion = persona.CalcularPulsacion(persona);

            
                Console.WriteLine($"Las pulsaciones son: {pulsacion}");
            }
            catch (ArgumentException ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
