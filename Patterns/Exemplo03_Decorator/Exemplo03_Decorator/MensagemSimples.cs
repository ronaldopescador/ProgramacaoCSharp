public class MensagemSimples : Mensagem
{
    public override void Enviar(string conteudo)
    {
        Console.WriteLine(conteudo);
    }
}