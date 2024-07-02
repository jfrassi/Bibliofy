class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateOnly DataPublicacao { get; set; }
    public enum Disponibilidade { 
        Disponivel,
        Emprestado,
        Reservado
     }
}