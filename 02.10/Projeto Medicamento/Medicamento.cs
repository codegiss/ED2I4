using System.Data.Common;

class Medicamento
{
    private int id;
    private string nome;
    private string laboratorio;
    private Queue<Lote> lotes;

    public int Id { get => id; set{ id = value;}}
    public string Nome { get => nome; set { nome = value; }}
    public string Laboratorio { get => laboratorio; set { laboratorio = value; }}
    public Queue<Lote> Lotes { get => lotes; set { lotes = value; }}

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

        foreach(Lote l in lotes)
        {
            qtd += l.Qtde;
        }
        return qtd;
    }

    public void comprar(Lote lote)
    {
        
    }

    public bool vender(int qtde)
    {
        return false;
    }

    public string toString()
    {
        return "";
    }

    public override bool Equals(object obj)
    {
        return false;
    }
}