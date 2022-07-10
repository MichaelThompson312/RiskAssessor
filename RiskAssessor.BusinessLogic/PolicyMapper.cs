using RiskAssessor.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RiskAssessor.BusinessLogic
{
    public interface IPolicyMapper
    {
        IEnumerable<CondensedCoveragePolicy> MapCoveragePolicy(IEnumerable<CoveragePolicy> policies);
    }
    public class PolicyMapper : IPolicyMapper
    {
        public IEnumerable<CondensedCoveragePolicy> MapCoveragePolicy(IEnumerable<CoveragePolicy> policies)
        {
            var condensedPolicies = new List<CondensedCoveragePolicy>();
            var groupedPolices = policies.GroupBy(x => new {x.DateOfBirth, x.LastName, x.FirstName, x.Id, x.CashValue, x.Company, x.Coverage, x.FaceAmount, x.Gender, x.IssueDate, x.IssueState, x.PolicyNumber, x.PremiumAmount }).OrderByDescending(x => x.Key.DateOfBirth).ThenBy(x => x.Key.LastName);
            
            foreach (var item in groupedPolices)
            {
                
                var totalCashValue = item.Select(x => x.CashValue).Sum();
                var totalFaceAmount = item.Select(x => x.FaceAmount).Sum();
                condensedPolicies.Add(new CondensedCoveragePolicy(totalCashValue, totalFaceAmount, item.First().Id, item.First().FirstName, item.First().LastName));
                //This may be considered wrong because it may not be passing the correct id but I cannot tell what id the output file should be using
            }

            return condensedPolicies;
        }
    }
}
