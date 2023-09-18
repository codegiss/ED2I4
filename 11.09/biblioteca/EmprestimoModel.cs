class Emprestimo {
    public DateTime dtEmprestimo;
    public DateTime dtDevolucao;

    public Emprestimo(DateTime dtEmprestimo)
    {
        this.dtEmprestimo = dtEmprestimo;
    }
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
        Emprestimo novoEmprestimo = new Emprestimo(DateTime.Now);
        emprestimos.Add(novoEmprestimo);
        return true;
    }

    public bool devolver()
    {
        emprestimos.Last().dtDevolucao = DateTime.Now;
        return true;
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
        return exemplares.Count();
    }

    public int qtdDisponiveis()
    {
        int disponivel = 0;

        foreach(Exemplar exemplar in exemplares){
            if(exemplar.emprestimos.Count == 0) disponivel++;
            else{
                if(exemplar.emprestimos.Last().dtDevolucao != null) disponivel++;
            }
        }

        return disponivel;
    }

    public int qtdEmprestimos()
    {
        int emprestimos = 0;

        foreach(Exemplar exemplar in exemplares){
            emprestimos += exemplar.emprestimos.Count;
        }
        return emprestimos;
    }

    public double percDisponibilidade()
    {
        if(qtdDisponiveis() == 0) return 0;
        return 100 * exemplares.Count / qtdDisponiveis();
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
