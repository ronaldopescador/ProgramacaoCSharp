class Program
{
    static void Main(string[] args)
    {
        NotificacaoFactory notificacaoFactory;

        notificacaoFactory = new EmailNotificacaoFactory();
        notificacaoFactory.Notificar("Seu relatório está pronto!");

        notificacaoFactory = new SmsNotificacaoFactory();
        notificacaoFactory.Notificar("Seu código de verificação é 123456.");
    }
}