using System;

namespace EncontroRemoto
{
  class Program
  {
    static void Main(string[] args)
    {



      Endereco end = new Endereco();
      end.logradouro = "Rua X";
      end.numero = 100;
      end.complemento = "proximo ao senai";
      end.enderecoComercial = false;

      PessoaJuridica pj = new PessoaJuridica();

      pj.endereco = end;
      pj.cnpj = "1234567890001";
      pj.razaoSocial = "Pessoa Juridica";

      if (pj.ValidarCNPJ(pj.cnpj))
      {
        Console.WriteLine("CNPJ válido");
      }
      else
      {
        Console.WriteLine($"CNPJ invalido");
      }

      PessoaFisica novapf = new PessoaFisica();
      novapf.endereco = end;
      novapf.cpf = "123456789";
      novapf.dataNascimento = new DateTime(1994, 05, 19);
      novapf.nome = "Pessoa Fisica";


      // Console.WriteLine(novapf.endereco.logradouro);
      // Console.WriteLine(novapf.endereco.numero);
      // Console.WriteLine(novapf.endereco.complemento);

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




    }
  }
}
