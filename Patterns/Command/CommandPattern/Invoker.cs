namespace CommandPattern
{
    public class Invoker
    {
        public int ExecuteCommand(ICommand command)
        {
            return command.Execute();
        }
    }
}
