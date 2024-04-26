class Banda{

    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> discografia = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album){
        discografia.Add(album);
    }

    public void ExibirDiscografia(){
        System.Console.WriteLine($"Discografia da banda {Nome}: ");
        foreach (Album album in discografia)
        {
            System.Console.WriteLine($"{album.Nome} ({album.DuracaoTotal/60} min.)");
        }
    }

}