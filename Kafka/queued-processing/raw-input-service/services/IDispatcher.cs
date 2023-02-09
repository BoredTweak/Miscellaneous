public interface IDispatcher {
    Task<bool> Dispatch(int input);
}