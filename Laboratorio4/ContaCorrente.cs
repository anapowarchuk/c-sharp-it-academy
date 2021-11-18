//criando classes
public class ContaCorrente{
    private decimal saldo; 

    public ContaCorrente(decimal valor, string? cpf)
    {
        saldo = valor;
        DataAbertura = DateTime.Now;
        CpfTitular = cpf;
    }
    public ContaCorrente()
    : this(0M, null)
    {
    }

    public void Depositar(decimal valor)
    {
        saldo = saldo + valor;
    }

    public void Sacar(decimal valor)
    {
        saldo = saldo - valor;
    }

    //propriedade de leitura
    public decimal Saldo //propriedade publica do tipo decimal
    {
        get //leitura de valor
        {
            return saldo;
        }
    }

    public DateTime DataAbertura { get; } //auto implementada
    public string? CpfTitular { get; set; } //propriedade nao eh obrigatoria
    //propriedade publica do tipo string que faz leitura e escrita
}