class Biblioteca {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    List<Livro> LivrosAlocados = new();
    List<Usuario> ListaUsuarios = new();
}