using System;
using Observer.Tradicional.Interfaces;

namespace Observer.Tradicional
{
    public class UsuarioC : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email Recebido pelo usuario C");
        }
    }
}
