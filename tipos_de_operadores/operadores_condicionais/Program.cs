// int quantidadeEmEstoque = 7;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar à venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso.");
// }
// else
// {
//     Console.WriteLine($"Desculpe. Só temos {quantidadeEmEstoque} em estoque.");
// }

Console.WriteLine("Digite uma letra");

string letra  = Console.ReadLine();

switch (letra)
{
    case "a":
    case "A":
    case "e":
    case "E":
    case "i":
    case "I":
    case "o":
    case "O":
    case "u":
    case "U":
    Console.WriteLine("É uma vogal");
    break;

    default:
    Console.WriteLine("Não é uma vogal");
    break;
}