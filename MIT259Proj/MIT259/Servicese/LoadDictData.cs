using System;
using Microsoft.EntityFrameworkCore;
using Eclipse360.Models;
using Eclipse360.Data;

namespace Eclipse360.Servicese
{
    public class LoadDictData
    {
        private readonly Eclipse360Context _db;
        public LoadDictData(Eclipse360Context db) => _db = db;

        public async Task<List<CountryList>> GetCountryListAsync()
        {
            try
            {
                return await _db.CountryLists
                    .OrderBy(c=> c.Enname)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log error (Serilog, ILogger, etc.)
                throw; // Re-throw or return empty list as fallback
            }
        }

        public async Task<List<Status>> GetCusStatusAsync(int StatusFD)
        {
            try
            {
                return await _db.Statuses
                    .Where(c => c.StatusForId == StatusFD)
                    .OrderBy(c => c.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log error (Serilog, ILogger, etc.)
                throw; // Re-throw or return empty list as fallback
            }
        }

        public async Task<List<Lead>> GetLeadAsync()
        {
            try
            {
                return await _db.Leads.OrderBy(c => c.Name).ToListAsync();
            }
            catch (Exception ex)
            {
                // Log error (Serilog, ILogger, etc.)
                throw; // Re-throw or return empty list as fallback
            }
        }
    }
}
