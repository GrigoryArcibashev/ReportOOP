namespace Mediator.Interfaces
{
    public interface IMediator
    {
        void Notify(IComponent sender, string ev);
    }
}