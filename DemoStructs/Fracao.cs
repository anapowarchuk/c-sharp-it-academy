public readonly struct Fracao //readonly - tudo o que estiver dentro da struct não pode ser alterada - não pode alterar o estado do objeto
{
    public int Numerador { get; init; } //pode ser inicializada - init
    public int Denominador { get; init; }
    override public string ToString() => $"{Numerador}/{Denominador}";
    public static Fracao operator +(Fracao f1, Fracao f2)
    {
        return new Fracao(){
            Numerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador,
            Denominador = f1.Denominador * f2.Denominador
        };
    }
}