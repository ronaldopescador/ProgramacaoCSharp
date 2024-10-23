class Program
{
    static void Main(string[] args)
    {
        Logger l1 = Logger.GetInstance();
        l1.Log("Adicionado ao carrinho.");

        Logger l2 = Logger.GetInstance();
        l1.Log("Efetuado o pagamento.");

        Console.WriteLine(Object.ReferenceEquals(l1, l2));  
    }
}