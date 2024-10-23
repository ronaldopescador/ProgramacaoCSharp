public class EmailNotificacao : Notificacao
{
    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}