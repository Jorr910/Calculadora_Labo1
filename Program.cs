using System;

namespace Calculadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool Continuar = true;


         do
         {
             
             Console.Write("\n--------CALCULADORA------\n");
             Console.Write("Ingrese el primer numero: ");
             double a = Convert.ToDouble(Console.ReadLine()); 
             Console.Write("Ingresa el segundo valor: ");
             double b = Convert.ToDouble(Console.ReadLine());
         
             Console.WriteLine("\nEscoja una opcion");
             Console.WriteLine("1- SUMA, \n2 Resta, \n3 multiplicacion, \n4 division, \n5 salir");
             Console.Write("Opción: ");
             int opciones = Convert.ToInt32(Console.ReadLine());
             switch (opciones)
             {
                 case 1:
                     Console.Write("La suma total de los numeros ingresados es: ");
                     Console.WriteLine(a + b);
                     break;
                 case 2:
                     Console.Write("La resta total de los numeros ingresados es: ");
                     Console.WriteLine(a - b);
                     break;

                 case 3:
                     Console.Write("La multiplicacion total de los numeros ingresados es: ");
                     Console.WriteLine(a * b);
                     break;

                 case 4:
                     Console.Write("La suma total de los numeros ingresados es: ");
                     Console.WriteLine(a / b);
                     break;
                 
                 case 5: 
                     Console.Write("Saliendo del programa");
                     Continuar = false;
                     break;
             }
         } while (Continuar);

        } 
    }
}