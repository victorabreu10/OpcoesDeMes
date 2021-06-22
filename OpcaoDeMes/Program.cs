using System;

namespace OpcaoDeMes
{
    class Program 
    {
        static void Main(string[] args)
        {
            string opcMes = "";
            while (!opcMes.Equals("s") && !opcMes.Equals("S"))
            {
                Console.WriteLine("digite o numero do mes ou digite a letra s para sair");
                opcMes = Console.ReadLine();
                if (!opcMes.Equals("s") && !opcMes.Equals("S") || !opcMes.Equals("m"))
                {
                    switch (opcMes)
                    {

                        case "1":
                            Console.WriteLine("o mes que voce selecionou é janeiro");
                            break;
                        case "2":
                            Console.WriteLine("o mes que voce selecionou é fevereiro");
                            break;
                        case "3":
                            Console.WriteLine("o mes que voce selecionou é março");
                            break;
                        case "4":
                            Console.WriteLine("o mes que voce selecionou é abril");
                            break;
                        case "5":
                            Console.WriteLine("o mes que voce selecionou é maio");
                            break;
                        case "6":
                            Console.WriteLine("o mes que voce selecionou é junho");
                            break;
                        case "7":
                            Console.WriteLine("o mes que voce selecionou é julho");
                            break;
                        case "8":
                            Console.WriteLine("o mes que voce selecionou é agosto");
                            break;
                        case "9":
                            Console.WriteLine("o mes que voce selecionou é setembro");
                            break;
                        case "10":
                            Console.WriteLine("o mes que voce selecionou é outubro");
                            break;
                        case "11":
                            Console.WriteLine("o mes que voce selecionou é novembro");
                            break;
                        case "12":
                            Console.WriteLine("o mes que voce selecionou é dezembro");
                            break;
                        default:
                            Console.WriteLine("o mes que voce digitou nao existe");
                            break;
                    }
                }
                //Console.ReadKey();
                
            }
            Console.WriteLine("Programa encerrado ...");



        }
    }
}
