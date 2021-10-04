using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    class Address
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phone;
        public string email;
        public Address(string firstname, string lastname, string address, string city,
       string state, string zip, string phone, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
    }
}
