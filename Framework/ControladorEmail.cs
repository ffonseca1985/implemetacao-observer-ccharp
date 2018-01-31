using System;
using System.Collections.Generic;

namespace Observer.Framework
{
    public class ControladorEmail : IObservable<Email>
    {
        private readonly List<IObserver<Email>> _usuarios;
        private readonly Email _email;

        public ControladorEmail(Email email)
        {
            _usuarios = new List<IObserver<Email>>();
            _email = email;
        }

        public IDisposable Subscribe(IObserver<Email> usuario)
        {
            if (!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);

            return new Disposer(_usuarios, usuario);
        }

        



        public void EnviarEmail()
        {
        
        
        
        
            _email.Descricao = "Email Recebido pelo usuário ";

            foreach (IObserver<Email> usuario in _usuarios)
            {
                usuario.OnNext(_email);
            }
        }
    }
}
