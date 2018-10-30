namespace ChainOfResponsibilityPattern
{
    public interface ILeaveRequestHandler
    {
        string HandleRequest(LeaveRequest request);
        ILeaveRequestHandler NextHandler { get; set; }
    }
}