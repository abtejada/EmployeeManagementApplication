using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Models.Entities;

public partial class PMMContext : DbContext
{
    public PMMContext()
    {
    }

    public PMMContext(DbContextOptions<PMMContext> options)
        : base(options)
    {
    }
    public DbSet<EmployeeSeparationHistory> EmployeeSeparationHistories { get; set; }

    public virtual DbSet<Awardee> Awardees { get; set; }

    public virtual DbSet<EmployeeRecord> EmployeeRecords { get; set; }

    public virtual DbSet<FinalList> FinalLists { get; set; }

    public virtual DbSet<HrisLogincredential> HrisLogincredentials { get; set; }

    public virtual DbSet<HrisModuleAccess> HrisModuleAccesses { get; set; }

    public virtual DbSet<IdCounter> IdCounters { get; set; }

    public virtual DbSet<IdDatum> IdData { get; set; }

    public virtual DbSet<IdPersonnelId> IdPersonnelIds { get; set; }

    public virtual DbSet<IdPrintEntry> IdPrintEntries { get; set; }

    public virtual DbSet<IdPrintType> IdPrintTypes { get; set; }

    public virtual DbSet<IdPrinter> IdPrinters { get; set; }

    public virtual DbSet<IdTransactionAudit> IdTransactionAudits { get; set; }

    public virtual DbSet<IdTransactionType> IdTransactionTypes { get; set; }

    public virtual DbSet<JobAppointOfficeHistory> JobAppointOfficeHistories { get; set; }

    public virtual DbSet<OtcSet> OtcSets { get; set; }

    public virtual DbSet<PersonnelView> PersonnelViews { get; set; }

    public virtual DbSet<PmsAuditTrail> PmsAuditTrails { get; set; }

    public virtual DbSet<PmsAwardeeRemark> PmsAwardeeRemarks { get; set; }

    public virtual DbSet<PmsBarangay> PmsBarangays { get; set; }

    public virtual DbSet<PmsCity> PmsCities { get; set; }

    public virtual DbSet<PmsCourseList> PmsCourseLists { get; set; }

    public virtual DbSet<PmsLoggedDateTime> PmsLoggedDateTimes { get; set; }

    public virtual DbSet<PmsOccupationGroup> PmsOccupationGroups { get; set; }

    public virtual DbSet<PmsOccupationIndex> PmsOccupationIndices { get; set; }

    public virtual DbSet<PmsOccupationService> PmsOccupationServices { get; set; }

    public virtual DbSet<PmsOccupationVoluntary> PmsOccupationVoluntaries { get; set; }

    public virtual DbSet<PmsOccupationWorkexp> PmsOccupationWorkexps { get; set; }

    public virtual DbSet<PmsPersonnelChild> PmsPersonnelChildren { get; set; }

    public virtual DbSet<PmsPersonnelEducation> PmsPersonnelEducations { get; set; }

    public virtual DbSet<PmsPersonnelEligibility> PmsPersonnelEligibilities { get; set; }

    public virtual DbSet<PmsPersonnelInformation> PmsPersonnelInformations { get; set; }

    public virtual DbSet<PmsPersonnelInterview> PmsPersonnelInterviews { get; set; }

    public virtual DbSet<PmsPersonnelLearningdevelopment> PmsPersonnelLearningdevelopments { get; set; }

    public virtual DbSet<PmsPersonnelLogincredential> PmsPersonnelLogincredentials { get; set; }

    public virtual DbSet<PmsPersonnelOrganization> PmsPersonnelOrganizations { get; set; }

    public virtual DbSet<PmsPersonnelParent> PmsPersonnelParents { get; set; }

    public virtual DbSet<PmsPersonnelRecognition> PmsPersonnelRecognitions { get; set; }

    public virtual DbSet<PmsPersonnelRelative> PmsPersonnelRelatives { get; set; }

    public virtual DbSet<PmsPersonnelSkill> PmsPersonnelSkills { get; set; }

    public virtual DbSet<PmsPersonnelSpouse> PmsPersonnelSpouses { get; set; }

    public virtual DbSet<PmsPosition> PmsPositions { get; set; }

    public virtual DbSet<PmsProvince> PmsProvinces { get; set; }

    public virtual DbSet<PmsPvaoPlantilla> PmsPvaoPlantillas { get; set; }

    public virtual DbSet<PmsRegion> PmsRegions { get; set; }

    public virtual DbSet<PmsSchoolList> PmsSchoolLists { get; set; }

    public virtual DbSet<PmsServiceRecord> PmsServiceRecords { get; set; }

    public virtual DbSet<PmsTownHallAttendance> PmsTownHallAttendances { get; set; }

