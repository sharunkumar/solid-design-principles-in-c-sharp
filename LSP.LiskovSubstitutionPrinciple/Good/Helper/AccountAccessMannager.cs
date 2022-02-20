using LSP.LiskovSubstitutionPrinciple.AccountTypes;
using LSP.LiskovSubstitutionPrinciple.Bad;
using System.Collections.Generic;

namespace LSP.LiskovSubstitutionPrinciple.Good
{
    class AccountAccessMannager
    {
        public AccountAccessMannager()
        {

        }

        public void GetMentorFromAccounts(List<TopPaidAccountAccess> accounts)
        {
            foreach (var account in accounts)
            {
                account.GetMentorAccessDetails();
            }
        }
    }
}