using Entity;
using System;
namespace Cpresentacion
{
     class ConsoleP
    {
           static void Main(string[] args, persona persona) 
        {

            int edad;
            string sexo;

            Console.WriteLine("Digite su edad");
            edad=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite su sexo");
            sexo=Console.ReadLine();

            persona Persona = new persona( sexo ,edad);
            
            persona.CalcularPulsacion(persona);
            Console.WriteLine($"Su Pulsaciones {persona.Pulsacion} ");

        }
    }
}
