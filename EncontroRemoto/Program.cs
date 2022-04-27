using System;
using System.Threading;

namespace EncontroRemoto
{
  class Program
  {
    static void Main(string[] args)
    {
      // List<PessoaFisica> listaPf = new List<PessoaFisica>();

      void BarraCarregamento(string textoCarregamento)
      {
        Console.ResetColor();
        Console.Write(textoCarregamento);
        Thread.Sleep(500);
        //Console.ForegroundColor = ConsoleColor.DarkRed;

        for (var contador = 0; contador < 10; contador++)
        {
          Console.Write(".");
          Thread.Sleep(500);

        }
        Console.ResetColor();
      }

      Console.Clear();
      //Console.ForegroundColor = ConsoleColor.Blue;
      //Console.BackgroundColor = ConsoleColor.Green;
      Console.WriteLine(@$"
      ****************************************************************
      *               Bem vindo ao sistema de cadastro de            *
      *               pessoa fisica e juridica                       *
      ****************************************************************
      ");
      BarraCarregamento("Iniciando");


      string? opcao;

      do
      {
        Console.WriteLine(@$"
      ****************************************************************
      *               Escolha uma das opções abaixo                  *
      ****************************************************************
      *                     PESSOA FÍSICA                            *
      *               1 - Cadastrar Pessoa Física                    *
      *               2 - Listar Pessoa Físisca                      *
      *               3 - Remover Pessoa Físisca                     *
      *                                                              *
      *                     PESSOA JURÍDICA                          *
      *               4 - Cadastrar Pessoa Jurídica                  *
      *               5 - Listar Pessoa Jurídica                     *
      *               6 - Remover Pessoa Jurídica                    *
      *                                                              *
      *               0 - Sair                                       *
      ****************************************************************
      ");

        opcao = Console.ReadLine();

        switch (opcao)
        {
          case "1":
            
            Endereco endPf = new Endereco();
            
            Console.WriteLine($"Digite seu Logradouro");                
            endPf.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o Numero");
            endPf.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Complemento (Pressione ENTER para vazio)");
            endPf.complemento = Console.ReadLine();

            Console.WriteLine($"Este endereço é comercial? S/N");
            string enderecoComercial = Console.ReadLine().ToUpper();

            if (enderecoComercial == "S" )
            {
              endPf.enderecoComercial = true;
            }
            else{
              endPf.enderecoComercial = false;
            }

            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = endPf;

            // Console.WriteLine($"Digite seu CPF (somente números)");
            // novapf.cpf = Console.ReadLine();

            Console.WriteLine($"Digite seu Nome");
            novapf.nome = Console.ReadLine();

            // Console.WriteLine($"Digite o valor do seu rendimento mensal");
            // novapf.rendimento = float.Parse(Console.ReadLine());

            // Console.WriteLine($"Digite sua data de nascimento [AAAA,MM,DD");
            // novapf.dataNascimento = DateTime.Parse(Console.ReadLine());     

           // Console.WriteLine($"Rua: {novapf.endereco.logradouro},{novapf.endereco.numero}");
            //Console.WriteLine(novapf.ValidarDataNascimento(novapf.dataNascimento));

            bool idadeValida = novapf.ValidarDataNascimento(novapf.dataNascimento);
            //Console.WriteLine(idadeValida);
            // if (idadeValida == true)
            // {
            //   Console.WriteLine($"Cadastro Aprovado");
            //   listaPf.Add(novapf);
            //   Console.WriteLine(novapf.PagarImposto(novapf.rendimento));
            // }
            // else
            // {
            //   Console.WriteLine($"Cadastro Reprovado");
            // }

            // using(StreamWriter sw = new StreamWriter($"{novapf.nome}.txt")){
            // sw.Write($"{novapf.nome}");
            // };


           // Console.WriteLine(novapf.PagarImposto(novapf.rendimento));
            break;

          case "2":
          using(StreamReader sr = new StreamReader("Odirlei.txt"))
          {
            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
              Console.WriteLine($"{linha}");
            }
          }
          Console.WriteLine($"Aperte enter para continuar");
          Console.ReadLine();

          // foreach (var cadaItem in listaPf)
          // {
          //   Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}, {cadaItem.endereco.logradouro}");
          // }

            // if (pj.ValidarCNPJ(pj.cnpj))
            // {
            //   Console.WriteLine("CNPJ válido");
            // }
            // else
            // {
            //   Console.WriteLine($"CNPJ invalido");
            // }

            // Console.WriteLine(pj.PagarImposto(pj.rendimento));
            break;

          case "3":
          Console.WriteLine("Digite o CPF do meliante que deseja excluir do sistema");
          string cpfProcurado = Console.ReadLine();

          // PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

          // if (pessoaEncontrada != null){
          //   listaPf.Remove(pessoaEncontrada);
          //   Console.WriteLine($"Cadastro Removido");
          // }else{
          //   Console.WriteLine($"CPF não encontrado");
          // }

          break;

          case "0":
            Console.WriteLine(@$"
      ****************************************************************
      *           Obrigado por utilizar o nosso sistema! S2          *
      ****************************************************************
      ");
            BarraCarregamento("Finalizando");
            BarraCarregamento("aburulumbumbabu");
            break;

          default:
            Console.WriteLine("Opção invaida, digite uma opção valida");
            break;
        }

      } while (opcao != "0");

    }
  }
}
