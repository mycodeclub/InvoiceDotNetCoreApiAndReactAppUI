using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InvoiceDemo.Models;

public partial class BitProSoftTechContext : DbContext
{
    public BitProSoftTechContext()
    {
    }

    public BitProSoftTechContext(DbContextOptions<BitProSoftTechContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CodeHelper> CodeHelpers { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseCategory> CourseCategories { get; set; }

    public virtual DbSet<EducationBoardsMaster> EducationBoardsMasters { get; set; }

    public virtual DbSet<Enquiry> Enquiries { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<IdentityUserRoleGuid> IdentityUserRoleGuids { get; set; }

    public virtual DbSet<Invoic> Invoics { get; set; }

    public virtual DbSet<InvoicDtocustomer> InvoicDtocustomers { get; set; }

    public virtual DbSet<InvoicDtomerchant> InvoicDtomerchants { get; set; }

    public virtual DbSet<InvoicItem> InvoicItems { get; set; }

    public virtual DbSet<InvoicPayment> InvoicPayments { get; set; }

    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<JobRole> JobRoles { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<RegistrationForm> RegistrationForms { get; set; }

    public virtual DbSet<RegistrationStatusMaster> RegistrationStatusMasters { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-GEEONL46\\MSSQLSERVER01;Initial Catalog=BitProSoftTech;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Address");

            entity.HasIndex(e => e.CityId, "IX_Address_CityId");

            entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

            entity.HasIndex(e => e.StateId, "IX_Address_StateId");

            entity.Property(e => e.PinCode).HasMaxLength(6);

            entity.HasOne(d => d.City).WithMany(p => p.Addresses).HasForeignKey(d => d.CityId);

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.State).WithMany(p => p.Addresses).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable("ApplicationUser");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.AddressId, "IX_ApplicationUser_AddressId");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Address).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.AddressId);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
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

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.Property(e => e.Ifsccode).HasColumnName("IFSCCode");
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.HasKey(e => e.UniqueId);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.StateId, "IX_Cities_StateId");

            entity.HasOne(d => d.State).WithMany(p => p.Cities).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<CodeHelper>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.SubjectId, "IX_CodeHelpers_SubjectId");

            entity.HasOne(d => d.Subject).WithMany(p => p.CodeHelpers).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.UniqueId);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.UniqueId);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Course");

            entity.HasIndex(e => e.CourseCategoryId, "IX_Course_CourseCategoryID");

            entity.Property(e => e.CourseCategoryId).HasColumnName("CourseCategoryID");

            entity.HasOne(d => d.CourseCategory).WithMany(p => p.Courses).HasForeignKey(d => d.CourseCategoryId);
        });

        modelBuilder.Entity<CourseCategory>(entity =>
        {
            entity.HasKey(e => e.UniqueId);
        });

        modelBuilder.Entity<EducationBoardsMaster>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("EducationBoardsMaster");
        });

        modelBuilder.Entity<Enquiry>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Enquiry");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.StudentId, "IX_Fees_StudentId");

            entity.HasOne(d => d.Student).WithMany(p => p.Fees).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<IdentityUserRoleGuid>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.ToTable("IdentityUserRole<Guid>");
        });

        modelBuilder.Entity<Invoic>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Invoic");

            entity.HasIndex(e => e.CustomerId, "IX_Invoic_CustomerId");

            entity.Property(e => e.BillableAmountAfterDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RemainingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPaid).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Invoics).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<InvoicDtocustomer>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("InvoicDTOCustomer");
        });

        modelBuilder.Entity<InvoicDtomerchant>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("InvoicDTOMerchant");

            entity.HasIndex(e => e.AccountDetailsUniqueId, "IX_InvoicDTOMerchant_AccountDetailsUniqueId");

            entity.HasOne(d => d.AccountDetailsUnique).WithMany(p => p.InvoicDtomerchants).HasForeignKey(d => d.AccountDetailsUniqueId);
        });

        modelBuilder.Entity<InvoicItem>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.InvoiceId, "IX_InvoicItems_InvoiceId");

            entity.Property(e => e.UnitCounts).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoicItems).HasForeignKey(d => d.InvoiceId);
        });

        modelBuilder.Entity<InvoicPayment>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.BaseInvoiceId, "IX_InvoicPayments_BaseInvoiceId");

            entity.Property(e => e.ReceivedAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BaseInvoice).WithMany(p => p.InvoicPayments).HasForeignKey(d => d.BaseInvoiceId);
        });

        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("JobApplication");
        });

        modelBuilder.Entity<JobRole>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("JobRole");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.SubjectId, "IX_Questions_SubjectId");

            entity.HasOne(d => d.Subject).WithMany(p => p.Questions).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<RegistrationForm>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("RegistrationForm");

            entity.HasIndex(e => e.ApplicationFor, "IX_RegistrationForm_ApplicationFor");

            entity.HasIndex(e => e.BoardId, "IX_RegistrationForm_BoardId");

            entity.HasIndex(e => e.StatusId, "IX_RegistrationForm_StatusId");

            entity.HasOne(d => d.ApplicationForNavigation).WithMany(p => p.RegistrationForms).HasForeignKey(d => d.ApplicationFor);

            entity.HasOne(d => d.Board).WithMany(p => p.RegistrationForms).HasForeignKey(d => d.BoardId);

            entity.HasOne(d => d.Status).WithMany(p => p.RegistrationForms).HasForeignKey(d => d.StatusId);
        });

        modelBuilder.Entity<RegistrationStatusMaster>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("RegistrationStatusMaster");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.HasIndex(e => e.CountryId, "IX_States_CountryId");

            entity.HasOne(d => d.Country).WithMany(p => p.States).HasForeignKey(d => d.CountryId);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Subject");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
