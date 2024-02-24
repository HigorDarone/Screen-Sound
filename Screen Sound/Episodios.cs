class Episodio
{
    public List<string> convidados = new();

    public Episodio(string titulo, int ordem, int duracao) 
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public int Ordem { get; }

    public int Duracao { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public string Titulo { get; }


     public void AdicionarConvidado(string convidado)
    {

        convidados.Add(convidado);
    }


    
}