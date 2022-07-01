using System;

namespace ProjetoRH;

public class Empregado
{
  public int id { get; set; }
  public string nome { get; set; }
  public Empregado(int id, string nome)
  {
    this.id = id;
    this.nome = nome;
  }

  public void Trabalhar()
  {
    System.Console.WriteLine("Trabalhando");
  }

  public void irEmbora()
  {
    System.Console.WriteLine("Saindo do trabalho");
  }

  public void tirarFolga()
  {
    System.Console.WriteLine("Folgando");
  }
}