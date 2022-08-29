using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class accessModifier
    {
        private string name;
        private long Number;

        public string Email;

        protected int Age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public long PhoneNumber
        {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }

       
        

    }
    public class User:accessModifier
    {
        static void Main(string[] args)
        {
            
        }
    }
}
