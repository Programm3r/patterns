namespace ChainOfResponsibilityPattern
{
    public class TeamLeader : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler { get; set; }

        public string HandleRequest(LeaveRequest request)
        {
            return request.LeaveDays <= 10 ? "Leave request approved by team leader" : NextHandler.HandleRequest(request);
        }
    }
}
