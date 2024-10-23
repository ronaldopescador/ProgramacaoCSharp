public abstract class MensagemDecorator : Mensagem
{
    protected Mensagem _mensagem;

    public MensagemDecorator(Mensagem mensagem)
    {
        _mensagem = mensagem;
    }

    public override void Enviar(string conteudo)
    {
        _mensagem.Enviar(conteudo);
    }
}