public class EmailNotificacaoFactory : NotificacaoFactory
{
    public override Notificacao CriarNotificacao()
    {
        return new EmailNotificacao();
    }
}

