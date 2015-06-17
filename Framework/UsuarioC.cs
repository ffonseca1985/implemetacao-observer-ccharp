using System;

namespace Observer.Framework
{
    public class UsuarioC : IObserver<Email>
    {
        private readonly IDisposable _disposer;

        public UsuarioC(IObservable<Email> controladorEmail)
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
            Console.WriteLine(value.Descricao + "C");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }

}
