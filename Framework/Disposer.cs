using System;
using System.Collections.Generic;

namespace Observer.Framework
{
    public class Disposer : IDisposable
    {
        private readonly List<IObserver<Email>> _usuarios;
        private readonly IObserver<Email> _usuario;

        public Disposer(List<IObserver<Email>> usuarios, IObserver<Email> usuario)
        {
            _usuarios = usuarios;
            _usuario = usuario;
        }

        public void Dispose()
        {
            if (_usuarios.Contains(_usuario))
                _usuarios.Remove(_usuario);
        }
    }
    
    
}
