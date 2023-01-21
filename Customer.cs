using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        public string Code;
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Nin;
        public string Bvn;
        public string Address;
        public string StateOfOrigin;
        public string Country = "Nigeria";
        public string CustomerType;
        public string Dob;
        public string PhoneNumber;
        public string Email;
        public string Gender;
        public string NokName;
        public string NokAddress;
        public string NokPhone;
        public string NokEmail;
        public string NokGender;
        public string NokRelationshipType;

        //Customer Methods
        public Customer CreateCustomer()
        {
            return null;
        }
        public Customer UpdateCustomer()
        {
            return null;
        }
        public Customer DeleteCustomer()
        {
            return null;
        }
        public void ListOfCustomers()
        {

        }
        public static void FindCustomer()
        {

        }
        public static void FindCustomerById()
        {

        }
        public static void FindCustomerByCode()
        {

        }
        public static bool VerifyNIN()
        {
            return true;
        }
        public static bool VerifyBVN()
        {
            return true;
        }



    }
}