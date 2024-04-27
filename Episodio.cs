class Episodio
{
    private List<string> listaConvidados = [];
    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => 
    $"{Numero}. {Titulo} - {Duracao} min.\n Convidado(s): {string.Join(", ", listaConvidados)}";

    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidado(string convidado){
        listaConvidados.Add(convidado);
    }

    public void ExibirResumo(){
        System.Console.WriteLine($"{Resumo}");
    }
}