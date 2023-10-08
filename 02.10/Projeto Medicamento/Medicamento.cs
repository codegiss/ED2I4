class Medicamento
{
    private int id;
    private string nome;
    private string laboratorio;
    private Queue<Lote> lotes;

    public int Id { get => id; set { id = value; } }
    public string Nome { get => nome; set { nome = value; } }
    public string Laboratorio { get => laboratorio; set { laboratorio = value; } }
    public Queue<Lote> Lotes { get => lotes; set { lotes = value; } }

    public Medicamento()
    {
        id = 0;
        nome = "";
        laboratorio = "";
    }

    public Medicamento(int id, string nome, string laboratorio)
    {
        this.id = id;
        this.nome = nome;
        this.laboratorio = laboratorio;
    }

    public int qtdeDisponivel()
    {
        int qtd = 0;

        try
        {
            if (lotes.Count > 0)
            {
                foreach (Lote l in lotes)
                {
                    qtd += l.Qtde;
                }
            }
        } catch (Exception e) {}

        return qtd;
    }

    public void comprar(Lote lote)
    {
        lotes.Append(lote);
    }

    public bool vender(int qtde)
    {
        if (qtdeDisponivel() < qtde) return false;

        while (qtde > 0)
        {
            if (lotes.First().Qtde < qtde)
            {
                qtde -= lotes.First().Qtde;
                lotes.Dequeue();
            }
            else
            {
                lotes.First().Qtde -= qtde;
                qtde = 0;

                if (lotes.First().Qtde == 0)
                {
                    lotes.Dequeue();
                }
            }
        }

        return true;
    }

    public string toString()
    {
        return Id + " - " + Nome + " - " + Laboratorio + " - " + qtdeDisponivel();
    }

    public string mostrarLotes()
    {
        string lote = "\n";

        try
        {
            if(lotes.Count == 0)
            {
                lote = "Não há lotes comprados para este remédio.";
            }
            else
            {
                foreach (Lote l in lotes)
                {
                    lote += l.Id + " - ";
                    lote += l.Qtde + " - ";
                    lote += l.Venc.Day + "/" +
                            l.Venc.Month + "/" +
                            l.Venc.Year + "\n";
                }
            }
        } catch (Exception e) {}
        return lote;
    }

    public override bool Equals(object obj)
    {
        return false;
    }
}
