using System;
using System.Threading;

namespace EncontroRemoto
{
  class Program
  {
    static void Main(string[] args)
    {

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
      *               1 - Pessoa Física                              *
      *               2 - Pessoa Juridica                            *
      *                                                              *
      *               0 - Sair                                       *
      ****************************************************************
      ");

        opcao = Console.ReadLine();

        switch (opcao)
        {
          case "1":
            Endereco endPf = new Endereco();
            endPf.logradouro = "Rua X";
            endPf.numero = 100;
            endPf.complemento = "proximo ao senai";
            endPf.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFisica();
            novapf.endereco = endPf;
            novapf.cpf = "123456789";
            novapf.rendimento = 1500;
            novapf.dataNascimento = new DateTime(1994, 05, 19);
            novapf.nome = "Pessoa Fisica";

            Console.WriteLine($"Rua: {novapf.endereco.logradouro},{novapf.endereco.numero}");


            //Console.WriteLine(novapf.ValidarDataNascimento(novapf.dataNascimento));

            bool idadeValida = novapf.ValidarDataNascimento(novapf.dataNascimento);
            //Console.WriteLine(idadeValida);
            if (idadeValida == true)
            {
              Console.WriteLine($"Cadastro Aprovado");
            }
            else
            {
              Console.WriteLine($"Cadastro Reprovado");
            }


            Console.WriteLine(novapf.PagarImposto(novapf.rendimento));
            break;

          case "2":
            Endereco endPj = new Endereco();
            endPj.logradouro = "Rua Y";
            endPj.numero = 200;
            endPj.complemento = "proximo ao senai";
            endPj.enderecoComercial = true;
            PessoaJuridica pj = new PessoaJuridica();

            pj.endereco = endPj;
            pj.cnpj = "1234567890001";
            pj.razaoSocial = "Pessoa Juridica";
            pj.rendimento = 8000;

            if (pj.ValidarCNPJ(pj.cnpj))
            {
              Console.WriteLine("CNPJ válido");
            }
            else
            {
              Console.WriteLine($"CNPJ invalido");
            }

            Console.WriteLine(pj.PagarImposto(pj.rendimento));
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
