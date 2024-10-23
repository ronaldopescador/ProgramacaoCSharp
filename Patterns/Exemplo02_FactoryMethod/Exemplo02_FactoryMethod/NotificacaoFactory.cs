public abstract class NotificacaoFactory
{
    public abstract Notificacao CriarNotificacao();

    public void Notificar(string mensagem)
    {
        var notificacao = CriarNotificacao();
        notificacao.Enviar(mensagem);
    }
}