class Emprestimo {
    public DateTime dtEmprestimo;
    public DateTime dtDevolucao;
}

class Exemplar {
    public int tombo;
    public List<Emprestimo> emprestimos;

    public Exemplar(int tombo)
    {
        this.tombo = tombo;
        emprestimos = new List<Emprestimo>();
    }

    public bool emprestar()
    {
        return false;
    }

    public bool devolver()
    {
        return false;
    }

    public bool disponivel()
    {
        return false;
    }

    public int qtdEmprestimos()
    {
        return emprestimos.Count();
    }
}

class Livro {
    public int isbn;
    public string titulo;
    public string autor;
    public string editora;
    public List<Exemplar> exemplares;

    public Livro()
    {
        this.isbn = 0;
        titulo = "";
        autor = "";
        editora = "";
        exemplares = new List<Exemplar>();
    }

    public Livro(int isbn)
    {
        this.isbn = isbn;
        titulo = "";
        autor = "";
        editora = "";
        exemplares = new List<Exemplar>();
    }

    public Livro(int isbn, string titulo, string autor, string editora)
    {
        this.isbn = isbn;
        this.titulo = titulo;
        this.autor = autor;
        this.editora = editora;
        exemplares = new List<Exemplar>();
    }

    public void adicionarExemplar(Exemplar exemplar)
    {
        exemplares.Add(exemplar);
    }

    public int qtdExemplares()
    {
        return 0;
    }

    public int qtdDisponiveis()
    {
        return 0;
    }

    public int qtdEmprestimos()
    {
        return 0;
    }

    public double percDisponibilidade()
    {
        return 0;
    }
}

class Livros {
    public List<Livro> acervo = new List<Livro>();

    public List<Livro> Acervo{
        get { return acervo; }
    }

    public void adicionar(Livro livro)
    {
        acervo.Add(livro);
    }

    public Livro pesquisar(Livro livro)
    {
        return livro;
    }
}