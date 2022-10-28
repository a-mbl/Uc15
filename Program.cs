using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Aley";
novaPF.cpf = "3510521455";
novaPF.rendimento = 6600.5f;

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");.

// concatenação 
//Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
//Console.WriteLine($"Bem vindo: {novaPF.nome} de CPF: {novaPF.cpf}");

// Pessoa física
float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
Console.WriteLine($"{impostaPagar:0.00}");
Console.WriteLine(impostaPagar.ToString("C2"));

// Pessoa juridica
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));



