namespace Heroes
{
    public interface IExecutor
    {
        void ExecuteCommand(ICommand command);
    }
}
