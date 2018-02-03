namespace EventBus.Listeners
{
    public interface Listener<T>
    {
        void Handle(T payload);
    }
}