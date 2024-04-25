class Album {
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; set; }
    public string Artista { get; set; }
    public double DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public void AdicionaMusica(Musica musica){
        listaDeMusicas.Add(musica);
    }

    public void ExibeListaDeMusicas(){
        int count = 1;
        System.Console.WriteLine($"Álbum: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}\n");
        foreach (Musica musica in listaDeMusicas){
            System.Console.WriteLine($"Faixa {count}: {musica.Nome} - {musica.Duracao/60} min.");
            count ++;
        }
        System.Console.WriteLine($"\nDuração total: {DuracaoTotal/60} min.");
    }
}