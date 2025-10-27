using System;
using Microsoft.EntityFrameworkCore;
using Eclipse360.Models;
using Eclipse360.Data;

namespace Eclipse360.Servicese
{
    public class SearchData
    {
        private readonly Eclipse360Context _db;
        public SearchData(Eclipse360Context db) => _db = db;

        public async Task<List<Project>> SearchProject(string SrchText)
        {
            //try
            //{
                return await _db.Projects.Where(p => p.Code.Contains(SrchText) || p.Code.Contains(SrchText))
            .Select(p => new Project
            {
                Id = p.Id,
                Title = p.Title,
                Code = p.Code,
                // Map other properties...
            })
            .ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    // Log error (Serilog, ILogger, etc.)
            //    throw; // Re-throw or return empty list as fallback
            //}
        }

    }
}
