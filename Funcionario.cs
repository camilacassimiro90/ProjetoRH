namespace ProjetoRH;
public class Funcionario
{
  public string nome { get; set; }
  public string id { get; set; }
  public Funcionario(string nome, string id)
  {
    this.nome = nome;
    this.id = id;
  }
}
public class NomeFuncionarioExcecao : Exception
{
  public NomeFuncionarioExcecao()
  {

  }
  public NomeFuncionarioExcecao(string nome) : base(String.Format($"Nome do funcionário invalido: {nome}"))
  {

  }
}

public class IdFuncionarioInvalidoExcecao : Exception
{
  public IdFuncionarioInvalidoExcecao()
  {
  }
  public IdFuncionarioInvalidoExcecao(string id)
  : base(String.Format($"Id do funcionário inválido: {id}"))
  {

  }
}
