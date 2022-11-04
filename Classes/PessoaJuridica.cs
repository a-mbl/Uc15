using System.Text.RegularExpressions;
using Back_End_ER.Classes;
using Back_End_ER02.Interfaces;

namespace Back_End_ER03.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public string caminho { get; private set;} = "Database/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f;
                
            } else if (rendimento > 3000 && rendimento <= 6000)
            {

                return rendimento * 0.05f;

            } else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * 0.07f;

            } else
            {
                return rendimento * 0.09f;
            }
        }

        //XX.XXX.XXX/0001-XX ----- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {

            // = Atribução
            // == Comparação
            // === Comparação exata 
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            // if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }


                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public void Inserir (PessoaJuridica pj) {
            Utils.VerificarPastaArquivo(caminho);
            string[] pjValores = {$"{pj.nome},{pj.cnpj},{pj.razaoSocial}"};
            File.AppendAllLines(caminho, pjValores);
        }

        public List<PessoaJuridica> LerArquivo(){
            
            List<PessoaJuridica> listPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                //   0     1      2
                // xxxx , wwww , zzzz
            
            PessoaJuridica CadaPj = new PessoaJuridica();

            CadaPj.nome = atributos[0];
            CadaPj.cnpj = atributos[1];
            CadaPj.razaoSocial = atributos[2];

            listPj.Add(CadaPj);
            
            } 

            return listPj;

        }
    }
}


