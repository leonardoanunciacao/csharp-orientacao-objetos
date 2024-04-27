// Banda queen = new("Queen");

// Musica loveOfMyLife = new("Love of My Life", queen)
// {
//     Duracao = 204,
//     Disponivel = true
// };

// Musica bohemianRhapsody = new("Bohemian Rhapsody", queen)
// {
//     Duracao = 354,
//     Disponivel = false
// };

// Album aNightAtTheOpera = new("A Night At The Opera", queen);

// aNightAtTheOpera.AdicionaMusica(loveOfMyLife);
// aNightAtTheOpera.AdicionaMusica(bohemianRhapsody);

// queen.AdicionarAlbum(aNightAtTheOpera);

// queen.ExibirDiscografia();
// aNightAtTheOpera.ExibeListaDeMusicas();

// System.Console.WriteLine("\n");
// loveOfMyLife.ExibirFichaTecnica();
// System.Console.WriteLine("\n");
// bohemianRhapsody.ExibirFichaTecnica();

Podcast bbc = new("Aprendendo do sol fa", "Leonardo Almeida");

Episodio episodio1 = new(1, "O que é música?", 5);
episodio1.AdicionarConvidado("Eduardo Almeida");
episodio1.AdicionarConvidado("Thifani Santos");

Episodio episodio2 = new(2, "Música pra quem?", 5);
episodio2.AdicionarConvidado("Artur Santos");
episodio2.AdicionarConvidado("Mariah Clara");

bbc.AdicionarEpisodios(episodio2);
bbc.AdicionarEpisodios(episodio1);
bbc.ExibirDetalhes();