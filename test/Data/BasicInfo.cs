using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace test.Data
{
    public partial class BasicInfo
    {
        public int EmployeeId { get; set; }
        public Prefix? EmployeePrefix { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeDesignation { get; set; }
        public string? EmployeeDepartment { get; set; }
        public DateTime? EmployeeDob { get; set; }
        public string? EmployeeAge { get; set; }
        public string? EmployeeReligion { get; set; }
        public relation? EmployeeFatherHusband { get; set; }
        public string? EmployeeFatherName { get; set; }
        public string? EmployeeHusbandName { get; set; }
        public maritalstatus? EmployeeMaritalStatus { get; set; }
        public string? EmployeePhoneNumber { get; set; }
        public string? EmployeeMobileNumber { get; set; }
        public string? EmployeeEmail { get; set; }
        public string? EmployeePermanentAddress { get; set; }
        public string? EmployeePermanentVillage { get; set; }
        public string? EmployeePermanentTaluka { get; set; }
        public string? EmployeePermanentCity { get; set; }
        public string? EmployeePermanentDistrict { get; set; }
        public string? EmployeePermanentState { get; set; }
        public string? EmployeePermanentCountry { get; set; }
        public string? EmployeePermanentPincode { get; set; }
        public string? EmployeePermanentPostoffice { get; set; }
        public string? EmployeePermanentPoliceStation { get; set; }
        public string? EmployeeResidentialAddress { get; set; }
        public string? EmployeeResidentialCity { get; set; }
        public string? EmployeeResidentialState { get; set; }
        public string? EmployeeResidentialCountry { get; set; }
        public string? EmployeeResidentialPincode { get; set; }
        public string? EmployeeBloodGroup { get; set; }
        public status? EmployeeTransportRequestStatus { get; set; }
        public string? EmployeeTransportPhoneNumber { get; set; }
        public string? EmployeeAadhar { get; set; }
        public string? EmployeeAadharLinkedPhone { get; set; }
        public string? EmployeePancard { get; set; }
        public DateTime? CanditateDoj { get; set; }
        public string? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public sbyte? Isactive { get; set; }
        public sbyte? DeleteFlag { get; set; }
        public sbyte? Isaddresssame { get; set; }
        public sbyte? Isphonesame { get; set; }
        public sbyte? Isaddharnumbersame { get; set; }

        public enum status
        {
            select,
            yes,
            No
            
        }

        public enum relation
        {
            select,
            father,
            Husband

        }

        public enum maritalstatus
        {
            select,
            Single,
            Married,
            Widow,
            Widower
        }

        
        public enum Prefix
        {
            select,
            Mr,
            Mrs,
            Miss
        }
    }
}
