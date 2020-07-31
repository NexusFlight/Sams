using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        public string StudentCourseCode { get; set; }
        public string StudentCourseTitle { get; set; }
        public ContactPreferences ContactPreferences { get; set; }
        public ContactDetails ContactDetails { get; set; }
    }

    public class ContactPreferences
    {
        public bool ByPhone { get; set; }
        public bool ByEmail { get; set; }
        public bool ByLetter { get; set; }
        //EF Foreign Keys 
        [JsonIgnore]
        public Student Student { get; set; }
        [JsonIgnore]
        public int StudentID { get; set; }
    }

    public class ContactDetails
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        //EF Foreign Keys 
        [JsonIgnore]
        public Student Student { get; set; }
        [JsonIgnore]
        public int StudentID { get; set; }
    }

    
    public class Address
    {
        
        public string DoorNumber { get; set; }
        public string RoadName { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }

        //EF Foreign Keys 
        [JsonIgnore]
        public ContactDetails ContactDetails { get; set; }
        [JsonIgnore]
        public int StudentID { get; set; }
    }
}
