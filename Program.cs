using DotNet_1RST_Project.Models;

Pessoa pessoa1 = new(); // camelCase ex: pessoaFisica
VarTypes varTypes = new(); // camelCase ex: pessoaFisica

void UsarVarTypes(){
    varTypes.Altura = 1.80; // double
    varTypes.Quantidade = 1; // int
    varTypes.Condicao = true; // bool
    varTypes.Preco = 180M; // decimal
    varTypes.Apresentacao = $"A Altura é {varTypes.Altura}; "+ 
    $"Quantidade é {varTypes.Quantidade}; Condição igual á {varTypes.Condicao}; "+
    $"Preço igual á {varTypes.Preco};"; // string
    varTypes.Apresentar();
}

UsarVarTypes();


// void ApresentarPessoa(){
//     pessoa1.Nome = "Gustavo";
//     pessoa1.Sobrenome = "Gonçalves";
//     pessoa1.Idade = 21;

//     pessoa1.Apresentar();
// }

// ApresentarPessoa();
