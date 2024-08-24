using DotNet_1RST_Project.Models;

Pessoa pessoa1 = new(); // camelCase ex: pessoaFisica
VarTypes varTypes = new(); 
DateTimeUse dateTimeUse = new(); 

void DateTimeHowToUse(){
    dateTimeUse.DateNow(); // mostra data de agora (PC Time)
    dateTimeUse.DateGMT0(); // mostra data GMT-0 (no meu caso é GMT-3)
    dateTimeUse.OnlyDate(); // mostra somente data
    dateTimeUse.OnlyTime(); // mostra somente horas
}

void ConvertTypes(){
    int string5 = int.Parse("5");
    int string6 = Convert.ToInt32("5");
    int stringNull = Convert.ToInt32(null); // 0

    Console.WriteLine($"string5: {string5}");
    Console.WriteLine($"string6: {string6}");
    Console.WriteLine($"stringNull: {stringNull}");

    int inteiro = 5;
    string a = inteiro.ToString();
    Console.WriteLine($"inteiro.toString(): {a}");

    // Implicity cast
    int b = 5;
    double c = b; // = 5
    Console.WriteLine($"c: {c}");

    // tryParse
    string d = "15-";
    int e = 0;

    int.TryParse(d, out e); // if can convert 'd', values pass to 'e'
    Console.WriteLine(e);
    Console.WriteLine("Conversão realizada!");

}

void switchCase(){
    Console.WriteLine("Digite uma vogal:");
    string? letra = Console.ReadLine();

    switch(letra)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("Vogal");
            break;
        default:
            Console.WriteLine("Não é uma vogal");
            break;

    }

}

void tabuadaX(){
    Console.WriteLine("Digite o numero da tabuada:");
    string? x = Console.ReadLine();
    int defaultNumber = 0;
    int.TryParse(x, out defaultNumber); 
    for (int i = 0; i <= 10; i++) // index
    {
        Console.WriteLine($"{defaultNumber} x {i} = {defaultNumber * i}");
    }
}

void doWhile(){
    int soma = 0, numero = 0;
    do
    {
        Console.WriteLine("Digite um numero (0 para parar)");
        numero = Convert.ToInt32(Console.ReadLine());

        soma += numero;
    } while (numero != 0);

    Console.WriteLine($"Total da soma dos numeros digitados é {soma}");
}

void menu(){
    string opcao;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção");
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
                Console.WriteLine("Deletar de cliente");
                break;
            case "4":
                Console.WriteLine("Encerrar");
                Environment.Exit(0); // exit of while true
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }
}

DateTimeHowToUse();
ConvertTypes();
switchCase();
tabuadaX();
doWhile();
menu();

// void UsarVarTypes(){
//     varTypes.Altura = 1.80; // double
//     varTypes.Quantidade = 1; // int
//     varTypes.Condicao = true; // bool
//     varTypes.Preco = 180M; // decimal
//     varTypes.Apresentacao = $"A Altura é {varTypes.Altura}; "+ 
//     $"Quantidade é {varTypes.Quantidade}; Condição igual á {varTypes.Condicao}; "+
//     $"Preço igual á {varTypes.Preco};"; // string
//     varTypes.Apresentar();
// }

// UsarVarTypes();


// void ApresentarPessoa(){
//     pessoa1.Nome = "Gustavo";
//     pessoa1.Sobrenome = "Gonçalves";
//     pessoa1.Idade = 21;

//     pessoa1.Apresentar();
// }

// ApresentarPessoa();
