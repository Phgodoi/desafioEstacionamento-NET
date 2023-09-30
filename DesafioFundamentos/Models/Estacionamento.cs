using System.ComponentModel;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;




        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Implementado

            Console.WriteLine("Digite a placa do veículo para estacionar:");

            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            //Implementado

            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Convert.ToString(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //Implementado

                int horas = 0;
                decimal valorTotal = 0;

                horas = Convert.ToInt16(Console.ReadLine());


                decimal pix = 0.9M;
                decimal dinheiroDebito = 0.95M;


                // Implementado


                Console.WriteLine("Selecione a forma de pagamento: ");
                Console.WriteLine("1: PIX 10% de desconto. ");
                Console.WriteLine("2: Dinheiro ou Débito 5% de desconto. ");
                Console.WriteLine("3: Crédito sem desconto. ");

                switch (Console.ReadLine())
                {
                    case "1":
                        valorTotal = (precoInicial + precoPorHora * horas)* pix ;

                        break;
                    case "2":
                        valorTotal = (precoInicial + precoPorHora * horas) * dinheiroDebito;

                        break;
                    case "3":
                        valorTotal = (precoInicial + precoPorHora) * horas;

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // Implementado
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculoEstacionado in veiculos)
                {
                    Console.WriteLine(veiculoEstacionado);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void CalcularDesconto()
        {

        }
    }
}