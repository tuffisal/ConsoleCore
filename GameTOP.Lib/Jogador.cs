
namespace GameTOP
{
  public interface IJogador
  {
    string Chuta();
    string Corre();
    string Passe();
  }


  public class Jogador1 : IJogador
  {
    public readonly string _Nome;

    public Jogador1(string nomeJogador = "Ronaldo")
    {
      _Nome = nomeJogador;
    }

    public string Chuta()
    {
      return $"{_Nome} está chutando";
    }

    public string Corre()
    {
      return $"{_Nome} está correndo";
    }

    public string Passe()
    {
      return $"{_Nome} está passando";
    }
  }

  public class Jogador2 : IJogador
  {
    public string Chuta()
    {
        return "Maradona estas pateando";        
    }

    public string Corre()
    {
        return "Maradona estas corriendo";        
    }

    public string Passe()
    {
        return "Maradona estas pasando";        
    }
  }
}