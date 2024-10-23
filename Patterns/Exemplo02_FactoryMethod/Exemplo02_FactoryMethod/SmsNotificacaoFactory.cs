public class SmsNotificacaoFactory : NotificacaoFactory
{
    public override Notificacao CriarNotificacao()
    {
        return new SmsNotificacao();
    }
}