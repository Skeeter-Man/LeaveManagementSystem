using LeaveManagementSystem.Web.Services.LeaveAllocations;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveAllocationController(ILeaveAllocationService _leaveAllocationService) 
        : Controller
    {
        public async Task<IActionResult> Details()
        {
            var leaveAllocations = await _leaveAllocationService.GetAllocations();
            return View();
        }
    }
}
