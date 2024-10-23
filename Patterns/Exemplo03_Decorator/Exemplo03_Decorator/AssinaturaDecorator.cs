public class AssinaturaDecorator : MensagemDecorator
{
    public AssinaturaDecorator(Mensagem mensagem) : base(mensagem) { }

    public override void Enviar(string conteudo)
    {
        base.Enviar(conteudo + "\nAtenciosamente,\nRonaldo");
    }
}