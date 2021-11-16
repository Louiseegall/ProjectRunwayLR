using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunwayLR
{
    class MyPersons
    {
        private string title, surname, forename, street, town, county, country, postcode, email, telNo;
        private DateTime dOB;
      
        public MyPersons() 
        {
            this.title = "";
            this.surname = "";
            this.forename = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.country = "";
            this.postcode = "";
            this.email = "";
            this.telNo = "";
            this.dOB = new DateTime();
        }

        public MyPersons(string title, string surname, string forename, string street, string town, string county, string country, string postcode, string email, string telNo, DateTime dOB)
        {
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.street = street;
            this.town = town;
            this.county = county;
            this.country = country;
            this.postcode = postcode;
            this.email = email;
            this.telNo = telNo;
            this.dOB = dOB;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.ToUpper() != "MR" && value.ToUpper() != "MRS" && value.ToUpper() != "MISS" && value.ToUpper() != "MS")
                    throw new MyException("Title must be Mr, Mrs, Miss or Ms.");
                else
                    title = MyValidation.firstLetterEachWordToUpper(value);
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 letters");
            }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");
            }
        }
        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }
        }


        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }
        }

        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-20 letters");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validStreet(value))
                {
                    country = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("street must be 2-15 letters");
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 8, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.eachLetterToUpper(value);
                }
                else
                    throw new MyException("Postcode must be 7-8 letters and alphanumeric only");
            }
        }

    

        public string TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }
        }

        public static bool validEmail(string txt)
        {
            int at = txt.IndexOf("@");
            int lastDot = txt.LastIndexOf(".");
            if (at < 1) return false;
            if (lastDot < at || txt.Contains("..") || txt.EndsWith(".")) return false;
            string local = txt.Substring(0, at);
            if (local.StartsWith(".") || local.EndsWith(".")) return false;
            if (local.StartsWith(".") || local.EndsWith(".")) return false;
            string domain = txt.Substring(at + 1, lastDot - at - 1);
            if (domain.StartsWith(".") || local.EndsWith(".")) return false;
            if (domain.StartsWith("-") || local.EndsWith("-")) return false;
            string topLevelDomain = txt.Substring(lastDot + 1);



            foreach (char c in local)
            {
                if (!validLocalChar(c)) return false;
            }
            foreach (char c in domain)
            {
                if (!validDomainChar(c)) return false;
            }
            foreach (char c in topLevelDomain)
            {
                if (!char.IsLetter(c)) return false;
            }
            return true;



        }
        private static bool validLocalChar(char c)
        {
            if (char.IsLetter(c)) return true;
            if (char.IsNumber(c)) return true;
            if ("!#$%&'*+-/=?^_`{|}~.".Contains(c.ToString())) return true;
            return false;
        }
        private static bool validDomainChar(char c)
        {
            if (char.IsLetter(c)) return true;
            if (char.IsNumber(c)) return true;
            if (c == '-' || c == '.') return true;
            return false;
        }

    }
}
