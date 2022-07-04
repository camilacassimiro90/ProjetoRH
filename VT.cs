using System;

namespace ProjetoRH;
public class VT : Cartao
{
  public VT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
  {

  }
  public override double VerificarValorTaxaCartao()
  {
    const double taxaVA = 0.04;
    return base.saldo * taxaVA;
  }
}