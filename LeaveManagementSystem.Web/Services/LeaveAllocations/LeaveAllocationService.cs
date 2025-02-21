
using AutoMapper;
using LeaveManagementSystem.Web.ViewModels.LeaveAllocations;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public class LeaveAllocationService(
        ApplicationDbContext _context, 
        IHttpContextAccessor _httpContextAccessor, 
        UserManager<ApplicationUser> _userManager,
        IMapper _mapper) : ILeaveAllocationService
    {
        public async Task AllocateLeave(string employeeId)
        {
            // get all the leave types
            var leaveTypes = await _context.LeaveTypes.ToListAsync();

            // get the current period based on the year
            var currentDate = DateTime.Now;
            var period = await _context.Periods.SingleAsync(x => x.EndDate.Year == currentDate.Year);
            var monthsRemaining = period.EndDate.Month - currentDate.Month;

            // foreach leave type, create an allocaiton entry
            foreach (var leaveType in leaveTypes)
            {
                var accuralRate = decimal.Divide(leaveType.NumberOfDays, 12);
                var leaveAllocation = new LeaveAllocation
                {
                    EmployeeId = employeeId,
                    LeaveTypeId = leaveType.LeaveTypeId,
                    PeriodId = period.Id,
                    Days = (int)Math.Ceiling(accuralRate) * monthsRemaining
                };

                _context.Add(leaveAllocation);
            }

            // save changes for all entites created
            await _context.SaveChangesAsync();
        }
    
        public async Task<List<LeaveAllocation>> GetAllocations()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);

            var leaveAllocations = await _context.LeaveAllocations
                .Include(x=>x.LeaveType)
                .Include(x=>x.Period)
                .Where(x => x.EmployeeId == user.Id)
                .ToListAsync();
            return leaveAllocations;
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocation()
        {
            var allocations = await GetAllocations();
            var allocationVMList = _mapper.Map<List<LeaveAllocation>, List<LeaveAllocationVM>>(allocations);

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            var employeeVM = new EmployeeAllocationVM
            {
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                LeaveAllocations = allocationVMList                
            };

            return employeeVM;
        }
    }

}
