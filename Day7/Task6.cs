using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task6
    {
        public static bool ValidatePersonId(string personId)
        {
            if (personId.Length != 12)
            {
                return false;
            }
            else if (!personId.Substring(6, 1).Equals("-"))
            {
                return false;
            }
            return true;
        }
        public static void PrintBirthday(string personId)
        {
            string day = personId.Substring(0, 2) + ". ";
            string month = personId.Substring(2, 2);
            string year = personId.Substring(4, 2);
            int yearCheck = Convert.ToInt32(personId.Substring(4, 2));
            if (yearCheck >= 19)
            {
                year = "19" + year + ". gads";
            }
            else
            {
                year = "20" + year + ". gads";
            }
            switch (month)
            {
                case "01":
                    month = "janvāris ";
                    break;

                case "02":
                    month = "februāris ";
                    break;

                case "03":
                    month = "marts ";
                    break;

                case "04":
                    month = "aprīlis";
                    break;

                case "05":
                    month = "maijs ";
                    break;

                case "06":
                    month = "jūnijs ";
                    break;

                case "07":
                    month = "jūlijs ";
                    break;

                case "08":
                    month = "augusts ";
                    break;

                case "09":
                    month = "septembris ";
                    break;

                case "10":
                    month = "oktobris ";
                    break;

                case "11":
                    month = "novembris ";
                    break;

                case "12":
                    month = "decembris ";
                    break;
            }
            Console.WriteLine($"{day}{month}{year}");
        }
    }
}
