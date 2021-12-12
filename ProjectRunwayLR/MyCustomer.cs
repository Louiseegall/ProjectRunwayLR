using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunwayLR
{
    class MyCustomer: MyPersons
    {
        private DateTime datePaid;
       
        
        public MyCustomer():base()
        {
            this.DatePaid = new DateTime();
          
        }

        public MyCustomer(DateTime datePaid, string title, string forename, string surname, string street, string town, string county, string country, string postcode, string email, string telNo, DateTime dOB)
         : base( title,  forename,  surname,  street,  town,  county,  country,  postcode,  email,  telNo,  dOB )
        {
            
            this.datePaid = datePaid;
          
        }
           

     

        public DateTime DatePaid { get => datePaid; set => datePaid = value; }
       
        public int IDNo { get; internal set; }
        public object Email { get; internal set; }
    }
}
