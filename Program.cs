using System;
using System.Text.RegularExpressions;

namespace ProjetoRH;
class Program
{
  static void Main(string[] args)
  {
    Secretaria func1 = new Secretaria(8, 1, 5000, 1, "Maria");

    const double taxa = 0.02;
    VA va = new VA("ticket", 450.0, taxa);
    Console.WriteLine($"Valor do cartão: {va.VerificarValorTaxaCartao()}");

    Funcionario objFuncionario = new Funcionario("Camila", "1");

    try
    {
      ValidarNomeFuncionario(objFuncionario);
      ValidarIdFuncionario(objFuncionario);
      VerificarObjFuncionarioEhNull(objFuncionario);
    }
    catch (Exception ex)
    {
      System.Console.WriteLine($"Falha:  {ex.Message}");

    }
  }
  public static void VerificarObjFuncionarioEhNull(Funcionario objFuncionario)
  {
    if (objFuncionario == null)
    {
      throw new NullReferenceException("Valor nulo! Favor informar um valor");
    }

    System.Console.WriteLine($"O nome do funcionário é: {objFuncionario.nome} e seu ID é: {objFuncionario.id}");
  }

  public static void ValidarNomeFuncionario(Funcionario objFuncionario)
  {
    Regex regex = new Regex("^[a-zA-Z]+$");
    if (!regex.IsMatch(objFuncionario.nome))
    {
      throw new NomeFuncionarioExcecao(objFuncionario.nome);
    }
  }

  public static void ValidarIdFuncionario(Funcionario objFuncionario)
  {
    Regex regex = new Regex("^[0-9]+$");
    if (!regex.IsMatch(objFuncionario.id))
    {
      throw new IdFuncionarioInvalidoExcecao(objFuncionario.nome);
    }
  }

  // ex 03
  // Cartao cartao = va;
  // if (cartao is VA)
  // {
  //   VA cartaoDowncasting = (VA)cartao;
  //   Console.WriteLine("Downcasting de Cartão para VA (cartão)");
  // }
  // else
  // {
  //   Console.WriteLine("Falha no Downcasting");
  // }
}

// }
