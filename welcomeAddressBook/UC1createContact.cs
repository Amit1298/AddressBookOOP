using System;

namespace createContact
{
    class Student
    {
        private string fname;
        private string lname;
        private string address;
        private string city;
        private string state;
        private int zip;
        private int phoneNumber;
        private string email;
        public string _fname
        {
            set
            {
                this.fname = value;
            }
            get
            {
                return this.fname;
            }
        }
        public string _lname
        {
            set
            {
                this.lname = value;
            }
            get
            {
                return this.lname;
            }
        }
        public string _address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }
        public string _city
        {
            set
            {
                this.city = value;
            }
            get
            {
                return this.city;
            }
        }
        public string _state
        {
            set
            {
                this.state = value;
            }
            get
            {
                return this.state;
            }
        }
        public int _zip
        {
            set
            {
                this.zip = value;
            }
            get
            {
                return this.zip;
            }
        }
        public int _phoneNumber
        {
            set
            {
                this.phoneNumber = value;
            }
            get
            {
                return this.phoneNumber;
            }
        }
        public string _email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Stud = new Student();
            Stud._fname = "Amit";
            Stud._lname = "Kumar";
            Console.WriteLine("Name: " + Stud._fname + " " + Stud._lname);
            Stud._address = "63A/P-489 Defence Colony";
            Stud._city = "Agra";
            Stud._state = "UP";
            Stud._zip = 282001;
            Console.WriteLine("Address: " + Stud._address + " " + Stud._city + " " + Stud._state + " " + Stud._zip);
            Stud._phoneNumber = 989713923;
            Console.WriteLine("Phone NUmber : " + Stud._phoneNumber);
            Stud._email = "amitkr24031995@gmil.com";
            Console.WriteLine("EmailID : " + Stud._email);
        }
    }
}
