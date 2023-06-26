using System.ComponentModel.Design;

namespace BankAccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student myStudent = new Student("Peter", 25, 911, 85);

            Banking newCustomer = new Banking(3698741, "Aaron", 10000.00, 1234);
            
            Console.WriteLine("Hello " + newCustomer.AccountHolderName + ". Your balance is: " + newCustomer.Balance);
            Console.WriteLine("Would you like to make of deposit or withdrawal? \n Enter 'W' for withdrawal or 'D' for deposit");
            char depOrWith = Convert.ToChar(Console.ReadLine().ToLower());

            if (depOrWith.Equals('d'))
            {
                newCustomer.Deposit();
            }
            else if (depOrWith.Equals('w'))
            {
                newCustomer.Withdrawal();
            }
            else
            {
                Console.WriteLine("Have a wonderful day " + newCustomer.AccountHolderName);
            }

            
            
           
        }
    }
}