using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string city;
        public string state;
        public string Zip_Code;
        public long Phone_Number;
        public string Email;

        //Defining constructor
        public AddressBook(string first_Name, string last_Name, string address, string city, string state, int zip_Code, long phone_Number, string email)
        {
            // Set The Class Level Variable Value From The Constructor.

            this.First_Name = first_Name;
            this.Last_Name = last_Name;
            this.Address = address;
            this.city = city;

            this.state = state;
            this.Zip_Code = Zip_Code;
            this.Phone_Number = phone_Number;
            this.Email = email;
        }
        public void DisplayContactDetails()
        {
            //Printing Details
            Console.WriteLine("\n Contact Details:-");
            Console.WriteLine("Name: {0}  {1} ", First_Name, Last_Name);
            Console.WriteLine("Address: {0},{1},{2} ", Address, city, state);
            Console.WriteLine("Zip Code:{0}", Zip_Code);
            Console.WriteLine("Phone_Number: {0}", Phone_Number);
            Console.WriteLine("Email Address: {0}", Email);
        }
    }
}
