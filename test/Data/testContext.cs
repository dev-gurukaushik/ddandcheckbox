using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test.Data
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BasicInfo> BasicInfos { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<Prefix> Prefixes { get; set; } = null!;
        public virtual DbSet<Studentinfo> Studentinfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=test;user=root;port=3306;password=Cma-Cgm@2022;persist security info=False;connect timeout=30", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<BasicInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PRIMARY");

                entity.ToTable("basic_info");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.CanditateDoj)
                    .HasMaxLength(6)
                    .HasColumnName("Canditate_DOJ");

                entity.Property(e => e.EmployeeAadhar)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Aadhar");

                entity.Property(e => e.EmployeeAadharLinkedPhone)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Aadhar_Linked_Phone");

                entity.Property(e => e.EmployeeAge)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Age");

                entity.Property(e => e.EmployeeBloodGroup)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Blood_Group");

                entity.Property(e => e.EmployeeDepartment)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Department");

                entity.Property(e => e.EmployeeDesignation)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Designation");

                entity.Property(e => e.EmployeeDob)
                    .HasMaxLength(6)
                    .HasColumnName("Employee_DOB");

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Email");

                entity.Property(e => e.EmployeeFatherHusband).HasColumnName("Employee _Father/Husband");

                entity.Property(e => e.EmployeeFatherName)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Father_Name");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_First_Name");

                entity.Property(e => e.EmployeeHusbandName)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Husband_Name");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Last_Name");

                entity.Property(e => e.EmployeeMaritalStatus).HasColumnName("Employee_Marital_Status");

                entity.Property(e => e.EmployeeMobileNumber)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Mobile_Number");

                entity.Property(e => e.EmployeePancard)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Pancard");

                entity.Property(e => e.EmployeePermanentAddress)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Address");

                entity.Property(e => e.EmployeePermanentCity)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_City");

                entity.Property(e => e.EmployeePermanentCountry)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Country");

                entity.Property(e => e.EmployeePermanentDistrict)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_District");

                entity.Property(e => e.EmployeePermanentPincode)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Pincode");

                entity.Property(e => e.EmployeePermanentPoliceStation)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_PoliceStation");

                entity.Property(e => e.EmployeePermanentPostoffice)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Postoffice");

                entity.Property(e => e.EmployeePermanentState)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_State");

                entity.Property(e => e.EmployeePermanentTaluka)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Taluka");

                entity.Property(e => e.EmployeePermanentVillage)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Permanent_Village");

                entity.Property(e => e.EmployeePhoneNumber)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Phone_Number");

                entity.Property(e => e.EmployeePrefix).HasColumnName("Employee_Prefix");

                entity.Property(e => e.EmployeeReligion)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Religion");

                entity.Property(e => e.EmployeeResidentialAddress)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Residential_Address");

                entity.Property(e => e.EmployeeResidentialCity)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Residential_City");

                entity.Property(e => e.EmployeeResidentialCountry)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Residential_Country");

                entity.Property(e => e.EmployeeResidentialPincode)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Residential_Pincode");

                entity.Property(e => e.EmployeeResidentialState)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Residential_State");

                entity.Property(e => e.EmployeeTransportPhoneNumber)
                    .HasMaxLength(45)
                    .HasColumnName("Employee_Transport_Phone_Number");

                entity.Property(e => e.EmployeeTransportRequestStatus).HasColumnName("Employee_Transport_Request_Status");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(45)
                    .HasColumnName("Entered_By");

                entity.Property(e => e.EnteredDate)
                    .HasMaxLength(6)
                    .HasColumnName("Entered_Date");

                entity.Property(e => e.Isaddharnumbersame).HasColumnName("isaddharnumbersame");

                entity.Property(e => e.Isaddresssame).HasColumnName("isaddresssame");

                entity.Property(e => e.Isphonesame).HasColumnName("isphonesame");

                entity.Property(e => e.UpdateDatetime)
                    .HasMaxLength(6)
                    .HasColumnName("Update_Datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(45)
                    .HasColumnName("Updated_By");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.GenderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Gender_Id");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(45)
                    .HasColumnName("Gender_Name");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Location_ID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(45)
                    .HasColumnName("Location_Name");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("marital_status");

                entity.Property(e => e.MaritalStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Marital_Status_Id");

                entity.Property(e => e.MaritalStatusName)
                    .HasMaxLength(45)
                    .HasColumnName("Marital_Status_Name");
            });

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.ToTable("prefix");

                entity.Property(e => e.PrefixId)
                    .ValueGeneratedNever()
                    .HasColumnName("Prefix_ID");

                entity.Property(e => e.PrefixName)
                    .HasMaxLength(45)
                    .HasColumnName("Prefix_Name");
            });

            modelBuilder.Entity<Studentinfo>(entity =>
            {
                entity.HasKey(e => e.CanditateId)
                    .HasName("PRIMARY");

                entity.ToTable("studentinfo");

                entity.Property(e => e.CanditateId).HasColumnName("Canditate_ID");

                entity.Property(e => e.CanditateAadhar)
                    .HasMaxLength(25)
                    .HasColumnName("Canditate_Aadhar");

                entity.Property(e => e.CanditateAddress1)
                    .HasMaxLength(1000)
                    .HasColumnName("Canditate_Address_1");

                entity.Property(e => e.CanditateAddress2)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Address_2");

                entity.Property(e => e.CanditateAddress3)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Address_3");

                entity.Property(e => e.CanditateAltNumber)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Alt_Number");

                entity.Property(e => e.CanditateBaseLocation)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Base_Location");

                entity.Property(e => e.CanditateDepartment)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Department");

                entity.Property(e => e.CanditateDoj)
                    .HasMaxLength(6)
                    .HasColumnName("Canditate_DOJ");

                entity.Property(e => e.CanditateEmail)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Email");

                entity.Property(e => e.CanditateFirstName)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_First_Name");

                entity.Property(e => e.CanditateGender).HasColumnName("Canditate_Gender");

                entity.Property(e => e.CanditateIdNumber)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_ID_Number");

                entity.Property(e => e.CanditateLastName)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Last_Name");

                entity.Property(e => e.CanditateLocation).HasColumnName("Canditate_Location");

                entity.Property(e => e.CanditateMaritialStatus).HasColumnName("Canditate_maritial_Status");

                entity.Property(e => e.CanditateMobile)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_Mobile");

                entity.Property(e => e.CanditatePancard)
                    .HasMaxLength(45)
                    .HasColumnName("Canditate_PANCard");

                entity.Property(e => e.CanditatePrefix).HasColumnName("Canditate_Prefix");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(45)
                    .HasColumnName("Entered_By");

                entity.Property(e => e.EnteredDate)
                    .HasMaxLength(6)
                    .HasColumnName("Entered_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(45)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasMaxLength(6)
                    .HasColumnName("Updated_Date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
