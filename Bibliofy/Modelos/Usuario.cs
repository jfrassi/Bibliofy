class Usuario {
    public int Codigo { get; set; }
    public string NomeUsu { get; set; }
    public int Idade { get; set; }
    List<Livro> LivrosEmprestados = new();
}