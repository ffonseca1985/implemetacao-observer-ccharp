using System.Collections.Generic;
using Observer.Tradicional.Interfaces;

namespace Observer.Tradicional
{
    public class ControladorEmail : ISubject
    {
        private readonly List<IObserver> _usuarios;

        public ControladorEmail()
        {
            _usuarios = new List<IObserver>();
        }

        public void Registrar(IObserver observer)
        {
            _usuarios.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            _usuarios.Remove(observer);
        }

        public void EnviarEmail()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.ReceberEmail();
            }
        }
    }

}
