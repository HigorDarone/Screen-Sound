
using System.Globalization;

class PodCast
{
    public List<Episodio> episodio=new List<Episodio>();

    public PodCast(string host, string nome) 
    {
        Host = host;
        Nome = nome;
    }    

    public string Host { get; }

    public string Nome { get; }

    public int TotalEpisodios => episodio.Count;

  



    public void AdicionarEpisodio(Episodio ep)
    {
        episodio.Add(ep);   
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nPodcast {Nome} apresentado por {Host}\n" );

        foreach(var ep in episodio.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios}. episodios\n");
    }

}