using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainOfResponsibilityPattern.Test
{
    [TestClass]
    public class ChainOfResponsibilityTest
    {
        [TestMethod]
        public void IfLeaveDaysIsLessThanOrEqualTo10()
        {
            LeaveRequest request = new LeaveRequest
            {
                Employee = "Mike",
                LeaveDays = 9
            };

            ILeaveRequestHandler teamLeader = new TeamLeader();
            ILeaveRequestHandler projectManager = new ProjectManager();
            ILeaveRequestHandler humanResources = new HumanResources();
            teamLeader.NextHandler = projectManager;
            projectManager.NextHandler = humanResources;

            var actual = teamLeader.HandleRequest(request);

            Assert.AreEqual("Leave request approved by team leader", actual);
        }

        [TestMethod]
        public void IfLeaveDaysIsLessThanOrEqualTo30()
        {
            LeaveRequest request = new LeaveRequest
            {
                Employee = "Mike",
                LeaveDays = 30
            };

            ILeaveRequestHandler teamLeader = new TeamLeader();
            ILeaveRequestHandler projectManager = new ProjectManager();
            ILeaveRequestHandler humanResources = new HumanResources();
            teamLeader.NextHandler = projectManager;
            projectManager.NextHandler = humanResources;

            var actual = teamLeader.HandleRequest(request);

            Assert.AreEqual("Leave request approved by project manager", actual);
        }

        [TestMethod]
        public void IfLeaveDaysIsGreaterThan30()
        {
            LeaveRequest request = new LeaveRequest
            {
                Employee = "Mike",
                LeaveDays = 31
            };

            ILeaveRequestHandler teamLeader = new TeamLeader();
            ILeaveRequestHandler projectManager = new ProjectManager();
            ILeaveRequestHandler humanResources = new HumanResources();
            teamLeader.NextHandler = projectManager;
            projectManager.NextHandler = humanResources;

            var actual = teamLeader.HandleRequest(request);

            Assert.AreEqual("Leave request approved by human resources", actual);
        }
    }
}
