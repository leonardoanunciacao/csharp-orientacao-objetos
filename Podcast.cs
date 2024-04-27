class Podcast
{
    private List<Episodio> listaEpisodios = [];
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => listaEpisodios.Count();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodios(Episodio episodio){
        listaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes(){
        System.Console.WriteLine($"\nPodcast {Nome} by {Host}");
        foreach (Episodio episodio in listaEpisodios.OrderBy(e => e.Numero))
        {
            System.Console.WriteLine($"{episodio.Resumo}");
        }
        System.Console.WriteLine($"\n{TotalEpisodios} episódio(s).");
    }
}