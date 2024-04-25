// Instanciar objeto do tipo Album
Album aNightAtTheOpera = new Album();

// Atribuir valores para propriedades de aNightAtTheOpera
aNightAtTheOpera.Nome = "A night at the opera";
aNightAtTheOpera.Artista = "Queen";

// Instanciar objetos do tipo Musica
Musica loveOfMyLife = new Musica();
Musica bohemianRhapsody = new Musica();

// Atribuir valores para as propriedades dos objetos do tipo Musica.
loveOfMyLife.Nome = "Love of My Life";
loveOfMyLife.Duracao = 213;
bohemianRhapsody.Nome = "Bohemian Rhapsody";
bohemianRhapsody.Duracao = 354;
;
// Adicionar objeto do tipo Musica à lista de músicas do objeto do tipo Album
aNightAtTheOpera.AdicionaMusica(loveOfMyLife);
aNightAtTheOpera.AdicionaMusica(bohemianRhapsody);

aNightAtTheOpera.ExibeListaDeMusicas();