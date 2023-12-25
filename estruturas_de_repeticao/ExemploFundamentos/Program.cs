string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("Digite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Enviornment.exit(0)
            break;

            default:
                Console.WriteLine("Opção inválida");
                break;
    }
}

Console.WriteLine("O programa foi encerrado");
































// FOR

// int numero = 7;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }

// WHILE

// int numero = 7;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 8)
//     {
//         break;
//     }
// }

// DO WHILE

// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite um número, 0 para parar");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// }while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitado é: {soma}");