namespace ChainOfResponsibilityPattern
{
    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler { get; set; }

        public string HandleRequest(LeaveRequest request)
        {
            return request.LeaveDays <= 30 ? "Leave request approved by project manager" : NextHandler.HandleRequest(request);
        }
    }
}
