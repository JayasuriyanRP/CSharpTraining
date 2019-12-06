using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Account
    {
        private string accountHolderName;
        private int accountId;
        private decimal currentBalance;
        public const decimal MINIMUMBALANCE = 1000;

        public Account()
        {

        }
        public Account(int accountId, string accountName, decimal balance)
        {
            this.accountHolderName = accountName;
            this.accountId = accountId;
            this.currentBalance = balance;
        }
        public string AccountHolderName
        {
            get => accountHolderName;
            set => accountHolderName = value;
        }
        public int AccountId
        {
            get => accountId;
            set => accountId = value;
        }
        public decimal CurrentBalance
        {
            get => currentBalance;
            set => currentBalance = value;
        }

        public bool CreditAmount(decimal amountToBeCredited)
        {
            if (amountToBeCredited > 0)
            {
                //this.currentBalance += amountToBeCredited;
                return true;
            }
            else
                return false;
        }
        public bool DebitAmount(decimal amountToBeDebited)
        {
            if (amountToBeDebited > 0)
            {
                if (amountToBeDebited < currentBalance)
                {
                    decimal temp = currentBalance;
                    if (temp - amountToBeDebited > MINIMUMBALANCE)
                    {
                        //currentBalance -= amountToBeDebited;
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
