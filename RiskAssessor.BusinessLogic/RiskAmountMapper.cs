using RiskAssessor.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RiskAssessor.BusinessLogic
{

    public interface IRiskAmountMapper
    {
        IEnumerable<ClientRiskAmount> Map(IEnumerable<CondensedCoveragePolicy> policies);
    }
    public class RiskAmountMapper : IRiskAmountMapper
    {
        public IEnumerable<ClientRiskAmount> Map(IEnumerable<CondensedCoveragePolicy> policies)
        {
            var clientRiskAmounts = new List<ClientRiskAmount>();
            foreach (var item in policies)
            {
                clientRiskAmounts.Add(new ClientRiskAmount(item.FaceAmount - item.CashValue, item.Id, item.FirstName, item.LastName));
            }

            return clientRiskAmounts.OrderByDescending(x => x.RiskAmount);
        }
    }
}
