using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunwayLR
{
    class MyValidation
    {
        public static bool validLength(String txt, int min, int max)
        {
            bool ok = true;
            if (String.IsNullOrEmpty(txt))
                ok = false;
            else if (txt.Length < min || txt.Length > max)
                ok = false;
            return ok;
        }
        public static bool validNumber(String txt)
        {
            bool ok = true;

            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                    ok = false;
            }
            return ok;
        }

        public static bool validLetter(String txt) // allows alphabetic character
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validLetterWhitespace(String txt)// alllows alphabetic characters and white space
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validLetterNumberWhitespace(String txt) //allows alphanumeric and white spaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
                ok = false;
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && (!char.IsWhiteSpace(txt[x])) && !(char.IsNumber(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validForename(String txt) //allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validSurname(String txt) // allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-'))
                        && !(txt[x].Equals('\'')))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validStreet(String txt) //allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validTown(String txt) //allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validCounty(String txt) //allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }

        internal static bool validNumber(int value)
        {
            throw new NotImplementedException();
        }

        internal static bool validLength(int value, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static bool validCountry(String txt) //allows alphabetic, dash and whitespaces
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }
        public static bool validDOB(String txt)
        {
            bool ok = true;

            DateTime currentDate = DateTime.Now;
            DateTime dOB = Convert.ToDateTime(txt);

            TimeSpan t = currentDate - dOB;
            double noOfDays = t.TotalDays;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (noOfDays <= 56)
                    ok = false;
            }
            return ok;
        }
        //  EmailAddress

        public static String firstLetterEachWordToUpper(String word)
        {
            Char[] array = word.ToCharArray();
            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }
            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {
                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToLower(array[x]);
                    }
                }
            }
            return new string(array);
        }



        public static String eachLetterToUpper(String word)
        {
            Char[] array = word.ToCharArray();
            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }
            }
            return new String(array);
        }

    }
}

