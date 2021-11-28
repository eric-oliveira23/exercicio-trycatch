using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materia_nova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o Primeiro Número");
                int pnum = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Segundo Número");
                int snum = int.Parse(Console.ReadLine());

                double resultado = pnum / snum;

                Console.WriteLine("O resultado da operação é: " + resultado);
            }

            catch (FormatException)
            {
                Console.WriteLine("Valor digitado inválido");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Tentativa de Divisão por Zero, Execução abortada.");
            }

            //esse catch sempre tem que ser o último, pq é o padrao das exceptions
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }



            finally
            {
                Console.WriteLine("Final da execução.");
            }

                Console.ReadKey();
            







        }
    }
}