    public virtual DbSet<PmsZipcode> PmsZipcodes { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<RecruitmentCo> RecruitmentCos { get; set; }

    public virtual DbSet<RecruitmentIncumbent> RecruitmentIncumbents { get; set; }

    public virtual DbSet<RecruitmentPlantillium> RecruitmentPlantillia { get; set; }

    public virtual DbSet<TimekeepingAction> TimekeepingActions { get; set; }

    public virtual DbSet<TimekeepingAuditTrail> TimekeepingAuditTrails { get; set; }

    public virtual DbSet<TimekeepingBioDeviceIdchecker> TimekeepingBioDeviceIdcheckers { get; set; }

    public virtual DbSet<TimekeepingCtoFiled> TimekeepingCtoFileds { get; set; }

    public virtual DbSet<TimekeepingCtoRef> TimekeepingCtoRefs { get; set; }

    public virtual DbSet<TimekeepingCutOff> TimekeepingCutOffs { get; set; }

    public virtual DbSet<TimekeepingDevice> TimekeepingDevices { get; set; }

    public virtual DbSet<TimekeepingDeviceEnrolUser> TimekeepingDeviceEnrolUsers { get; set; }

    public virtual DbSet<TimekeepingDivision> TimekeepingDivisions { get; set; }

    public virtual DbSet<TimekeepingEmpStatus> TimekeepingEmpStatuses { get; set; }

    public virtual DbSet<TimekeepingEvaluation> TimekeepingEvaluations { get; set; }

    public virtual DbSet<TimekeepingFacePass> TimekeepingFacePasses { get; set; }

    public virtual DbSet<TimekeepingFingerTemplate> TimekeepingFingerTemplates { get; set; }

    public virtual DbSet<TimekeepingForVeriOb> TimekeepingForVeriObs { get; set; }

    public virtual DbSet<TimekeepingForVerification> TimekeepingForVerifications { get; set; }

    public virtual DbSet<TimekeepingFwa> TimekeepingFwas { get; set; }

    public virtual DbSet<TimekeepingIssueRemove> TimekeepingIssueRemoves { get; set; }

    public virtual DbSet<TimekeepingJointId> TimekeepingJointIds { get; set; }

    public virtual DbSet<TimekeepingLeave> TimekeepingLeaves { get; set; }

    public virtual DbSet<TimekeepingLeaveBal> TimekeepingLeaveBals { get; set; }

    public virtual DbSet<TimekeepingLeaveItem> TimekeepingLeaveItems { get; set; }

    public virtual DbSet<TimekeepingLeaveOff> TimekeepingLeaveOffs { get; set; }

    public virtual DbSet<TimekeepingLeaveWithOutPay> TimekeepingLeaveWithOutPays { get; set; }

    public virtual DbSet<TimekeepingLetterOrder> TimekeepingLetterOrders { get; set; }

    public virtual DbSet<TimekeepingLetterOrderSub> TimekeepingLetterOrderSubs { get; set; }

    public virtual DbSet<TimekeepingLogRecord> TimekeepingLogRecords { get; set; }

    public virtual DbSet<TimekeepingLogin> TimekeepingLogins { get; set; }

    public virtual DbSet<TimekeepingMonetize> TimekeepingMonetizes { get; set; }

    public virtual DbSet<TimekeepingMonthlySummaryLeave> TimekeepingMonthlySummaryLeaves { get; set; }

    public virtual DbSet<TimekeepingNewLogrecord> TimekeepingNewLogrecords { get; set; }

    public virtual DbSet<TimekeepingNonWorkingDay> TimekeepingNonWorkingDays { get; set; }

    public virtual DbSet<TimekeepingNotification> TimekeepingNotifications { get; set; }

    public virtual DbSet<TimekeepingOccupationDetail> TimekeepingOccupationDetails { get; set; }

    public virtual DbSet<TimekeepingOfficialBusiness> TimekeepingOfficialBusinesses { get; set; }

    public virtual DbSet<TimekeepingOtclog> TimekeepingOtclogs { get; set; }

    public virtual DbSet<TimekeepingRestDay> TimekeepingRestDays { get; set; }

    public virtual DbSet<TimekeepingSchedHistory> TimekeepingSchedHistories { get; set; }

    public virtual DbSet<TimekeepingSchedule> TimekeepingSchedules { get; set; }

    public virtual DbSet<TimekeepingSetSched> TimekeepingSetScheds { get; set; }

    public virtual DbSet<TimekeepingSetup> TimekeepingSetups { get; set; }

    public virtual DbSet<TimekeepingSignatory> TimekeepingSignatories { get; set; }

    public virtual DbSet<TimekeepingSpecialCaseSched> TimekeepingSpecialCaseScheds { get; set; }

    public virtual DbSet<TimekeepingTempCtoFiled> TimekeepingTempCtoFileds { get; set; }

    public virtual DbSet<TimekeepingTempLeaveWithOutPay> TimekeepingTempLeaveWithOutPays { get; set; }

    public virtual DbSet<TimekeepingTempMonetize> TimekeepingTempMonetizes { get; set; }

    public virtual DbSet<TimekeepingTempOfficialBusiness> TimekeepingTempOfficialBusinesses { get; set; }

    public virtual DbSet<TimekeepingTempUndertime> TimekeepingTempUndertimes { get; set; }

    public virtual DbSet<TimekeepingTempUsedLeave> TimekeepingTempUsedLeaves { get; set; }

    public virtual DbSet<TimekeepingUndertime> TimekeepingUndertimes { get; set; }

    public virtual DbSet<TownHallMf> TownHallMfs { get; set; }

    public virtual DbSet<ViewDeviceEnrolledDetail> ViewDeviceEnrolledDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:PMMDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Awardee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Awardee");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(12)
                .HasColumnName("employee_id");
            entity.Property(e => e.HiredDate).HasColumnName("hired_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MonthName).HasMaxLength(30);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameOfEmployee)
                .HasMaxLength(93)
                .HasColumnName("Name_of_Employee");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmployeeRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmployeeRecord");

            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.BloodType)
                .HasMaxLength(3)
                .HasColumnName("blood_type");
            entity.Property(e => e.CivilStatus)
                .HasMaxLength(20)
                .HasColumnName("civil_status");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(11)
                .HasColumnName("contact_number");
            entity.Property(e => e.Division).HasColumnName("division");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(12)
                .HasColumnName("employee_id");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(10)
                .HasColumnName("extension_name");
            entity.Property(e => e.GivenName)
                .HasMaxLength(50)
                .HasColumnName("given_name");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("height");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.IdImage).HasColumnType("image");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.Mobilenum)
                .HasMaxLength(11)
                .HasColumnName("mobilenum");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NamePerson)
                .HasMaxLength(100)
                .HasColumnName("name_person");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .HasColumnName("surname");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<FinalList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FinalList");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("employee_id");
            entity.Property(e => e.GivenName)
                .HasMaxLength(255)
                .HasColumnName("given_name");
            entity.Property(e => e.HiredDate)
                .HasColumnType("datetime")
                .HasColumnName("hired_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("middle_name");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("position");
            entity.Property(e => e.Sname)
                .HasMaxLength(255)
                .HasColumnName("sname");
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<HrisLogincredential>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRIS_logincredentials");

            entity.Property(e => e.Amm).HasColumnName("AMM");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("employee_id");
            entity.Property(e => e.HrisId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PmmAdmin).HasColumnName("PMM_admin");
            entity.Property(e => e.PmmEmp).HasColumnName("PMM_emp");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<HrisModuleAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRIS_moduleAccess");

            entity.Property(e => e.Amm).HasColumnName("AMM");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ObLo).HasColumnName("OB_LO");
        });

        modelBuilder.Entity<IdCounter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ID_Counters");

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.KeyPrefix)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IdDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IdData");

            entity.Property(e => e.BirthDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birth_date");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(50)
                .HasColumnName("birth_place");
            entity.Property(e => e.BloodType)
                .HasMaxLength(3)
                .HasColumnName("blood_type");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(11)
                .HasColumnName("contact_number");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(12)
                .HasColumnName("employee_id");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(10)
                .HasColumnName("extension_name");
            entity.Property(e => e.GivenName)
                .HasMaxLength(50)
                .HasColumnName("given_name");
            entity.Property(e => e.GsisId)
                .HasMaxLength(100)
                .HasColumnName("gsis_id");
            entity.Property(e => e.Height)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("height");
            entity.Property(e => e.HrisId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("hris_id");
            entity.Property(e => e.IceBrgy)
                .HasMaxLength(100)
                .HasColumnName("Ice_brgy");
            entity.Property(e => e.IceCtyMnicplty)
                .HasMaxLength(100)
                .HasColumnName("Ice_CtyMnicplty");
            entity.Property(e => e.IceNumber)
                .HasMaxLength(100)
                .HasColumnName("Ice_number");
            entity.Property(e => e.IceProvince)
                .HasMaxLength(100)
                .HasColumnName("Ice_province");
            entity.Property(e => e.IceStreet)
                .HasMaxLength(100)
                .HasColumnName("Ice_street");
            entity.Property(e => e.IdFingerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdFingerPrint).HasColumnType("image");
            entity.Property(e => e.IdImage).HasColumnType("image");
            entity.Property(e => e.IdentifyingMark)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedUserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lthumb).HasColumnType("image");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.NamePerson)
                .HasMaxLength(100)
                .HasColumnName("name_person");
            entity.Property(e => e.PhilhealthId)
                .HasMaxLength(100)
                .HasColumnName("philhealth_id");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Relationship)
                .HasMaxLength(20)
                .HasColumnName("relationship");
            entity.Property(e => e.ResidentialBrgy)
                .HasMaxLength(100)
                .HasColumnName("residential_brgy");
            entity.Property(e => e.ResidentialCtyMnicplty)
                .HasMaxLength(100)
                .HasColumnName("residential_CtyMnicplty");
            entity.Property(e => e.ResidentialNumber)
                .HasMaxLength(100)
                .HasColumnName("residential_number");
            entity.Property(e => e.ResidentialProvince)
                .HasMaxLength(100)
                .HasColumnName("residential_province");
            entity.Property(e => e.ResidentialStreet)
                .HasMaxLength(100)
                .HasColumnName("residential_street");
            entity.Property(e => e.Rthumb).HasColumnType("image");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
            entity.Property(e => e.SignatureImage).HasColumnType("image");
            entity.Property(e => e.SssId)
                .HasMaxLength(100)
                .HasColumnName("sss_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .HasColumnName("surname");
            entity.Property(e => e.TinId)
                .HasMaxLength(100)
                .HasColumnName("tin_id");
            entity.Property(e => e.Weight)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<IdPersonnelId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ID_PersonnelID");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdFingerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdFingerPrint).HasColumnType("image");
            entity.Property(e => e.IdImage).HasColumnType("image");
            entity.Property(e => e.IdNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdentifyingMark)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedUserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lthumb).HasColumnType("image");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Rthumb).HasColumnType("image");
            entity.Property(e => e.SignatureImage).HasColumnType("image");
        });

        modelBuilder.Entity<IdPrintEntry>(entity =>
        {
            entity.HasKey(e => e.PrintEntryId);

            entity.ToTable("ID_PrintEntries");

            entity.Property(e => e.PrintEntryId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_id");
            entity.Property(e => e.Error)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FailedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.HrisId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Hris_id");
            entity.Property(e => e.IdTemplate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastAttemptedDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PrintSourceId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrintStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrintTypeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrintTypeName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PrintedDate).HasColumnType("datetime");
            entity.Property(e => e.Printer)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.QueuedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RequeuedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<IdPrintType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ID_PrintTypes");

            entity.Property(e => e.PrintTypeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrintTypeName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IdPrinter>(entity =>
        {
            entity.HasKey(e => e.Serial);

            entity.ToTable("ID_Printers");

            entity.Property(e => e.Serial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IdTransactionAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ID_TransactionAudit");

            entity.Property(e => e.ExecutedDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutedUserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IdNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TransactionAuditId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransactionName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TransactionTypeCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<IdTransactionType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ID_TransactionTypes");

            entity.Property(e => e.Scope)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransactionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionTypeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<JobAppointOfficeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Job_Appoint_Office_History");

            entity.Property(e => e.AssumptionDate).HasColumnName("assumption_date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.DivisionId).HasColumnName("division_id");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SectionId).HasColumnName("section_id");
        });

        modelBuilder.Entity<OtcSet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTC_SET");

            entity.Property(e => e.DbId).HasColumnName("DB_ID");
            entity.Property(e => e.OtcFullname)
                .IsUnicode(false)
                .HasColumnName("OTC_FULLNAME");
            entity.Property(e => e.OtcId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OTC_ID");
        });

        modelBuilder.Entity<PersonnelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("personnel_view");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(12)
                .HasColumnName("employee_id");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(10)
                .HasColumnName("extension_name");
            entity.Property(e => e.GivenName)
                .HasMaxLength(50)
                .HasColumnName("given_name");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<PmsAuditTrail>(entity =>
        {
            entity.ToTable("PMS_AuditTrail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");
        });

        modelBuilder.Entity<PmsAwardeeRemark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_AwardeeRemarks");

            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PmsBarangay>(entity =>
        {
            entity.HasKey(e => e.IdBrgy).HasName("PK_Barangay");

            entity.ToTable("PMS_Barangay");

            entity.Property(e => e.IdBrgy).HasColumnName("id_Brgy");
            entity.Property(e => e.BrgyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Brgy_name");
            entity.Property(e => e.IdCity).HasColumnName("id_City");
        });

        modelBuilder.Entity<PmsCity>(entity =>
        {
            entity.HasKey(e => e.IdCity).HasName("PK_City");

            entity.ToTable("PMS_City");

            entity.Property(e => e.IdCity).HasColumnName("id_City");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_name");
            entity.Property(e => e.ProvinceId).HasColumnName("Province_id");
        });

        modelBuilder.Entity<PmsCourseList>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK_course_list");

            entity.ToTable("PMS_course_list");

            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CourseDescription)
                .HasMaxLength(100)
                .HasColumnName("course_description");
        });

        modelBuilder.Entity<PmsLoggedDateTime>(entity =>
        {
            entity.ToTable("PMS_LoggedDateTime");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ipAddress");
            entity.Property(e => e.LoggedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("loggedDateTime");
        });

        modelBuilder.Entity<PmsOccupationGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_occupation_groups");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .HasColumnName("group_code");
            entity.Property(e => e.GroupName)
                .HasMaxLength(80)
                .HasColumnName("group_name");
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .HasColumnName("service_code");
        });

        modelBuilder.Entity<PmsOccupationIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_occupation_index");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .HasColumnName("group_code");
            entity.Property(e => e.Position)
                .HasMaxLength(40)
                .HasColumnName("position");
            entity.Property(e => e.PositionCode)
                .HasMaxLength(10)
                .HasColumnName("position_code");
            entity.Property(e => e.SalaryGrade).HasColumnName("salary_grade");
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .HasColumnName("service_code");
        });

        modelBuilder.Entity<PmsOccupationService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_occupation_services");

            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .HasColumnName("service_code");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(60)
                .IsFixedLength()
                .HasColumnName("service_name");
        });

        modelBuilder.Entity<PmsOccupationVoluntary>(entity =>
        {
            entity.ToTable("PMS_occupation_voluntary");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.Hours).HasColumnName("hours");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Organization)
                .HasMaxLength(50)
                .HasColumnName("organization");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
        });

        modelBuilder.Entity<PmsOccupationWorkexp>(entity =>
        {
            entity.HasKey(e => e.WExpId).HasName("PK_occupation_workexp");

            entity.ToTable("PMS_occupation_workexp");

            entity.Property(e => e.WExpId).HasColumnName("wExpId");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.GovtService).HasColumnName("govt_service");
            entity.Property(e => e.HoursWeek).HasColumnName("hours_week");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MajorDuties)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("major_duties");
            entity.Property(e => e.MonthlySalary)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("monthly_salary");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.PositionTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position_title");
            entity.Property(e => e.ReasonLeave)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason_leave");
            entity.Property(e => e.SalaryGrade).HasColumnName("salary_grade");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.StepIncrement).HasColumnName("step_increment");
        });

        modelBuilder.Entity<PmsPersonnelChild>(entity =>
        {
            entity.HasKey(e => e.ChildId).HasName("PK_personnel_children");

            entity.ToTable("PMS_personnel_children");

            entity.Property(e => e.ChildId).HasColumnName("child_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(500)
                .HasColumnName("extension_name");
            entity.Property(e => e.GivenName)
                .HasMaxLength(500)
                .HasColumnName("given_name");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.Surname)
                .HasMaxLength(500)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<PmsPersonnelEducation>(entity =>
        {
            entity.HasKey(e => e.EducId).HasName("PK_personnel_education");

            entity.ToTable("PMS_personnel_education");

            entity.Property(e => e.EducId).HasColumnName("educ_id");
            entity.Property(e => e.AttendedFrom).HasColumnName("attended_from");
            entity.Property(e => e.AttendedTo).HasColumnName("attended_to");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .HasColumnName("course_name");
            entity.Property(e => e.EducationalLevel)
                .HasMaxLength(20)
                .HasColumnName("educational_level");
            entity.Property(e => e.HighestLevel)
                .HasMaxLength(20)
                .HasColumnName("highest_level");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.ScholarshipHonors)
                .HasMaxLength(50)
                .HasColumnName("scholarship_honors");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(100)
                .HasColumnName("school_name");
            entity.Property(e => e.YearGraduated).HasColumnName("year_graduated");
        });

        modelBuilder.Entity<PmsPersonnelEligibility>(entity =>
        {
            entity.HasKey(e => e.CivilId).HasName("PK_personnel_eligibilities");

            entity.ToTable("PMS_personnel_eligibilities");

            entity.Property(e => e.CivilId).HasColumnName("civil_id");
            entity.Property(e => e.ConferedDate).HasColumnName("confered_date");
            entity.Property(e => e.ConferedPlace)
                .HasMaxLength(50)
                .HasColumnName("confered_place");
            entity.Property(e => e.EligibilityName)
                .HasMaxLength(60)
                .HasColumnName("eligibility_name");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.LicenseId)
                .HasMaxLength(20)
                .HasColumnName("license_id");
            entity.Property(e => e.Rating)
                .HasMaxLength(10)
                .HasColumnName("rating");
            entity.Property(e => e.ValiditiyDate).HasColumnName("validitiy_date");
        });

        modelBuilder.Entity<PmsPersonnelInformation>(entity =>
        {
            entity.HasKey(e => e.HrisId);
            entity.ToTable("PMS_personnel_information");

            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id").HasMaxLength(12);
            entity.Property(e => e.Prefix).HasColumnName("prefix").HasMaxLength(50);
            entity.Property(e => e.Suffix).HasColumnName("suffix").HasMaxLength(50);
            entity.Property(e => e.Surname).HasColumnName("surname").HasMaxLength(50);
            entity.Property(e => e.GivenName).HasColumnName("given_name").HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasColumnName("middle_name").HasMaxLength(50);
            entity.Property(e => e.ExtensionName).HasColumnName("extension_name").HasMaxLength(10);
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.BirthPlace).HasColumnName("birth_place").HasMaxLength(100);
            entity.Property(e => e.Sex).HasColumnName("sex").HasMaxLength(10);
            entity.Property(e => e.CivilStatus).HasColumnName("civil_status").HasMaxLength(20);
            entity.Property(e => e.Height).HasColumnName("height").HasColumnType("decimal(4, 2)");
            entity.Property(e => e.Weight).HasColumnName("weight").HasColumnType("decimal(5, 2)");
            entity.Property(e => e.BloodType).HasColumnName("blood_type").HasMaxLength(5);

            // Government IDs
            entity.Property(e => e.GsisId).HasColumnName("gsis_id").HasMaxLength(50);
            entity.Property(e => e.PagibigId).HasColumnName("pagibig_id").HasMaxLength(50);
            entity.Property(e => e.PhilhealthId).HasColumnName("philhealth_id").HasMaxLength(50);
            entity.Property(e => e.SssId).HasColumnName("sss_id").HasMaxLength(50);
            entity.Property(e => e.TinId).HasColumnName("tin_id").HasMaxLength(50);

            // Citizenship
            entity.Property(e => e.CitizenshipDual).HasColumnName("citizenship_dual");
            entity.Property(e => e.CitizenshipBirth).HasColumnName("citizenship_birth");
            entity.Property(e => e.CitizenshipCountry).HasColumnName("citizenship_country").HasMaxLength(50);

            // Residential Address
            entity.Property(e => e.ResidentialRegion).HasColumnName("residential_region").HasMaxLength(100);
            entity.Property(e => e.ResidentialProvince).HasColumnName("residential_province").HasMaxLength(100);
            entity.Property(e => e.ResidentialCtyMnicplty).HasColumnName("residential_CtyMnicplty").HasMaxLength(100);
            entity.Property(e => e.ResidentialBrgy).HasColumnName("residential_brgy").HasMaxLength(100);
            entity.Property(e => e.ResidentialNumber).HasColumnName("residential_number").HasMaxLength(50);
            entity.Property(e => e.ResidentialStreet).HasColumnName("residential_street").HasMaxLength(100);
            entity.Property(e => e.ResidentialZipcode).HasColumnName("residential_zipcode");

            // Permanent Address
            entity.Property(e => e.PermanentRegion).HasColumnName("permanent_region").HasMaxLength(100);
            entity.Property(e => e.PermanentProvince).HasColumnName("permanent_province").HasMaxLength(100);
            entity.Property(e => e.PermanentCtyMnicplty).HasColumnName("permanent_CtyMnicplty").HasMaxLength(100);
            entity.Property(e => e.PermanentBrgy).HasColumnName("permanent_brgy").HasMaxLength(100);
            entity.Property(e => e.PermanentNumber).HasColumnName("permanent_number").HasMaxLength(50);
            entity.Property(e => e.PermanentStreet).HasColumnName("permanent_street").HasMaxLength(100);
            entity.Property(e => e.PermanentZipcode).HasColumnName("permanent_zipcode");

            // Emergency Contact (ICE) - Notice the exact database column casing/names
            entity.Property(e => e.NamePerson).HasColumnName("name_person").HasMaxLength(100);
            entity.Property(e => e.ContactNumber).HasColumnName("contact_number").HasMaxLength(50);
            entity.Property(e => e.Relationship).HasColumnName("relationship").HasMaxLength(50);
            entity.Property(e => e.IceRegion).HasColumnName("Ice_region").HasMaxLength(100);
            entity.Property(e => e.IceProvince).HasColumnName("Ice_province").HasMaxLength(100);
            entity.Property(e => e.IceCtyMnicplty).HasColumnName("Ice_CtyMnicplty").HasMaxLength(100);
            entity.Property(e => e.IceBrgy).HasColumnName("Ice_brgy").HasMaxLength(100);
            entity.Property(e => e.IceNumber).HasColumnName("Ice_number").HasMaxLength(50);
            entity.Property(e => e.IceStreet).HasColumnName("Ice_street").HasMaxLength(100);
            entity.Property(e => e.IceZipcode).HasColumnName("Ice_zipcode");

            // Contact Info
            entity.Property(e => e.Telephonenum).HasColumnName("telephonenum").HasMaxLength(50);
            entity.Property(e => e.Mobilenum).HasColumnName("mobilenum").HasMaxLength(50);
            entity.Property(e => e.Email).HasColumnName("email").HasMaxLength(100);
        });

        modelBuilder.Entity<PmsPersonnelInterview>(entity =>
        {
            entity.HasKey(e => e.InterviewId).HasName("PK_personnel_interview");

            entity.ToTable("PMS_personnel_interview");

            entity.Property(e => e.InterviewId).HasColumnName("interview_id");
            entity.Property(e => e.AdministrativeOffense).HasColumnName("administrative_offense");
            entity.Property(e => e.AoDetails)
                .HasMaxLength(100)
                .HasColumnName("ao_details");
            entity.Property(e => e.Convicted).HasColumnName("convicted");
            entity.Property(e => e.ConvictedDetails)
                .HasMaxLength(100)
                .HasColumnName("convicted_details");
            entity.Property(e => e.CriminallyCharge).HasColumnName("criminally_charge");
            entity.Property(e => e.DateFiled).HasColumnName("date_filed");
            entity.Property(e => e.DegreeDetails)
                .HasMaxLength(100)
                .HasColumnName("degree_details");
            entity.Property(e => e.EcDetails)
                .HasMaxLength(100)
                .HasColumnName("ec_details");
            entity.Property(e => e.ElectionCandidate).HasColumnName("election_candidate");
            entity.Property(e => e.ElectionResignation).HasColumnName("election_resignation");
            entity.Property(e => e.ErDetails)
                .HasMaxLength(100)
                .HasColumnName("er_details");
            entity.Property(e => e.FourthDegree).HasColumnName("fourth_degree");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Immigrant).HasColumnName("immigrant");
            entity.Property(e => e.ImmigrantDetails)
                .HasMaxLength(100)
                .HasColumnName("immigrant_details");
            entity.Property(e => e.IndigenousPerson).HasColumnName("indigenous_person");
            entity.Property(e => e.IpDetails)
                .HasMaxLength(100)
                .HasColumnName("ip_details");
            entity.Property(e => e.PvaoScholar).HasColumnName("pvao_scholar");
            entity.Property(e => e.Pwd).HasColumnName("pwd");
            entity.Property(e => e.PwdDetails)
                .HasMaxLength(100)
                .HasColumnName("pwd_details");
            entity.Property(e => e.PwdIdno)
                .HasMaxLength(50)
                .HasColumnName("pwd_idno");
            entity.Property(e => e.SeparatedDetails)
                .HasMaxLength(100)
                .HasColumnName("separated_details");
            entity.Property(e => e.SeparatedService).HasColumnName("separated_service");
            entity.Property(e => e.SoloParent).HasColumnName("solo_parent");
            entity.Property(e => e.SpDetails)
                .HasMaxLength(100)
                .HasColumnName("sp_details");
            entity.Property(e => e.SpdDetails)
                .HasMaxLength(100)
                .HasColumnName("spd_details");
            entity.Property(e => e.SpouseDescendant).HasColumnName("spouse_descendant");
            entity.Property(e => e.StatusCase)
                .HasMaxLength(50)
                .HasColumnName("status_case");
            entity.Property(e => e.ThirdDegree).HasColumnName("third_degree");
        });

        modelBuilder.Entity<PmsPersonnelLearningdevelopment>(entity =>
        {
            entity.HasKey(e => e.LdId).HasName("PK_personnel_learningdevelopment");

            entity.ToTable("PMS_personnel_learningdevelopment");

            entity.Property(e => e.LdId).HasColumnName("ld_id");
            entity.Property(e => e.Conducted)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conducted");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Hours)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("hours");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Program)
                .IsUnicode(false)
                .HasColumnName("program");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.TypeLd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type_ld");
        });

        modelBuilder.Entity<PmsPersonnelLogincredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_personnel_logincredentials");

            entity.ToTable("PMS_personnel_logincredentials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("employee_id");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userType");
        });

        modelBuilder.Entity<PmsPersonnelOrganization>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK_personnel_organization");

            entity.ToTable("PMS_personnel_organization");

            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Organization)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("organization");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
        });

        modelBuilder.Entity<PmsPersonnelParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_personnel_parents");

            entity.Property(e => e.FatherExtensionName)
                .HasMaxLength(10)
                .HasColumnName("father_extension_name");
            entity.Property(e => e.FatherGivenName)
                .HasMaxLength(20)
                .HasColumnName("father_given_name");
            entity.Property(e => e.FatherMiddleName)
                .HasMaxLength(20)
                .HasColumnName("father_middle_name");
            entity.Property(e => e.FatherSurname)
                .HasMaxLength(20)
                .HasColumnName("father_surname");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MotherGivenName)
                .HasMaxLength(20)
                .HasColumnName("mother_given_name");
            entity.Property(e => e.MotherMiddleName)
                .HasMaxLength(20)
                .HasColumnName("mother_middle_name");
            entity.Property(e => e.MotherSurname)
                .HasMaxLength(20)
                .HasColumnName("mother_surname");
        });

        modelBuilder.Entity<PmsPersonnelRecognition>(entity =>
        {
            entity.HasKey(e => e.RecogId).HasName("PK_personnel_recognition");

            entity.ToTable("PMS_personnel_recognition");

            entity.Property(e => e.RecogId).HasColumnName("recog_id");
            entity.Property(e => e.AcquiredDate).HasColumnName("acquired_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Organization)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("organization");
            entity.Property(e => e.Recognition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recognition");
        });

        modelBuilder.Entity<PmsPersonnelRelative>(entity =>
        {
            entity.HasKey(e => e.Relativeid);

            entity.ToTable("PMS_personnel_relative");

            entity.Property(e => e.Relativeid).HasColumnName("relativeid");
            entity.Property(e => e.EmpHrisId).HasColumnName("emp_hris_id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Relationship)
                .HasMaxLength(50)
                .HasColumnName("relationship");
            entity.Property(e => e.RelativeHrisId).HasColumnName("relative_hris_id");
        });

        modelBuilder.Entity<PmsPersonnelSkill>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("PK_personnel_skill");

            entity.ToTable("PMS_personnel_skill");

            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Skill)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("skill");
        });

        modelBuilder.Entity<PmsPersonnelSpouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_personnel_spouse");

            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(40)
                .HasColumnName("contact_number");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(40)
                .HasColumnName("employer_address");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(40)
                .HasColumnName("employer_name");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(10)
                .HasColumnName("extension_name");
            entity.Property(e => e.GivenName)
                .HasMaxLength(20)
                .HasColumnName("given_name");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.Occupation)
                .HasMaxLength(100)
                .HasColumnName("occupation");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<PmsPosition>(entity =>
        {
            entity.HasKey(e => e.Positionid);

            entity.ToTable("PMS_Position");

            entity.Property(e => e.Positionid).HasColumnName("positionid");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
        });

        modelBuilder.Entity<PmsProvince>(entity =>
        {
            entity.HasKey(e => e.IdProvince).HasName("PK_Province");

            entity.ToTable("PMS_Province");

            entity.Property(e => e.IdProvince).HasColumnName("id_province");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Province_name");
            entity.Property(e => e.RegionId).HasColumnName("Region_id");
        });

        modelBuilder.Entity<PmsPvaoPlantilla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_pvao_plantilla");

            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.OrgLocDiv)
                .HasMaxLength(10)
                .HasColumnName("org_loc_div");
            entity.Property(e => e.PlantillaId)
                .HasMaxLength(50)
                .HasColumnName("plantilla_id");
            entity.Property(e => e.PositionCode)
                .HasMaxLength(10)
                .HasColumnName("position_code");
        });

        modelBuilder.Entity<PmsRegion>(entity =>
        {
            entity.HasKey(e => e.IdRegion).HasName("PK_Region");

            entity.ToTable("PMS_Region");

            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PmsSchoolList>(entity =>
        {
            entity.HasKey(e => e.SchoolId).HasName("PK_school_list");

            entity.ToTable("PMS_school_list");

            entity.Property(e => e.SchoolId).HasColumnName("school_id");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("school_name");
        });

        modelBuilder.Entity<PmsServiceRecord>(entity =>
        {
            entity.HasKey(e => e.Servicerecordid);

            entity.ToTable("PMS_service_record");

            entity.Property(e => e.Servicerecordid).HasColumnName("servicerecordid");
            entity.Property(e => e.Agency)
                .HasMaxLength(50)
                .HasColumnName("agency");
            entity.Property(e => e.AnnualSalary).HasColumnName("annual_salary");
            entity.Property(e => e.DateFrom).HasColumnName("date_from");
            entity.Property(e => e.DateTo).HasColumnName("date_to");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(12)
                .HasColumnName("employeeid");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.SeparationCause)
                .HasMaxLength(50)
                .HasColumnName("separation_cause");
            entity.Property(e => e.SeparationDate).HasColumnName("separation_date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<PmsTownHallAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PMS_TownHallAttendance");

            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.DateOfBirth).HasColumnName("dateOfBirth");
            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.Employee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("employee");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fileName");
            entity.Property(e => e.Filepath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("filepath");
            entity.Property(e => e.GrpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<PmsZipcode>(entity =>
        {
            entity.HasKey(e => e.IdZipcode).HasName("PK_Zipcode");

            entity.ToTable("PMS_Zipcode");

            entity.Property(e => e.IdZipcode).HasColumnName("id_zipcode");
            entity.Property(e => e.IdBrgy).HasColumnName("id_Brgy");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Profile");

            entity.Property(e => e.AllowGraceperiod).HasColumnName("allow_graceperiod");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(50)
                .HasColumnName("birth_place");
            entity.Property(e => e.CivilStatus)
                .HasMaxLength(20)
                .HasColumnName("civil_status");
            entity.Property(e => e.CustomSched).HasColumnName("custom_sched");
            entity.Property(e => e.Division).HasColumnName("division");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(12)
                .HasColumnName("employee_id");
            entity.Property(e => e.EmploymentStats).HasColumnName("employment_stats");
            entity.Property(e => e.ExtensionName)
                .HasMaxLength(10)
                .HasColumnName("extension_name");
            entity.Property(e => e.Fwa).HasColumnName("FWA");
            entity.Property(e => e.GivenName)
                .HasMaxLength(50)
                .HasColumnName("given_name");
            entity.Property(e => e.GsisId)
                .HasMaxLength(100)
                .HasColumnName("gsis_id");
            entity.Property(e => e.HiredDate).HasColumnName("hired_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.MandatoryImmunity).HasColumnName("mandatory_immunity");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.PagibigId)
                .HasMaxLength(100)
                .HasColumnName("pagibig_id");
            entity.Property(e => e.PhilhealthId)
                .HasMaxLength(100)
                .HasColumnName("philhealth_id");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Pwd).HasColumnName("pwd");
            entity.Property(e => e.Schedule).HasColumnName("schedule");
            entity.Property(e => e.SeparationDate).HasColumnName("separation_date");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
            entity.Property(e => e.SoloParent).HasColumnName("solo_parent");
            entity.Property(e => e.SssId)
                .HasMaxLength(100)
                .HasColumnName("sss_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .HasColumnName("surname");
            entity.Property(e => e.TinId)
                .HasMaxLength(100)
                .HasColumnName("tin_id");
        });

        modelBuilder.Entity<RecruitmentCo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recruitment_COS");

            entity.Property(e => e.AssignedLoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assigned_loc");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.OriginalLoc)
                .IsUnicode(false)
                .HasColumnName("original_loc");
            entity.Property(e => e.Premium20)
                .HasColumnType("money")
                .HasColumnName("premium_20%");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
            entity.Property(e => e.Sg).HasColumnName("sg");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<RecruitmentIncumbent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recruitment_Incumbent");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Nature)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nature");
            entity.Property(e => e.ReasonOfVacant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reason_of_vacant");
            entity.Property(e => e.VacantDate).HasColumnName("vacant_date");
        });

        modelBuilder.Entity<RecruitmentPlantillium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recruitment_Plantillia");

            entity.Property(e => e.AssignedLoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assigned_loc");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.OriginalLoc)
                .IsUnicode(false)
                .HasColumnName("original_loc");
            entity.Property(e => e.PlantiliaItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("plantilia_itemNumber");
            entity.Property(e => e.Sg).HasColumnName("sg");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TimekeepingAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Action");

            entity.Property(e => e.ActionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("action_id");
            entity.Property(e => e.ActionName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("action_name");
        });

        modelBuilder.Entity<TimekeepingAuditTrail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_AuditTrail");

            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");
        });

        modelBuilder.Entity<TimekeepingBioDeviceIdchecker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_BioDeviceIDChecker");

            entity.Property(e => e.CheckDate).HasColumnName("check_date");
            entity.Property(e => e.CreatedInfo)
                .HasColumnType("datetime")
                .HasColumnName("created_info");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<TimekeepingCtoFiled>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_CtoFiled");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.CtoHr).HasColumnName("cto_hr");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Implementation).HasColumnName("implementation");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("origin");
        });

        modelBuilder.Entity<TimekeepingCtoRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_CtoRef");

            entity.Property(e => e.CtoFrom).HasColumnName("cto_from");
            entity.Property(e => e.CtoTo).HasColumnName("cto_to");
            entity.Property(e => e.Montly).HasColumnName("montly");
            entity.Property(e => e.NumberHr).HasColumnName("numberHr");
        });

        modelBuilder.Entity<TimekeepingCutOff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_CutOff");

            entity.Property(e => e.CreatedInfo)
                .HasColumnType("datetime")
                .HasColumnName("created_info");
            entity.Property(e => e.Cutoff).HasColumnName("cutoff");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<TimekeepingDevice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Device");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Commkey)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("commkey");
            entity.Property(e => e.ConnectType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.MachineName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("machine_name");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("product_name");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serial_number");
        });

        modelBuilder.Entity<TimekeepingDeviceEnrolUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_DeviceEnrolUser");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UserType).HasColumnName("user_type");
        });

        modelBuilder.Entity<TimekeepingDivision>(entity =>
        {
            entity.ToTable("timekeeping_Division");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.AlternateHead).HasColumnName("alternate_head");
            entity.Property(e => e.AlternateHeadDesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alternate_head_designation");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.DivIdSuperior).HasColumnName("div_id_superior");
            entity.Property(e => e.HeadHrisId).HasColumnName("head_hris_id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OfficeLevel).HasColumnName("office_level");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TimekeepingEmpStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_EmpStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TimekeepingEvaluation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Evaluation");

            entity.Property(e => e.AbsentNum).HasColumnName("absent_num");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TardHrtotal).HasColumnName("tard_HRtotal");
            entity.Property(e => e.TardMntotal).HasColumnName("tard_MNtotal");
            entity.Property(e => e.TardNum).HasColumnName("tard_num");
            entity.Property(e => e.UnderHrtotal).HasColumnName("under_HRtotal");
            entity.Property(e => e.UnderMntotal).HasColumnName("under_MNtotal");
            entity.Property(e => e.UnderNum).HasColumnName("under_num");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<TimekeepingFacePass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_FacePass");

            entity.Property(e => e.BioId).HasColumnName("bio_id");
            entity.Property(e => e.Face)
                .IsUnicode(false)
                .HasColumnName("face");
            entity.Property(e => e.Ifacelenght).HasColumnName("ifacelenght");
            entity.Property(e => e.Pass)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<TimekeepingFingerTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_FingerTemplate");

            entity.Property(e => e.BioId).HasColumnName("bio_id");
            entity.Property(e => e.Findex).HasColumnName("findex");
            entity.Property(e => e.Iflag).HasColumnName("iflag");
            entity.Property(e => e.Template)
                .IsUnicode(false)
                .HasColumnName("template");
        });

        modelBuilder.Entity<TimekeepingForVeriOb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_ForVeriOB");

            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ObType).HasColumnName("ob_type");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref");
        });

        modelBuilder.Entity<TimekeepingForVerification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_ForVerification");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DateGenerated)
                .HasColumnType("datetime")
                .HasColumnName("dateGenerated");
            entity.Property(e => e.Done).HasColumnName("done");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<TimekeepingFwa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_FWA");

            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Fri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fri");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastModifyInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mon");
            entity.Property(e => e.Thu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("thu");
            entity.Property(e => e.Tue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tue");
            entity.Property(e => e.Wed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("wed");
        });

        modelBuilder.Entity<TimekeepingIssueRemove>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_IssueRemove");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TimekeepingJointId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_JointID");

            entity.Property(e => e.BiometricId).HasColumnName("biometric_id");
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_id");
        });

        modelBuilder.Entity<TimekeepingLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Leave");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.LFrom).HasColumnName("L_from");
            entity.Property(e => e.LTo).HasColumnName("L_to");
            entity.Property(e => e.LeaveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("leave_id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TimekeepingLeaveBal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_LeaveBal");

            entity.Property(e => e.EmpNum).HasColumnName("emp_num");
            entity.Property(e => e.GainSl)
                .HasColumnType("numeric(6, 3)")
                .HasColumnName("gain_SL");
            entity.Property(e => e.GainVl)
                .HasColumnType("numeric(6, 3)")
                .HasColumnName("gain_VL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MonthYear).HasColumnName("month_year");
        });

        modelBuilder.Entity<TimekeepingLeaveItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_LeaveItem");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ApplicableTo).HasColumnName("applicableTo");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DaysUse).HasColumnName("days_use");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leave_name");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
        });

        modelBuilder.Entity<TimekeepingLeaveOff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_LeaveOff");

            entity.Property(e => e.CancelDate).HasColumnName("cancel_date");
            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
        });

        modelBuilder.Entity<TimekeepingLeaveWithOutPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_LeaveWithOutPay");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.LFrom).HasColumnName("L_from");
            entity.Property(e => e.LTo).HasColumnName("L_to");
            entity.Property(e => e.LeaveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("leave_id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TimekeepingLetterOrder>(entity =>
        {
            entity.ToTable("timekeeping_LetterOrder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmendedId).HasColumnName("amended_id");
            entity.Property(e => e.Attachment)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsAmend).HasColumnName("is_amend");
            entity.Property(e => e.RefNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ref_no");
        });

        modelBuilder.Entity<TimekeepingLetterOrderSub>(entity =>
        {
            entity.ToTable("timekeeping_LetterOrderSub");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Days)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("days");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.LoId).HasColumnName("LO_id");
            entity.Property(e => e.ObType).HasColumnName("ob_type");
            entity.Property(e => e.RefNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.Lo).WithMany(p => p.TimekeepingLetterOrderSubs)
                .HasForeignKey(d => d.LoId)
                .HasConstraintName("FK_timekeeping_LetterOrderSub_timekeeping_LetterOrder1");
        });

        modelBuilder.Entity<TimekeepingLogRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_LogRecord");

            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("device_sn");
            entity.Property(e => e.EntryNum)
                .ValueGeneratedOnAdd()
                .HasColumnName("entry_num");
            entity.Property(e => e.Flexi).HasColumnName("flexi");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("logtime");
            entity.Property(e => e.Modtype).HasColumnName("modtype");
            entity.Property(e => e.NoMandosched).HasColumnName("no_mandosched");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("personnel_id");
            entity.Property(e => e.Sched).HasColumnName("sched");
            entity.Property(e => e.UserId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Workcode).HasColumnName("workcode");
        });

        modelBuilder.Entity<TimekeepingLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Login");

            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsLock).HasColumnName("is_lock");
            entity.Property(e => e.Pass)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Reset).HasColumnName("reset");
            entity.Property(e => e.Usern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usern");
        });

        modelBuilder.Entity<TimekeepingMonetize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Monetize");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.MonitizeLeave).HasColumnName("monitize_leave");
            entity.Property(e => e.Remarks)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.TypeLeave).HasColumnName("type_leave");
        });

        modelBuilder.Entity<TimekeepingMonthlySummaryLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_MonthlySummaryLeave");

            entity.Property(e => e.CurrentFl).HasColumnName("current_FL");
            entity.Property(e => e.CurrentPl).HasColumnName("current_PL");
            entity.Property(e => e.CurrentSl)
                .HasColumnType("numeric(6, 3)")
                .HasColumnName("current_SL");
            entity.Property(e => e.CurrentSoloParent).HasColumnName("current_SoloParent");
            entity.Property(e => e.CurrentVl)
                .HasColumnType("numeric(6, 3)")
                .HasColumnName("current_VL");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
        });

        modelBuilder.Entity<TimekeepingNewLogrecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_NewLogrecord");

            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("device_sn");
            entity.Property(e => e.EntryNum)
                .ValueGeneratedOnAdd()
                .HasColumnName("entry_num");
            entity.Property(e => e.Flexi).HasColumnName("flexi");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("logtime");
            entity.Property(e => e.Modtype).HasColumnName("modtype");
            entity.Property(e => e.NoMandosched).HasColumnName("no_mandosched");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("personnel_id");
            entity.Property(e => e.Sched).HasColumnName("sched");
            entity.Property(e => e.UserId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Workcode).HasColumnName("workcode");
        });

        modelBuilder.Entity<TimekeepingNonWorkingDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_NonWorkingDays");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.NwdCut).HasColumnName("nwd_cut");
            entity.Property(e => e.NwdDay).HasColumnName("nwd_day");
            entity.Property(e => e.NwdDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nwd_desc");
            entity.Property(e => e.NwdId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nwd_id");
            entity.Property(e => e.NwdType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nwd_type");
        });

        modelBuilder.Entity<TimekeepingNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Notification");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Information).IsUnicode(false);
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<TimekeepingOccupationDetail>(entity =>
        {
            entity.ToTable("timekeeping_OccupationDetails");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.SeparationDate).HasColumnName("separation_date");
            entity.Property(e => e.SeparationReason).HasColumnName("separation_reason");

            // Map separation remarks column
            entity.Property(e => e.SeparationRemarks).HasColumnName("separation_remarks");
        });

        modelBuilder.Entity<TimekeepingOfficialBusiness>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_OfficialBusiness");

            entity.Property(e => e.AmendedId).HasColumnName("amended_id");
            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LoDetailsId).HasColumnName("lo_details_id");
            entity.Property(e => e.LoId).HasColumnName("lo_id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<TimekeepingOtclog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_OTCLogs");

            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("device_sn");
            entity.Property(e => e.EntryNum)
                .ValueGeneratedOnAdd()
                .HasColumnName("entry_num");
            entity.Property(e => e.Flexi).HasColumnName("flexi");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("logtime");
            entity.Property(e => e.Modtype).HasColumnName("modtype");
            entity.Property(e => e.NoMandosched).HasColumnName("no_mandosched");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("personnel_id");
            entity.Property(e => e.Sched).HasColumnName("sched");
            entity.Property(e => e.UserId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Workcode).HasColumnName("workcode");
        });

        modelBuilder.Entity<TimekeepingRestDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_RestDay");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TimekeepingSchedHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_SchedHistory");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateEffectivity).HasColumnName("date_effectivity");
            entity.Property(e => e.Fri).HasColumnName("fri");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Mon).HasColumnName("mon");
            entity.Property(e => e.Thu).HasColumnName("thu");
            entity.Property(e => e.Tue).HasColumnName("tue");
            entity.Property(e => e.Wed).HasColumnName("wed");
        });

        modelBuilder.Entity<TimekeepingSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Schedule");

            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.SchedId)
                .ValueGeneratedOnAdd()
                .HasColumnName("sched_id");
            entity.Property(e => e.SchedName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sched_name");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
        });

        modelBuilder.Entity<TimekeepingSetSched>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_SetSched");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.ExcludeMandoSched).HasColumnName("excludeMandoSched");
            entity.Property(e => e.FixSched).HasColumnName("fixSched");
            entity.Property(e => e.Fri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fri");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsFlexi).HasColumnName("isFlexi");
            entity.Property(e => e.Mon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mon");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Thu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("thu");
            entity.Property(e => e.Tue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tue");
            entity.Property(e => e.Wed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("wed");
        });

        modelBuilder.Entity<TimekeepingSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Setup");

            entity.Property(e => e.DsSs).HasColumnName("DS_SS");
            entity.Property(e => e.Graceperiod).HasColumnName("graceperiod");
            entity.Property(e => e.GraceperiodEnable).HasColumnName("graceperiod_enable");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ImperativeEnable).HasColumnName("imperative_enable");
            entity.Property(e => e.ImperativeSched)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Imperative_sched");
            entity.Property(e => e.SelectedImpSched).HasColumnName("selected_Imp_sched");
            entity.Property(e => e.Selectedsched).HasColumnName("selectedsched");
            entity.Property(e => e.WorkingHrs).HasColumnName("workingHrs");
            entity.Property(e => e.Workingmins).HasColumnName("workingmins");
        });

        modelBuilder.Entity<TimekeepingSignatory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Signatory");

            entity.Property(e => e.CertifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("certified_by");
            entity.Property(e => e.FormId)
                .ValueGeneratedOnAdd()
                .HasColumnName("form_id");
            entity.Property(e => e.FormName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("form_name");
            entity.Property(e => e.PreparedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("prepared_by");
            entity.Property(e => e.ReviewedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reviewed_by");
        });

        modelBuilder.Entity<TimekeepingSpecialCaseSched>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_SpecialCaseSched");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SchedId).HasColumnName("sched_id");
        });

        modelBuilder.Entity<TimekeepingTempCtoFiled>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempCtoFiled");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.CtoHr).HasColumnName("cto_hr");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Implementation).HasColumnName("implementation");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("origin");
        });

        modelBuilder.Entity<TimekeepingTempLeaveWithOutPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempLeaveWithOutPay");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.LFrom).HasColumnName("L_from");
            entity.Property(e => e.LTo).HasColumnName("L_to");
            entity.Property(e => e.LeaveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("leave_id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TimekeepingTempMonetize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempMonetize");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.MonitizeLeave).HasColumnName("monitize_leave");
            entity.Property(e => e.Remarks)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.TypeLeave).HasColumnName("type_leave");
        });

        modelBuilder.Entity<TimekeepingTempOfficialBusiness>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempOfficialBusiness");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.ObRef).HasColumnName("ob_ref");
            entity.Property(e => e.Origin)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("origin");
        });

        modelBuilder.Entity<TimekeepingTempUndertime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempUndertime");

            entity.Property(e => e.CreatebBy).HasColumnName("createbBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.TimeEquivalent).HasColumnName("time_equivalent");
            entity.Property(e => e.Undertime)
                .HasColumnType("numeric(5, 3)")
                .HasColumnName("undertime");
        });

        modelBuilder.Entity<TimekeepingTempUsedLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_TempUsedLeave");

            entity.Property(e => e.CreatedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_info");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("emp_id");
            entity.Property(e => e.LFrom).HasColumnName("L_from");
            entity.Property(e => e.LTo).HasColumnName("L_to");
            entity.Property(e => e.LeaveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("leave_id");
            entity.Property(e => e.ModifiedInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_info");
            entity.Property(e => e.Origin)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ref_no");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TimekeepingUndertime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timekeeping_Undertime");

            entity.Property(e => e.CreatebBy).HasColumnName("createbBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.TimeEquivalent).HasColumnName("time_equivalent");
            entity.Property(e => e.Undertime)
                .HasColumnType("numeric(5, 3)")
                .HasColumnName("undertime");
        });

        modelBuilder.Entity<TownHallMf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TownHallMF");

            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.HrisId).HasColumnName("hris_id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameEmployee)
                .HasMaxLength(103)
                .HasColumnName("name_employee");
        });

        modelBuilder.Entity<ViewDeviceEnrolledDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_deviceEnrolledDetails");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.Face)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("face");
            entity.Property(e => e.Finger).HasColumnName("finger");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.UserType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("user_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
