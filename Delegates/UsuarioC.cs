using System;

namespace Observer.Delegates
{
    public class UsuarioC
    {
        public void Assinar(ControladorEmail controlador)
        {
            controlador.ProcessarEmail += ProcessarEmail;
        }
        public void ProcessarEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário C");
        }
        public void CancelarAssinatura(ControladorEmail controlador)
        {
            controlador.ProcessarEmail -= ProcessarEmail;
        }
    }
}
