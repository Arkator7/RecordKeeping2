using System;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeping.Models
{
    public class User
    {
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128), RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$")]
        public string Password { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Firstname { get; set; }

        [Required, StringLength(100), Display(Name = "Surname")]
        public string Lastname { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> DateOfBirth { get; set; }

        [Required, StringLength(256)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }
    }
}
