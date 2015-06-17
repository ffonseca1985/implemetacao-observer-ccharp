using System;

namespace Observer.Framework
{
    public class UsuarioA : IObserver<Email>
    {
        private readonly IDisposable _disposer;

        public UsuarioA(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "A");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}
