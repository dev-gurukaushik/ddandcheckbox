using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test.Data
{
    public partial class Studentinfo
    {
        public int CanditateId { get; set; }
        [Required]
        public string CanditateFirstName { get; set; } = null!;
        [Required]
        public string CanditateLastName { get; set; } = null!;
        [Required]
        public string CanditateAadhar { get; set; } = null!;
        [Required]
        public string CanditatePancard { get; set; } = null!;
        [Required]
        public string CanditateEmail { get; set; } = null!;
        [Required]
        public gender CanditateGender { get; set; }
        [Required]
        public Location CanditateLocation { get; set; }
        [Required]
        public maritalstatus CanditateMaritialStatus { get; set; }
        [Required]
        public DateTime? CanditateDoj { get; set; }
        [Required]
        public string? CanditateDepartment { get; set; }
        [Required]
        public string? CanditateAddress1 { get; set; }
        [Required]
        public string? CanditateAltNumber { get; set; }

        public string? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public sbyte? IsActive { get; set; }
        public sbyte? DeleteFlag { get; set; }


        public string? CanditateIdNumber { get; set; }
        [Required]
        public string? CanditateBaseLocation { get; set; }
        [Required]
        public string? CanditateMobile { get; set; }
        [Required]
        public Prefix CanditatePrefix { get; set; }
        [Required]
        public string? CanditateAddress2 { get; set; }
        [Required]
        public string? CanditateAddress3 { get; set; }

        public enum gender
        {
            select,
            Male,
            Female,
            Others
        }

        public enum maritalstatus
        {
            select,
            Single,
            Married,
            Widow,
            Widower
        }

        public enum Location
        {
            select,
            [Display(Name = "Chennai")]
            Chennai,
            [Display(Name = "Mumbai")]
            Mumbai,
            [Display(Name = "Delhi")]
            Delhi,
            [Display(Name = "Pune")]
            Pune
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
