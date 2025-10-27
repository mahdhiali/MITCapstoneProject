using Eclipse360.Data;
using Eclipse360.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Eclipse360.Servicese
{
    public class LoadData
    {
        private readonly Eclipse360Context _db;
        public LoadData(Eclipse360Context db) => _db = db;
        public async Task<List<Customer>> GetCustomerListAsync()
        {
            try
            {
                return await _db.Customers
                    .OrderBy(c => c.Fname)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log error (Serilog, ILogger, etc.)
                throw; // Re-throw or return empty list as fallback
            }
        }

        public async Task<List<ApprovalDoA>> GetDoAListAsync(int ModuleId)
        {
            try
            {
                return await _db.ApprovalDoAs.Where(c=> c.ApprovalFor == ModuleId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log error (Serilog, ILogger, etc.)
                throw; // Re-throw or return empty list as fallback
            }
        }

        public async Task<List<LoadManagersToCreateProjectForm>> LoadPMAsync()
        {
            return await _db.LoadManagersToCreateProjectForms.OrderBy(c=> c.Fname).ToListAsync();
        }

        public async Task<List<ProjectNodType>> LoadLocationNodType()
        {
            return await _db.ProjectNodTypes.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<List<ProjectType>> LoadProjectTypeAsync()
        {
            return await _db.ProjectTypes.OrderBy(c=> c.Name).ToListAsync();
        }
        public async Task<List<ViewAllMyPendingApproval>> ViewAllMyPendingApprovalAsync(int UerId)
        {
            try
            {
                List<ApproverQueMember> approverQueMembers = new List<ApproverQueMember>(); // get user queue id

                var queueId = await _db.ApproverQueMembers
                    .Where(c => c.UserId == UerId)
                    .Select(c => c.QueueId)
                    .ToListAsync();

                var PendingApprovals = await _db.ViewAllMyPendingApprovals.Where(c => queueId.Contains(c.QueueId))
                        .ToListAsync();

                return PendingApprovals;
            }
            catch (Exception ex)
            {
                    // Log error (Serilog, ILogger, etc.)
                    throw; // Re-throw or return empty list as fallback
            }
            
            
        }

        //public async Task<string> LoadProjectPositionStucture(int ProjectId)
        //{
        //    string Position;

        //    Position = await _db.

        //    return
        //}
    }
}
