using Eclipse360.Data;
using Eclipse360.Models;
using Eclipse360.Servicese.TModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;


namespace Eclipse360.Servicese
{
    public class ViewDatas
    {
        private readonly Eclipse360Context _db;
        public ViewDatas(Eclipse360Context db) => _db = db;

        public async Task<List<ListAllQuoat>> GetQuotationViewsAsync()
        {
            return await _db.ListAllQuoats.ToListAsync();
        }

        public async Task<List<ViewQoVerDt>> GetQuoatVerData(int QOID)
        {
            return await _db.ViewQoVerDts.Where(c => c.QuoatId == QOID).ToListAsync();
        }

        public async Task<ViewQuoatInfo> GetQuoatDetails(int QOID)
        {
            return await _db.ViewQuoatInfos
                .FirstOrDefaultAsync(q => q.Id == QOID);
        }

        public async Task<List<ProjectLocation>> GetLocationTreeAsync(int LocaCatId)
        {
            return await _db.ProjectLocations.Where(c => c.CatId == LocaCatId).ToListAsync();
        }
    }
}
