public class Termometro
{
    private double valor;
    public double Temperatura
    {
        get
        {
            return valor;
        }
    }
    public virtual void Aumentar()
    {
        valor += 0.1;
    }
    public virtual void Aumentar(double quantia)
    {
        valor += quantia;
    }
    override public string ToString() //representa a temperatura atual do termometro
    {
        return $"Temperatura: {Temperatura}";
    }
}

public class TermometroLimite : Termometro
{
    private bool disparadoEventoLimiteSuperior;
    public double LimiteSuperior { get; set; }
    public event EventHandler? LimiteSuperiorAlcancado; //multicast delegate que referencia todos os metodos chamados quando um evento for disparado
    protected virtual void OnLimiteSuperiorAlcancado()
    {
        if ((Temperatura > LimiteSuperior) && (!disparadoEventoLimiteSuperior))
        {
            if (LimiteSuperiorAlcancado != null)
            {
                LimiteSuperiorAlcancado(this, EventArgs.Empty);
                disparadoEventoLimiteSuperior = true;
            }
        }
    }
    public override void Aumentar()
    {
        base.Aumentar();
        OnLimiteSuperiorAlcancado();
    }
    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        OnLimiteSuperiorAlcancado();
    }
}