using System;

namespace EncontroRemoto
{
  public class PessoaFisica : Pessoa
  {
    public string? cpf { get; set; }

    public DateTime dataNascimento { get; set; }

    // public override void PagarImposto(float salario);

    public bool ValidarDataNascimento(DateTime dataNasc)
    {
      DateTime dataAtual = DateTime.Today;
      double anos = (dataAtual - dataNasc).TotalDays / 365;
      if (anos >= 18)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

}