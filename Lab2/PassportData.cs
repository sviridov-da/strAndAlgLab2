using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PassportData
    {
        string PassportNumber;
        DateTime DateOfIssue;

        public PassportData(string number, DateTime dateOfIssue)
        {
            PassportNumber = number;
            DateOfIssue = dateOfIssue.Date;
        }

        public int YearOfIssue
        {
            get
            {
                return DateOfIssue.Year;
            }
        }

        public int MonthOfIssue
        {
            get
            {
                return DateOfIssue.Month;
            }
        }

        public int DayOfIssue
        {
            get
            {
                return DateOfIssue.Day;
            }
        }

        public override bool Equals(object obj)
        {
            PassportData passportData = (PassportData)obj;
            return PassportNumber == passportData.PassportNumber && DateOfIssue.Equals(passportData.DateOfIssue);
        }

        public override int GetHashCode()
        {
            int hashCode = -1029081903;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PassportNumber);
            hashCode = hashCode * -1521134295 + DateOfIssue.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Number: " + PassportNumber.ToString() + ". Date of issue: " + DateOfIssue.Day.ToString() + "." + DateOfIssue.Month.ToString() + "." + DateOfIssue.Year.ToString(); ;
        }
    }
}
