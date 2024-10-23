public class SmsNotificacao : Notificacao
{
    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}