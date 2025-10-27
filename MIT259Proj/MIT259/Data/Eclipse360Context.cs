using System;
using System.Collections.Generic;
using Eclipse360.Models;
using Microsoft.EntityFrameworkCore;

namespace Eclipse360.Data;

public partial class Eclipse360Context : DbContext
{
    public Eclipse360Context()
    {
    }

    public Eclipse360Context(DbContextOptions<Eclipse360Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AlternateApproval> AlternateApprovals { get; set; }

    public virtual DbSet<AlternateApprover> AlternateApprovers { get; set; }

    public virtual DbSet<Approval> Approvals { get; set; }

    public virtual DbSet<ApprovalAction> ApprovalActions { get; set; }

    public virtual DbSet<ApprovalDoA> ApprovalDoAs { get; set; }

    public virtual DbSet<ApprovalDoAflow> ApprovalDoAflows { get; set; }

    public virtual DbSet<ApprovalDoAflowVersion> ApprovalDoAflowVersions { get; set; }

    public virtual DbSet<ApprovalDoAfor> ApprovalDoAfors { get; set; }

    public virtual DbSet<ApprovalDoatype> ApprovalDoatypes { get; set; }

    public virtual DbSet<ApprovalTask> ApprovalTasks { get; set; }

    public virtual DbSet<ApproverQueMember> ApproverQueMembers { get; set; }

    public virtual DbSet<ApproverQueue> ApproverQueues { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<CateregoryFor> CateregoryFors { get; set; }

    public virtual DbSet<Catergory> Catergories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<ComplaintTask> ComplaintTasks { get; set; }

    public virtual DbSet<ComplaintTaskHistory> ComplaintTaskHistories { get; set; }

    public virtual DbSet<CoplaintFollowpTask> CoplaintFollowpTasks { get; set; }

    public virtual DbSet<CoplaintHistory> CoplaintHistories { get; set; }

    public virtual DbSet<CountryList> CountryLists { get; set; }

    public virtual DbSet<CusIntrest> CusIntrests { get; set; }

    public virtual DbSet<CusOppTracker> CusOppTrackers { get; set; }

    public virtual DbSet<CusOpportunity> CusOpportunities { get; set; }

    public virtual DbSet<CusPosition> CusPositions { get; set; }

    public virtual DbSet<CusStatus> CusStatuses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<InvPo> InvPos { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LeadCatergory> LeadCatergories { get; set; }

    public virtual DbSet<ListAllQuoat> ListAllQuoats { get; set; }

    public virtual DbSet<LoadManagersToCreateProjectForm> LoadManagersToCreateProjectForms { get; set; }

    public virtual DbSet<NotificationHistory> NotificationHistories { get; set; }

    public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }

    public virtual DbSet<Opportunity> Opportunities { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PositionStrutureUserMaping> PositionStrutureUserMapings { get; set; }

    public virtual DbSet<PositionStucture> PositionStuctures { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectCat> ProjectCats { get; set; }

    public virtual DbSet<ProjectLocation> ProjectLocations { get; set; }

    public virtual DbSet<ProjectNodType> ProjectNodTypes { get; set; }

    public virtual DbSet<ProjectTask> ProjectTasks { get; set; }

    public virtual DbSet<ProjectType> ProjectTypes { get; set; }

    public virtual DbSet<QuoatDatum> QuoatData { get; set; }

    public virtual DbSet<QuoatVersion> QuoatVersions { get; set; }

    public virtual DbSet<Quotation> Quotations { get; set; }

    public virtual DbSet<ResourceType> ResourceTypes { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StatusFor> StatusFors { get; set; }

    public virtual DbSet<TaskTemplate> TaskTemplates { get; set; }

    public virtual DbSet<UsedResourceForTask> UsedResourceForTasks { get; set; }

    public virtual DbSet<UserInfro> UserInfros { get; set; }

    public virtual DbSet<ViewAllMyPendingApproval> ViewAllMyPendingApprovals { get; set; }

    public virtual DbSet<ViewApprovedQuoatCustomerList> ViewApprovedQuoatCustomerLists { get; set; }

    public virtual DbSet<ViewQoVerDt> ViewQoVerDts { get; set; }

    public virtual DbSet<ViewQuoatInfo> ViewQuoatInfos { get; set; }

    public virtual DbSet<VwUserPendingApprovalTask> VwUserPendingApprovalTasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLDDLFV;Initial Catalog=Eclipse360;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlternateApproval>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClosedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Approval).WithMany(p => p.AlternateApprovalsNavigation)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlternateApprovals_Approval");

            entity.HasOne(d => d.RequestedByNavigation).WithMany(p => p.AlternateApprovals)
                .HasForeignKey(d => d.RequestedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlternateApprovals_AspNetUsers");
        });

        modelBuilder.Entity<AlternateApprover>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<Approval>(entity =>
        {
            entity.ToTable("Approval");

            entity.Property(e => e.AlternateApprovals).HasColumnType("ntext");
            entity.Property(e => e.ApplicationFor).HasColumnType("ntext");
            entity.Property(e => e.ApprovedActionCount).HasDefaultValue(0);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DoAid).HasColumnName("DoAId");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Approval_AspNetUsers");

            entity.HasOne(d => d.DoA).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.DoAid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Approval_ApprovalDoA");
        });

        modelBuilder.Entity<ApprovalAction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ActionName).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ApprovalDoA>(entity =>
        {
            entity.ToTable("ApprovalDoA");

            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultVersion).HasDefaultValue(1);
            entity.Property(e => e.DoAname)
                .HasMaxLength(50)
                .HasColumnName("DoAName");
            entity.Property(e => e.FlowData).HasColumnType("ntext");

            entity.HasOne(d => d.ApprovalForNavigation).WithMany(p => p.ApprovalDoAs)
                .HasForeignKey(d => d.ApprovalFor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDoA_ApprovalDoAFor");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ApprovalDoAs)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDoA_AspNetUsers");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.ApprovalDoAs)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDoA_ApprovalDOAType");
        });

        modelBuilder.Entity<ApprovalDoAflow>(entity =>
        {
            entity.ToTable("ApprovalDoAFlow");

            entity.Property(e => e.FlowVid).HasColumnName("FlowVID");
            entity.Property(e => e.IncludeAlternateApprovers).HasColumnType("ntext");
            entity.Property(e => e.PositionTitle).HasColumnType("ntext");
            entity.Property(e => e.SlainHr).HasColumnName("SLAInHR");

            entity.HasOne(d => d.FlowV).WithMany(p => p.ApprovalDoAflows)
                .HasForeignKey(d => d.FlowVid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDoAFlow_ApprovalDoAFlowVersion");
        });

        modelBuilder.Entity<ApprovalDoAflowVersion>(entity =>
        {
            entity.ToTable("ApprovalDoAFlowVersion");

            entity.Property(e => e.DoAid).HasColumnName("DoAId");

            entity.HasOne(d => d.DoA).WithMany(p => p.ApprovalDoAflowVersions)
                .HasForeignKey(d => d.DoAid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDoAFlowVersion_ApprovalDoA");
        });

        modelBuilder.Entity<ApprovalDoAfor>(entity =>
        {
            entity.ToTable("ApprovalDoAFor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Purpose).HasMaxLength(50);
        });

        modelBuilder.Entity<ApprovalDoatype>(entity =>
        {
            entity.ToTable("ApprovalDOAType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<ApprovalTask>(entity =>
        {
            entity.ToTable("ApprovalTask");

            entity.Property(e => e.ApprovalPositionId).HasColumnName("ApprovalPositionID");
            entity.Property(e => e.Attachment).HasColumnType("ntext");
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DoAflowId).HasColumnName("DoAFlowID");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalTasks)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalTask_Approval");

            entity.HasOne(d => d.CompletedByNavigation).WithMany(p => p.ApprovalTasks)
                .HasForeignKey(d => d.CompletedBy)
                .HasConstraintName("FK_ApprovalTask_AspNetUsers");

            entity.HasOne(d => d.DoAflow).WithMany(p => p.ApprovalTasks)
                .HasForeignKey(d => d.DoAflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalTask_ApprovalDoAFlowVersion");
        });

        modelBuilder.Entity<ApproverQueMember>(entity =>
        {
            entity.HasOne(d => d.Queue).WithMany(p => p.ApproverQueMembers)
                .HasForeignKey(d => d.QueueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApproverQueMembers_ApproverQueue");
        });

        modelBuilder.Entity<ApproverQueue>(entity =>
        {
            entity.ToTable("ApproverQueue");

            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.QueName)
                .HasMaxLength(65)
                .IsFixedLength();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ApproverQueues)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApproverQueue_AspNetUsers");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

            entity.HasOne(d => d.Role).WithMany().HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LoginProvider).HasMaxLength(450);
            entity.Property(e => e.Name).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<CateregoryFor>(entity =>
        {
            entity.ToTable("CateregoryFor");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Catergory>(entity =>
        {
            entity.ToTable("Catergory");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.CatFor).WithMany(p => p.Catergories)
                .HasForeignKey(d => d.CatForId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Catergory_CateregoryFor");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.FieldOfService)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(65)
                .IsFixedLength();
            entity.Property(e => e.OfficialEmail)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Phone1).HasColumnName("phone1");
            entity.Property(e => e.WebSite).HasColumnType("text");
        });

        modelBuilder.Entity<Complaint>(entity =>
        {
            entity.ToTable("Complaint");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CloseDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RefrenceNo)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Solution).HasColumnType("text");

            entity.HasOne(d => d.CatergoryNavigation).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.Catergory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Complaint_ComplaintTask");

            entity.HasOne(d => d.Cus).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.CusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Complaint_Customer");
        });

        modelBuilder.Entity<ComplaintTask>(entity =>
        {
            entity.ToTable("ComplaintTask");

            entity.Property(e => e.AdditioanlDescRiption).HasColumnType("text");
            entity.Property(e => e.ClosedDate).HasColumnType("datetime");
            entity.Property(e => e.ClosureNote).HasColumnType("text");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.TaskTemplate).WithMany(p => p.ComplaintTasks)
                .HasForeignKey(d => d.TaskTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComplaintTask_TaskTemplate");
        });

        modelBuilder.Entity<ComplaintTaskHistory>(entity =>
        {
            entity.ToTable("ComplaintTaskHistory");

            entity.Property(e => e.CommentNote).HasColumnType("text");
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Task).WithMany(p => p.ComplaintTaskHistories)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComplaintTaskHistory_ComplaintTask");
        });

        modelBuilder.Entity<CoplaintFollowpTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CoplaintFollowpTask");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<CoplaintHistory>(entity =>
        {
            entity.ToTable("CoplaintHistory");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Complient).WithMany(p => p.CoplaintHistories)
                .HasForeignKey(d => d.ComplientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CoplaintHistory_Complaint");
        });

        modelBuilder.Entity<CountryList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CountryList");

            entity.Property(e => e.Arname)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("ARName");
            entity.Property(e => e.CurrencySymbole)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Enname)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("ENName");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.TelCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<CusIntrest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CusIntrest");

            entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CusOppTracker>(entity =>
        {
            entity.ToTable("CusOppTracker");

            entity.Property(e => e.Crew).HasColumnType("text");
            entity.Property(e => e.MeetingHour).HasColumnType("text");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");

            entity.HasOne(d => d.CusOpp).WithMany(p => p.CusOppTrackers)
                .HasForeignKey(d => d.CusOppId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CusOppTracker_CusOpportunity");
        });

        modelBuilder.Entity<CusOpportunity>(entity =>
        {
            entity.ToTable("CusOpportunity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.Ref).HasColumnType("text");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CusOpportunities)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CusOpportunity_AspNetUsers");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.CusOpportunities)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CusOpportunity_Opportunity");
        });

        modelBuilder.Entity<CusPosition>(entity =>
        {
            entity.ToTable("CusPosition");

            entity.Property(e => e.PositionName)
                .HasMaxLength(30)
                .IsFixedLength();

            entity.HasOne(d => d.Comp).WithMany(p => p.CusPositions)
                .HasForeignKey(d => d.CompId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CusPosition_Company");

            entity.HasOne(d => d.Cus).WithMany(p => p.CusPositions)
                .HasForeignKey(d => d.CusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CusPosition_Customer");
        });

        modelBuilder.Entity<CusStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CusStatus");

            entity.Property(e => e.Desc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnType("ntext");
            entity.Property(e => e.City).HasColumnType("ntext");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasColumnType("ntext")
                .HasColumnName("EMail");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Intrest).HasColumnType("text");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
            entity.Property(e => e.Mname)
                .HasMaxLength(50)
                .HasColumnName("MName");
            entity.Property(e => e.Nicno)
                .HasMaxLength(20)
                .HasColumnName("NICNo");
            entity.Property(e => e.PassportNo).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.StateProvince).HasColumnType("ntext");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InvPo>(entity =>
        {
            entity.ToTable("InvPo");

            entity.Property(e => e.AdditionalNote).HasColumnType("text");
            entity.Property(e => e.ItemDetails).HasColumnType("text");
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Inv).WithMany(p => p.InvPos)
                .HasForeignKey(d => d.InvId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvPo_Invoice");

            entity.HasOne(d => d.InvNavigation).WithMany(p => p.InvPos)
                .HasForeignKey(d => d.InvId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvPo_PaymentMethod");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice");

            entity.Property(e => e.FroSaleProj).HasColumnName("Fro_Sale_proj");
            entity.Property(e => e.InvRef).HasColumnType("text");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.ToTable("Lead");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.CatNavigation).WithMany(p => p.Leads)
                .HasForeignKey(d => d.Cat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lead_LeadCatergory");
        });

        modelBuilder.Entity<LeadCatergory>(entity =>
        {
            entity.ToTable("LeadCatergory");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ListAllQuoat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListAllQuoat");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefreNo).HasMaxLength(25);
            entity.Property(e => e.VerRowId).HasColumnName("VerRowID");
        });

        modelBuilder.Entity<LoadManagersToCreateProjectForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LoadManagersToCreateProjectForm");

            entity.Property(e => e.Fname).HasColumnName("FName");
            entity.Property(e => e.LoginId).HasColumnName("loginId");
            entity.Property(e => e.Mname).HasColumnName("MName");
        });

        modelBuilder.Entity<NotificationHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotificationHistory");

            entity.Property(e => e.AdditionalInfor).HasColumnType("text");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<NotificationTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotificationTemplate");

            entity.Property(e => e.Body).HasColumnType("text");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Opportunity>(entity =>
        {
            entity.ToTable("Opportunity");

            entity.Property(e => e.Desc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.ToTable("PaymentMethod");

            entity.Property(e => e.Desc).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<PositionStrutureUserMaping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PositionStrutureUserMaping");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PositionStucture>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PositionStucture");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project");

            entity.Property(e => e.Attachments).HasColumnType("ntext");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Title)
                .HasMaxLength(65)
                .IsFixedLength();

            entity.HasOne(d => d.ClosedByNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ClosedBy)
                .HasConstraintName("FK_Project_AspNetUsers1");

            entity.HasOne(d => d.ProjectNodeNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ProjectNode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_AspNetUsers");
        });

        modelBuilder.Entity<ProjectCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProjectCat");

            entity.Property(e => e.CatName).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MyParentCatId).HasColumnName("MyParentCatID");
        });

        modelBuilder.Entity<ProjectLocation>(entity =>
        {
            entity.ToTable("ProjectLocation");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NodName).HasMaxLength(50);
            entity.Property(e => e.ProjLocationLat)
                .HasMaxLength(15)
                .HasColumnName("ProjLocation_Lat");
            entity.Property(e => e.ProjLocationLong)
                .HasMaxLength(15)
                .HasColumnName("ProjLocation_Long");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProjectLocations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_ProjectLocation_AspNetUsers");
        });

        modelBuilder.Entity<ProjectNodType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProjectNodType");

            entity.Property(e => e.Desc).HasColumnType("text");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ProjectTask>(entity =>
        {
            entity.ToTable("ProjectTask");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualEnd).HasColumnType("datetime");
            entity.Property(e => e.ActualStart).HasColumnType("datetime");
            entity.Property(e => e.AdditionalDesc).HasColumnType("text");
            entity.Property(e => e.ClosedDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CrewTeam).HasColumnType("text");
            entity.Property(e => e.ScheduleEnd).HasColumnType("datetime");
            entity.Property(e => e.ScheduleStart).HasColumnType("datetime");

            entity.HasOne(d => d.ClosedByNavigation).WithMany(p => p.ProjectTaskClosedByNavigations)
                .HasForeignKey(d => d.ClosedBy)
                .HasConstraintName("FK_ProjectTask_AspNetUsers");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProjectTaskCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectTask_AspNetUsers1");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectTasks)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectTask_Project");
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProjectType");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<QuoatDatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Col1).HasColumnType("text");
            entity.Property(e => e.Col2).HasColumnType("text");
            entity.Property(e => e.Col3).HasColumnType("text");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UnitScal).HasMaxLength(10);

            entity.HasOne(d => d.QuVe).WithMany(p => p.QuoatData)
                .HasForeignKey(d => d.QuVeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuoatData_QuoatVersion");
        });

        modelBuilder.Entity<QuoatVersion>(entity =>
        {
            entity.ToTable("QuoatVersion");

            entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FormData).HasColumnType("ntext");
            entity.Property(e => e.GrantTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RefreNo).HasMaxLength(25);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.QuoatVersions)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuoatVersion_AspNetUsers");

            entity.HasOne(d => d.Quoat).WithMany(p => p.QuoatVersions)
                .HasForeignKey(d => d.QuoatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuoatVersion_Quotation");
        });

        modelBuilder.Entity<Quotation>(entity =>
        {
            entity.ToTable("Quotation");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RefranceNo)
                .HasMaxLength(15)
                .IsFixedLength();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Quotations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quotation_AspNetUsers");

            entity.HasOne(d => d.Cus).WithMany(p => p.Quotations)
                .HasForeignKey(d => d.CusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quotation_Customer");
        });

        modelBuilder.Entity<ResourceType>(entity =>
        {
            entity.ToTable("ResourceType");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agrement).HasColumnType("text");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Inv).WithMany(p => p.Sales)
                .HasForeignKey(d => d.InvId)
                .HasConstraintName("FK_Sales_Invoice");

            entity.HasOne(d => d.Quot).WithMany(p => p.Sales)
                .HasForeignKey(d => d.QuotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Quotation");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.StatusFor).WithMany(p => p.Statuses)
                .HasForeignKey(d => d.StatusForId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Status_StatusFor");
        });

        modelBuilder.Entity<StatusFor>(entity =>
        {
            entity.ToTable("StatusFor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ModulePurpose)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TaskTemplate>(entity =>
        {
            entity.ToTable("TaskTemplate");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UsedResourceForTask>(entity =>
        {
            entity.ToTable("UsedResourceForTask");

            entity.Property(e => e.Data).HasColumnType("text");
            entity.Property(e => e.DateTime)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.UsedResourceForTasks)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsedResourceForTask_AspNetUsers");

            entity.HasOne(d => d.ResourceTypeNavigation).WithMany(p => p.UsedResourceForTasks)
                .HasForeignKey(d => d.ResourceType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsedResourceForTask_ResourceType");

            entity.HasOne(d => d.Task).WithMany(p => p.UsedResourceForTasks)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsedResourceForTask_ProjectTask");
        });

        modelBuilder.Entity<UserInfro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserInfro");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CompEmail).HasMaxLength(50);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .HasColumnName("EmpID");
            entity.Property(e => e.Fname).HasColumnName("FName");
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LoginId).HasColumnName("loginId");
            entity.Property(e => e.Mname).HasColumnName("MName");
            entity.Property(e => e.PrimaryMobileNumber)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.RegistredDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SecondaryMobile).HasMaxLength(16);
            entity.Property(e => e.Whatsapp).HasMaxLength(16);
        });

        modelBuilder.Entity<ViewAllMyPendingApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAllMyPendingApproval");

            entity.Property(e => e.ApplicationStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.QvRefreNo).HasMaxLength(25);
            entity.Property(e => e.Subject).HasColumnType("ntext");
        });

        modelBuilder.Entity<ViewApprovedQuoatCustomerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewApprovedQuoatCustomerList");

            entity.Property(e => e.Email)
                .HasColumnType("ntext")
                .HasColumnName("EMail");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
            entity.Property(e => e.Mname)
                .HasMaxLength(50)
                .HasColumnName("MName");
        });

        modelBuilder.Entity<ViewQoVerDt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewQoVerDT");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dscount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FormData).HasColumnType("ntext");
            entity.Property(e => e.GrantTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qvstatus)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("qvstatus");
            entity.Property(e => e.RefreNo).HasMaxLength(25);
        });

        modelBuilder.Entity<ViewQuoatInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewQuoatInfo");

            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerStatus).HasMaxLength(50);
            entity.Property(e => e.Enname)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("ENName");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.LeadSource).HasMaxLength(50);
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
            entity.Property(e => e.QuotationStatus).HasMaxLength(50);
            entity.Property(e => e.UserFirstName).HasMaxLength(256);
            entity.Property(e => e.UserLname)
                .HasMaxLength(256)
                .HasColumnName("UserLName");
        });

        modelBuilder.Entity<VwUserPendingApprovalTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UserPendingApprovalTasks");

            entity.Property(e => e.ApplicationStatus)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasColumnType("ntext");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
