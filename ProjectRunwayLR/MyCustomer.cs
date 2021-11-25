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
        private double discount;
        
        public MyCustomer():base()
        {
            this.DatePaid = new DateTime();
            this.discount = 0.0;
        }

        public MyCustomer(DateTime datePaid, double discount, string title, string forename, string surname, string street, string town, string county, string country, string postcode, string email, string telNo, DateTime dOB)
         : base( title,  forename,  surname,  street,  town,  county,  country,  postcode,  email,  telNo,  dOB )
        {
            
            this.datePaid = datePaid;
            this.discount = discount;
        }
           

     

        public DateTime DatePaid { get => datePaid; set => datePaid = value; }
        public double Discount { get => discount; set => discount = value; }
        public int IDNo { get; internal set; }
        public object Email { get; internal set; }
    }
}
