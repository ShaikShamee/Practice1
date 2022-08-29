using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
 
        public abstract class OfferLetter
        {
            public abstract string Name(string name);
            public abstract string Designation(string designation);
            public abstract int Payment(int pay);
            public abstract string DOJ(string doj);
            public string CompanyName()
            {
                return "XYZ Corporation Pvt. Ltd.";
            }
            public string OfficeAddress()
            {
                return "512, Manhattan, NY";
            }
            public string CompanyBranding()
            {
                return this.CompanyName() + " is a privately owned regsitered corporation operating \n under the license provided by the state of New York.";
            }
            public string Disclaimer()
            {
                return "This letter and its contents are confidential in nature and are intended only \n for the recipient." +
                "\nIf you are not the correct recipient, kindly return it immediately \n to " + this.CompanyName() + " " + this.OfficeAddress() + ".";
            }
        }
        class PrintOfferLetter : OfferLetter
        {
            public override string Name(string name)
            {
                return name;
            }
            public override string Designation(string designation)
            {
                return designation;
            }
            public override int Payment(int pay)
            {
                return pay;
            }
            public override string DOJ(string doj)
            {
                return doj;
            }
        }
}

