using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Transcation
    {
        public static void Commit(Account debitAccount,Account creditAccount, decimal amount)
        {
            debitAccount.CurrentBalance -= amount;
            creditAccount.CurrentBalance += amount;
        }
        public static void Rollback(Account debitAccount, Account creditAccount, decimal amount)
        {
            debitAccount.CurrentBalance += amount;
            creditAccount.CurrentBalance -= amount;
        }
    }
}
