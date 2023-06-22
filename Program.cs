using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09Estacionamento
{
    internal class Program
    {
        static List<string> vagas = new List<string> { "_____", "_____", "_____", "_____", "_____",};
        
        static void Main(string[] args)
        {
            Console.WriteLine("=====Bem vindo ao sistema de estacionamento=====");
            Console.WriteLine("'1' Estacionar\n'2' Retirar veículo\n'3' Listar veículos");
            string opcao = Console.ReadLine();
            
            if(opcao !="1" && opcao!="2" && opcao!="3"){
                Console.WriteLine("Digite um numero de operção valida...");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;
            }

            if (opcao == "1")
            {
                for (int cont = 0; cont < vagas.Count; cont++)
                {
                    if (vagas[cont] == "_____")
                    {
                        Console.Write("Digite a placa do seu veiculo: ");
                        string placa = Console.ReadLine();
                        string placaTratada = placa.ToUpper();
                        
                        if (vagas.Contains(placaTratada)){
                            Console.WriteLine("\nJá temos um veiculo com está placa estacionado...");
                            Console.ReadLine();
                            Console.Clear();
                            Main(null);
                            return;
                        }
                        
                        if (placa.Length==6)
                        {
                            vagas[cont] = placaTratada;
                            Console.WriteLine($"O veículo de placa {vagas[cont]} foi estacionado");
                            cont++;
                            Console.ReadLine();
                            Console.Clear();
                            Main(null);
                            return;

                        }

                        Console.WriteLine("Digite uma placa com 6 caracteres");
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);
                        return;

                    }
                }

                Console.WriteLine("Estamos sem vagas no estacionamento...");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;

            }

            if (opcao == "2")
            {
                Console.Write("Digite a placa do seu veiculo: ");
                string retirar = Console.ReadLine();


                for (int cont = 0; cont < vagas.Count; cont++)
                {
                    if (vagas[cont] == retirar.ToUpper())
                    {

                        Console.WriteLine("Veículo retirado da vaga");
                        vagas[cont] = "_____";
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);
                        return;

                    }

                }

                Console.WriteLine("O veiculo com essa placa não está estacionado em nossas vagas...");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;

            }

            if (opcao == "3")
            {


                Console.WriteLine($"[{vagas[0]}] [{vagas[1]}] [{vagas[2]}] [{vagas[3]}] [{vagas[4]}]");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;
            }
        }
    }
}
