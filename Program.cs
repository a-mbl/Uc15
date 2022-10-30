using Back_End_ER03.Classes;

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

DateTime temp = new DateTime(2005, 01, 01);
Console.WriteLine(novaPF.ValidarDataNasc("04/12/2001"));



