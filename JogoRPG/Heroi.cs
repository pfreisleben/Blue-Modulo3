using System;
using System.Collections.Generic;

namespace JogoRPG
{
  public class Heroi
  {

    public string Nome
    { get; set; }
    private int _experiencia = 0;

    public int Experiencia
    {
      get => _experiencia;
      set { _experiencia += value; }
    }
    private int _nivel = 1;
    public int Nivel
    {
      get => _nivel;
      set { _nivel += value; }
    }

    private int _vida = 10;
    public int Vida
    {
      get => _vida;
      set { _vida += value; }
    }
    private int _ataqueBase;
    public int ataqueBase
    {
      get => _ataqueBase;
      set { _ataqueBase += value; }
    }

    public void mostrarHeroi()
    {
      Console.WriteLine($"Herói {_nome} criado com sucesso!");
      Console.WriteLine($"Experiência: {_experiencia}.");
      Console.WriteLine($"Nivel: {_nivel}.");
      Console.WriteLine($"Vida: {_vida}.");
      Console.WriteLine($"Ataque base: {_ataqueBase}.");
    }




  }
}
