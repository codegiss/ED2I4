class EmprestimoController {
    public Livros biblioteca;

    public EmprestimoController()
    {
        biblioteca = new Livros();
    }

    public bool addLivro(Livro novo)
    {    
        bool existente = biblioteca.acervo.Any(e => e.isbn == novo.isbn);
        if(existente) return false;

        biblioteca.adicionar(novo);
        return true;
    }

    public Livro pesquisa(Livro achar)
    {
        int index = biblioteca.acervo.FindIndex(e => e.isbn == achar.isbn);
        if(index < 0) return new Livro(0);
        return biblioteca.acervo[index];
    }

    public Livro pesquisarLivroSintetico() {
        return new Livro();
    }

    public Livro pesquisarLivroAnalitico() {
        return new Livro();
    }

    public bool addExemplar(Livro livro, Exemplar exemplar) {
        if(exemplar.tombo <= 0) return false;

        livro.adicionarExemplar(exemplar);
        return true;
    }

    public int verExemplares(Livro livro)
    {
        return livro.exemplares.Count();
    }

    public bool emprestar(Livro livro) {
        // pegar o item emprestimo dentro de exemplar
        // resumindo, uma lista dentro de outra lista
        return false;
    }

    public bool devolver() {
        return false;
    }
}