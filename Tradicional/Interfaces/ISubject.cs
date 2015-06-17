namespace Observer.Tradicional.Interfaces
{
    public interface ISubject
    {
        void Registrar(IObserver observer);
        void Remover(IObserver observer);
        void EnviarEmail();
    }
}
