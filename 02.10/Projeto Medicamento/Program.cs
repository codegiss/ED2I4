int resp = -1, id = 0, dia = 0, mes = 0, ano = 0, qtd = 0;
string nome, lab;
Medicamentos listaRemedios = new Medicamentos();
Medicamento pesquisa, resultado;

do
{
    do
    {
        Console.WriteLine("0. Finalizar processo");
        Console.WriteLine("1. Cadastrar medicamento");
        Console.WriteLine("2. Consultar medicamento (sintético)");
        Console.WriteLine("3. Consultar medicamento (analítico)");
        Console.WriteLine("4. Comprar medicamento");
        Console.WriteLine("5. Vender medicamento");
        Console.WriteLine("6. Listar medicamentos");

        try
        {
            resp = int.Parse(Console.ReadLine());
        }
        catch (Exception e) { }
    }
    while (resp < 0 || resp > 6);

    switch (resp)
    {
        case 1:
            Console.Write("Digite o nome do medicamento: ");
            nome = Console.ReadLine();
            Console.Write("Digite o laboratório do medicamento: ");
            lab = Console.ReadLine();

            listaRemedios.adicionar(new Medicamento(1, nome, lab));
            Console.WriteLine("Medicamento adicionado com sucesso.");
            break;
        case 2:
            do
            {
                try
                {
                    Console.Write("Digite o ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {}
            }
            while (id < 0);

            pesquisa = new Medicamento(id, "", "");
            resultado = listaRemedios.pesquisar(pesquisa);

            Console.WriteLine(resultado.toString());
            break;
        case 3:
            do
            {
                try
                {
                    Console.Write("Digite o ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception e) { }
            }
            while (id < 0);

            pesquisa = new Medicamento(id, "", "");
            resultado = listaRemedios.pesquisar(pesquisa);

            Console.WriteLine(resultado.toString());
            Console.WriteLine(resultado.mostrarLotes());
            break;
        case 4:
            do
            {
                try
                {
                    Console.Write("Digite o ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception e) { }
            }
            while (id < 0);

            pesquisa = new Medicamento(id, "", "");
            resultado = listaRemedios.pesquisar(pesquisa);
            
            if(resultado.Id != -1)
            {
                do
                {
                    try
                    {
                        Console.Write("Digite a quantidade a ser comprada: ");
                        qtd = int.Parse(Console.ReadLine());
                    } catch (Exception e) {}
                } while (qtd <= 0);

                do
                {
                    try
                    {
                        Console.Write("Digite o dia de vencimento: ");
                        dia = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) { }
                } while (dia <= 0);

                do
                {
                    try
                    {
                        Console.Write("Digite o mês de vencimento: ");
                        mes = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) { }
                } while (mes <= 0);

                do
                {
                    try
                    {
                        Console.Write("Digite o ano de vencimento: ");
                        ano = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) { }
                } while (ano <= 0);

                DateTime venc = new DateTime(ano, mes, dia);
                Lote comprar = new Lote(resultado.Lotes.Count, qtd, venc);
                resultado.Lotes.Enqueue(comprar);
                Console.WriteLine("Lote do medicamento comprado com sucesso.");
            }
            else
            {
                Console.WriteLine("O medicamento não está cadastrado.");
            }
            break;
        case 5:
            do
            {
                try
                {
                    Console.Write("Digite o ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception e) { }
            }
            while (id < 0);

            pesquisa = new Medicamento(id, "", "");
            resultado = listaRemedios.pesquisar(pesquisa);

            if(resultado.Id != -1)
            {
                if(resultado.Lotes.Count > 0)
                {
                    qtd = 0;

                    do
                    {
                        try
                        {
                            Console.Write("Digite a quantidade a ser vendida: ");
                            qtd = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e) { }
                    } while (qtd == 0);

                    Console.WriteLine(resultado.vender(qtd) ? "Venda concluída." : "Não há quantidade suficiente para venda.");
                }
                else
                {
                    Console.WriteLine("Não há lotes cadastrados.");
                }
            }
            else
            {
                Console.WriteLine("Medicamento não cadastrado.");
            }
            break;
        case 6:
            listaRemedios.mostrarMedicamentos();
            break;
    }
}
while (resp != 0);
