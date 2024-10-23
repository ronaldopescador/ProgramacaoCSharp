public class Calculadora
{
    private IOperacao _operacao;

    public void DefinirOperacao(IOperacao operacao)
    {
        _operacao = operacao;
    }

    public int ExecutarOperacao(int a, int b)
    {
        if (_operacao == null)
            throw new InvalidOperationException("Nenhuma operação foi definida.");

        return _operacao.Calcular(a, b);
    }
}
