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
        novo.Lotes = new Queue<Lote>();
        medicamentos.Add(novo);
    }

    public bool deletar(Medicamento medicamento)
    {
        Medicamento apagar = medicamentos.Find(e => e.Id == medicamento.Id);

        if(apagar.Id == -1) return false;

        return apagar.qtdeDisponivel() ==0 ? medicamentos.Remove(apagar) : false;
    }

    public Medicamento pesquisar(Medicamento medicamento)
    {
        Medicamento achou = medicamentos.Find(e => e.Id == medicamento.Id);

        return achou;
    }

    public void mostrarMedicamentos()
    {
        foreach (Medicamento m in medicamentos)
        {
            Console.WriteLine(m.toString());
        }
    }
}
