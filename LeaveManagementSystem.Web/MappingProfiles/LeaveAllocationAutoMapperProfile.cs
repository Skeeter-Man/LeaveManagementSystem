using AutoMapper;
using LeaveManagementSystem.Web.ViewModels.LeaveAllocations;
using LeaveManagementSystem.Web.ViewModels.LeaveTypes;
using LeaveManagementSystem.Web.ViewModels.Periods;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class LeaveAllocationAutoMapperProfile : Profile
    {
        public LeaveAllocationAutoMapperProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationVM>();
            CreateMap<Period, PeriodsVM>();
        }
    }
}
