using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Escriba un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba un segundo numero:  ");
            n2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Escriba un tercer numero: ");
            n3 = int.Parse(Console.ReadLine());

            int mayor, menor;

            mayor = n1;

            if (mayor < n2) mayor = n2;
            if (mayor < n3) mayor = n3;

            menor = n1;

            if (menor > n2) menor = n2;
            if (menor > n3) menor = n3;

            Console.WriteLine("El mayor de los tres numeros es: " + mayor);
            Console.WriteLine("El menor de los tres numeros es: " + menor);

            Console.ReadLine();
        }
    }
}
