using System;

namespace ProjetoRH;

public class Secretaria : SalarioEmpregado
{
  public int qtdAnosEmpresa { get; set; }
  public Secretaria(int qtdAnosEmpresa, int codigoFuncionario, double valorSalario, int id, string nome) : base(codigoFuncionario, valorSalario, id, nome)
  {
    this.qtdAnosEmpresa = qtdAnosEmpresa;
  }

  public void AtenderCliente()
  {
    System.Console.WriteLine("Atendendo clientes");
  }
  public void RealizarLigacoes()
  {
    System.Console.WriteLine("Ligando");
  }
}