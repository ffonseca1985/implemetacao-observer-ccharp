using System;
using Observer.Tradicional.Interfaces;

namespace Observer.Tradicional
{
    public class UsuarioA : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário A");
        }
    }

}
