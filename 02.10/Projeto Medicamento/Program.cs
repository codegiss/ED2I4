int resp = -1;
string nome, lab;
Medicamentos listaRemedios = new Medicamentos();

do
{
    do
    {
        Console.Clear();

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
        catch (Exception e) {}
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
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
}
while (resp != 0);