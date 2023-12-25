using modulo_01.sintaxe.Models.Dados;

DadosPessoais dadosPessoais = new()
{
    Nome = "Lucas",
    Idade = 18,
    Altura = 1.75M
};
dadosPessoais.Apresentar();