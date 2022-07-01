using System;
namespace ProjetoRH;

public class SalarioEmpregado : Empregado
{
  public int codigoFuncionario { get; set; }
  public double valorSalario { get; set; }

  public SalarioEmpregado(int codigoFuncionario, double valorSalario, int id, string nome) : base(id, nome)
  {
    this.codigoFuncionario = codigoFuncionario;
    this.valorSalario = valorSalario;
  }
  public void CalcularFolhaPagamento()
  {
    System.Console.WriteLine("Calculando folha de pagamento");
  }

}