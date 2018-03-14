using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMIYUSTORE.BL
{
    // pur class has a public access modifier allowing it to be accessed publicly
    public class Customer
    {
        // data is hidden by defining a private backing field, uses a private modifier to ensure
        // no code ouside the class can access it.

        // when defining a property you need to create a variable to store a value which is the backing field.
        private string _lastName;

        // use internal if you want our property to be accessed by the class alone.
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        // this is a short incase you dont need a getter or a setter, here the backing field is managed for you.
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }

        // no backing field as the 1st and last name already have it
        // this has a getter and no setter meaning no other coe even in our class can change this value.
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
    }
}
