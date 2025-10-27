using Eclipse360.Data;
using Eclipse360.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace Eclipse360.Servicese.InsertDataaa
{
    public class InsrtData
    {
        private readonly Eclipse360Context _db;
        public InsrtData(Eclipse360Context db) => _db = db;


        public async Task AddCustomerAsync(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
        }


        public async Task<int> SaveQuotationWithVersionAsync(Quotation quotation, decimal grantTotal, decimal netTotal, decimal discount, string @QOData)
        {
            int cusId = quotation.CusId;
            int status = quotation.Status;
            int createdBy = quotation.CreatedBy;

            // Use FromSqlRaw to get the actual returned value
            var result = await _db.Database
                .SqlQuery<int>($"EXEC SaveQuotationWithData {cusId}, {status}, {createdBy}, {grantTotal}, {netTotal}, {discount},{QOData}" )
                .ToListAsync();

            return result.FirstOrDefault(); // Returns the VersionId
        }


        public async Task AddQuoatDataAsync(List<QuoatDatum> quoatData)
        {
            _db.QuoatData.AddRange(quoatData);
            await _db.SaveChangesAsync();
        }


        public async Task<int> SubmitQuoatVerForApprovalAsync(int SelectedQoVerRowId, int UserId, int DoaID, string ApplicationFor)
        {
            // Define the output parameter
            var resultMessageParam = new SqlParameter
            {
                ParameterName = "@ResultMessage",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            // Define the input parameters
            var selectedQoVerRowIdParam = new SqlParameter("@SelectedQoVerRowId", SelectedQoVerRowId);
            var userIdParam = new SqlParameter("@UserId", UserId);
            var doaIdParam = new SqlParameter("@DoaID", DoaID);
            var applicationForParam = new SqlParameter("@ApplicationFor", ApplicationFor);

            // Call the stored procedure using ExecuteSqlRawAsync
            await _db.Database.ExecuteSqlRawAsync(
                "EXEC SubmitForApproval @SelectedQoVerRowId, @UserId, @DoaID, @ApplicationFor, @ResultMessage OUTPUT",
                selectedQoVerRowIdParam,
                userIdParam,
                doaIdParam,
                applicationForParam,
                resultMessageParam);

            // Retrieve the value from the output parameter
            return (int)resultMessageParam.Value;
        }

        public async Task<int> SubmitQuoatApprovalAsync(string ApprovalComment, int ActId, int TaskRowID, int QVRID, int QVOID, int APPId, int UserId)
        {
            var resultMessageParam = new SqlParameter
            {
                ParameterName = "@ResultMessage",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            // Define the input parameters
            var ApprovalCommentParam = new SqlParameter("@ApprovalComment", ApprovalComment);
            var userIdParam = new SqlParameter("@UserId", UserId);
            var ActIdParam = new SqlParameter("@ActId", ActId);
            var TaskRowIDParam = new SqlParameter("@TaskRowID", TaskRowID);
            var dQVRIDParam = new SqlParameter("@QVRID", QVRID);
            var QVOIDParam = new SqlParameter("@QVOID", QVOID);
            var APPIdParam = new SqlParameter("@APPId", APPId);

            // Call the stored procedure using ExecuteSqlRawAsync
            await _db.Database.ExecuteSqlRawAsync(
                "EXEC RecordApprovalActions @ApprovalComment, @UserId, @ActId, @TaskRowID, @QVRID, @QVOID, @APPId, @ResultMessage OUTPUT",
                ApprovalCommentParam,
                userIdParam,
                ActIdParam,
                TaskRowIDParam,
                dQVRIDParam,
                QVOIDParam, APPIdParam,
                resultMessageParam);

            // Retrieve the value from the output parameter
            return (int)resultMessageParam.Value;
        }

        public async Task<int> CreateNod(int ParentNodID, string NodName, string NodCode, int createdBy, int NodType)
        {
            var resultMessageParam = new SqlParameter
            {
                ParameterName = "@ResultMessage",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            // Correct parameter order matching stored procedure
            var para1 = new SqlParameter("@createdBy", SqlDbType.Int) { Value = createdBy };
            var para2 = new SqlParameter("@ParentNodID", SqlDbType.Int) { Value = ParentNodID };
            var para3 = new SqlParameter("@NodName", SqlDbType.NVarChar, 255) { Value = (object)NodName ?? DBNull.Value };
            var para4 = new SqlParameter("@NodCode", SqlDbType.NVarChar, 100) { Value = (object)NodCode ?? DBNull.Value };
            var para5 = new SqlParameter("@Nodtype", SqlDbType.Int) { Value = NodType };

            await _db.Database.ExecuteSqlRawAsync(
                "EXEC CreateNewNode @createdBy, @ParentNodID, @NodName, @NodCode, @Nodtype, @ResultMessage OUTPUT",
                para1,    // createdBy first
                para2,    // ParentNodID second  
                para3,
                para4,
                para5,
                resultMessageParam);

            return resultMessageParam.Value != DBNull.Value ? (int)resultMessageParam.Value : 500;
        }

        public async Task<int> CreateProject
    (int ParentNodID, string ProjectName, string ProjectCode, int createdBy, int QuoatId, int ProjectType, int PM, string CoredLat, string CordLong)
        {
            var resultMessageParam = new SqlParameter
            {
                ParameterName = "@ResultMessage",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };


//@CreatedBy int,
//@ProjectType int,
//@ProjectName nvarchar(MAX),
//@ProjectCode nvarchar(MAX),
//@PM int,
//@CoredLat nvarchar(15),
//@CordLong nvarchar(15),
//@parentNodId int,
//@QuoatId int,
//@ResultMessage int output

            // Correct parameter order matching stored procedure
            var para1 = new SqlParameter("@CreatedBy", SqlDbType.Int) { Value = createdBy };
            var para2 = new SqlParameter("@ProjectType", SqlDbType.Int) { Value = ProjectType };
            var para3 = new SqlParameter("@ProjectName", SqlDbType.NVarChar, 255) { Value = (object)ProjectName ?? DBNull.Value };
            var para4 = new SqlParameter("@ProjectCode", SqlDbType.NVarChar, 100) { Value = (object)ProjectCode ?? DBNull.Value };
            var para5 = new SqlParameter("@PM", SqlDbType.Int) { Value = PM };
            var para6 = new SqlParameter("@CoredLat", SqlDbType.NVarChar, 100) { Value = (object)CoredLat ?? DBNull.Value };
            var para7 = new SqlParameter("@CordLong", SqlDbType.NVarChar, 255) { Value = (object)CordLong ?? DBNull.Value };
            var para8 = new SqlParameter("@parentNodId", SqlDbType.Int) { Value = ParentNodID };
            var para9 = new SqlParameter("@QuoatId", SqlDbType.Int) { Value = QuoatId };

            await _db.Database.ExecuteSqlRawAsync(
                "EXEC CreteProject @CreatedBy, @ProjectType, @ProjectName, @ProjectCode, @PM, @CoredLat, @CordLong, @parentNodId, @QuoatId, @ResultMessage OUTPUT",
                para1,    // createdBy first
                para2,    // ParentNodID second  
                para3,
                para4,
                para5,
                para6,
                para7,
                para8,
                para9,
                resultMessageParam);

            return resultMessageParam.Value != DBNull.Value ? (int)resultMessageParam.Value : 500;
        }


    }
}
