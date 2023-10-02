class Lote
{
    private int id;
    private int qtde;
    private DateTime venc;

    public int Id { get => id; set { id = value; }}
    public int Qtde { get => qtde; set { qtde = value; }}
    public DateTime Venc { get => venc; set { venc = value; }}

    public Lote()
    {
        id = 0;
        qtde = 0;
        venc = DateTime.Now;
    }

    public Lote(int id, int qtde, DateTime venc)
    {
        this.id = id;
        this.qtde = qtde;
        this.venc = venc;
    }

    public string toString()
    {
        return "";
    }
}