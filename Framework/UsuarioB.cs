using System;

namespace Observer.Framework
{
    public class UsuarioB : IObserver<Email>
    {
        private readonly IDisposable _disposer;

        public UsuarioB(IObservable<Email> controladorEmail)
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
            Console.WriteLine(value.Descricao + "B");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}
