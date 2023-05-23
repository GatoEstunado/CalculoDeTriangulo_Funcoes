// Bibliotecas
using System;
using System.Globalization;

// Inicio do programa
namespace Course
{
    // Classe Program
    public class Program
    {
        // Funcao que recebe informacoes e calcula
        // Programa principal
        public static void Main(string[] args)
        {   
            // Recebe as medidas dos triangulos X e Y
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");

            // Calcula os valores dos triangulos X e Y
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            // Interface do usuario, para recerber as informacoes dos triangulos X e Y
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // IF para que se X maior que Y, informar
            if (areaX > areaY)
            {
                // COUT do C#
                Console.WriteLine("Maior area: X");
            }
            // ELSE para que se X  não maior que Y, informar
            else
            {
                // COUT do C# 
                Console.WriteLine("Maior area: Y");
            }
        }
        
        // Funcao para alocar as informacoes do programa principal
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            // ARRAY para as medidas
            double[] medidas = new double[3];

            // Interface do usuario, para colocar as medidas
            Console.WriteLine("Entre com as medidas do triangulo " + nomeTriangulo + ":");
            // Loop
            for (int i = 0; i < 3; i++)
            {
                // PARSE para ler e vincular os valores na READLINE a nova variavel 
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Retornar as medidas
            return medidas;
        }

        // Funcao para alocar as informacoes do programa principal
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            // Puxar os valoreas das medidas na ARRAY
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            // Efetuar o calculo da area do triangulo
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Retornar a area
            return area;
        }

    }
}