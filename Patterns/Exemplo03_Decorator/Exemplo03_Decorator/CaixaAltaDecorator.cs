public class CaixaAltaDecorator : MensagemDecorator
{
    public CaixaAltaDecorator(Mensagem mensagem) : base(mensagem) { }

    public override void Enviar(string conteudo)
    {
        base.Enviar(conteudo.ToUpper());
    }
}