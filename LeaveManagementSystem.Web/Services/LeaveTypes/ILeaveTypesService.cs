﻿using LeaveManagementSystem.Web.ViewModels.LeaveTypes;

namespace LeaveManagementSystem.Web.Services.LeaveTypes
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<List<LeaveTypeReadOnlyVM>> GetAllAsync();
        Task<T?> GetAsync<T>(int id) where T : class;
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}