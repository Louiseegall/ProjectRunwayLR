using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunwayLR
{
    class MyStaff: MyPersons
    {
        private int staffNumber;
        private String speciality, emergencyContact;

        public MyStaff():base()
        {
            this.emergencyContact = "x";
            this.staffNumber = 0000;
            this.speciality = "x";
        }

        public MyStaff(String emergencyContact, int staffNumber, String Speciality, string title,
            string forename, string surname, string street, string town, string county,
            string country, string postcode, string email, string telNo, DateTime dOB, string speciality)
            : base(title, forename, surname, street, town, county, country, postcode, email, telNo, dOB)
        {
            this.emergencyContact = emergencyContact;
            this.staffNumber = staffNumber;
            this.speciality = speciality;
           
        }

        public String EmergencyContact { get => emergencyContact; set => emergencyContact = value; }
        public int StaffNumber { get => staffNumber; set => staffNumber = value; }
        public object email { get; internal set; }
        public string Speciality { get => speciality; set => speciality = value; }
    }
    
}
