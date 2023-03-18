using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso , altura, imc;

            Console.WriteLine("Insira sua altura em cm e usando vírgula: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu peso: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é de {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc >= 18.5) && (imc <= 25))
            {
                Console.WriteLine("Peso Normal");
            }
            else if ((imc >= 25) && (imc <= 30))
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }


        }


    }
}
