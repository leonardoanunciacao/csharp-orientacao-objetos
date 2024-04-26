Banda queen = new("Queen");

Musica loveOfMyLife = new("Love of My Life", queen)
{
    Duracao = 204,
    Disponivel = true
};

Musica bohemianRhapsody = new("Bohemian Rhapsody", queen)
{
    Duracao = 354,
    Disponivel = false
};

Album aNightAtTheOpera = new("A Night At The Opera", queen);

aNightAtTheOpera.AdicionaMusica(loveOfMyLife);
aNightAtTheOpera.AdicionaMusica(bohemianRhapsody);

queen.AdicionarAlbum(aNightAtTheOpera);

queen.ExibirDiscografia();
aNightAtTheOpera.ExibeListaDeMusicas();

System.Console.WriteLine("\n");
loveOfMyLife.ExibirFichaTecnica();
System.Console.WriteLine("\n");
bohemianRhapsody.ExibirFichaTecnica();