using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Delegates
{
    public class UsuarioB
    {
        public void Assinar(ControladorEmail controlador)
        {
            controlador.ProcessarEmail += ProcessarEmail;
        }
        public void ProcessarEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário B");
        }
        public void CancelarAssinatura(ControladorEmail controlador)
        {
            controlador.ProcessarEmail -= ProcessarEmail;
        }

    }
}
