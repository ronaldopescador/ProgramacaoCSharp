class Program
{
    static void Main(string[] args)
    {
        Mensagem mensagem = new MensagemSimples();
        mensagem.Enviar("Olá, esta é uma mensagem simples.");
        
        Mensagem mensagemCaixaAlta = new CaixaAltaDecorator(
                new MensagemSimples());
        mensagemCaixaAlta.Enviar("Olá, esta é uma mensagem simples.");

        Mensagem mensagemComAssinatura = new AssinaturaDecorator(
                new MensagemSimples());
        mensagemComAssinatura.Enviar("Olá, esta é uma mensagem simples.");

        Mensagem mensagemCaixaAltaComAssinatura = new AssinaturaDecorator(
                new CaixaAltaDecorator(
                    new MensagemSimples()));
        mensagemCaixaAltaComAssinatura.Enviar("Olá, esta é uma mensagem simples.");
    }
}