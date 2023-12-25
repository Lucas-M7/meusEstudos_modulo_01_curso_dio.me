namespace modulo_01.sintaxe.Models.Dados
{
    public class DadosPessoais
    {
        public decimal Altura { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Olá, me chamo {Nome} e " + 
            $"tenho {Idade} anos. A minha altura é {Altura}cm.");
        }
    }
}