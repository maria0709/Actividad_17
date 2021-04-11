using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_17
{
    class Program
    {
        /*Solicite el ingreso de dos números al usuario y presente la suma, la resta, la multiplicación, la división, 
        el resto, el primero elevado a la potencia del segundo.*/

        static void Main(string[] args)
        {

            double primerNumero, 
                
                segundoNumero;

            Console.Write("Por favor ingrese el primer número: ");
            bool resultado = Double.TryParse(Console.ReadLine(), out primerNumero);
            if (!resultado)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como un valor numérico.");
                
               return;
           
            }
            Console.ReadKey();
            Console.Write("Por favor ingrese el segundo número: ");
            resultado = Double.TryParse(Console.ReadLine(), out segundoNumero);
            if (!resultado)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }
           
            Console.WriteLine("\r");
            Console.WriteLine($"Suma: {primerNumero + segundoNumero}");
            Console.WriteLine($"Resta: {primerNumero - segundoNumero}");
            Console.WriteLine($"Mutiplicación: {primerNumero * segundoNumero}");
            if (segundoNumero != 0)
            {
                Console.WriteLine($"División: {primerNumero / segundoNumero}");
                Console.WriteLine($"Modulo: {primerNumero % segundoNumero}");
            }
            else
            {
                Console.WriteLine("División y módulo no son posibles porque el segundo ingreso es 0.");
            }

            Console.WriteLine($"Potencia: {Math.Pow(primerNumero, segundoNumero)}");

            Console.WriteLine("Presione cualquier tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
