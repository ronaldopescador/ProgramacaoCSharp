class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        calculadora.DefinirOperacao(new Adicao());
        Console.WriteLine("Adição: " + calculadora.ExecutarOperacao(10, 5));

        calculadora.DefinirOperacao(new Subtracao());
        Console.WriteLine("Subtração: " + calculadora.ExecutarOperacao(10, 5));

        calculadora.DefinirOperacao(new Multiplicacao());
        Console.WriteLine("Multiplicação: " + calculadora.ExecutarOperacao(10, 5));

        calculadora.DefinirOperacao(new Divisao());
        Console.WriteLine("Divisão: " + calculadora.ExecutarOperacao(10, 5));
    }
}