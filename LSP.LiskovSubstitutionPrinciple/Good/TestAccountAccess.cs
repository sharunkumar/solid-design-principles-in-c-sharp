using LSP.LiskovSubstitutionPrinciple.AccountTypes;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good
{
    public static class TestAccountAccess
    {
        static void GetAccountAccess()
        {
            AccountAccessMannager accountAccess = new AccountAccessMannager();

            List<TopPaidAccountAccess> accounts = new List<TopPaidAccountAccess>();
            accounts.Add(new FreeAccount());
            accounts.Add(new GoldAccount());
            accounts.Add(new PlatinumAccount());

            accountAccess.GetMentorFromAccounts(accounts);
        }
    }
}
