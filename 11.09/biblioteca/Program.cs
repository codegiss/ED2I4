int resp = 0;
int isbn, tombo;
string titulo, autor, editora;
EmprestimoController emprestimoController = new EmprestimoController();

do
{
    do
    {
        Console.WriteLine("0. Sair");
        Console.WriteLine("1. Adicionar livro");
        Console.WriteLine("2. Pesquisar livro (sintético)");
        Console.WriteLine("3. Pesquisar livro (analítico)");
        Console.WriteLine("4. Adicionar exemplar");
        Console.WriteLine("5. Registrar empréstimo");
        Console.WriteLine("6. Registrar devolução");
        Console.Write("Opção selecionada: ");
        resp = int.Parse(Console.ReadLine());
    }
    while (resp < 0 || resp > 6);

    switch(resp)
    {
        case 0:
            break;
        case 1:
            do{
                Console.Write("Qual o ISBN do livro? ");
                isbn = int.Parse(Console.ReadLine());
            } while (isbn <= 0);
            
            do{
                Console.Write("Qual o título do livro? ");
                titulo = Console.ReadLine();
            } while(titulo == null);
            
            do{
                Console.Write("Qual o nome do autor do livro? ");
                autor = Console.ReadLine();
            } while(autor == null);
            
            do{
                Console.Write("Qual a editora do livro? ");
                editora = Console.ReadLine();
            } while(editora == null);

            Livro novoLivro = new Livro(isbn, titulo, autor, editora);

            Console.WriteLine(emprestimoController.addLivro(novoLivro)? "Livro adicionado." : "Livro não adicionado. ISBN já existente.");
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            do{
                Console.Write("Digite o número do ISBN: ");
                isbn = int.Parse(Console.ReadLine());
            } while (isbn <= 0);

            Livro novoExemplar = emprestimoController.pesquisa(new Livro(isbn));

            if(novoExemplar.isbn != 0)
            {
                do
                {
                    Console.Write("Digite o número do tombo: ");
                    tombo = int.Parse(Console.ReadLine());
                } while (tombo <= 0);

                Exemplar novo = new Exemplar(tombo);

                Console.WriteLine(emprestimoController.addExemplar(novoExemplar, novo)? "adicionou" : "nao funfou");
            }
            else
            {
                Console.WriteLine("Livro inexistente. Verifique o ISBN.");
            }
            break;
        case 5:
            do
            {
                Console.Write("Digite o número do ISBN: ");
                isbn = int.Parse(Console.ReadLine());
            } while (isbn <= 0);

            Livro emprestar = emprestimoController.pesquisa(new Livro(isbn));

            if(emprestar.isbn != 0)
            {
                int qtdExemplares = emprestimoController.verExemplares(emprestar);
                Console.WriteLine(qtdExemplares);

                if(qtdExemplares > 0)
                {
                    emprestimoController.emprestar(emprestar);
                }
            }
            else
            {
                Console.WriteLine("Livro não existente.");
            }
            break;
        case 6:
            break;
        default:
            resp = -1;
            break;
    }
}
while (resp!=0);