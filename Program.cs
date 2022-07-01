using System;

namespace ProjetoRH;

class Program
{
  static void Main(string[] args)
  {
    Secretaria func1 = new Secretaria(8, 1, 5000, 1, "Maria");

    const double taxa = 0.02;
    VA va = new VA("ticket", 450.0, taxa);
    Console.WriteLine($"Valor do cartão: {va.VerificarValorTaxaCartao()}");
  }

}
