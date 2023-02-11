public interface IDispatcher
{
    Task<Guid?> Dispatch(int input);

    Task<string?> GetStatus(Guid identifier);
}