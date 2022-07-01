using System;
namespace ProjetoRH;

public class FuncionarioHorista : Empregado
{
  public string cnpj { get; set; }

  public double taxa { get; set; }

  public FuncionarioHorista(string cnpj, double taxa, int id, string nome) : base(id, nome)
  {
    this.cnpj = cnpj;
    this.taxa = taxa;
  }

  public void Calculartaxas()
  {
    System.Console.WriteLine("Calculando as taxas");
  }

  public void EmitirNota()
  {
    System.Console.WriteLine("Emitindo nota");

  }
}
