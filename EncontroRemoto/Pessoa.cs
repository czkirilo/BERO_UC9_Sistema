using System;

namespace EncontroRemoto
{
  public abstract class Pessoa
  {
    public string? nome { get; set; }
    public Endereco endereco { get; set; }
    // public abstract void PagarImposto();
  }
}