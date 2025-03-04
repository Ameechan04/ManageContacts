using System;

namespace ManageContactsLocal
{
    public class Contact
    {
        private string name;
        private string email;
        private string phone;
        private string address;
        private string company;

        public Contact(string name, string email, string phone, string address, string company)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.company = company;
        }

     
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
}
