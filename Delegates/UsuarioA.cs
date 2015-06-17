using System;

namespace Observer.Delegates
{
    public class UsuarioA
    {
        public void Assinar(ControladorEmail controlador)
        {
            controlador.ProcessarEmail += ProcessarEmail;
        }
        public void ProcessarEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário A");
        }

        public void CancelarAssinatura(ControladorEmail controlador)
        {
            controlador.ProcessarEmail -= ProcessarEmail;
        }
    }
}
