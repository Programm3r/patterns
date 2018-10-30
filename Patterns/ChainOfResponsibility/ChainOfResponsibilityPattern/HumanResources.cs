namespace ChainOfResponsibilityPattern
{
    public class HumanResources : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler { get; set; }

        public string HandleRequest(LeaveRequest request)
        {
            return request.LeaveDays > 30 ? "Leave request approved by human resources" : NextHandler.HandleRequest(request);
        }
    }
}
