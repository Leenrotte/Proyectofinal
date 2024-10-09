using System;

namespace SistemaMenu
{
    // Este programa es un menú interactivo para el usuario.
    // Tiene tres opciones: ver la fecha y hora actual, calcular el factorial de un número, o contar las vocales en una palabra.
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0; // Opción del menú seleccionada por el usuario

            // Bucle que muestra el menú hasta que el usuario elige salir
            while (opcion != 4)
            {
                // Mostrar el menú
                Console.WriteLine("\n--- Menú Principal ---");
                Console.WriteLine("1. Ver fecha y hora actual");
                Console.WriteLine("2. Calcular factorial de un número");
                Console.WriteLine("3. Contar vocales en una palabra");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                // Leer la opción elegida
                opcion = int.Parse(Console.ReadLine());

                // Usamos un if anidado para procesar la opción elegida
                if (opcion == 1)
                {
                    // Opción 1: Mostrar la fecha y hora actuales
                    MostrarFechaHora();
                }
                else if (opcion == 2)
                {
                    // Opción 2: Calcular el factorial de un número
                    Console.Write("Ingresa un número para calcular su factorial: ");
                    int numero = int.Parse(Console.ReadLine());
                    int factorial = CalcularFactorial(numero);
                    Console.WriteLine($"El factorial de {numero} es {factorial}.");
                }
                else if (opcion == 3)
                {
                    // Opción 3: Contar las vocales de una palabra
                    Console.Write("Ingresa una palabra para contar sus vocales: ");
                    string palabra = Console.ReadLine();
                    int numVocales = ContarVocales(palabra);
                    Console.WriteLine($"La palabra '{palabra}' tiene {numVocales} vocales.");
                }
                else if (opcion == 4)
                {
                    // Opción 4: Salir
                    Console.WriteLine("Saliendo del programa. ¡Adiós!");
                }
                else
                {
                    // Opción inválida
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                }
            }
        }

        // Método para mostrar la fecha y hora actual
        static void MostrarFechaHora()
        {
            DateTime fechaHoraActual = DateTime.Now;
            Console.WriteLine($"Fecha actual: {fechaHoraActual.ToShortDateString()}");
            Console.WriteLine($"Hora actual: {fechaHoraActual.ToShortTimeString()}");
        }

        // Método para calcular el factorial de un número
        static int CalcularFactorial(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i; // Multiplicar acumulativamente para obtener el factorial
            }
            return resultado;
        }

        // Método para contar el número de vocales en una palabra
        static int ContarVocales(string palabra)
        {
            int contador = 0;
            string vocales = "aeiouAEIOU"; // Consideramos tanto minúsculas como mayúsculas

            // Recorremos cada letra de la palabra
            foreach (char letra in palabra)
            {
                if (vocales.Contains(letra)) // Si la letra está en el conjunto de vocales
                {
                    contador++; // Incrementar el contador de vocales
                }
            }
            return contador;
        }
    }
}