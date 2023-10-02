class Medicamentos
{
    private List<Medicamento> medicamentos;

    public Medicamentos()
    {
        medicamentos = new List<Medicamento>();
    }

    public void adicionar(Medicamento medicamento)
    {
        Medicamento novo = new Medicamento(medicamentos.Count, medicamento.Nome, medicamento.Laboratorio);
        medicamentos.Add(novo);
        Console.WriteLine(medicamentos.Last().Laboratorio);
    }

    public bool deletar()
    {
        return false;
    }

    public Medicamento pesquisar(Medicamento medicamento)
    {
        return medicamento;
    }
}