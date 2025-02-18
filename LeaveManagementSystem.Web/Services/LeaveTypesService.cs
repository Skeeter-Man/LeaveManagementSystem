using AutoMapper;
using LeaveManagementSystem.Web.Data;

namespace LeaveManagementSystem.Web.Services
{
    public class LeaveTypesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LeaveTypesService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
