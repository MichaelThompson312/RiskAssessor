using RiskAssessor.BusinessLogic;
using RiskAssessor.BusinessLogic.Handler;
using RiskAssessor.DataAccess;
using System;

namespace RiskAssessor
{
    class Program
    {
        static void Main(string[] args)
        {
            CoveragePolicyLoader loader = new CoveragePolicyLoader(new ClientCoveragePolicyRepository(), new RiskAmountMapper(), new PolicyMapper());
            loader.Handlepolicies();
        }
    }
}
