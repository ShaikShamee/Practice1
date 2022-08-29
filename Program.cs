using System;

namespace Practice
{
    public partial class Customer
    {
        // Deposit function  
        public void depositAmount(int deposit_amount)
        {
            amount += deposit_amount;
            Console.WriteLine(deposit_amount + " amount is deposited");
            Console.WriteLine("Available balance is: " + amount);
        }
    }
    public partial class Customer
    {
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        // Withdraw function  
        public void withdraw(int withdraw_amount)
        {
            amount -= withdraw_amount;
            Console.WriteLine(withdraw_amount + " is withdrawn");
            Console.WriteLine("Available balance is: " + amount);
        }



    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Amount = 2000;
            //Console.WriteLine("Current balance is: " + customer.Amount);
            //customer.depositAmount(1000);
            //// Accessing seperate file function  
            //customer.withdraw(500);
            //Console.ReadLine();
        
            PrintOfferLetter ltr = new PrintOfferLetter();
            string empName = "shaik seema", designation = "Software Engineer Trainee", doj = "22-09-2020";
            int pay = 20000;
            Console.WriteLine(ltr.CompanyName() + " is very happy to extend this offer letter to \n" + ltr.Name(empName)
            + " at the designation of " + ltr.Designation(designation) + " with an annual pay of " + ltr.Payment(pay) + "$.");
            Console.WriteLine("\nYou are required to report at " + ltr.OfficeAddress() + " from " + ltr.DOJ(doj) + " (dd-mm-yyyy).");
            Console.WriteLine("\n\n" + ltr.CompanyBranding());
            Console.WriteLine("\n\n" + ltr.Disclaimer());
            Console.ReadLine();
        }


    }
}