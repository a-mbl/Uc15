using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Aley";
novaPF.cpf = "3510521455";

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");
// concatenação 
Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
Console.WriteLine($"Bem vindo: {novaPF.nome} de CPF: {novaPF.cpf}");



