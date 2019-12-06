using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccountLibrary;

namespace AccountManagerApp
{
    class Program
    {
        static void Main()
        {
            Account myAccount = CreateAccount();

            Account[] payeeList = CreatePayeeList();

            DisplayPayeeList(payeeList);
            Account otherAccount =  ChoosePayee(payeeList);

            //Account otherAccount = CreateAccount();
            decimal amountToTransfer = GetAmount();

            bool debitStatus = myAccount.DebitAmount(amountToTransfer);
            bool creditStatus = otherAccount.CreditAmount(amountToTransfer);

            if (debitStatus && creditStatus)
            {
                Transcation.Commit(myAccount, otherAccount, amountToTransfer);
                Console.WriteLine("amount has been transferred sucessfully");
            }
            else
            {
                Transcation.Commit(myAccount, otherAccount, amountToTransfer);
                Console.WriteLine("amount transfer failed...");
            }
        }

        private static Account ChoosePayee(Account[] payeeList)
        {
            Console.Write("enter payee account id: ");
            int accId = int.Parse(Console.ReadLine());

            Account other = null;
            foreach (Account account in payeeList)
            {
                if(account.AccountId == accId)
                {
                    other = account;
                    break;
                }
            }
            return other;
        }

        private static void DisplayPayeeList(Account[] payeeList)
        {
            foreach (Account account in payeeList)
            {
                Console.WriteLine(account.AccountHolderName+"\t"+account.AccountId);
            }
        }

        private static Account[] CreatePayeeList()
        {
            Account[] accounts = new Account[2];
            for (int i = 0; i < 2; i++)
            {
                Account other = CreateAccount();
                accounts[i] = other;
            }
            return accounts;
        }

        private static Account CreateAccount()
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("account id: ");
            int accId = int.Parse(Console.ReadLine());

            Console.Write("current balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Account account = new Account(accId, name, balance);
            return account;
        }

        private static decimal GetAmount()
        {
            Console.Write("\nenter amount to transfer");
            decimal amount = decimal.Parse(Console.ReadLine());
            return amount;
        }
    }
}
