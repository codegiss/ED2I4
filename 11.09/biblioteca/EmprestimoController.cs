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

    public string pesquisarLivroSintetico(Livro livro) {
        string pesqSintetica = "";
        int index = biblioteca.acervo.FindIndex(e => e.isbn == livro.isbn);

        if(index<0) return "Livro inexistente.";
        else
        {
            pesqSintetica += "\nTotal de exemplares: " + livro.exemplares.Count +
                             "\nExemplares disponíveis: " + livro.qtdDisponiveis() +
                             "\nTotal de empréstimos: " + livro.qtdEmprestimos() +
                             "\nDisponibilidade: " + livro.percDisponibilidade() +
                             "%";
        }
        return pesqSintetica;
    }

    public string pesquisarLivroAnalitico(Livro livro) {
        string pesquisa = pesquisarLivroSintetico(livro);

        if(pesquisa == "Livro inexistente.") return pesquisa;

        pesquisa += "\n";

        foreach(Exemplar exemplar in livro.exemplares)
        {
            pesquisa += "\nTombo: " + exemplar.tombo;
            
            foreach(Emprestimo emprestimos in exemplar.emprestimos)
            {
                pesquisa += "\nData de empréstimo: " + emprestimos.dtEmprestimo;

                if(emprestimos.dtDevolucao != null)
                    pesquisa += "\nData de devolução: " + emprestimos.dtDevolucao;
                pesquisa += "\n";
            }
        }

        return pesquisa;
    }

    public bool addExemplar(Livro livro, Exemplar exemplar) {
        if(exemplar.tombo <= 0) return false;

        livro.adicionarExemplar(exemplar);
        return true;
    }

    public bool verExemplar(Exemplar exemplar)
    {
        if(exemplar.emprestimos.Count == 0) return true;
        if(exemplar.emprestimos.Last().dtDevolucao != null) return true;
        return false;
    }

    public bool emprestar(Livro livro) {
        if (livro.qtdDisponiveis()<1) return false;
        
        foreach(Exemplar exemplar in livro.exemplares)
        {
            if(verExemplar(exemplar))
            {
                return exemplar.emprestar();
            }
        }
        return false;
    }

    public bool devolver(Livro livro, int tombo) {
        int index;

        foreach(Exemplar exemplar in livro.exemplares)
        {
            index = livro.exemplares.FindIndex(e => e.tombo == exemplar.tombo);
            if(index < 0)
            {
                livro.exemplares[index].devolver();
                return true;
            }
        }
        return false;
    }
}
