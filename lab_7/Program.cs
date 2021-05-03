using System;
using System.Text.RegularExpressions;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name:");
            string userName = Console.ReadLine();
            Console.WriteLine(CheckName(userName));

            Console.WriteLine("Please enter a valid email:");
            string userEmail = Console.ReadLine();
            Console.WriteLine(CheckEmail(userEmail));

            Console.WriteLine("Please enter a valid phone number:");
            string userMobile = Console.ReadLine();
            Console.WriteLine(CheckMobile(userMobile));

            Console.WriteLine("Please enter a valid date:");
            string userDate = Console.ReadLine();
            Console.WriteLine(CheckDate(userDate));
        }

        public static string CheckName(string userName)
        {
            
            string nameRegex = "^[A-Z]{1,1}[a-z]{1,30}$";
            if (Regex.IsMatch(userName, nameRegex))
            {
                return "Name is valid!";
            }
            else
            {
                return "Sorry, name is not valid.";
            }

        }

        public static string CheckEmail(string email)
        {
            
            string emailRegex = "^[A-Z, a-z, 0-9]{5,10}[@][A-Z, a-z, 0-9]{5,10}[.][A-Z, a-z, 0-9]{2,3}$";
            if (Regex.IsMatch(email, emailRegex))
            {
                return "Email is valid!";
            }
            else
            {
                return "Sorry, email is not valid.";
            }

        }

        public static string CheckMobile(string mobile)
        {
            
            string mobileRegex = "^[0-9]{3,3}[-][0-9]{3,3}[-][0-9]{4,4}$";
            if (Regex.IsMatch(mobile, mobileRegex))
            {
                return "Phone number is valid!";
            }
            else
            {
                return "Sorry, phone number is not valid.";
            }

        }

        public static string CheckDate(string date)
        {
            
            string dateRegex = "^[0-9]{2,2}[/][0-9]{2,2}[/][0-9]{4,4}$";
            if (Regex.IsMatch(date, dateRegex))
            {
                return "Date is valid!";
            }
            else
            {
                return "Sorry, date is not vaild!";
            }

        }
    }
}
