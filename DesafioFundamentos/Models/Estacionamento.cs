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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string veiculo = Console.ReadLine();
            this.veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo para remover:");

                string placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = this.precoInicial + this.precoPorHora * horas;

                    this.veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);
                Console.WriteLine("Aperte qualquer tecla para continuar mesmo assim.");
                Console.ReadLine();
            }
        }

        public void ListarVeiculos()
        {
            try
            {
                // Verifica se há veículos no estacionamento
                if (veiculos.Any())
                {
                    Console.WriteLine("Os veículos estacionados são:");

                    for (int i = 0; i < this.veiculos.Count; i++)
                    {
                        Console.WriteLine(this.veiculos[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);
                Console.WriteLine("Aperte qualquer tecla para continuar mesmo assim.");
                Console.ReadLine();
            }

        }
    }
}
