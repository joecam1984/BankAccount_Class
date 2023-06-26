using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClass
{
    public class Banking
    {
        //Fields
        private int accountNumber;
        private string accountHolderName;
        private double balance;
        private int pin;
        //Properties
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }
        public int Pin { get; set; }
        //Constructors
        public Banking(int accountNumber, string accountHolderName, double balance, int pin)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            Pin = pin;
            
        }
        //Methods
        public void Withdrawal()
        {
            double withdrawalAmount;
            Console.WriteLine("Withdrawal Amount");
            withdrawalAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawalAmount > Balance)
            {
                Console.WriteLine("Your amount exceeds your balance");
            }
            else
            { 
                Balance = Balance - withdrawalAmount;
                Console.WriteLine("Here is your new balance: " + Balance);
            }
            
        }
        public void Deposit()
        {
            double depositAmount;
            Console.WriteLine("Deposit Amount");
            depositAmount = Convert.ToDouble(Console.ReadLine());

            
            
                Balance = Balance + depositAmount;
                Console.WriteLine("Here is your new balance: " + Balance);
            
        }


    }
}
