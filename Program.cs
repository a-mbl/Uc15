using Back_End_ER.Classes;
using Back_End_ER03.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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
|           1 - Pessoa física                 |
|                                             |
|           2 - Pessoa jurídica               |
|                                             |
|           0 - Sair                          |
===============================================
");


    opcao = Console.ReadLine();

    IEnumerable<PessoaJuridica> listaExibicaoPj = null;
    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            ===============================================
            |                                             |
            |           1 - Cadastrar pessoa física       |
            |                                             |
            |           2 - Listar pessoa física          |
            |                                             |
            |           0 - Voltar ao menu anterior       |
            ===============================================
            ");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":

                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física. Pressione ENTER ao digitar");
                        novaPf.nome = Console.ReadLine();


                        // bool dataValida;
                        // do
                        // {

                        //     Console.WriteLine($"Digite a data de nascimento - dd/mm/aaaa");
                        //     string? dataNasc = Console.ReadLine();

                        //     dataValida = novaPf.ValidarDataNasc(dataNasc);

                        //     if (dataValida)
                        //     {
                        //         DateTime.TryParse(dataNasc, out DateTime dataConvertida);
                        //         novaPf.dataNasc = dataConvertida;
                        //     }
                        //     else
                        //     {

                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Data inválida, insira um valor válido - dd/mm/aaaa");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);

                        //     }

                        // } while (dataValida == false); //repetir laço

                        // Console.WriteLine($"Digite o número de CPF; pressione ENTER ao final");
                        // novaPf.cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o valor do rendimento mensal (somente números)");
                        // novaPf.rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial?   S/N");
                        // String endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPf.endereco = novoEndPf;

                        // listaPf.Add(novaPf);

                        //exemplo 1
                        // StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt);
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();


                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(novaPf.nome);
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cadastro gravado");
                        Console.ResetColor();
                        Thread.Sleep(2000);

                        break;

                    case "2":
                        //                         Console.Clear();
                        //                         if (listaPf.Count > 0)
                        //                         {

                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"

                        // Nome: {cadaPessoa.nome}
                        // Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}, {cadaPessoa.endereco.complemento}
                        // Rendimento: {cadaPessoa.rendimento.ToString("C")}
                        // Imposto a ser pago: {metodosPf.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
                        // CPF: {cadaPessoa.cpf}
                        // Data Nasc.: {cadaPessoa.dataNasc.ToString("C")}

                        // ");                            
                        //                             Console.WriteLine($"Aperte ENTER para continuar");
                        //                             Console.ReadLine();
                        //                             }

                        //                         }
                        //                         else
                        //                         {
                        //                             Console.Clear();
                        //                             Console.ForegroundColor = ConsoleColor.Green;
                        //                             Console.WriteLine($"Lista vazia, cadastre uma nova P.F.");
                        //                             Console.ResetColor();
                        //                             Thread.Sleep(2000); 
                        //                         }

                        using (StreamReader sr = new StreamReader("Aley.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(linha);
                            }
                            Console.WriteLine($"Pressione ENTER para continuar");
                            Console.ReadLine();

                        }

                        break;


                    case "0":

                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida, por favor seleicone uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }



            } while (opcaoPf != "0");




            // novaPF.nome = "Aley";
            // novaPF.cpf = "3510521455";
            // novaPF.rendimento = 6600.5f;
            // novaPF.dataNasc = new DateTime(2001, 12, 04);

            // novaPF.endereco = novoEndPf;

            // Console.WriteLine(@$"

            // Nome: {novaPF.nome}
            // Rendimento: {novaPF.rendimento}
            // CPF: {novaPF.cpf}
            // Logradouro: {novaPF.endereco.logradouro}
            // Número: {novaPF.endereco.numero}");
            // Thread.Sleep(3000);

            // Console.WriteLine($"Aperte ENTER para continuar");
            // Console.ReadLine();

            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.razaoSocial = "Razão Social PJ";
            novaPj.cnpj = "00.476.645/0001-03";
            novaPj.rendimento = 10000.5f;

            novoEndPj.logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Senai Informática";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            metodosPj.Inserir(novaPj);

        //     Console.Clear();
        //     Console.WriteLine(@$"
        // Nome: {novaPj.nome}
        // Razão Social: {novaPj.razaoSocial}
        // CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
        // Endereço: {novaPj.endereco.logradouro}, nº {novaPj.endereco.numero}
        // Complemento: {novaPj.endereco.complemento}
        // ");

        //     Console.WriteLine($"Pressione ENTER para continuar");
        //     Console.ReadLine();

            foreach (PessoaJuridica cadaItem in listaExibicaoPj)
            {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaItem.nome}
Razão social: {cadaItem.razaoSocial}
// CNPJ: {cadaItem.cnpj}
");
                
                Console.WriteLine($"Pressione ENTER apra continuar");
                Console.ReadLine();
                
            }


            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando");
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor insira corretamente");
            Console.ResetColor();
            Thread.Sleep(3000);

            break;
    }



} while (opcao != "0");



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



