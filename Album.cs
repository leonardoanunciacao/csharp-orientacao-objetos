class Album {

    public Album(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
    }
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; }
    public Banda Banda { get; }
    public double DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public void AdicionaMusica(Musica musica){
        listaDeMusicas.Add(musica);
    }

    public void ExibeListaDeMusicas(){
        System.Console.WriteLine($"\nMúsicas do álbum {Nome}: ");
        foreach (Musica musica in listaDeMusicas){
            System.Console.WriteLine($"{musica.Nome} ({musica.Duracao/60} min.)");
        }
    }
}