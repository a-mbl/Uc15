using Back_End_ER.Classes;
using Back_End_ER03.Classes;

Utils.BarraCarregamento("Carregando");

string? opcao;
do
{
Console.Clear();
Console.WriteLine(@$"
===============================================
|        Bem-vindo ao Sistema de Cadastro     |
|            Pessoa física & jurídica         |
===============================================
|                                             |
|           1 Pessoa física                   |
|                                             |
|           2 Pessoa jurídica                 |
|                                             |
|           0 Sair                            |
===============================================
");


opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine($"Pessoa física");
        PessoaFisica novaPF = new PessoaFisica();
        Endereco novoEndPf = new Endereco();

        novaPF.nome = "Aley";
        novaPF.cpf = "3510521455";
        novaPF.rendimento = 6600.5f;
        novaPF.dataNasc = new DateTime(2001, 12, 04);


        novoEndPf.logradouro = "Rua Niteroi";
        novoEndPf.numero  = 180;
        novoEndPf.complemento = "Escola Senai";
        novoEndPf.endComercial = true;

        novaPF.endereco = novoEndPf;

        Console.WriteLine(@$"

        Nome: {novaPF.nome}
        Rendimento: {novaPF.rendimento}
        CPF: {novaPF.cpf}
        Logradouro: {novaPF.endereco.logradouro}
        Número: {novaPF.endereco.numero}");
        Thread.Sleep(3000);
        break;

    case "2":
        Console.WriteLine($"Pessoa jurídica");
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Nome Pj";
        novaPj.razaoSocial = "Razão Social PJ";
        novaPj.cnpj = "00.476.645/0001-03";

        novoEndPj.logradouro = "Rua Niteroi";
        novoEndPj.numero = 180;

        novaPj.endereco = novoEndPj;

        Console.WriteLine(@$"
        Nome: {novaPj.nome}
        Razão Social: {novaPj.razaoSocial}
        CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
        ");
        Console.WriteLine($"Insira ENTER para sair");
        Console.ReadLine();
        break;

    case "0":
        Console.WriteLine($"Finalizado");
        
        break;

    default:
        Console.WriteLine($"Opção Inválida");
        
        break;
}


    
} while (opcao !="0");

Utils.BarraCarregamento("Finalizando");




// Thread.Sleep(4000);
// Console.Clear();


// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");.

// concatenação 
//Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
//Console.WriteLine($"Bem vindo: {novaPF.nome} de CPF: {novaPF.cpf}");

// Pessoa física =================================
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C2"));

// Pessoa juridica =======================================
// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// ------------------------------------------------------------------
// var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
// Console.WriteLine(date1);

// DateTime date3 = DateTime.Today;
// Console.WriteLine(date3);

// DateTime temp = new DateTime(2005, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("04/12/2001"));



