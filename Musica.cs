class Musica
{
    public Musica(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
    }
    public string Nome { get; }
    public Banda Banda { get; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Banda.Nome}";

    public void ExibirFichaTecnica()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Banda: {Banda.Nome}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            System.Console.WriteLine($"Disponível no plano.");
        } else
        {
            System.Console.WriteLine($"Adquira o plano Plus.");
        }
        System.Console.WriteLine(DescricaoResumida);
    }
}